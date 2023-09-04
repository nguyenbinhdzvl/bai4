using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int intA, intB;

            double Bi ;
            Console.WriteLine("-------- CHUONG TRINH GIAI PHUONG TRINH BAC 1 --------");
            Console.WriteLine("--------- ax + b = 0 ---------");

            // nhap a
            Console.Write("Nhap a:  ");
              intA = Convert.ToInt32(Console.ReadLine());

            //nhap b


            Console.Write("Nhap b:  ");
                intB = Convert.ToInt32(Console.ReadLine());
            //lenh if 1
            if (intA == 0 && intB == 0)
            {
                Console.WriteLine("PHuong Trinh Co Vo So Nghiem");
            }

            // lenh 2

            else if (intA == 0 && intB != 0)
            {
                Console.WriteLine("phuong trinh co vo so nghiem");
            }

            // lenh 3
            else
            {
                Bi = (double)-intB / intA;
                Console.WriteLine("phuong trinh co 1 nghiem duy nhat x = {0}", Bi);
            }

                Console.ReadKey();
            
        }
    }
}
