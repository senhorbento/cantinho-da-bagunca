using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class operacoes
    {
        public static int Somar(int FirstValue, int SecondValue) { return FirstValue + SecondValue; }
        public static int Subtrair(int FirstValue, int SecondValue) { return FirstValue - SecondValue; }
        public static int Dividir(int FirstValue, int SecondValue) { return FirstValue / SecondValue; }
        public static int Multiplicar(int FirstValue, int SecondValue) { return FirstValue * SecondValue; }
    }
}
