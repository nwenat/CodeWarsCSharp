using System;

namespace ComplementaryDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeComplement("TAACG"));
        }

        public static string MakeComplement(string dna)
        {
            string rezult = "";
            for (int i = 0; i < dna.Length; i++)
            {
                switch (dna[i])
                {
                    case 'A':
                        rezult = rezult + "T";
                        break;
                    case 'T':
                        rezult = rezult + "A";
                        break;
                    case 'G':
                        rezult = rezult + "C";
                        break;
                    case 'C':
                        rezult = rezult + "G";
                        break;
                }
            }
            return rezult;
        }
    }
}
