using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMetanit
{
    class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);
        delegate void GetMessage();
        delegate T Operation<T, K>(K val);
        class Math
        {
            public int Sum(int x, int y) { return x + y; }
        }
        static void Main(string[] args)
        {
            //Primer1();
            //Primer2();
            //Primer3();
            //Primer4();
        }

        public static void Primer1()
        {
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }
            mes();
            Console.ReadLine();
        }
        public static void Primer2()
        {
            Operation del = Add;
            int result = del(4, 5);
            Console.WriteLine(result);

            del = Multiplay;
            result = del(4, 5);
            Console.WriteLine(result);
            Console.Read();
        }
        public static void Primer3()
        {
            Math math = new Math();
            Operation del = math.Sum;
            int result = del(4, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void Primer4()
        {
            if(DateTime.Now.Hour < 12)
            {
                Show_Message(GoodMorning);
            }
            else
            {
                Show_Message(GoodEvening);
            }
        }
        public static void Primer5()
        {
            Operation<decimal, int> op = Square;
        }
        static decimal Square(int n)
        {
            return n * n;
        }
        private static void Show_Message(GetMessage _del)
        {
            _del?.Invoke();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Mornin");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Goog Evening");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiplay(int x, int y)
        {
            return x * y;
        }
    }
}
