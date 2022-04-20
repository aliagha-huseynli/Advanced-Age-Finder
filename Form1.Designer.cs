namespace Yasimi_bul
{
    partial class AgeFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeFinder));
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopDays = new System.Windows.Forms.TextBox();
            this.txtTopHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopMins = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTopSecs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timeLife = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(31, 78);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Your Birth Date";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAge.ForeColor = System.Drawing.Color.Red;
            this.txtAge.Location = new System.Drawing.Point(376, 43);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 38);
            this.txtAge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(396, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Age";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(136, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find My Age";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Days";
            // 
            // txtTopDays
            // 
            this.txtTopDays.Enabled = false;
            this.txtTopDays.Location = new System.Drawing.Point(123, 115);
            this.txtTopDays.Name = "txtTopDays";
            this.txtTopDays.Size = new System.Drawing.Size(332, 20);
            this.txtTopDays.TabIndex = 6;
            // 
            // txtTopHours
            // 
            this.txtTopHours.Enabled = false;
            this.txtTopHours.Location = new System.Drawing.Point(123, 150);
            this.txtTopHours.Name = "txtTopHours";
            this.txtTopHours.Size = new System.Drawing.Size(332, 20);
            this.txtTopHours.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Hours";
            // 
            // txtTopMins
            // 
            this.txtTopMins.Enabled = false;
            this.txtTopMins.Location = new System.Drawing.Point(123, 188);
            this.txtTopMins.Name = "txtTopMins";
            this.txtTopMins.Size = new System.Drawing.Size(332, 20);
            this.txtTopMins.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Minutes";
            // 
            // txtTopSecs
            // 
            this.txtTopSecs.Enabled = false;
            this.txtTopSecs.Location = new System.Drawing.Point(123, 227);
            this.txtTopSecs.Name = "txtTopSecs";
            this.txtTopSecs.Size = new System.Drawing.Size(332, 20);
            this.txtTopSecs.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Seconds";
            // 
            // timeLife
            // 
            this.timeLife.Interval = 1000;
            this.timeLife.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AgeFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(509, 392);
            this.Controls.Add(this.txtTopSecs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTopMins);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTopHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTopDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBirthDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgeFinder";
            this.Text = "Age Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTopDays;
        private System.Windows.Forms.TextBox txtTopHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTopMins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTopSecs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timeLife;
    }
}

