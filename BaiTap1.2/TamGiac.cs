using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap1._2
{
    public class TamGiac 
    {
        public double a { get; set; }
        public double b { get; set; }   
        public double c { get; set; }   
        internal bool ok { get; private set; }

        public double chuvi { get; private set; }   
        public bool TinhChuViHinhTamGiac()
        {
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            if (a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b)
            {
                chuvi = a + b + c;
                ok = true;  
                return true;
            }
            else
            {
                chuvi=0;
                ok = false; 
                return false;
            }
        }
    }
}
