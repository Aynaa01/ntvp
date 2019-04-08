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
    public partial class MainForm : Form
    {
        private List<IFigure> _figuresList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AddFigure = new FigureEdit();
            if (AddFigure.ShowDialog() != DialogResult.OK) return;
            var figure = AddFigure.GetFigure();
            _figuresList.Add(figure);

        }
    }
}
