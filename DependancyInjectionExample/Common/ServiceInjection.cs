namespace DependancyInjectionExample.Common
{
    public class ServiceInjection
    {
        public delegate T ServiceResolver<T>(bool key);
    }
}