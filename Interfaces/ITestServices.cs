using test2.Models;

namespace test2.Interfaces
{
    public interface ITestServices
    {
        //City GetCity(int cityId);
        bool TestInitial(TestModel t);

        bool Save();
    }
}
