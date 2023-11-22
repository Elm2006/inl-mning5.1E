using System;
namespace inlämning5.__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Skriv ett namn");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
