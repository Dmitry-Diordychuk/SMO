using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SMO
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int max = 1000;
        int speed = 10;
        Stopwatch modelingTime = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load( object sender, EventArgs e )
        {
            int res1;
            if ((res1 = (int)(ArrivalGenerator.GetNextTime() * speed)) == 0)
                timer1.Interval = 1;
            else
                timer1.Interval = res1;
            labelArrive.Text = $"Arrive Time: {timer1.Interval}";

            int res2;
            if ((res2 = (int)(Service.Work() * speed)) == 0)
                timer2.Interval = 1;
            else
                timer2.Interval = res2;

            labelServe.Text = $"Serve Time: {timer2.Interval}";

            timerMidTimeInQueue.Interval = 1000;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
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
            int res1;
            if ((res1 = (int)(ArrivalGenerator.GetNextTime() * speed)) == 0)
                timer1.Interval = 1;
            else
                timer1.Interval = res1;
            labelArrive.Text = $"Arrive Time: {timer1.Interval}";
            labelLosses.Text = $"Losses: {Queue.Losses}";
            counter++;
            labelCounter.Text = $"Counter: {counter}";
            if( counter+Queue.Losses > max )
            {
                timer1.Stop();
            }
        }
        List<long> timesInQueue = new List<long>();
        List<int> midQueueSize = new List<int>();
        Stopwatch aoTime = new Stopwatch();
        //АО
        private void Timer2_Tick( object sender, EventArgs e )
        {
            long timeQueueTemp = Queue.GetFrom();
            if(!aoTime.IsRunning)
                aoTime.Start();
            if (timeQueueTemp > -1)
            {
                timesInQueue.Add(timeQueueTemp);
                labelProgress.Text = (--progressBar1.Value).ToString();
                int res;
                if ((res = (int)(Service.Work() * speed)) == 0)
                    timer2.Interval = 1;
                else
                    timer2.Interval = res;
                labelServe.Text = $"Serve Time: {timer2.Interval}";
            }
            else
            {
                aoTime.Stop();
                timer2.Interval = 1;
            }
            //Условия окончания моделирования
            if( counter+Queue.Losses > max && Queue.Empty == true)
            {
                timer2.Stop();
                double losses = (double)Queue.Losses / max ;
                aoTime.Stop();
                modelingTime.Stop();
                double time = (double)aoTime.ElapsedMilliseconds / (double)modelingTime.ElapsedMilliseconds;
                listView1.Items.Add("Коэффициент загрузки АО: " + (time).ToString());
                listView1.Items.Add("Среднее время ожидания: "+(timesInQueue.Sum() / timesInQueue.Count).ToString()).EnsureVisible();
                listView1.Items.Add("Средняя длина очереди: " + (midQueueSize.Sum() / midQueueSize.Count).ToString()).EnsureVisible();
                listView1.Items.Add("Вероятность потери:" + (losses).ToString());
                if (Queue.Losses == 0)
                    listView1.Items.Add($"Оптимальная очередь: {size}");
                else
                    listView1.Items.Add($"Очередь: {size}");
                if (losses != 0)
                {
                    size = size + (int)(losses * 1000);
                    StartModelling(size);
                }
                else if (time < 0.99 && Queue.Size > 1)
                {
                    size = 1;
                    StartModelling(size);
                }
            }
        }
        int size;
        private void ButtonSimulate_Click( object sender, EventArgs e )
        {
            max = Int32.Parse(textBox1.Text);

            ArrivalGenerator.a = Double.Parse(textBoxA.Text);
            ArrivalGenerator.b = Double.Parse(textBoxB.Text);

            Service.lambda = Double.Parse(textBoxLambda.Text);
            Service.shape = Int32.Parse(textBoxShape.Text);

            size = Int32.Parse(textBoxSize.Text);
            StartModelling(size);

        }

        private void StartModelling(int size)
        {

            int res1;
            if ((res1 = (int)(ArrivalGenerator.GetNextTime() * speed)) == 0)
                timer1.Interval = 1;
            else
                timer1.Interval = res1;
            labelArrive.Text = $"Arrive Time: {timer1.Interval}";

            int res2;
            if ((res2 = (int)(Service.Work() * speed)) == 0)
                timer2.Interval = 1;
            else
                timer2.Interval = res2;
            //сброс
            counter = 0;
            Queue.Losses = 0;

            
            
            Queue.Size = size;
            progressBar1.Maximum = size;
            

            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
            timerMidTimeInQueue.Enabled = true;
            timerMidTimeInQueue.Start();

            modelingTime.Start();
        }

        private void timerStatistic(object sender, EventArgs e)
        {

            midQueueSize.Add(progressBar1.Value);

           
        }
    }
}
