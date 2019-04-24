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
        int speed = 10;
        Stopwatch totalModelingTime = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load( object sender, EventArgs e )
        {
            SetTimerInterval(Arrival.GetNextTime(), timerArrival, speed);
            labelArrive.Text = $"Arrive Time: {timerArrival.Interval}";

            SetTimerInterval(Service.Work(), timerSevice, speed);
            labelServe.Text = $"Serve Time: {timerSevice.Interval}";

            timerAverageInQueue.Interval = 1000;

            progressBarQueue.Minimum = 0;
            progressBarQueue.Value = 0;
        }

        private void SetTimerInterval(double method, Timer timer,int speed)
        {
            int nextTime = (int)(method * speed);
            if (nextTime != 0)
                timer.Interval = nextTime;
            else
                timer.Interval = 1;
        }

        private void TimerArrival_Tick( object sender, EventArgs e )
        {
            Queue.AddTo();

            progressBarQueue.Value = Queue.Messages.Count;
            labelProgress.Text = Queue.Counter.ToString();

            SetTimerInterval(Arrival.GetNextTime(), timerArrival, speed);

            labelArrive.Text = $"Arrive Time: {timerArrival.Interval}";
            labelLosses.Text = $"Losses: {Queue.Losses}";
            labelCounter.Text = $"Arrival.Counter: {Arrival.Counter}";
            if( Arrival.Closed )
            {
                timerArrival.Stop();
            }
        }


        //АО
        Stopwatch ServiceTime = new Stopwatch();
        private void TimerService_Tick( object sender, EventArgs e )
        {
            if(!ServiceTime.IsRunning)
                ServiceTime.Start();

            long timeQueueTemp = Queue.GetFrom();
            if (timeQueueTemp > -1)
            {
                progressBarQueue.Value = Queue.Messages.Count;
                SetTimerInterval(Service.Work(), timerSevice, speed);
                labelServe.Text = $"Serve Time: {timerSevice.Interval}";
            }
            else
            {
                //Очередь пуста ждем -1
                ServiceTime.Stop();

                timerSevice.Interval = 1;
            }
            //Условия окончания моделирования и статистика
            if( Arrival.Closed && Queue.Empty)
            {
                timerSevice.Stop();
                ServiceTime.Stop();
                totalModelingTime.Stop();

                double loadOfServiceCoefficient = (double)ServiceTime.ElapsedMilliseconds / (double)totalModelingTime.ElapsedMilliseconds;
                listView1.Items.Add("Коэффициент загрузки АО: " + (loadOfServiceCoefficient).ToString());
                listView1.Items.Add("Среднее время ожидания: " + (Message.EachMessageTimeInQueue.Sum() / Message.EachMessageTimeInQueue.Count).ToString()).EnsureVisible();
                listView1.Items.Add("Средняя длина очереди: " + (Queue.StatisticSizes.Sum() / Queue.StatisticSizes.Count).ToString()).EnsureVisible();
                double lossProbability = (double)Queue.Losses / Arrival.Max;
                listView1.Items.Add("Вероятность потери:" + (lossProbability).ToString());
                //Подсчет оптимальной очереди
                if (Queue.Losses == 0)
                    listView1.Items.Add($"Оптимальная очередь: {Queue.Size}");
                else
                    listView1.Items.Add($"Очередь: {Queue.Size}");
                if (lossProbability != 0)
                {
                    Queue.Size = Queue.Size + (int)(lossProbability * 1000);
                    StartModelling();
                }
                else if (loadOfServiceCoefficient < 0.90 && Queue.Size > 1)
                {
                    Queue.Size = 1;
                    StartModelling();
                }
            }
        }
       
        private void ButtonSimulate_Click( object sender, EventArgs e )
        {
            Arrival.Max = Int32.Parse(textBox1.Text);
            Arrival.a = Double.Parse(textBoxA.Text);
            Arrival.b = Double.Parse(textBoxB.Text);

            Service.lambda = Double.Parse(textBoxLambda.Text);
            Service.shape = Int32.Parse(textBoxShape.Text);

            Queue.Size = Int32.Parse(textBoxSize.Text);
            StartModelling();

        }

        private void StartModelling()
        {

            int res1;
            if ((res1 = (int)(Arrival.GetNextTime() * speed)) == 0)
                timerArrival.Interval = 1;
            else
                timerArrival.Interval = res1;
            labelArrive.Text = $"Arrive Time: {timerArrival.Interval}";

            int res2;
            if ((res2 = (int)(Service.Work() * speed)) == 0)
                timerSevice.Interval = 1;
            else
                timerSevice.Interval = res2;
            //сброс
            Arrival.Counter = 0;
            Queue.Losses = 0;

            
            
    
            progressBarQueue.Maximum = Queue.Size;
            

            timerArrival.Enabled = true;
            timerArrival.Start();
            timerSevice.Enabled = true;
            timerSevice.Start();
            timerAverageInQueue.Enabled = true;
            timerAverageInQueue.Start();

            totalModelingTime.Start();
        }

        private void timerStatistic(object sender, EventArgs e)
        {
            Queue.StatisticSizes.Add(progressBarQueue.Value);
        }
    }
}
