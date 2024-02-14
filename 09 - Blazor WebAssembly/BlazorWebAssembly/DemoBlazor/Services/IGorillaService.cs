using DemoBlazor.Models;

namespace DemoBlazor.Services
{
    public interface IGorillaService
    {
        public bool Post(Gorilla gorilla);
        public bool Delete(int id);
    }
}
