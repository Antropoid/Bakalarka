namespace Bakalarska_Prace
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.teplotaButton = new MetroFramework.Controls.MetroButton();
            this.osvetleniButton = new MetroFramework.Controls.MetroButton();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.levaLabel = new MetroFramework.Controls.MetroLabel();
            this.pravaLabel = new MetroFramework.Controls.MetroLabel();
            this.stredLabel = new MetroFramework.Controls.MetroLabel();
            this.jmenoHodnotyLabel = new MetroFramework.Controls.MetroLabel();
            this.hodnotaLabel = new MetroFramework.Controls.MetroLabel();
            this.graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.White;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // teplotaButton
            // 
            this.teplotaButton.Location = new System.Drawing.Point(0, 100);
            this.teplotaButton.Name = "teplotaButton";
            this.teplotaButton.Size = new System.Drawing.Size(81, 37);
            this.teplotaButton.TabIndex = 0;
            this.teplotaButton.Text = "Teplota";
            this.teplotaButton.UseSelectable = true;
            this.teplotaButton.Click += new System.EventHandler(this.teplotaButton_Click);
            // 
            // osvetleniButton
            // 
            this.osvetleniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.osvetleniButton.Location = new System.Drawing.Point(0, 60);
            this.osvetleniButton.Margin = new System.Windows.Forms.Padding(0);
            this.osvetleniButton.Name = "osvetleniButton";
            this.osvetleniButton.Size = new System.Drawing.Size(81, 37);
            this.osvetleniButton.TabIndex = 1;
            this.osvetleniButton.Text = "Osvětlení";
            this.osvetleniButton.UseSelectable = true;
            this.osvetleniButton.Click += new System.EventHandler(this.osvetleniButton_Click);
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(106, 319);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(476, 23);
            this.metroTrackBar1.TabIndex = 2;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // levaLabel
            // 
            this.levaLabel.AutoSize = true;
            this.levaLabel.Location = new System.Drawing.Point(106, 297);
            this.levaLabel.Name = "levaLabel";
            this.levaLabel.Size = new System.Drawing.Size(56, 19);
            this.levaLabel.TabIndex = 3;
            this.levaLabel.Text = "Zavřené";
            // 
            // pravaLabel
            // 
            this.pravaLabel.AutoSize = true;
            this.pravaLabel.Location = new System.Drawing.Point(519, 297);
            this.pravaLabel.Name = "pravaLabel";
            this.pravaLabel.Size = new System.Drawing.Size(63, 19);
            this.pravaLabel.TabIndex = 4;
            this.pravaLabel.Text = "Otevrene";
            // 
            // stredLabel
            // 
            this.stredLabel.AutoSize = true;
            this.stredLabel.Location = new System.Drawing.Point(321, 297);
            this.stredLabel.Name = "stredLabel";
            this.stredLabel.Size = new System.Drawing.Size(50, 19);
            this.stredLabel.TabIndex = 5;
            this.stredLabel.Text = "Zaluzie";
            // 
            // jmenoHodnotyLabel
            // 
            this.jmenoHodnotyLabel.AutoSize = true;
            this.jmenoHodnotyLabel.Location = new System.Drawing.Point(106, 60);
            this.jmenoHodnotyLabel.Name = "jmenoHodnotyLabel";
            this.jmenoHodnotyLabel.Size = new System.Drawing.Size(0, 0);
            this.jmenoHodnotyLabel.TabIndex = 6;
            // 
            // hodnotaLabel
            // 
            this.hodnotaLabel.AutoSize = true;
            this.hodnotaLabel.Location = new System.Drawing.Point(195, 60);
            this.hodnotaLabel.Name = "hodnotaLabel";
            this.hodnotaLabel.Size = new System.Drawing.Size(0, 0);
            this.hodnotaLabel.TabIndex = 7;
            // 
            // graf
            // 
            this.graf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.graf.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            this.graf.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            chartArea1.BackSecondaryColor = System.Drawing.SystemColors.Window;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.graf.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.WindowFrame;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.ShadowColor = System.Drawing.Color.Maroon;
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.graf.Legends.Add(legend1);
            this.graf.Location = new System.Drawing.Point(106, 100);
            this.graf.Name = "graf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graf.Series.Add(series1);
            this.graf.Size = new System.Drawing.Size(476, 194);
            this.graf.TabIndex = 8;
            this.graf.Text = "chart1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 365);
            this.Controls.Add(this.graf);
            this.Controls.Add(this.hodnotaLabel);
            this.Controls.Add(this.jmenoHodnotyLabel);
            this.Controls.Add(this.stredLabel);
            this.Controls.Add(this.pravaLabel);
            this.Controls.Add(this.levaLabel);
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.osvetleniButton);
            this.Controls.Add(this.teplotaButton);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Main";
            this.Text = "HMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroButton osvetleniButton;
        private MetroFramework.Controls.MetroButton teplotaButton;
        private MetroFramework.Controls.MetroLabel pravaLabel;
        private MetroFramework.Controls.MetroLabel levaLabel;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroLabel stredLabel;
        private MetroFramework.Controls.MetroLabel hodnotaLabel;
        private MetroFramework.Controls.MetroLabel jmenoHodnotyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf;
    }
}

