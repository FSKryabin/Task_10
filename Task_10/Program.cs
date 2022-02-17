using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Введите данные");
            Console.WriteLine("Введите количество градусов угла");
            int Grade_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут угла");
            int Minutes_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество секунд угла");
            int Seconds_ = Convert.ToInt32(Console.ReadLine());
            Radians radians = new Radians(Grade_, Minutes_, Seconds_);
            double Radians = radians.ToRadians();
            Console.WriteLine("Значение данного угла в радианах=" + Radians);
            Console.ReadKey();
        }

        
           
   
    }
}
