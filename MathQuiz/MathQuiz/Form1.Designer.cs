namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.proRightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.proLeftLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(196, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Left";
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Time.Location = new System.Drawing.Point(329, 42);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(92, 17);
            this.Time.TabIndex = 1;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Location = new System.Drawing.Point(152, 101);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "+";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Location = new System.Drawing.Point(274, 101);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(16, 17);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(415, 101);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 22);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(416, 165);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 22);
            this.product.TabIndex = 4;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "=";
            // 
            // proRightLabel
            // 
            this.proRightLabel.AutoSize = true;
            this.proRightLabel.Location = new System.Drawing.Point(274, 165);
            this.proRightLabel.Name = "proRightLabel";
            this.proRightLabel.Size = new System.Drawing.Size(16, 17);
            this.proRightLabel.TabIndex = 9;
            this.proRightLabel.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "*";
            // 
            // proLeftLabel
            // 
            this.proLeftLabel.AutoSize = true;
            this.proLeftLabel.Location = new System.Drawing.Point(153, 165);
            this.proLeftLabel.Name = "proLeftLabel";
            this.proLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.proLeftLabel.TabIndex = 7;
            this.proLeftLabel.Text = "?";
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(415, 134);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 22);
            this.difference.TabIndex = 3;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "=";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Location = new System.Drawing.Point(274, 134);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(16, 17);
            this.minusRightLabel.TabIndex = 14;
            this.minusRightLabel.Text = "?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "-";
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Location = new System.Drawing.Point(152, 134);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.minusLeftLabel.TabIndex = 12;
            this.minusLeftLabel.Text = "?";
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(415, 201);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(120, 22);
            this.div.TabIndex = 5;
            this.div.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(382, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "=";
            // 
            // divRightLabel
            // 
            this.divRightLabel.AutoSize = true;
            this.divRightLabel.Location = new System.Drawing.Point(274, 201);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(16, 17);
            this.divRightLabel.TabIndex = 19;
            this.divRightLabel.Text = "?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(251, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "/";
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.AutoSize = true;
            this.divLeftLabel.Location = new System.Drawing.Point(152, 201);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(16, 17);
            this.divLeftLabel.TabIndex = 17;
            this.divLeftLabel.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.div);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proRightLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.proLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label proRightLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label proLeftLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown div;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

