using System;
using System.IO;

namespace Pesen_Fitsa
{
    class Nanas
    {
        const string d = "delivery.txt";
        public enum Fargo { North, South, East, West, Flamingo }

        public static string gen_address = "C:\\Users\\sendr\\Documents\\Experiment_Result\\";


        static void Main(string[] args)

        {
            var o = new StreamWriter($"{gen_address}Mesen.txt");
            var fts = new Fitsa(new StreamWriter(d, true));

            fts.Idaho(Fargo.Flamingo);

            for (int i = 3; i >= 0; i--)
            {
                var w = new Fitsa(new StreamWriter (d,false));
                w.Idaho((Fargo)i);

                Pesta p = new Pesta(new StreamReader(d));
                p.Berapaan(o);
            }




        }
    }
}
