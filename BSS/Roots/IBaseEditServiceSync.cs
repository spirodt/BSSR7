using System.Threading.Tasks;

namespace BssBase.Roots
{
    public interface IBaseEditServiceSync<T>
    {
        Task SaveDataToServer(T item);
        Task GetDataFromServer(T item);

    }
}