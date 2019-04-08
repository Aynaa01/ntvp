using ClassLibrary4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelView
{
    public partial class FigureEdit : Form
    {
        public FigureEdit()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public IFigure GetFigure()
        {
            if (TabControlFigure.SelectedIndex == 0)
            {
                var ellipse = new ellipse();
                ellipse.SemimajorAxis = Convert.ToInt32(Radius.Text);
                ellipse.MinorAxis = Convert.ToInt32(Radius.Text);
                return ellipse;
            }
            else if (TabControlFigure.SelectedIndex == 1)
            {
                var ellipse = new ellipse();
                ellipse.SemimajorAxis = Convert.ToInt32(Radius.Text);
                ellipse.MinorAxis = Convert.ToInt32(Radius.Text);
                return ellipse;
            }
            else if (TabControlFigure.SelectedIndex == 2)
            {
                var ellipse = new ellipse();
                ellipse.SemimajorAxis = Convert.ToInt32(Radius.Text);
                ellipse.MinorAxis = Convert.ToInt32(Radius.Text);
                return ellipse;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
