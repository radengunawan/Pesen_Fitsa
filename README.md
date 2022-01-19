# Pesen_Fitsa
Pemesanan pijja

The enum is used to print a lot of the output. 
We learned in Chapter 8 that an enum’s ToString method returns the equivalent string, so Fargo.North.ToString() returns the string “North”.

The Pizza class keeps a StreamWriter as a private field, and its Idaho method writes Fargo enums to the file using their ToString methods, which WriteLine calls automatically.

The Party class has a StreamReader field, and its HowMuch method reads a line from that StreamReader and writes it to a StreamWriter.

Line 19 - 34 of Nanas file:
Here’s the entry point for the program. It creates a StreamWriter that it passes to the Party class. Then it loops through the Fargo members, passing each of them to the Pizza.Idaho method to print.
