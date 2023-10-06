using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magic_8_ball
{
    public partial class Form1 : Form
    {
        Random number = new Random(1-9);
        public Form1()
        {
            InitializeComponent();
        }

        private void shakebutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
