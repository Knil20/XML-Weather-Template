namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.date4 = new System.Windows.Forms.Label();
            this.date5 = new System.Windows.Forms.Label();
            this.date6 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.max4 = new System.Windows.Forms.Label();
            this.max6 = new System.Windows.Forms.Label();
            this.max5 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.min4 = new System.Windows.Forms.Label();
            this.min5 = new System.Windows.Forms.Label();
            this.min6 = new System.Windows.Forms.Label();
            this.dayBox1 = new System.Windows.Forms.PictureBox();
            this.dayBox2 = new System.Windows.Forms.PictureBox();
            this.dayBox3 = new System.Windows.Forms.PictureBox();
            this.dayBox4 = new System.Windows.Forms.PictureBox();
            this.dayBox5 = new System.Windows.Forms.PictureBox();
            this.dayBox6 = new System.Windows.Forms.PictureBox();
            this.weekLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(186, 454);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(117, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "This Week";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today\'s Forecast";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.min1.Location = new System.Drawing.Point(314, 73);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(57, 25);
            this.min1.TabIndex = 48;
            this.min1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(312, 12);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(60, 34);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = "Min";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.ForeColor = System.Drawing.Color.Red;
            this.max1.Location = new System.Drawing.Point(236, 73);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(57, 25);
            this.max1.TabIndex = 45;
            this.max1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(233, 12);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(60, 34);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(188, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(58, 73);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(172, 25);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(58, 114);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(172, 28);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.min2.Location = new System.Drawing.Point(314, 117);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(57, 25);
            this.min2.TabIndex = 68;
            this.min2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.ForeColor = System.Drawing.Color.Red;
            this.max2.Location = new System.Drawing.Point(236, 117);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(58, 25);
            this.max2.TabIndex = 66;
            this.max2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date3
            // 
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(58, 156);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(172, 28);
            this.date3.TabIndex = 70;
            this.date3.Text = "Date";
            // 
            // date4
            // 
            this.date4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date4.ForeColor = System.Drawing.Color.White;
            this.date4.Location = new System.Drawing.Point(58, 199);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(172, 28);
            this.date4.TabIndex = 71;
            this.date4.Text = "Date";
            // 
            // date5
            // 
            this.date5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date5.ForeColor = System.Drawing.Color.White;
            this.date5.Location = new System.Drawing.Point(58, 245);
            this.date5.Name = "date5";
            this.date5.Size = new System.Drawing.Size(172, 28);
            this.date5.TabIndex = 72;
            this.date5.Text = "Date";
            // 
            // date6
            // 
            this.date6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date6.ForeColor = System.Drawing.Color.White;
            this.date6.Location = new System.Drawing.Point(58, 289);
            this.date6.Name = "date6";
            this.date6.Size = new System.Drawing.Size(172, 28);
            this.date6.TabIndex = 73;
            this.date6.Text = "Date";
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.ForeColor = System.Drawing.Color.Red;
            this.max3.Location = new System.Drawing.Point(235, 159);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(58, 25);
            this.max3.TabIndex = 74;
            this.max3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max4
            // 
            this.max4.BackColor = System.Drawing.Color.Transparent;
            this.max4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max4.ForeColor = System.Drawing.Color.Red;
            this.max4.Location = new System.Drawing.Point(236, 202);
            this.max4.Name = "max4";
            this.max4.Size = new System.Drawing.Size(58, 25);
            this.max4.TabIndex = 75;
            this.max4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max6
            // 
            this.max6.BackColor = System.Drawing.Color.Transparent;
            this.max6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max6.ForeColor = System.Drawing.Color.Red;
            this.max6.Location = new System.Drawing.Point(236, 292);
            this.max6.Name = "max6";
            this.max6.Size = new System.Drawing.Size(58, 25);
            this.max6.TabIndex = 76;
            this.max6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // max5
            // 
            this.max5.BackColor = System.Drawing.Color.Transparent;
            this.max5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max5.ForeColor = System.Drawing.Color.Red;
            this.max5.Location = new System.Drawing.Point(236, 248);
            this.max5.Name = "max5";
            this.max5.Size = new System.Drawing.Size(58, 25);
            this.max5.TabIndex = 76;
            this.max5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.Transparent;
            this.min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.min3.Location = new System.Drawing.Point(314, 159);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(57, 25);
            this.min3.TabIndex = 77;
            this.min3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min4
            // 
            this.min4.BackColor = System.Drawing.Color.Transparent;
            this.min4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.min4.Location = new System.Drawing.Point(314, 202);
            this.min4.Name = "min4";
            this.min4.Size = new System.Drawing.Size(57, 25);
            this.min4.TabIndex = 78;
            this.min4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min5
            // 
            this.min5.BackColor = System.Drawing.Color.Transparent;
            this.min5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.min5.Location = new System.Drawing.Point(313, 248);
            this.min5.Name = "min5";
            this.min5.Size = new System.Drawing.Size(57, 25);
            this.min5.TabIndex = 79;
            this.min5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // min6
            // 
            this.min6.BackColor = System.Drawing.Color.Transparent;
            this.min6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.min6.Location = new System.Drawing.Point(314, 292);
            this.min6.Name = "min6";
            this.min6.Size = new System.Drawing.Size(57, 25);
            this.min6.TabIndex = 80;
            this.min6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayBox1
            // 
            this.dayBox1.BackColor = System.Drawing.Color.Transparent;
            this.dayBox1.Location = new System.Drawing.Point(8, 68);
            this.dayBox1.Name = "dayBox1";
            this.dayBox1.Size = new System.Drawing.Size(30, 30);
            this.dayBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayBox1.TabIndex = 81;
            this.dayBox1.TabStop = false;
            // 
            // dayBox2
            // 
            this.dayBox2.BackColor = System.Drawing.Color.Transparent;
            this.dayBox2.Location = new System.Drawing.Point(8, 112);
            this.dayBox2.Name = "dayBox2";
            this.dayBox2.Size = new System.Drawing.Size(30, 30);
            this.dayBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayBox2.TabIndex = 82;
            this.dayBox2.TabStop = false;
            // 
            // dayBox3
            // 
            this.dayBox3.BackColor = System.Drawing.Color.Transparent;
            this.dayBox3.Location = new System.Drawing.Point(8, 154);
            this.dayBox3.Name = "dayBox3";
            this.dayBox3.Size = new System.Drawing.Size(30, 30);
            this.dayBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayBox3.TabIndex = 83;
            this.dayBox3.TabStop = false;
            // 
            // dayBox4
            // 
            this.dayBox4.BackColor = System.Drawing.Color.Transparent;
            this.dayBox4.Location = new System.Drawing.Point(8, 197);
            this.dayBox4.Name = "dayBox4";
            this.dayBox4.Size = new System.Drawing.Size(30, 30);
            this.dayBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayBox4.TabIndex = 84;
            this.dayBox4.TabStop = false;
            // 
            // dayBox5
            // 
            this.dayBox5.BackColor = System.Drawing.Color.Transparent;
            this.dayBox5.Location = new System.Drawing.Point(8, 243);
            this.dayBox5.Name = "dayBox5";
            this.dayBox5.Size = new System.Drawing.Size(30, 30);
            this.dayBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayBox5.TabIndex = 85;
            this.dayBox5.TabStop = false;
            // 
            // dayBox6
            // 
            this.dayBox6.BackColor = System.Drawing.Color.Transparent;
            this.dayBox6.Location = new System.Drawing.Point(8, 287);
            this.dayBox6.Name = "dayBox6";
            this.dayBox6.Size = new System.Drawing.Size(30, 30);
            this.dayBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dayBox6.TabIndex = 86;
            this.dayBox6.TabStop = false;
            // 
            // weekLabel
            // 
            this.weekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekLabel.ForeColor = System.Drawing.Color.Gold;
            this.weekLabel.Location = new System.Drawing.Point(8, 12);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(222, 34);
            this.weekLabel.TabIndex = 87;
            this.weekLabel.Text = "Week\'s Forecast";
            this.weekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 88;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekLabel);
            this.Controls.Add(this.dayBox6);
            this.Controls.Add(this.dayBox5);
            this.Controls.Add(this.dayBox4);
            this.Controls.Add(this.dayBox3);
            this.Controls.Add(this.dayBox2);
            this.Controls.Add(this.dayBox1);
            this.Controls.Add(this.min6);
            this.Controls.Add(this.min5);
            this.Controls.Add(this.min4);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.max5);
            this.Controls.Add(this.max6);
            this.Controls.Add(this.max4);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.date6);
            this.Controls.Add(this.date5);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(400, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dayBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label date4;
        private System.Windows.Forms.Label date5;
        private System.Windows.Forms.Label date6;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label max4;
        private System.Windows.Forms.Label max6;
        private System.Windows.Forms.Label max5;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label min4;
        private System.Windows.Forms.Label min5;
        private System.Windows.Forms.Label min6;
        private System.Windows.Forms.PictureBox dayBox1;
        private System.Windows.Forms.PictureBox dayBox2;
        private System.Windows.Forms.PictureBox dayBox3;
        private System.Windows.Forms.PictureBox dayBox4;
        private System.Windows.Forms.PictureBox dayBox5;
        private System.Windows.Forms.PictureBox dayBox6;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label label1;
    }
}
