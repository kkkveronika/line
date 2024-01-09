// Практическая работа №2
// Написать программу, находящую в массиве две неубывающие последовательности максимальной длины
// Студент группы 414, Кондиляброва Вероника Данииловна. 2023 год
using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace graficNS{
    public class grafic
    {
        public static void Main()
        {

        }
        public static List<double> function_test(double x1, double x2, double n, double a)
        {
            List<double> result = new List<double>();
            for (double i = x1; i <= x2; i += n)
            {
                double m = (double)(a / 2);
                double degree = (double)(i / a);
                double min_degree = -degree;
                var y_tmp = m * (Math.Exp(degree) + Math.Exp(min_degree));
                result.Add(y_tmp);
            }
            return result;
        }
    }

}
