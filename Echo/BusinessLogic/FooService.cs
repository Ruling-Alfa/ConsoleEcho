using Echo.BusinessLogic.Interfaces;

namespace Echo.BusinessLogic
{
    public class FooService : IFooService
    {
        public FooService()
        {

        }

        public string Echo(string data)
        {
            return data;
        }
    }
}
