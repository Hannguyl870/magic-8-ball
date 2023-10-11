//Hannah Guylee
// magic 8 ball simulation
//October 11,2023
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
       
        Random random = new Random();
        int number;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void shakebutton_Click(object sender, EventArgs e)
        {
            //string answers = questionoutput.Text;
            number = random.Next(1, 9);

            switch (number)
            {
                case 1:
                   questionoutput.Text = "NO";
                    break;
                case 2:
                    questionoutput.Text = "You wish";
                    break;
                case 3:
                    questionoutput.Text = "Yes";
                    break;
                case 4:
                    questionoutput.Text = "be proactive";
                    break;
                case 5:
                    questionoutput.Text = "you'll figure it out";
                    break;
                case 6:
                    questionoutput.Text = "not everything is as it seems";
                    break;
                case 7:
                    questionoutput.Text = "actions speek more than words";
                    break;
                case 8:
                    questionoutput.Text = "are you sure";
                    break;

            }
        }
    }
}
