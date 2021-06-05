using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouse_tracker
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            

            labelX.Text = $"X: {x}";
            labelY.Text = $"Y: {y}";

            Location = new Point(x + 10, y);
        }

        
    }
}
