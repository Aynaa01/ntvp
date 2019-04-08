using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    /// <summary>
    /// Круг. 
    /// </summary>
    public class Circle: IFigure
    {
        /// <summary>
        /// двойной радиус
        /// </summary>
        private double radius;

        /// <summary>
        /// вычисление радиуса
        /// </summary>
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    radius = value;
                }
            }
        }

        /// <summary>
        /// Расчет площади круга
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double Area = 3.14 * radius * radius;
            return Area;
        }
    }
}
