using System;
using System.Data.SqlClient;

public class Sessions : IDisposable
{
    public string Sesija { set; get; }

    private string Sesion = string.Empty;

    private int UserID { set; get; }

    private int FirmaID { set; get; }

    private bool IsDisposed = false;
    private string Konekcija;

    public static void LogAction(string sesion, string Akcija, int Status = 1, string connectionStr = "")
    {
        if (!BssBase.settings.LogiranjeNaSessii)
        {
            return;
        }
        if (string.IsNullOrEmpty(connectionStr))
        {
            connectionStr = BssBase.settings.konekcija;
        }
        using (var con = new SqlConnection(connectionStr))
        {
            using (var com = new SqlCommand("INSERT INTO _tblLog (Sesija, Akcija, DatumIVreme,Status) VALUES( @Sesija, @Akcija, @DatumIVreme,@Status) ", con))
            {
                try
                {
                    com.Parameters.AddWithValue("@Sesija", sesion);
                    com.Parameters.AddWithValue("@Akcija", Akcija);
                    com.Parameters.AddWithValue("@DatumIVreme", DateTime.Now);
                    com.Parameters.AddWithValue("@Status", Status);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Tools.PrevediSQLException(ex);
                }
            }
        }
    }

    public Sessions(int userId, int firmaId, string connection)
    {
        UserID = userId;
        FirmaID = firmaId;
        Konekcija = connection;
        Sesion = StartSession();
        Sesija = Sesion;
    }

    public void Dispose()
    {
        Dispose(true);
    }

    protected virtual void Dispose(bool Diposing) 
    {
        if (!IsDisposed)
        {
            if (Diposing)
            {
                StopSession();
            }
            StopSession();
        }
        IsDisposed = true;
    }

    ~Sessions()
    {
        Dispose(false);
    }

    public string StartSession()
    {
        if (!BssBase.settings.LogiranjeNaSessii)
        {
            return string.Empty;
        }
        var sessionIdFromDB = string.Empty;
        using (var con = new SqlConnection(Konekcija))
        {
            using (var com = new SqlCommand("INSERT INTO _tblSesija (Pocnata, FirmaID, UserID) VALUES(@Pocnata,@FirmaID,@UserId);Select @@IDENTITY as newId;", con))
            {
                try
                {
                    con.Open();
                    com.Parameters.AddWithValue("@Pocnata", DateTime.Now);
                    com.Parameters.AddWithValue("@FirmaID", FirmaID);
                    com.Parameters.AddWithValue("@UserId", UserID);
                    var ID = com.ExecuteScalar().ToString();
                    com.Parameters.Clear();
                    com.CommandText = "Select Sesija from _tblSesija where ID=" + ID.ToString();
                    sessionIdFromDB = com.ExecuteScalar().ToString();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Tools.PrevediSQLException(ex);
                }
            }
        }

        return sessionIdFromDB;
    }

    public void StopSession()
    {
        if (!BssBase.settings.LogiranjeNaSessii)
        {
            return;
        }
        using (var con = new SqlConnection(Konekcija))
        {
            using (var com = new SqlCommand("Update _tblSesija set Zavrsena=@Zavrsena WHERE Sesija=@Sesija", con))
            {
                try
                {
                    com.Parameters.AddWithValue("@Zavrsena", DateTime.Now);
                    com.Parameters.AddWithValue("@Sesija", Sesion);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    Tools.PrevediSQLException(ex);
                }
            }
        }
    }
}