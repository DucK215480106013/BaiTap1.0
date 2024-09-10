using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.InputEncoding = Encoding.UTF8;
           Console.OutputEncoding  = Encoding.UTF8;
           Console.WriteLine("Phần Mềm Tính Chu Vi Hình Tam Giác");
           Console.Write("Nhập 3 cạnh của tam giác:  ");
           string  P = Console.ReadLine();
           string[] items = P.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
           if (items.Length == 3 )
            {
                double a=double.Parse(items[0]);
                double b = double.Parse(items[1]);
                double c = double.Parse(items[2]);

                if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
                {
                    double p = (a + b + c);
                    Console.WriteLine($"Chu Vi Hình Tam Giác = {P}");
                }
                else
                {
                    Console.WriteLine("3 cạnh không tạo thành một tam giác");
                }
                Console.ReadKey();
            }
        }  
    }
    
}
