using BusinessObjects.Interfaces;

namespace BusinessObjects.Implementations
{
    public class ServiceA : IService
    {
        public string DoTheThing()
        {
            return "ServiceA";
        }
    }
}
