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
        int counter = 0;
        int max = 1000;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load( object sender, EventArgs e )
        {
            
            timer1.Interval = (int)(ArrivalGenerator.GetNextTime()*100);
            labelArrive.Text = $"Arrive Time: {timer1.Interval}";
            
            timer2.Interval = (int)( Service.Work() * 100 );
            labelServe.Text = $"Serve Time: {timer2.Interval}";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Value = 0;

            
        }

        private void Timer1_Tick( object sender, EventArgs e )
        {
            Queue.AddTo();
            //pictureBox1.Image = Image.FromFile( "img/ArrivalGreen.jpg" );
            //pictureBox1.Image = Image.FromFile( "img/Arrival.jpg" );
            if( progressBar1.Value < progressBar1.Maximum)
                ++progressBar1.Value;
            labelProgress.Text = Queue.Counter.ToString();
            timer1.Interval = (int)(ArrivalGenerator.GetNextTime()*100);
            labelArrive.Text = $"Arrive Time: {timer1.Interval}";
            labelLosses.Text = $"Losses: {Queue.Losses}";
            counter++;
            labelCounter.Text = $"Counter: {counter}";
            if( counter > max )
            {
                timer1.Stop();
            }
        }

        private void Timer2_Tick( object sender, EventArgs e )
        {
            if( Queue.GetFrom() )
            {
                labelProgress.Text = (--progressBar1.Value).ToString();
                timer2.Interval = (int)(Service.Work()*100);
                labelServe.Text = $"Serve Time: {timer2.Interval}";
            }
            else
                timer2.Interval = 1;
            if( counter > max && Queue.Empty == true)
            {
                timer2.Stop();
            }
        }

        private void ButtonSimulate_Click( object sender, EventArgs e )
        {
            ArrivalGenerator.a = Double.Parse( textBoxA.Text );
            ArrivalGenerator.b = Double.Parse( textBoxB.Text );
            int size = Int32.Parse( textBoxSize.Text );
            Queue.Size = size;
            progressBar1.Maximum = size;
            Service.lambda = Double.Parse( textBoxLambda.Text );
            Service.shape = Int32.Parse( textBoxShape.Text );

            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
        }
    }
}
