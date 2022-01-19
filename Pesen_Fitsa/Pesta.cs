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

        // -----------------Fields & Constructors-----------------



        //-----------------Methods------------------------
        // Method #1
        public void Berapaan (StreamWriter penulis_brp)
        {
            penulis_brp.WriteLine(this.pembaca.ReadLine());
            this.pembaca.Close();
        } // END Method #1 

        //-----------------Methods------------------------

    }// end class (Pesta)
}//end namespace Pesen_Fitsa
