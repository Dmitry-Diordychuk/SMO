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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(302, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 69);
            this.progressBar1.TabIndex = 0;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(78, 290);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(78, 318);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 2;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(52, 293);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(20, 17);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(52, 321);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 17);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "b:";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(302, 373);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(182, 65);
            this.buttonSimulate.TabIndex = 5;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.ButtonSimulate_Click);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(384, 290);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxSize.TabIndex = 6;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(290, 290);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(84, 17);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Queue size:";
            // 
            // labelShape
            // 
            this.labelShape.AutoSize = true;
            this.labelShape.Location = new System.Drawing.Point(637, 324);
            this.labelShape.Name = "labelShape";
            this.labelShape.Size = new System.Drawing.Size(19, 17);
            this.labelShape.TabIndex = 11;
            this.labelShape.Text = "k:";
            // 
            // labelLambda
            // 
            this.labelLambda.AutoSize = true;
            this.labelLambda.Location = new System.Drawing.Point(598, 296);
            this.labelLambda.Name = "labelLambda";
            this.labelLambda.Size = new System.Drawing.Size(58, 17);
            this.labelLambda.TabIndex = 10;
            this.labelLambda.Text = "lambda:";
            // 
            // textBoxShape
            // 
            this.textBoxShape.Location = new System.Drawing.Point(662, 321);
            this.textBoxShape.Name = "textBoxShape";
            this.textBoxShape.Size = new System.Drawing.Size(100, 22);
            this.textBoxShape.TabIndex = 9;
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(662, 293);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(100, 22);
            this.textBoxLambda.TabIndex = 8;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(390, 97);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(16, 17);
            this.labelProgress.TabIndex = 12;
            this.labelProgress.Text = "0";
            // 
            // labelLosses
            // 
            this.labelLosses.AutoSize = true;
            this.labelLosses.Location = new System.Drawing.Point(302, 234);
            this.labelLosses.Name = "labelLosses";
            this.labelLosses.Size = new System.Drawing.Size(69, 17);
            this.labelLosses.TabIndex = 14;
            this.labelLosses.Text = "Losses: 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SMO.Properties.Resources.Service;
            this.pictureBox2.Location = new System.Drawing.Point(510, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMO.Properties.Resources.Arrival;
            this.pictureBox1.Location = new System.Drawing.Point(170, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelArrive
            // 
            this.labelArrive.AutoSize = true;
            this.labelArrive.Location = new System.Drawing.Point(180, 18);
            this.labelArrive.Name = "labelArrive";
            this.labelArrive.Size = new System.Drawing.Size(96, 17);
            this.labelArrive.TabIndex = 16;
            this.labelArrive.Text = "Arrive Time: 0";
            // 
            // labelServe
            // 
            this.labelServe.AutoSize = true;
            this.labelServe.Location = new System.Drawing.Point(522, 18);
            this.labelServe.Name = "labelServe";
            this.labelServe.Size = new System.Drawing.Size(96, 17);
            this.labelServe.TabIndex = 17;
            this.labelServe.Text = "Serve Time: 0";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(302, 208);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(74, 17);
            this.labelCounter.TabIndex = 18;
            this.labelCounter.Text = "Counter: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar progressBar1;
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
    }
}

