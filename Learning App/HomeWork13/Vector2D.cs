using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork13
{
    class Vector2D
    {
        private double a { get; set; }
        private double b { get; set; }

        public Vector2D(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetVectorA()
        {
            return a;
        }
        public double GetVectorB()
        {
            return b;
        }

        public double VectorScalarMultyply()
        {
            return GetVectorA() * GetVectorB() * Math.Cos(0);
        }
    }
}
