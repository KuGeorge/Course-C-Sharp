using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_C_Sharp
{
    class RNA_Transcription
    {
        public static void Test()
        {
            Console.WriteLine(ToRNA("GCTA"));
            Console.WriteLine(ToRNA("GCTAATCG"));
            Console.WriteLine(ToRNA("GCTAATCGXX"));
            Console.WriteLine(ToRNA("PPPUAYXX"));
            Console.WriteLine(ToRNA("gcta"));
            Console.ReadLine();
        }

        public static string ToRNA(string dna)
        {
            string rna = "";
            foreach (char nucleotide in dna)
            {
                switch (nucleotide)
                {
                    case 'G':
                        rna += 'C';
                        break;
                    case 'C':
                        rna += 'G';
                        break;
                    case 'T':
                        rna += 'A';
                        break;
                    case 'A':
                        rna += 'U';
                        break;
                    default:
                        rna = "Invalid input";
                        break;
                }
                if (rna == "Invalid input") break;
            }
            return rna;
        }
    }
}
