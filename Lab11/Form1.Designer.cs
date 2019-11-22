namespace Lab11
{
    partial class Form1
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
            this.Work = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Today = new System.Windows.Forms.Button();
            this.clinup_1 = new System.Windows.Forms.Button();
            this.Splitup = new System.Windows.Forms.Button();
            this.clinup_2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tomorrow = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.AutoSize = true;
            this.Work.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Work.Location = new System.Drawing.Point(12, 32);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(185, 25);
            this.Work.TabIndex = 0;
            this.Work.Text = "Работа с датами";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 224);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 184);
            this.textBox2.TabIndex = 2;
            // 
            // Today
            // 
            this.Today.Location = new System.Drawing.Point(68, 361);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(94, 43);
            this.Today.TabIndex = 3;
            this.Today.Text = "Сегодня";
            this.Today.UseVisualStyleBackColor = true;
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // clinup_1
            // 
            this.clinup_1.Location = new System.Drawing.Point(68, 425);
            this.clinup_1.Name = "clinup_1";
            this.clinup_1.Size = new System.Drawing.Size(94, 43);
            this.clinup_1.TabIndex = 3;
            this.clinup_1.Text = "Очистить";
            this.clinup_1.UseVisualStyleBackColor = true;
            this.clinup_1.Click += new System.EventHandler(this.clinup_1_Click);
            // 
            // Splitup
            // 
            this.Splitup.Location = new System.Drawing.Point(182, 361);
            this.Splitup.Name = "Splitup";
            this.Splitup.Size = new System.Drawing.Size(94, 43);
            this.Splitup.TabIndex = 3;
            this.Splitup.Text = "Разделить";
            this.Splitup.UseVisualStyleBackColor = true;
            this.Splitup.Click += new System.EventHandler(this.Splitup_Click);
            // 
            // clinup_2
            // 
            this.clinup_2.Location = new System.Drawing.Point(182, 425);
            this.clinup_2.Name = "clinup_2";
            this.clinup_2.Size = new System.Drawing.Size(94, 43);
            this.clinup_2.TabIndex = 3;
            this.clinup_2.Text = "Очистить";
            this.clinup_2.UseVisualStyleBackColor = true;
            this.clinup_2.Click += new System.EventHandler(this.clinup_2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(422, 414);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 4;
            // 
            // tomorrow
            // 
            this.tomorrow.Location = new System.Drawing.Point(422, 309);
            this.tomorrow.Name = "tomorrow";
            this.tomorrow.Size = new System.Drawing.Size(100, 33);
            this.tomorrow.TabIndex = 5;
            this.tomorrow.Text = "Завтра";
            this.tomorrow.UseVisualStyleBackColor = true;
            this.tomorrow.Click += new System.EventHandler(this.tomorrow_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(445, 440);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(100, 28);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Расчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.tomorrow);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.clinup_2);
            this.Controls.Add(this.Splitup);
            this.Controls.Add(this.clinup_1);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Work);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Work;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.Button clinup_1;
        private System.Windows.Forms.Button Splitup;
        private System.Windows.Forms.Button clinup_2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button tomorrow;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

