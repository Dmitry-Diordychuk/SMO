using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = (int)(ArrivalRate.GetNextTime()*100);
        }

        private void Timer1_Tick( object sender, EventArgs e )
        {
            
            timer1.Interval = (int)(ArrivalRate.GetNextTime()*100);
        }
    }
}
