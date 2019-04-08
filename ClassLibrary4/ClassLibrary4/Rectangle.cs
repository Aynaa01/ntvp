using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    /// <summary>
    /// прямоугольник
    /// </summary>
    public class Rectangle: IFigure
    {
        /// <summary>
        /// 
        /// </summary>
        private double _width;
        /// <summary>
        /// вычисление ширины
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _width = value;
                }
            }
        }
        /// <summary>
        /// вычисление высоты
        /// </summary>
        private double _heigth;
        /// <summary>
        /// 
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _heigth = value;
                }
            }
        }
        /// <summary>
        /// Расчет площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double Area = _width * _heigth;
            return Area;
        }
    }
}
