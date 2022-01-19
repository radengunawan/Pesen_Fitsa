using System;
using System.IO;

namespace Pesen_Fitsa
{
    class Nanas
    {
        public static string gen_address = @"C:\Users\sendr\Documents\Experiment_Result\";
        //public static string gen_address = "C:\\Users\\sendr\\Documents\\Experiment_Result\\";

        public static string d = $"{gen_address}delivery_with_@.txt";
        public enum Fargo { North, South, East, West, Flamingo }

       


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

            o.WriteLine("That’s all folks!");
            o.Close();
        }
    }
}
