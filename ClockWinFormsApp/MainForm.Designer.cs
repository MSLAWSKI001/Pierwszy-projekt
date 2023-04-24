
namespace ClockWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelClock = new System.Windows.Forms.Label();
            this.ReadTime = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelStoper = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.buttonstopdelta = new System.Windows.Forms.Button();
            this.buttonstartdelta = new System.Windows.Forms.Button();
            this.labeldelta = new System.Windows.Forms.Label();
            this.timerdelta = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(74, 72);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(38, 15);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "label1";
            // 
            // ReadTime
            // 
            this.ReadTime.Location = new System.Drawing.Point(12, 148);
            this.ReadTime.Name = "ReadTime";
            this.ReadTime.Size = new System.Drawing.Size(251, 60);
            this.ReadTime.TabIndex = 1;
            this.ReadTime.Text = "Odczytaj czas";
            this.ReadTime.UseVisualStyleBackColor = true;
            this.ReadTime.Click += new System.EventHandler(this.ReadTime_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelStoper
            // 
            this.labelStoper.AutoSize = true;
            this.labelStoper.Location = new System.Drawing.Point(422, 27);
            this.labelStoper.Name = "labelStoper";
            this.labelStoper.Size = new System.Drawing.Size(90, 15);
            this.labelStoper.TabIndex = 2;
            this.labelStoper.Text = "labelStopWatch";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(422, 91);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(543, 91);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // buttonstopdelta
            // 
            this.buttonstopdelta.Location = new System.Drawing.Point(558, 262);
            this.buttonstopdelta.Name = "buttonstopdelta";
            this.buttonstopdelta.Size = new System.Drawing.Size(75, 23);
            this.buttonstopdelta.TabIndex = 7;
            this.buttonstopdelta.Text = "Stop";
            this.buttonstopdelta.UseVisualStyleBackColor = true;
            this.buttonstopdelta.Click += new System.EventHandler(this.buttonstopdelta_Click);
            // 
            // buttonstartdelta
            // 
            this.buttonstartdelta.Location = new System.Drawing.Point(404, 262);
            this.buttonstartdelta.Name = "buttonstartdelta";
            this.buttonstartdelta.Size = new System.Drawing.Size(75, 23);
            this.buttonstartdelta.TabIndex = 6;
            this.buttonstartdelta.Text = "Start";
            this.buttonstartdelta.UseVisualStyleBackColor = true;
            this.buttonstartdelta.Click += new System.EventHandler(this.buttonstartdelta_Click);
            // 
            // labeldelta
            // 
            this.labeldelta.AutoSize = true;
            this.labeldelta.Location = new System.Drawing.Point(422, 193);
            this.labeldelta.Name = "labeldelta";
            this.labeldelta.Size = new System.Drawing.Size(116, 15);
            this.labeldelta.TabIndex = 5;
            this.labeldelta.Text = "labelStopWatchdelta";
            // 
            // timerdelta
            // 
            this.timerdelta.Tick += new System.EventHandler(this.timerdelta_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonstopdelta);
            this.Controls.Add(this.buttonstartdelta);
            this.Controls.Add(this.labeldelta);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelStoper);
            this.Controls.Add(this.ReadTime);
            this.Controls.Add(this.labelClock);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button ReadTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelStoper;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerStopWatch;
        private System.Windows.Forms.Button buttonstopdelta;
        private System.Windows.Forms.Button buttonstartdelta;
        private System.Windows.Forms.Label labeldelta;
        private System.Windows.Forms.Timer timerdelta;
    }
}

