using System;

namespace BssBase.Functions
{
    internal interface IWebApiSync
    {
         void SendAllData();
         void GetAllData();
         void SyncAllData();

         int GetAllDataFromServerForSYNC(DateTime dateTime, bool force);

    }
}