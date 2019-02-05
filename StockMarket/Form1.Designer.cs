namespace StockMarket
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPriceChange = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.ButtonUpdateStockName = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 152);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(794, 362);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ratio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(125, 97);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(109, 23);
            this.buttonPrice.TabIndex = 6;
            this.buttonPrice.Text = "Min Max Price";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(79, 110);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(40, 20);
            this.textBoxNumberOfDays.TabIndex = 7;
            this.textBoxNumberOfDays.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days";
            // 
            // buttonPriceChange
            // 
            this.buttonPriceChange.Location = new System.Drawing.Point(249, 96);
            this.buttonPriceChange.Name = "buttonPriceChange";
            this.buttonPriceChange.Size = new System.Drawing.Size(87, 23);
            this.buttonPriceChange.TabIndex = 9;
            this.buttonPriceChange.Text = "Price Change";
            this.buttonPriceChange.UseVisualStyleBackColor = true;
            this.buttonPriceChange.Click += new System.EventHandler(this.buttonPriceChange_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(558, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 121);
            this.listBox1.TabIndex = 10;
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(357, 102);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(149, 28);
            this.buttonClearList.TabIndex = 11;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // ButtonUpdateStockName
            // 
            this.ButtonUpdateStockName.Location = new System.Drawing.Point(376, 17);
            this.ButtonUpdateStockName.Name = "ButtonUpdateStockName";
            this.ButtonUpdateStockName.Size = new System.Drawing.Size(162, 23);
            this.ButtonUpdateStockName.TabIndex = 12;
            this.ButtonUpdateStockName.Text = "Update Stock Name in Table";
            this.ButtonUpdateStockName.UseVisualStyleBackColor = true;
            this.ButtonUpdateStockName.Click += new System.EventHandler(this.ButtonUpdateStockName_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(12, 81);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(75, 23);
            this.buttonAverage.TabIndex = 13;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 526);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.ButtonUpdateStockName);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPriceChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPriceChange;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button ButtonUpdateStockName;
        private System.Windows.Forms.Button buttonAverage;
    }
}

