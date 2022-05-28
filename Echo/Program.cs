using Infra;
using Echo.BusinessLogic.Interfaces;

namespace Echo
{
    public class Program
    {
        public static void Main()
        {
            BootUpConfig.SetUpServices();

            var foo = Dependencies.GetService<IFooService>();

            Console.WriteLine(foo?.Echo("Hello World"));
        }
    }
}