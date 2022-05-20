using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfr_Cezara
{
    class Program
    {
        static void Main(string[] args)
        {
            int przesuniecie;
            int znak;
            Console.Write("Podaj przesunięcie: ");
            przesuniecie = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Zacznij wpisywać tekst do zaszyfrowania (q aby zakończyć): ");
            
            while ((znak = Console.ReadKey(true).KeyChar) != 'q')
            {
                if(znak>='a' && znak<='z') Console.Write(Convert.ToChar((znak - 'a'+ przesuniecie)%26+'a'));
            }
                      
            Console.ReadKey();
        }
    }
}
