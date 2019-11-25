namespace Stopwatch
{
    partial class StopWatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Hours = new System.Windows.Forms.Label();
            this.label_Minutes = new System.Windows.Forms.Label();
            this.label_Seconds = new System.Windows.Forms.Label();
            this.label_DD1 = new System.Windows.Forms.Label();
            this.label_DD2 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Hours
            // 
            this.label_Hours.AutoSize = true;
            this.label_Hours.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.label_Hours.Location = new System.Drawing.Point(78, 69);
            this.label_Hours.Name = "label_Hours";
            this.label_Hours.Size = new System.Drawing.Size(121, 81);
            this.label_Hours.TabIndex = 0;
            this.label_Hours.Text = "00";
            // 
            // label_Minutes
            // 
            this.label_Minutes.AutoSize = true;
            this.label_Minutes.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.label_Minutes.Location = new System.Drawing.Point(220, 69);
            this.label_Minutes.Name = "label_Minutes";
            this.label_Minutes.Size = new System.Drawing.Size(121, 81);
            this.label_Minutes.TabIndex = 1;
            this.label_Minutes.Text = "00";
            // 
            // label_Seconds
            // 
            this.label_Seconds.AutoSize = true;
            this.label_Seconds.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.label_Seconds.Location = new System.Drawing.Point(364, 69);
            this.label_Seconds.Name = "label_Seconds";
            this.label_Seconds.Size = new System.Drawing.Size(121, 81);
            this.label_Seconds.TabIndex = 2;
            this.label_Seconds.Text = "00";
            // 
            // label_DD1
            // 
            this.label_DD1.AutoSize = true;
            this.label_DD1.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.label_DD1.Location = new System.Drawing.Point(176, 63);
            this.label_DD1.Name = "label_DD1";
            this.label_DD1.Size = new System.Drawing.Size(59, 81);
            this.label_DD1.TabIndex = 4;
            this.label_DD1.Text = ":";
            // 
            // label_DD2
            // 
            this.label_DD2.AutoSize = true;
            this.label_DD2.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Bold);
            this.label_DD2.Location = new System.Drawing.Point(320, 63);
            this.label_DD2.Name = "label_DD2";
            this.label_DD2.Size = new System.Drawing.Size(59, 81);
            this.label_DD2.TabIndex = 5;
            this.label_DD2.Text = ":";
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Start.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(61, 196);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(118, 50);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Stop.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stop.Location = new System.Drawing.Point(219, 196);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(118, 50);
            this.button_Stop.TabIndex = 8;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Reset.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.Location = new System.Drawing.Point(378, 196);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(118, 50);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(558, 306);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_DD2);
            this.Controls.Add(this.label_DD1);
            this.Controls.Add(this.label_Seconds);
            this.Controls.Add(this.label_Minutes);
            this.Controls.Add(this.label_Hours);
            this.Name = "StopWatch";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.StopWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Hours;
        private System.Windows.Forms.Label label_Minutes;
        private System.Windows.Forms.Label label_Seconds;
        private System.Windows.Forms.Label label_DD1;
        private System.Windows.Forms.Label label_DD2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Reset;
    }
}

