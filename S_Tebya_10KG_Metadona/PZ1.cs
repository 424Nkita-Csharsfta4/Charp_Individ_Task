using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Tebya_10KG_Metadona
{
    internal class PZ1
    {
        // Коэффициенты числителя полинома
        private int[] numeratorCoefficients;

        // Коэффициенты знаменателя полинома
        private int[] denominatorCoefficients;

        // Порядок полинома
        private int order;

        public PZ1(int[] numeratorCoefficients, int[] denominatorCoefficients, int order)
        {
            // Инициализация коэффициентов числителя, знаменателя и порядка полинома
            this.numeratorCoefficients = numeratorCoefficients;
            this.denominatorCoefficients = denominatorCoefficients;
            this.order = order;
        }

        public PZ1(int[] numeratorCoefficients, int[] denominatorCoefficients)
        {
            // Инициализация коэффициентов числителя и знаменателя полинома, а также определение порядка полинома
            this.numeratorCoefficients = numeratorCoefficients;
            this.denominatorCoefficients = denominatorCoefficients;
            this.order = Math.Max(numeratorCoefficients.Length - 1, denominatorCoefficients.Length - 1);
        }

        public double Evaluate(double x)
        {
            // Вычисление значения числителя и знаменателя полинома для заданной величины x
            double numeratorValue = EvaluatePolynomial(numeratorCoefficients, x);
            double denominatorValue = EvaluatePolynomial(denominatorCoefficients, x);

            if (denominatorValue == 0)
            {
                // Проверка на равенство нулю знаменателя и вывод сообщения об ошибке
                Console.WriteLine("Ошибка: Знаменатель равен нулю.");
                return 0;
            }

            // Возвращение результата деления числителя на знаменатель
            return numeratorValue / denominatorValue;
        }

        private double EvaluatePolynomial(int[] coefficients, double x)
        {
            // Вычисление значения полинома для заданной величины x
            double value = 0;

            for (int i = 0; i < coefficients.Length; i++)
            {
                value += coefficients[i] * Math.Pow(x, i);
            }

            // Возвращение значения полинома
            return value;
        }
    }

}
