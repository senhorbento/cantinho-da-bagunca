using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TesteBuscaArquivo
{
    internal class Arquivo
    {
        public static List<String> LerArquivo(String caminho)
        {
            List<String> lines = new List<string>();
            String[] leitura = System.IO.File.ReadAllLines(caminho);
            foreach (String linha in leitura)
                lines.Add(linha);
            return lines;
        }

        public static void GravarArquivo(List<String> lista, String caminho)
        {
            try
            {
                StreamWriter sw = new StreamWriter(caminho);
                foreach(String linha in lista)
                {
                    sw.WriteLine(linha);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
