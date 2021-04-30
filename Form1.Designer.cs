
namespace AutoClick
{
    partial class Form1
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
            this.btPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalClickCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.btStops = new System.Windows.Forms.Button();
            this.tbSec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPause = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStartAfter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPause
            // 
            this.btPause.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPause.Location = new System.Drawing.Point(506, 335);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(248, 63);
            this.btPause.TabIndex = 0;
            this.btPause.Text = "PAUSE";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(253, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total click(s)";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTotal.Location = new System.Drawing.Point(234, 117);
            this.tbTotal.MaxLength = 10;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(195, 50);
            this.tbTotal.TabIndex = 4;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(506, 266);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(248, 63);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current clicks count";
            // 
            // lbTotalClickCount
            // 
            this.lbTotalClickCount.AutoSize = true;
            this.lbTotalClickCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalClickCount.Location = new System.Drawing.Point(161, 322);
            this.lbTotalClickCount.Name = "lbTotalClickCount";
            this.lbTotalClickCount.Size = new System.Drawing.Size(37, 45);
            this.lbTotalClickCount.TabIndex = 7;
            this.lbTotalClickCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(265, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Si Dang AutoClick";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(37, 387);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(0, 30);
            this.lbStartTime.TabIndex = 10;
            // 
            // btStops
            // 
            this.btStops.Location = new System.Drawing.Point(538, 404);
            this.btStops.Name = "btStops";
            this.btStops.Size = new System.Drawing.Size(183, 34);
            this.btStops.TabIndex = 11;
            this.btStops.Text = "STOP";
            this.btStops.UseVisualStyleBackColor = true;
            this.btStops.Click += new System.EventHandler(this.btStops_Click);
            // 
            // tbSec
            // 
            this.tbSec.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSec.Location = new System.Drawing.Point(12, 117);
            this.tbSec.MaxLength = 10;
            this.tbSec.Name = "tbSec";
            this.tbSec.Size = new System.Drawing.Size(198, 50);
            this.tbSec.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(80, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pause for ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPause
            // 
            this.tbPause.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPause.Location = new System.Drawing.Point(216, 188);
            this.tbPause.MaxLength = 5;
            this.tbPause.Name = "tbPause";
            this.tbPause.Size = new System.Drawing.Size(144, 50);
            this.tbPause.TabIndex = 14;
            this.tbPause.TextChanged += new System.EventHandler(this.tbPause_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(366, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(406, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "second(s) if mouse was moved";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(470, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Start after";
            // 
            // tbStartAfter
            // 
            this.tbStartAfter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStartAfter.Location = new System.Drawing.Point(453, 117);
            this.tbStartAfter.MaxLength = 5;
            this.tbStartAfter.Name = "tbStartAfter";
            this.tbStartAfter.Size = new System.Drawing.Size(167, 50);
            this.tbStartAfter.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(626, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "second(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbStartAfter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSec);
            this.Controls.Add(this.btStops);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalClickCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPause);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Si Dang AutoClick";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalClickCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Button btStops;
        private System.Windows.Forms.TextBox tbSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPause;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStartAfter;
        private System.Windows.Forms.Label label8;
    }
}

