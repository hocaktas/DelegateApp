using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        
        public delegate void Temsilci(int a, int b);
        public static void topla(int a,int b)
        {
            Console.WriteLine("Toplam:{0}",a+b);
        }  
        public static void cikar(int a,int b)
        {
            Console.WriteLine("Fark:{0}",a-b);
        }  
        public static void carp(int a,int b)
        {
            Console.WriteLine("Çarpım:{0}",a*b);
        }  
        public static void bol(int a,int b)
        {
            Console.WriteLine("Bölüm:{0}",a/b);
        }
        static void Main(string[] args)
        {

            Temsilci t = new Temsilci(topla) + new Temsilci(cikar) + new Temsilci(carp) + new Temsilci(bol);
            //t(10,8);
            t.Invoke(10, 80);
            Console.ReadKey();

            
        }
    }
}
