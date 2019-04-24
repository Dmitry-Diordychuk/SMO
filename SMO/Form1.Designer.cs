namespace SMO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerArrival = new System.Windows.Forms.Timer(this.components);
            this.timerSevice = new System.Windows.Forms.Timer(this.components);
            this.progressBarQueue = new System.Windows.Forms.ProgressBar();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelShape = new System.Windows.Forms.Label();
            this.labelLambda = new System.Windows.Forms.Label();
            this.textBoxShape = new System.Windows.Forms.TextBox();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelLosses = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelArrive = new System.Windows.Forms.Label();
            this.labelServe = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.timerAverageInQueue = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timerArrival.Tick += new System.EventHandler(this.TimerArrival_Tick);
            // 
            // timer2
            // 
            this.timerSevice.Tick += new System.EventHandler(this.TimerService_Tick);
            // 
            // progressBar1
            // 
            this.progressBarQueue.Location = new System.Drawing.Point(340, 96);
            this.progressBarQueue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBarQueue.Name = "progressBar1";
            this.progressBarQueue.Size = new System.Drawing.Size(205, 86);
            this.progressBarQueue.TabIndex = 0;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(88, 362);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(112, 26);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(88, 398);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(112, 26);
            this.textBoxB.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(58, 366);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(22, 20);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(58, 401);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(22, 20);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "b:";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(340, 466);
            this.buttonSimulate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(205, 81);
            this.buttonSimulate.TabIndex = 5;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.ButtonSimulate_Click);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(432, 362);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(112, 26);
            this.textBoxSize.TabIndex = 6;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(326, 362);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(93, 20);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Queue size:";
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Location = new System.Drawing.Point(717, 405);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(21, 20);
            this.labelShape.TabIndex = 11;
            this.labelShape.Text = "k:";
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(673, 370);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(65, 20);
            this.labelLambda.TabIndex = 10;
            this.labelLambda.Text = "lambda:";
            // 
            // textBoxShape
            // 
            this.textBoxShape.Location = new System.Drawing.Point(745, 401);
            this.textBoxShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxShape.Name = "textBoxShape";
            this.textBoxShape.Size = new System.Drawing.Size(112, 26);
            this.textBoxShape.TabIndex = 9;
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(745, 366);
            this.textBoxLambda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(112, 26);
            this.textBoxLambda.TabIndex = 8;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(439, 121);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(18, 20);
            this.labelProgress.TabIndex = 12;
            this.labelProgress.Text = "0";
            // 
            // labelLosses
            // 
            this.labelLosses.AutoSize = true;
            this.labelLosses.Location = new System.Drawing.Point(340, 292);
            this.labelLosses.Name = "labelLosses";
            this.labelLosses.Size = new System.Drawing.Size(77, 20);
            this.labelLosses.TabIndex = 14;
            this.labelLosses.Text = "Losses: 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SMO.Properties.Resources.Service;
            this.pictureBox2.Location = new System.Drawing.Point(574, 62);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMO.Properties.Resources.Arrival;
            this.pictureBox1.Location = new System.Drawing.Point(191, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelArrive
            // 
            this.labelArrive.AutoSize = true;
            this.labelArrive.Location = new System.Drawing.Point(202, 22);
            this.labelArrive.Name = "labelArrive";
            this.labelArrive.Size = new System.Drawing.Size(104, 20);
            this.labelArrive.TabIndex = 16;
            this.labelArrive.Text = "Arrive Time: 0";
            // 
            // labelServe
            // 
            this.labelServe.AutoSize = true;
            this.labelServe.Location = new System.Drawing.Point(587, 22);
            this.labelServe.Name = "labelServe";
            this.labelServe.Size = new System.Drawing.Size(105, 20);
            this.labelServe.TabIndex = 17;
            this.labelServe.Text = "Serve Time: 0";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(340, 260);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(83, 20);
            this.labelCounter.TabIndex = 18;
            this.labelCounter.Text = "Counter: 0";
            // 
            // timerMidTimeInQueue
            // 
            this.timerAverageInQueue.Tick += new System.EventHandler(this.timerStatistic);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(721, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 265);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quantity of arrivers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelServe);
            this.Controls.Add(this.labelArrive);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelLosses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelShape);
            this.Controls.Add(this.labelLambda);
            this.Controls.Add(this.textBoxShape);
            this.Controls.Add(this.textBoxLambda);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.progressBarQueue);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerArrival;
        private System.Windows.Forms.Timer timerSevice;
        private System.Windows.Forms.ProgressBar progressBarQueue;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Label labelLambda;
        private System.Windows.Forms.TextBox textBoxShape;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLosses;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelArrive;
        private System.Windows.Forms.Label labelServe;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Timer timerAverageInQueue;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

