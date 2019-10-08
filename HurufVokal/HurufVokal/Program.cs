using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurufVokal
{
    class Vokal
    {
        private string strings;

        public string NamaVokal(string v)
        {
            string temp = "";
            Console.Write("Huruf Vocal    = ");
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == 'a' || v[i] == 'e' || v[i] == 'i' || v[i] == 'u' || v[i] == 'o')
                {

                    Console.Write(v[i] + " ");
                    temp += v[i];
                                        
                }
            }
            this.strings = temp;
            return temp;

        }
        public int JumlahVokal()
        {
            int jumlah = strings.Length;
            return jumlah;
        }
        
    }
    class Program
    {
        public static int Huruf { get; private set; }

        static void Main(string[] args)
        {
            Vokal vokal = new Vokal();
            Console.WriteLine();
            Console.Write("Input Kalimat : ");
            string kalimat = Console.ReadLine();
            Console.WriteLine(" ");
            vokal.NamaVokal(kalimat);
            Console.WriteLine();

            Console.WriteLine("Jumlah:  {0}", vokal.JumlahVokal());

        }
    }
}
