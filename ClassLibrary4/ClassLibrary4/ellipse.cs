using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    /// <summary>
    /// круг
    /// </summary>
    public class ellipse: IFigure
    {
        /// <summary>
        /// 
        /// </summary>
        private double minorAxis;
        /// <summary>
        /// 
        /// </summary>
        public double MinorAxis
        {
            get
            {
                return minorAxis;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    minorAxis = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private double semimajorAxis;
        /// <summary>
        /// 
        /// </summary>
        public double SemimajorAxis
        {
            get
            {
                return semimajorAxis;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    semimajorAxis = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double Area = 3.14 * semimajorAxis * minorAxis;
            return Area;
        }
    }
}
