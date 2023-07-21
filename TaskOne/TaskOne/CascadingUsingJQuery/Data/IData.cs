using CascadingUsingJQuery.Models;

namespace CascadingUsingJQuery.Data
{
    public interface IData
    {
        List<AllCascadingData> ListAll();
        List<AllCascadingData> ListById(int id);
    }
}