using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object01
{
    class Teglalap
 {
        private int a, b;
        public Teglalap(int aoldal, boldal)
        {
            a = aoldal;
            b = boldal;
        }
        //private int a;
        //private int b;

        public int Kerulet()
        {
            return 2 * (a + b);
        }
        public int Terulet()
        {
            return a * b;
        }

    }
    /*class Ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            string valasz = $"{nev} vagyok {eletkor} éves.";
            return valasz;

            return $"{nev} vagyok {eletkor} éves.";
        }
    }
    
     class Kor
    {
        private int r;
        public Kor(int sugar)
        {
            r = sugar;
        }

        public double Kerulet2()
        {
            return 2 * r * Math.PI;
        }

        public double Terulet2()
        {
            return Math.PI * Math.Pow(r, 2);
        }
       


    }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*Ember pisti = new Ember();
            Ember eva = new Ember();

            pisti.nev = "Nagy Pisti";
            pisti.eletkor = 20;

            eva.nev = "Nagy Éva";
            eva.eletkor = 18;

            pisti.eletkor++;


            Console.WriteLine(pisti.Bemutatkozas());
            Console.WriteLine(eva.Bemutatkozas());
            
             
            Teglalap adat1 = new Teglalap();
            adat1.a = 3;
            adat1.b = 4;

            Console.WriteLine("Kerület: {0} ", adat1.Kerulet());
            Console.WriteLine("Terület: {0} ", adat1.Terulet());



            Console.WriteLine("Írja be a kör sugarát: ");
            int sugar = int.Parse(Console.ReadLine());
            Kor adatok = new Kor(sugar);

            Console.WriteLine("Kerület: {0} ", adatok.Kerulet2());
            Console.WriteLine("Terület: {0} ", adatok.Terulet2());*/



            Console.WriteLine("Írja be a téglalap egyik oldalát:");
            int aoldal= int.Parse(Console.ReadLine());
          
            Console.WriteLine("Írja be a téglalap másik oldalát:");
            int boldal = int.Parse(Console.ReadLine());
            Teglalap oldal2 = new Teglalap(aoldal, boldal);

            Console.WriteLine("Kerület: {0} ", oldal2.Kerulet());
            Console.WriteLine("Terület: {0} ", oldal2.Terulet());





            Console.ReadKey();
        }
    }
}
