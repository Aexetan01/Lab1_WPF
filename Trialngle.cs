using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ivan_WPF
{
    public class Trialngle
    {
        private double a;
        private double b;
        private double c;
        private double h;

        public Trialngle()
        {
            a = 0;
            b = 0;
            c = 0;
            h = 0;
        }

        public Trialngle(double a, double h)
        {
            this.a = a;
            this.h = h;
            b = 0;
            c = 0;
        }

        public Trialngle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            h = 0;
        }

        public Trialngle(double a, double b, double c, double h) : this(a, b, c)
        {
            this.h = h;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double H { get => h; set => h = value; }

        public double GetPerimetr()
        {
            return a + b + c;
        }

        public double GetSquare()
        {
            return (a * h) / 2d;
        }


    }
}
