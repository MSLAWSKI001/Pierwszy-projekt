
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
            this.ReadTime.Location = new System.Drawing.Point(99, 218);
            this.ReadTime.Name = "ReadTime";
            this.ReadTime.Size = new System.Drawing.Size(205, 23);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadTime);
            this.Controls.Add(this.labelClock);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button ReadTime;
        private System.Windows.Forms.Timer timerClock;
    }
}

