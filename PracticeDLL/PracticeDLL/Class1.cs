using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PracticeDLL
{
    public class Class1
    {
        public static double Vvod(TextBox t, ErrorProvider a)
        {
            if (t.Text == "")
            {
                a.SetError(t, "Строка пуста");
                return 0;
            }
            else return Convert.ToDouble(t.Text);
        }

        public static void Vivod(TextBox t, double c)
        {
            t.Text = Convert.ToString(c);
        }

        public static bool Check(double x, double y)
        {
            if (x * (x - y) * (3 * x + y) == 0) return false;
            else return true;
        }

        public static double SolveTaskRet(double x, double y)
        {
            return Math.Round((x * Math.Exp(x * y) + 8 * Math.Pow(Math.Sin(x), 2)) / (x * (x - y) * (3 * x + y)), 4);
        }

        public static void SolveTaskOut(double x, double y, out double result)
        {
            result = Math.Round((x * Math.Exp(x * y) + 8 * Math.Pow(Math.Sin(x), 2)) / (x * (x - y) * (3 * x + y)), 4);
        }

        public static void SolveTaskRef(double x, double y, ref double result)
        {
            result += Math.Round((x * Math.Exp(x * y) + 8 * Math.Pow(Math.Sin(x), 2)) / (x * (x - y) * (3 * x + y)), 4);
        }

        public static void Main(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, ErrorProvider z)
        {
            z.SetError(a, null);
            z.SetError(b, null);
            double x = Vvod(a, z);
            double y = Vvod(b, z);
            if (z.GetError(a) == "Строка пуста" || z.GetError(b) == "Строка пуста")
            {
                c.Text = string.Empty;
                d.Text = string.Empty;
                e.Text = string.Empty;
                return;
            }
            if (Check(x, y))
            {
                double result_out;
                SolveTaskOut(x, y, out result_out);
                double result_ref = 0;
                SolveTaskRef(x, y, ref result_ref);
                Vivod(c, SolveTaskRet(x, y));
                Vivod(d, result_out);
                Vivod(e, result_ref);
            }
            else MessageBox.Show("Ошибка, недопустимые значения X и Y (в знаменателе функции получается 0)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static double ExtraMethod(double x)
        {
            return (Math.Exp(x) + Math.Exp(-x)) / 2;
        }

        public static void SolveTask2Out(double x, out double result)
        {
            result = Math.Round(ExtraMethod(x + 2) - 3 * ExtraMethod(x) + Math.Pow(Math.Tan(1 - ExtraMethod(2 * x - 3)), 2), 4);
        }

        public static void SolveTask2Ref(double x, ref double result)
        {
            result += Math.Round(ExtraMethod(x + 2) - 3 * ExtraMethod(x) + Math.Pow(Math.Tan(1 - ExtraMethod(2 * x - 3)), 2), 4);
        }

        public static bool CheckTask2(double x)
        {
            double underTg = 1 - ExtraMethod(2 * x - 3);
            double theRealUnderTg = underTg - Math.PI * Convert.ToInt64(underTg / (Math.PI * 2));
            if (theRealUnderTg == (Math.PI / 2) || theRealUnderTg == (Math.PI / 2 * 3)) return false;
            else return true;
        }

        public static void MainTask2 (TextBox a, TextBox b, TextBox c, ErrorProvider z)
        {
            z.SetError(a, null);
            double x = Vvod(a, z);
            if (z.GetError(a) == "Строка пуста")
            {
                b.Text = string.Empty;
                c.Text = string.Empty;
                return;
            }
            if (CheckTask2(x))
            {
                double result_out;
                SolveTask2Out(x, out result_out);
                double result_ref = 0;
                SolveTask2Ref(x, ref result_ref);
                Vivod(b, result_out);
                Vivod(c, result_ref);
            }
            else MessageBox.Show("Ошибка, недопустимое значение X (невозможно посчитать тангенс)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static double SolveTask3Ret (double x, double y, double a, double b, double c)
        {
            double result = 0;
            if (x > 1 && y > 1)
            {
                double Max = Math.Sqrt(Math.Abs(Math.Log(Math.Pow(y, 2))));
                if (Math.Exp(Math.Log10(y)) > Max) Max = Math.Exp(Math.Log10(y));
                if (Math.Pow(Math.Log10(x * y), a) > Max) Max = Math.Pow(Math.Log10(x * y), a);
                result = a + Max;
            }
            else if (1 <= x && x < 20 && 1<=y && y < 10)
            {
                double Min = Math.Sqrt(x);
                if (Math.Sqrt(y) < Min) Min = Math.Sqrt(y);
                if (c < Min) Min = c;
                result = b + Min;
            }
            else
            {
                double Min = a;
                if (x < Min) Min = x;
                result = Math.Exp(Min);
            }
            return Math.Round(result, 4);
        }

        public static void MainTask3 (TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, ErrorProvider z)
        {
            z.SetError(a, null);
            z.SetError(b, null);
            z.SetError(c, null);
            z.SetError(d, null);
            z.SetError(e, null);
            double x = Vvod(a, z);
            double y = Vvod(b, z);
            double al = Vvod(c, z);
            double bl = Vvod(d, z);
            double cl = Vvod(e, z);
            if (z.GetError(a) == "Строка пуста" || z.GetError(b) == "Строка пуста" || z.GetError(c) == "Строка пуста" || z.GetError(d) == "Строка пуста" || z.GetError(e) == "Строка пуста")
            {
                f.Text = string.Empty;
                return;
            }
            double result = SolveTask3Ret(x, y, al, bl, cl);
            Vivod(f, result);
        }
    }
}
