using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CLS_Person person = new CLS_Person(20, "Ahmed", "Ibrahim");
            Console.WriteLine(person.Fname);
            Console.WriteLine(person.info);
        }
    }
}

