namespace StockMarket
{
    partial class FormRatio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonSeries1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSeries2 = new System.Windows.Forms.Button();
            this.buttonRatio = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPriceChange = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.comboBoxStockGroup = new System.Windows.Forms.ComboBox();
            this.buttonAverageVolume = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSeries1
            // 
            this.buttonSeries1.Location = new System.Drawing.Point(14, 90);
            this.buttonSeries1.Name = "buttonSeries1";
            this.buttonSeries1.Size = new System.Drawing.Size(120, 68);
            this.buttonSeries1.TabIndex = 0;
            this.buttonSeries1.Text = "Show";
            this.buttonSeries1.UseVisualStyleBackColor = true;
            this.buttonSeries1.Click += new System.EventHandler(this.buttonSeries1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(41, 270);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(981, 407);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSeries2
            // 
            this.buttonSeries2.Location = new System.Drawing.Point(202, 90);
            this.buttonSeries2.Name = "buttonSeries2";
            this.buttonSeries2.Size = new System.Drawing.Size(121, 68);
            this.buttonSeries2.TabIndex = 3;
            this.buttonSeries2.Text = "Show";
            this.buttonSeries2.UseVisualStyleBackColor = true;
            this.buttonSeries2.Click += new System.EventHandler(this.buttonSeries2_Click);
            // 
            // buttonRatio
            // 
            this.buttonRatio.Location = new System.Drawing.Point(14, 164);
            this.buttonRatio.Name = "buttonRatio";
            this.buttonRatio.Size = new System.Drawing.Size(309, 70);
            this.buttonRatio.TabIndex = 5;
            this.buttonRatio.Text = "Ratio";
            this.buttonRatio.UseVisualStyleBackColor = true;
            this.buttonRatio.Click += new System.EventHandler(this.buttonRatio_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(558, 189);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(109, 23);
            this.buttonPrice.TabIndex = 6;
            this.buttonPrice.Text = "Min Max Price";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(607, 218);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(40, 20);
            this.textBoxNumberOfDays.TabIndex = 7;
            this.textBoxNumberOfDays.Text = "7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Days";
            // 
            // buttonPriceChange
            // 
            this.buttonPriceChange.Location = new System.Drawing.Point(673, 189);
            this.buttonPriceChange.Name = "buttonPriceChange";
            this.buttonPriceChange.Size = new System.Drawing.Size(87, 23);
            this.buttonPriceChange.TabIndex = 9;
            this.buttonPriceChange.Text = "Price Change";
            this.buttonPriceChange.UseVisualStyleBackColor = true;
            this.buttonPriceChange.Click += new System.EventHandler(this.buttonPriceChange_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(558, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 121);
            this.listBox1.TabIndex = 10;
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(558, 155);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(149, 28);
            this.buttonClearList.TabIndex = 11;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(798, 215);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(75, 23);
            this.buttonAverage.TabIndex = 13;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // comboBoxStockGroup
            // 
            this.comboBoxStockGroup.FormattingEnabled = true;
            this.comboBoxStockGroup.Location = new System.Drawing.Point(13, 27);
            this.comboBoxStockGroup.Name = "comboBoxStockGroup";
            this.comboBoxStockGroup.Size = new System.Drawing.Size(310, 21);
            this.comboBoxStockGroup.TabIndex = 14;
            this.comboBoxStockGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxList1_SelectedIndexChanged);
            // 
            // buttonAverageVolume
            // 
            this.buttonAverageVolume.Location = new System.Drawing.Point(653, 216);
            this.buttonAverageVolume.Name = "buttonAverageVolume";
            this.buttonAverageVolume.Size = new System.Drawing.Size(139, 23);
            this.buttonAverageVolume.TabIndex = 15;
            this.buttonAverageVolume.Text = "Average Volume";
            this.buttonAverageVolume.UseVisualStyleBackColor = true;
            this.buttonAverageVolume.Click += new System.EventHandler(this.buttonAverageVolume_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // FormRatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 689);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.buttonAverageVolume);
            this.Controls.Add(this.comboBoxStockGroup);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPriceChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.buttonRatio);
            this.Controls.Add(this.buttonSeries2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonSeries1);
            this.Name = "FormRatio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeries1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSeries2;
        private System.Windows.Forms.Button buttonRatio;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPriceChange;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.ComboBox comboBoxStockGroup;
        private System.Windows.Forms.Button buttonAverageVolume;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

