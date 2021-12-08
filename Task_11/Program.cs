using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation MyEq = new Equation { k = 2.12, b = -7.5 }; //создание экземпляра структуры
            MyEq.Root();
        }
    }
    public struct Equation //структура
    {
        internal double k;
        internal double b;
        internal double x;

        public void Root() //метод решения уравнения
        {
            if (k == 0)
            {
                Console.WriteLine("Ошибка! Деление на 0!");
            }
            else
            {
                x = -b / k; //kx+b=0
                Console.WriteLine("В уравнении kx+b=0 при k = {0:f2}, b = {1:f2}, x = {2:f2}", k, b, x);
            }
            Console.ReadKey();
        }
    }
}

        
    
