using System.Text;

namespace OOP_task2
{
    class Program
    {
        static void Main(String[] args) 
        {
            MTime aboba1 = new EuTime();
            MTime aboba2 = new UsTime();
            aboba1 = new AddSymbols(aboba1);
            //aboba1 = new AddSymbols(aboba1);
            aboba2 = new AddSymbols(aboba2);
            //aboba2 = new AddSymbols(aboba2);
            Console.WriteLine(aboba1.FormatDateTime());
            Console.WriteLine(aboba2.FormatDateTime());
        }
    }
}