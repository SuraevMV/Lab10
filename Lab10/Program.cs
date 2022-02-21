using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            int minute_ = Convert.ToInt32(Console.ReadLine());
            int sec_ = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus_, minute_, sec_);

            double toRadian = angle.ToRadian();
            Console.WriteLine("Угол {0}d {1}\' {2}\"", angle.Gradus, angle.Min, angle.Sec);
            Console.WriteLine("Угол в радианах равен = {0}", toRadian);

            Console.ReadKey();
        }
    }
}
