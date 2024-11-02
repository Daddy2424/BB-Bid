namespace videoPlayer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Monthly = new System.Windows.Forms.Button();
            this.btn_Hourly = new System.Windows.Forms.Button();
            this.inp_BullKeyX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inp_BullKeyY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.inp_BearKeyX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inp_BearKeyY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_BullVolume = new System.Windows.Forms.Label();
            this.lbl_BearVolume = new System.Windows.Forms.Label();
            this.lbl_BullishLevelX = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_BullishLevelY = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_BearishLevelY = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl_BearishLevelX = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_Bull = new System.Windows.Forms.ProgressBar();
            this.pb_Bear = new System.Windows.Forms.ProgressBar();
            this.btn_Help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BullKeyX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BullKeyY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BearKeyX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BearKeyY)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.No;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(23, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 5;
            series3.Name = "BULLISH";
            series3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.YValuesPerPoint = 4;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "BEARISH";
            series4.YValuesPerPoint = 4;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(858, 489);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.BackColor = System.Drawing.Color.WhiteSmoke;
            title2.Name = "DATA";
            title2.Text = "Vizualizer";
            this.chart1.Titles.Add(title2);
            // 
            // btn_Order
            // 
            this.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order.Location = new System.Drawing.Point(963, 438);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(145, 52);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Monthly
            // 
            this.btn_Monthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Monthly.Location = new System.Drawing.Point(174, 507);
            this.btn_Monthly.Name = "btn_Monthly";
            this.btn_Monthly.Size = new System.Drawing.Size(145, 52);
            this.btn_Monthly.TabIndex = 2;
            this.btn_Monthly.Text = "Stop Vizualizing";
            this.btn_Monthly.UseVisualStyleBackColor = true;
            this.btn_Monthly.Click += new System.EventHandler(this.btn_Monthly_Click);
            // 
            // btn_Hourly
            // 
            this.btn_Hourly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Hourly.Location = new System.Drawing.Point(23, 507);
            this.btn_Hourly.Name = "btn_Hourly";
            this.btn_Hourly.Size = new System.Drawing.Size(145, 52);
            this.btn_Hourly.TabIndex = 3;
            this.btn_Hourly.Text = "Start Vizualizing";
            this.btn_Hourly.UseVisualStyleBackColor = true;
            this.btn_Hourly.Click += new System.EventHandler(this.btn_Hourly_Click);
            // 
            // inp_BullKeyX
            // 
            this.inp_BullKeyX.Location = new System.Drawing.Point(1077, 61);
            this.inp_BullKeyX.Name = "inp_BullKeyX";
            this.inp_BullKeyX.Size = new System.Drawing.Size(120, 22);
            this.inp_BullKeyX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(960, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bullish Key At X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(960, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bullish Key At Y :";
            // 
            // inp_BullKeyY
            // 
            this.inp_BullKeyY.Location = new System.Drawing.Point(1077, 98);
            this.inp_BullKeyY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inp_BullKeyY.Name = "inp_BullKeyY";
            this.inp_BullKeyY.Size = new System.Drawing.Size(120, 22);
            this.inp_BullKeyY.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(961, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bearish Key At X :";
            // 
            // inp_BearKeyX
            // 
            this.inp_BearKeyX.Location = new System.Drawing.Point(1090, 191);
            this.inp_BearKeyX.Name = "inp_BearKeyX";
            this.inp_BearKeyX.Size = new System.Drawing.Size(120, 22);
            this.inp_BearKeyX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bearish Key At Y :";
            // 
            // inp_BearKeyY
            // 
            this.inp_BearKeyY.Location = new System.Drawing.Point(1090, 234);
            this.inp_BearKeyY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inp_BearKeyY.Name = "inp_BearKeyY";
            this.inp_BearKeyY.Size = new System.Drawing.Size(120, 22);
            this.inp_BearKeyY.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(960, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bullish Volume :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(960, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bearish Volume :";
            // 
            // lbl_BullVolume
            // 
            this.lbl_BullVolume.AutoSize = true;
            this.lbl_BullVolume.Location = new System.Drawing.Point(1071, 331);
            this.lbl_BullVolume.Name = "lbl_BullVolume";
            this.lbl_BullVolume.Size = new System.Drawing.Size(14, 16);
            this.lbl_BullVolume.TabIndex = 14;
            this.lbl_BullVolume.Text = "0";
            // 
            // lbl_BearVolume
            // 
            this.lbl_BearVolume.AutoSize = true;
            this.lbl_BearVolume.Location = new System.Drawing.Point(1074, 369);
            this.lbl_BearVolume.Name = "lbl_BearVolume";
            this.lbl_BearVolume.Size = new System.Drawing.Size(14, 16);
            this.lbl_BearVolume.TabIndex = 15;
            this.lbl_BearVolume.Text = "0";
            // 
            // lbl_BullishLevelX
            // 
            this.lbl_BullishLevelX.AutoSize = true;
            this.lbl_BullishLevelX.Location = new System.Drawing.Point(831, 560);
            this.lbl_BullishLevelX.Name = "lbl_BullishLevelX";
            this.lbl_BullishLevelX.Size = new System.Drawing.Size(14, 16);
            this.lbl_BullishLevelX.TabIndex = 17;
            this.lbl_BullishLevelX.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(720, 560);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(99, 16);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Bullish Level X :";
            // 
            // lbl_BullishLevelY
            // 
            this.lbl_BullishLevelY.AutoSize = true;
            this.lbl_BullishLevelY.Location = new System.Drawing.Point(973, 560);
            this.lbl_BullishLevelY.Name = "lbl_BullishLevelY";
            this.lbl_BullishLevelY.Size = new System.Drawing.Size(14, 16);
            this.lbl_BullishLevelY.TabIndex = 19;
            this.lbl_BullishLevelY.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(862, 560);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 16);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Bullish Level Y :";
            // 
            // lbl_BearishLevelY
            // 
            this.lbl_BearishLevelY.AutoSize = true;
            this.lbl_BearishLevelY.Location = new System.Drawing.Point(1300, 560);
            this.lbl_BearishLevelY.Name = "lbl_BearishLevelY";
            this.lbl_BearishLevelY.Size = new System.Drawing.Size(14, 16);
            this.lbl_BearishLevelY.TabIndex = 23;
            this.lbl_BearishLevelY.Text = "0";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(1189, 560);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(107, 16);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "Bearish Level Y :";
            // 
            // lbl_BearishLevelX
            // 
            this.lbl_BearishLevelX.AutoSize = true;
            this.lbl_BearishLevelX.Location = new System.Drawing.Point(1158, 560);
            this.lbl_BearishLevelX.Name = "lbl_BearishLevelX";
            this.lbl_BearishLevelX.Size = new System.Drawing.Size(14, 16);
            this.lbl_BearishLevelX.TabIndex = 21;
            this.lbl_BearishLevelX.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(1047, 560);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(106, 16);
            this.lbl3.TabIndex = 20;
            this.lbl3.Text = "Bearish Level X :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "KEY X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "KEY Y";
            // 
            // pb_Bull
            // 
            this.pb_Bull.Location = new System.Drawing.Point(1113, 331);
            this.pb_Bull.Name = "pb_Bull";
            this.pb_Bull.Size = new System.Drawing.Size(100, 23);
            this.pb_Bull.TabIndex = 26;
            // 
            // pb_Bear
            // 
            this.pb_Bear.Location = new System.Drawing.Point(1113, 369);
            this.pb_Bear.Name = "pb_Bear";
            this.pb_Bear.Size = new System.Drawing.Size(100, 23);
            this.pb_Bear.TabIndex = 27;
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(743, 507);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(138, 27);
            this.btn_Help.TabIndex = 28;
            this.btn_Help.Text = "Help?";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 585);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.pb_Bear);
            this.Controls.Add(this.pb_Bull);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_BearishLevelY);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl_BearishLevelX);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl_BullishLevelY);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl_BullishLevelX);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl_BearVolume);
            this.Controls.Add(this.lbl_BullVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inp_BearKeyY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inp_BearKeyX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inp_BullKeyY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inp_BullKeyX);
            this.Controls.Add(this.btn_Hourly);
            this.Controls.Add(this.btn_Monthly);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "BB Bid";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BullKeyX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BullKeyY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BearKeyX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inp_BearKeyY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Monthly;
        private System.Windows.Forms.Button btn_Hourly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Help;
        public System.Windows.Forms.ProgressBar pb_Bull;
        public System.Windows.Forms.ProgressBar pb_Bear;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.NumericUpDown inp_BullKeyX;
        public System.Windows.Forms.NumericUpDown inp_BullKeyY;
        public System.Windows.Forms.NumericUpDown inp_BearKeyX;
        public System.Windows.Forms.NumericUpDown inp_BearKeyY;
        public System.Windows.Forms.Label lbl_BullVolume;
        public System.Windows.Forms.Label lbl_BearVolume;
        public System.Windows.Forms.Label lbl_BullishLevelX;
        public System.Windows.Forms.Label lbl_BullishLevelY;
        public System.Windows.Forms.Label lbl_BearishLevelY;
        public System.Windows.Forms.Label lbl_BearishLevelX;
    }
}

