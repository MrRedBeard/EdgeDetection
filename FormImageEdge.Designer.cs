namespace Image
{
    partial class FormImageEdge
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
            this.buttonTest = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.listBoxYFilter = new System.Windows.Forms.ListBox();
            this.listBoxXFilter = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.labelErrors = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPos = new System.Windows.Forms.TextBox();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPlotCoords = new System.Windows.Forms.Button();
            this.chartarea = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartarea)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(183, 376);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Load Image";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(95, 82);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(456, 288);
            this.pictureBoxPreview.TabIndex = 1;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPreview_MouseDown);
            this.pictureBoxPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPreview_MouseMove);
            // 
            // listBoxYFilter
            // 
            this.listBoxYFilter.FormattingEnabled = true;
            this.listBoxYFilter.Items.AddRange(new object[] {
            "",
            "Laplacian3x3",
            "Laplacian5x5",
            "Sobel3x3Horizontal",
            "Sobel3x3Vertical",
            "Prewitt3x3Horizontal",
            "Prewitt3x3Vertical",
            "Kirsch3x3Horizontal",
            "Kirsch3x3Vertical"});
            this.listBoxYFilter.Location = new System.Drawing.Point(586, 402);
            this.listBoxYFilter.Name = "listBoxYFilter";
            this.listBoxYFilter.Size = new System.Drawing.Size(120, 95);
            this.listBoxYFilter.TabIndex = 2;
            // 
            // listBoxXFilter
            // 
            this.listBoxXFilter.FormattingEnabled = true;
            this.listBoxXFilter.Items.AddRange(new object[] {
            "",
            "Laplacian3x3",
            "Laplacian5x5",
            "Sobel3x3Horizontal",
            "Sobel3x3Vertical",
            "Prewitt3x3Horizontal",
            "Prewitt3x3Vertical",
            "Kirsch3x3Horizontal",
            "Kirsch3x3Vertical"});
            this.listBoxXFilter.Location = new System.Drawing.Point(440, 402);
            this.listBoxXFilter.Name = "listBoxXFilter";
            this.listBoxXFilter.Size = new System.Drawing.Size(120, 95);
            this.listBoxXFilter.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y Filter";
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Location = new System.Drawing.Point(538, 561);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyFilters.TabIndex = 5;
            this.buttonApplyFilters.Text = "Apply Filters";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.Location = new System.Drawing.Point(535, 21);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(196, 50);
            this.labelErrors.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Original Image";
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(619, 82);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(456, 288);
            this.pictureBoxResult.TabIndex = 1;
            this.pictureBoxResult.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result Image";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.LargeChange = 10;
            this.trackBarThreshold.Location = new System.Drawing.Point(365, 513);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.Size = new System.Drawing.Size(410, 42);
            this.trackBarThreshold.TabIndex = 12;
            this.trackBarThreshold.Value = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(873, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image Green Data Points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Threshold";
            // 
            // textBoxPos
            // 
            this.textBoxPos.Location = new System.Drawing.Point(12, 563);
            this.textBoxPos.Name = "textBoxPos";
            this.textBoxPos.Size = new System.Drawing.Size(100, 20);
            this.textBoxPos.TabIndex = 15;
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(1116, 148);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(138, 23);
            this.buttonSaveAs.TabIndex = 16;
            this.buttonSaveAs.Text = "Save to application dir";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Visible = false;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.AcceptsReturn = true;
            this.textBoxData.AcceptsTab = true;
            this.textBoxData.Location = new System.Drawing.Point(773, 405);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(326, 180);
            this.textBoxData.TabIndex = 17;
            this.textBoxData.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(811, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // buttonPlotCoords
            // 
            this.buttonPlotCoords.Location = new System.Drawing.Point(1105, 403);
            this.buttonPlotCoords.Name = "buttonPlotCoords";
            this.buttonPlotCoords.Size = new System.Drawing.Size(75, 23);
            this.buttonPlotCoords.TabIndex = 20;
            this.buttonPlotCoords.Text = "Plot Coords";
            this.buttonPlotCoords.UseVisualStyleBackColor = true;
            this.buttonPlotCoords.Click += new System.EventHandler(this.buttonPlotCoords_Click);
            // 
            // chartarea
            // 
            chartArea1.Name = "ChartArea1";
            this.chartarea.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartarea.Legends.Add(legend1);
            this.chartarea.Location = new System.Drawing.Point(13, 13);
            this.chartarea.Name = "chartarea";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartarea.Series.Add(series1);
            this.chartarea.Size = new System.Drawing.Size(36, 32);
            this.chartarea.TabIndex = 21;
            this.chartarea.Text = "Chart Area";
            this.chartarea.Visible = false;
            // 
            // FormImageEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 597);
            this.Controls.Add(this.chartarea);
            this.Controls.Add(this.buttonPlotCoords);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.textBoxPos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.buttonApplyFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxXFilter);
            this.Controls.Add(this.listBoxYFilter);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonTest);
            this.Name = "FormImageEdge";
            this.Text = "Single Color Edge Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTest;
        public System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ListBox listBoxYFilter;
        private System.Windows.Forms.ListBox listBoxXFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPos;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPlotCoords;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartarea;
    }
}

