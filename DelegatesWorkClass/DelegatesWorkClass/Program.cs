using System;

namespace DelegatesWorkClass
{

  
    class Program
    {
        
        public static void Hello(string name)
        {
            Console.WriteLine($"welcome{name}");
        }
        public static void print2()
        {
            Console.WriteLine("Another function called with same Delegate");
        }
        public static void Shalom()
        {
            Console.WriteLine("shalom");
        }
        public static void Shalom(string name)
        {
            Console.WriteLine($"shalom{name}");
        }

        public static void Main(string[] args)
        {
            MyFirstDelegate MyFirstDelegate1 = new MyFirstDelegate(Shalom);
            MyFirstDelegate1();
            MyFirstDelegate MysecondDelegate1 = new MyFirstDelegate(print2);
            MysecondDelegate1();
            Greet Greet2 = new Greet(Hello);
            Greet2(" david");
            Greet Greet3 = new Greet(Shalom);
            Greet3(" yarin");
            Number Combine = new Number();
            Combine.Add(1, 2);
            Number.Sub(2, 1);

            //Greet greet4 = new Greet(print2); לא עובד כי אין סטרינג בפארמטר של PRINT2
          


        }
    }
}
