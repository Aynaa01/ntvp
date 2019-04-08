using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    /// <summary>
    /// треугольник
    /// </summary>
    public class triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        /// <summary>
        /// 
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Координаты Y
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Координаты Z
        /// </summary>
        public int Z { get; set; }

        /// </summary>
        /// <returns></returns>
        public double a
        {
            get
            {
                return _a;
            }
            set
            {
                if (a < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _a = value;
                }
            }
        }
        public double b
        {
            get
            {
                return _b;
            }
            set
            {
                if (b < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _b = value;
                }
            }
        }
        public double c
        {
            get
            {
                return _c;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _c = value;
                }
            }
        }
        /// <summary>
        /// Расчет площади треугольника
        /// </summary>
        /// <returns></returns>

        public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
