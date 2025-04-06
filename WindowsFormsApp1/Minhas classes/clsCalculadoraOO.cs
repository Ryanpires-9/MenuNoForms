using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Minhas_classes
{
    internal class clsCalculadoraOO
    {
        private decimal _Num1;
        private decimal _Num2;
        private decimal _Resultado;

        public decimal Num1 { get => _Num1; set => _Num1 = value; }
        public decimal Num2 { get => _Num2; set => _Num2 = value; }
        public decimal Resultado { get => _Resultado; set => _Resultado = value; }

        public void Somar()
        {
            _Resultado = _Num1 + _Num2;
        }

        public void Subtrair()
        {
            _Resultado = _Num1 - _Num2;
        }

        public void Multiplicar()
        {
            _Resultado = _Num1 * _Num2;
        }

        public void Dividir()
        {
            _Resultado = _Num1 / _Num2;
        }

        public void Potenciar()
        {
            _Resultado = (decimal)Math.Pow((double)_Num1, (double)_Num2);
        }
    }
}
