/*
 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pesen_Fitsa
{
    class Fitsa
    {
        
        // -----------------Fields & Constructors-----------------
        // Fields
        private StreamWriter penulis;           //Field #1

       //Constructor
        public Fitsa(StreamWriter penulis)       //Constructor #1
        {
            this.penulis = penulis;
        } // End constructor

         //There is only 1 field & 1 constructor in this class
       
         //-----------------Methods-----------------

        // Method #1 Begin
        public void Idaho(Nanas.Fargo f)
        {
            penulis.WriteLine(f);
            penulis.Close();
        }// Method #1 End


        // There are only 1 methods in this class


    } // end class
}// end namespace
