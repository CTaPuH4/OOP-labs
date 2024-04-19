namespace OOP_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 test = new Task1(3, 1);
            Task1 test1 = new Task1(-3, 1);
            Task1 test2 = new Task1(5, 10);
            Task1 aboba = test2 - test;
            Console.WriteLine(aboba.ToString());
            if (test > test2)
                Console.WriteLine("YASYASYAS");
            else
                Console.WriteLine("NONONO");
        }
    }
}