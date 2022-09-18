using System;

namespace if_else_ternary
{
    class program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            string text = time <= 24 && time >= 20 ? "good night" : time <= 20 && time >= 16 ? "good evening" : "good afternoon";
            Console.WriteLine(text); 
            Console.ReadKey();
        }
    }
}