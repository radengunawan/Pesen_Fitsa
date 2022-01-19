using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pesen_Fitsa
{
    class Pesta
    {
        // -----------------Fields & Constructors-----------------
        // Field
        private StreamReader pembaca;

        //Constructor
        public Pesta(StreamReader pembaca) {
            
            this.pembaca = pembaca;
        }

        //There is only 1 field & 1 constructor in this class (Pesta)



        //-----------------Methods------------------------
        // Method #1
        public void Berapaan (StreamWriter penulis_brp)
        {
            penulis_brp.WriteLine(this.pembaca.ReadLine());
            this.pembaca.Close();
        } // END Method #1 

        //There is only 1 method in this class (Pesta)

    }// end class (Pesta)
}//end namespace Pesen_Fitsa
