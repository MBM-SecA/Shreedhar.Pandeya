using System;
using System.Threading.Tasks;
namespace CounterApp
{
    class Program
    {
        static void Main(string[] argument)
        {
            int limit = int.MaxValue;
            if (argument.Length>0)
            {
                limit = int.Parse(argument[0]);



            }
            int counter = 1;
            while(counter < limit)
            {
                Console.WriteLine(counter);
                counter++;
                await.Task.Delay(1000);

            }
        }
    }
}
