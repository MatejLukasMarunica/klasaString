using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "danas radimo klasu string";

            Console.WriteLine(tekst);

            Console.WriteLine("Broj znakova je:" + tekst.Length);

            Console.WriteLine("Velika slova: " + tekst.ToUpper());
            Console.WriteLine("Mala slova: " + tekst.ToLower());

            Console.WriteLine(tekst.Substring(0, 5));

            Console.WriteLine(tekst.Substring(13, tekst.Length - 13));

            Console.WriteLine(tekst.Replace("danas", "Sutra"));

            string[] rijeci = tekst.Split(' ');
            for(int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]); 
            }
            foreach(string rijec in rijeci)
            {
                Console.WriteLine(rijec);
            }
            Console.WriteLine(tekst.Insert(tekst.IndexOf("radimo"), "intenzivno "));

            Console.ReadKey(); 
        }
    }
}
