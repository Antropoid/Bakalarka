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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.teplotaButton = new MetroFramework.Controls.MetroButton();
            this.osvetleniButton = new MetroFramework.Controls.MetroButton();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.levaLabel = new MetroFramework.Controls.MetroLabel();
            this.pravaLabel = new MetroFramework.Controls.MetroLabel();
            this.jmenoHodnotyLabel = new MetroFramework.Controls.MetroLabel();
            this.hodnotaLabel = new MetroFramework.Controls.MetroLabel();
            this.graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IntervalTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RozsahLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rozsahOdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.rozsahDoTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.stredniHodnotaLabel = new MetroFramework.Controls.MetroLabel();
            this.stredniHodnotaChekBox = new MetroFramework.Controls.MetroCheckBox();
            this.minimimCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.maximumCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.minimumLabel = new MetroFramework.Controls.MetroLabel();
            this.MaximumLabel = new MetroFramework.Controls.MetroLabel();
            this.mriskaCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mezniHodMinTextBox = new MetroFramework.Controls.MetroTextBox();
            this.mezniHodMaxTextBox = new MetroFramework.Controls.MetroTextBox();
            this.mezniHodNastavitButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.mezniHodCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.rucDiodToggle = new MetroFramework.Controls.MetroToggle();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.nacistBtn = new MetroFramework.Controls.MetroButton();
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
            this.metroTrackBar1.Location = new System.Drawing.Point(59, 542);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(827, 23);
            this.metroTrackBar1.TabIndex = 2;
            this.metroTrackBar1.Text = "metroTrackBar1";
            // 
            // levaLabel
            // 
            this.levaLabel.AutoSize = true;
            this.levaLabel.Location = new System.Drawing.Point(59, 520);
            this.levaLabel.Name = "levaLabel";
            this.levaLabel.Size = new System.Drawing.Size(31, 19);
            this.levaLabel.TabIndex = 3;
            this.levaLabel.Text = "Min";
            // 
            // pravaLabel
            // 
            this.pravaLabel.AutoSize = true;
            this.pravaLabel.Location = new System.Drawing.Point(823, 520);
            this.pravaLabel.Name = "pravaLabel";
            this.pravaLabel.Size = new System.Drawing.Size(34, 19);
            this.pravaLabel.TabIndex = 4;
            this.pravaLabel.Text = "Max";
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
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            chartArea3.BackSecondaryColor = System.Drawing.SystemColors.Window;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.graf.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.SystemColors.WindowFrame;
            legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.HeaderSeparatorColor = System.Drawing.Color.White;
            legend3.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            legend3.ShadowColor = System.Drawing.Color.Maroon;
            legend3.TitleForeColor = System.Drawing.Color.White;
            legend3.TitleSeparatorColor = System.Drawing.Color.White;
            this.graf.Legends.Add(legend3);
            this.graf.Location = new System.Drawing.Point(112, 60);
            this.graf.Name = "graf";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series3.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graf.Series.Add(series3);
            this.graf.Size = new System.Drawing.Size(774, 283);
            this.graf.TabIndex = 8;
            this.graf.Text = "chart1";
            this.graf.DoubleClick += new System.EventHandler(this.graf_DoubleClick);
            this.graf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graf_MouseMove);
            // 
            // IntervalTextBox
            // 
            // 
            // 
            // 
            this.IntervalTextBox.CustomButton.Image = null;
            this.IntervalTextBox.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.IntervalTextBox.CustomButton.Name = "";
            this.IntervalTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.IntervalTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IntervalTextBox.CustomButton.TabIndex = 1;
            this.IntervalTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IntervalTextBox.CustomButton.UseSelectable = true;
            this.IntervalTextBox.CustomButton.Visible = false;
            this.IntervalTextBox.Lines = new string[] {
        "1"};
            this.IntervalTextBox.Location = new System.Drawing.Point(265, 346);
            this.IntervalTextBox.MaxLength = 32767;
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.PasswordChar = '\0';
            this.IntervalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IntervalTextBox.SelectedText = "";
            this.IntervalTextBox.SelectionLength = 0;
            this.IntervalTextBox.SelectionStart = 0;
            this.IntervalTextBox.ShortcutsEnabled = true;
            this.IntervalTextBox.Size = new System.Drawing.Size(51, 27);
            this.IntervalTextBox.TabIndex = 9;
            this.IntervalTextBox.Text = "1";
            this.IntervalTextBox.UseSelectable = true;
            this.IntervalTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IntervalTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RozsahLabel
            // 
            this.RozsahLabel.AutoSize = true;
            this.RozsahLabel.Location = new System.Drawing.Point(112, 357);
            this.RozsahLabel.Name = "RozsahLabel";
            this.RozsahLabel.Size = new System.Drawing.Size(58, 19);
            this.RozsahLabel.TabIndex = 10;
            this.RozsahLabel.Text = "Interval: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(113, 387);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Rozsah zobrazení:  ";
            // 
            // rozsahOdTextBox
            // 
            // 
            // 
            // 
            this.rozsahOdTextBox.CustomButton.Image = null;
            this.rozsahOdTextBox.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.rozsahOdTextBox.CustomButton.Name = "";
            this.rozsahOdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.rozsahOdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rozsahOdTextBox.CustomButton.TabIndex = 1;
            this.rozsahOdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rozsahOdTextBox.CustomButton.UseSelectable = true;
            this.rozsahOdTextBox.CustomButton.Visible = false;
            this.rozsahOdTextBox.Lines = new string[] {
        "10"};
            this.rozsahOdTextBox.Location = new System.Drawing.Point(265, 379);
            this.rozsahOdTextBox.MaxLength = 32767;
            this.rozsahOdTextBox.Name = "rozsahOdTextBox";
            this.rozsahOdTextBox.PasswordChar = '\0';
            this.rozsahOdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rozsahOdTextBox.SelectedText = "";
            this.rozsahOdTextBox.SelectionLength = 0;
            this.rozsahOdTextBox.SelectionStart = 0;
            this.rozsahOdTextBox.ShortcutsEnabled = true;
            this.rozsahOdTextBox.Size = new System.Drawing.Size(51, 27);
            this.rozsahOdTextBox.TabIndex = 12;
            this.rozsahOdTextBox.Text = "10";
            this.rozsahOdTextBox.UseSelectable = true;
            this.rozsahOdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rozsahOdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rozsahDoTextBox
            // 
            // 
            // 
            // 
            this.rozsahDoTextBox.CustomButton.Image = null;
            this.rozsahDoTextBox.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.rozsahDoTextBox.CustomButton.Name = "";
            this.rozsahDoTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.rozsahDoTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.rozsahDoTextBox.CustomButton.TabIndex = 1;
            this.rozsahDoTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rozsahDoTextBox.CustomButton.UseSelectable = true;
            this.rozsahDoTextBox.CustomButton.Visible = false;
            this.rozsahDoTextBox.Lines = new string[] {
        "20"};
            this.rozsahDoTextBox.Location = new System.Drawing.Point(357, 379);
            this.rozsahDoTextBox.MaxLength = 32767;
            this.rozsahDoTextBox.Name = "rozsahDoTextBox";
            this.rozsahDoTextBox.PasswordChar = '\0';
            this.rozsahDoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rozsahDoTextBox.SelectedText = "";
            this.rozsahDoTextBox.SelectionLength = 0;
            this.rozsahDoTextBox.SelectionStart = 0;
            this.rozsahDoTextBox.ShortcutsEnabled = true;
            this.rozsahDoTextBox.Size = new System.Drawing.Size(51, 27);
            this.rozsahDoTextBox.TabIndex = 13;
            this.rozsahDoTextBox.Text = "20";
            this.rozsahDoTextBox.UseSelectable = true;
            this.rozsahDoTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.rozsahDoTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(322, 384);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Do:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(234, 384);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Od:";
            // 
            // stredniHodnotaLabel
            // 
            this.stredniHodnotaLabel.AutoSize = true;
            this.stredniHodnotaLabel.Location = new System.Drawing.Point(870, 345);
            this.stredniHodnotaLabel.Name = "stredniHodnotaLabel";
            this.stredniHodnotaLabel.Size = new System.Drawing.Size(16, 19);
            this.stredniHodnotaLabel.TabIndex = 17;
            this.stredniHodnotaLabel.Text = "0";
            // 
            // stredniHodnotaChekBox
            // 
            this.stredniHodnotaChekBox.AutoSize = true;
            this.stredniHodnotaChekBox.Location = new System.Drawing.Point(748, 349);
            this.stredniHodnotaChekBox.Name = "stredniHodnotaChekBox";
            this.stredniHodnotaChekBox.Size = new System.Drawing.Size(116, 15);
            this.stredniHodnotaChekBox.TabIndex = 18;
            this.stredniHodnotaChekBox.Text = "Střední Hodnota: ";
            this.stredniHodnotaChekBox.UseSelectable = true;
            this.stredniHodnotaChekBox.CheckedChanged += new System.EventHandler(this.stredniHodnotaChekBox_CheckedChanged);
            // 
            // minimimCheckBox
            // 
            this.minimimCheckBox.AutoSize = true;
            this.minimimCheckBox.Location = new System.Drawing.Point(748, 370);
            this.minimimCheckBox.Name = "minimimCheckBox";
            this.minimimCheckBox.Size = new System.Drawing.Size(82, 15);
            this.minimimCheckBox.TabIndex = 19;
            this.minimimCheckBox.Text = "Minimum: ";
            this.minimimCheckBox.UseSelectable = true;
            this.minimimCheckBox.CheckedChanged += new System.EventHandler(this.minimimCheckBox_CheckedChanged);
            // 
            // maximumCheckBox
            // 
            this.maximumCheckBox.AutoSize = true;
            this.maximumCheckBox.Location = new System.Drawing.Point(748, 394);
            this.maximumCheckBox.Name = "maximumCheckBox";
            this.maximumCheckBox.Size = new System.Drawing.Size(83, 15);
            this.maximumCheckBox.TabIndex = 20;
            this.maximumCheckBox.Text = "Maximum: ";
            this.maximumCheckBox.UseSelectable = true;
            this.maximumCheckBox.CheckedChanged += new System.EventHandler(this.maximumCheckBox_CheckedChanged);
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(870, 366);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(16, 19);
            this.minimumLabel.TabIndex = 21;
            this.minimumLabel.Text = "0";
            // 
            // MaximumLabel
            // 
            this.MaximumLabel.AutoSize = true;
            this.MaximumLabel.Location = new System.Drawing.Point(870, 390);
            this.MaximumLabel.Name = "MaximumLabel";
            this.MaximumLabel.Size = new System.Drawing.Size(16, 19);
            this.MaximumLabel.TabIndex = 22;
            this.MaximumLabel.Text = "0";
            // 
            // mriskaCheckBox
            // 
            this.mriskaCheckBox.AutoSize = true;
            this.mriskaCheckBox.Checked = true;
            this.mriskaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mriskaCheckBox.Location = new System.Drawing.Point(748, 415);
            this.mriskaCheckBox.Name = "mriskaCheckBox";
            this.mriskaCheckBox.Size = new System.Drawing.Size(58, 15);
            this.mriskaCheckBox.TabIndex = 23;
            this.mriskaCheckBox.Text = "Mřížka";
            this.mriskaCheckBox.UseSelectable = true;
            this.mriskaCheckBox.CheckedChanged += new System.EventHandler(this.mriskaCheckBox_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(113, 415);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Mezní Hodonoty: ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(234, 414);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Min:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(322, 415);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(37, 19);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Max:";
            // 
            // mezniHodMinTextBox
            // 
            // 
            // 
            // 
            this.mezniHodMinTextBox.CustomButton.Image = null;
            this.mezniHodMinTextBox.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.mezniHodMinTextBox.CustomButton.Name = "";
            this.mezniHodMinTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mezniHodMinTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mezniHodMinTextBox.CustomButton.TabIndex = 1;
            this.mezniHodMinTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mezniHodMinTextBox.CustomButton.UseSelectable = true;
            this.mezniHodMinTextBox.CustomButton.Visible = false;
            this.mezniHodMinTextBox.Lines = new string[0];
            this.mezniHodMinTextBox.Location = new System.Drawing.Point(265, 410);
            this.mezniHodMinTextBox.MaxLength = 32767;
            this.mezniHodMinTextBox.Name = "mezniHodMinTextBox";
            this.mezniHodMinTextBox.PasswordChar = '\0';
            this.mezniHodMinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mezniHodMinTextBox.SelectedText = "";
            this.mezniHodMinTextBox.SelectionLength = 0;
            this.mezniHodMinTextBox.SelectionStart = 0;
            this.mezniHodMinTextBox.ShortcutsEnabled = true;
            this.mezniHodMinTextBox.Size = new System.Drawing.Size(51, 23);
            this.mezniHodMinTextBox.TabIndex = 27;
            this.mezniHodMinTextBox.UseSelectable = true;
            this.mezniHodMinTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mezniHodMinTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mezniHodMaxTextBox
            // 
            // 
            // 
            // 
            this.mezniHodMaxTextBox.CustomButton.Image = null;
            this.mezniHodMaxTextBox.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.mezniHodMaxTextBox.CustomButton.Name = "";
            this.mezniHodMaxTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mezniHodMaxTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mezniHodMaxTextBox.CustomButton.TabIndex = 1;
            this.mezniHodMaxTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mezniHodMaxTextBox.CustomButton.UseSelectable = true;
            this.mezniHodMaxTextBox.CustomButton.Visible = false;
            this.mezniHodMaxTextBox.Lines = new string[0];
            this.mezniHodMaxTextBox.Location = new System.Drawing.Point(357, 410);
            this.mezniHodMaxTextBox.MaxLength = 32767;
            this.mezniHodMaxTextBox.Name = "mezniHodMaxTextBox";
            this.mezniHodMaxTextBox.PasswordChar = '\0';
            this.mezniHodMaxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mezniHodMaxTextBox.SelectedText = "";
            this.mezniHodMaxTextBox.SelectionLength = 0;
            this.mezniHodMaxTextBox.SelectionStart = 0;
            this.mezniHodMaxTextBox.ShortcutsEnabled = true;
            this.mezniHodMaxTextBox.Size = new System.Drawing.Size(51, 23);
            this.mezniHodMaxTextBox.TabIndex = 28;
            this.mezniHodMaxTextBox.UseSelectable = true;
            this.mezniHodMaxTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mezniHodMaxTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mezniHodNastavitButton
            // 
            this.mezniHodNastavitButton.Location = new System.Drawing.Point(414, 410);
            this.mezniHodNastavitButton.Name = "mezniHodNastavitButton";
            this.mezniHodNastavitButton.Size = new System.Drawing.Size(75, 23);
            this.mezniHodNastavitButton.TabIndex = 29;
            this.mezniHodNastavitButton.Text = "Nastavit";
            this.mezniHodNastavitButton.UseSelectable = true;
            this.mezniHodNastavitButton.Click += new System.EventHandler(this.mezniHodNastavitButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(414, 379);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Nastavit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(414, 350);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 31;
            this.metroButton2.Text = "Nastavit";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // mezniHodCheckBox
            // 
            this.mezniHodCheckBox.AutoSize = true;
            this.mezniHodCheckBox.Location = new System.Drawing.Point(495, 414);
            this.mezniHodCheckBox.Name = "mezniHodCheckBox";
            this.mezniHodCheckBox.Size = new System.Drawing.Size(207, 15);
            this.mezniHodCheckBox.TabIndex = 32;
            this.mezniHodCheckBox.Text = "Povolení regulace mezních hodnot";
            this.mezniHodCheckBox.UseSelectable = true;
            this.mezniHodCheckBox.CheckedChanged += new System.EventHandler(this.mezniHodCheckBox_CheckedChanged);
            // 
            // rucDiodToggle
            // 
            this.rucDiodToggle.AutoSize = true;
            this.rucDiodToggle.Location = new System.Drawing.Point(236, 473);
            this.rucDiodToggle.Name = "rucDiodToggle";
            this.rucDiodToggle.Size = new System.Drawing.Size(80, 17);
            this.rucDiodToggle.TabIndex = 35;
            this.rucDiodToggle.Text = "Off";
            this.rucDiodToggle.UseSelectable = true;
            this.rucDiodToggle.CheckedChanged += new System.EventHandler(this.rucDiodToggle_CheckedChanged);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(116, 439);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 36;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(113, 471);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
            this.metroLabel7.TabIndex = 37;
            this.metroLabel7.Text = "Ruční ovládání: ";
            // 
            // nacistBtn
            // 
            this.nacistBtn.Location = new System.Drawing.Point(414, 439);
            this.nacistBtn.Name = "nacistBtn";
            this.nacistBtn.Size = new System.Drawing.Size(75, 23);
            this.nacistBtn.TabIndex = 38;
            this.nacistBtn.Text = "Načíst";
            this.nacistBtn.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 581);
            this.Controls.Add(this.nacistBtn);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.rucDiodToggle);
            this.Controls.Add(this.mezniHodCheckBox);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mezniHodNastavitButton);
            this.Controls.Add(this.mezniHodMaxTextBox);
            this.Controls.Add(this.mezniHodMinTextBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mriskaCheckBox);
            this.Controls.Add(this.MaximumLabel);
            this.Controls.Add(this.minimumLabel);
            this.Controls.Add(this.maximumCheckBox);
            this.Controls.Add(this.minimimCheckBox);
            this.Controls.Add(this.stredniHodnotaChekBox);
            this.Controls.Add(this.stredniHodnotaLabel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.rozsahDoTextBox);
            this.Controls.Add(this.rozsahOdTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.RozsahLabel);
            this.Controls.Add(this.graf);
            this.Controls.Add(this.hodnotaLabel);
            this.Controls.Add(this.jmenoHodnotyLabel);
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
        private MetroFramework.Controls.MetroLabel hodnotaLabel;
        private MetroFramework.Controls.MetroLabel jmenoHodnotyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf;
        private MetroFramework.Controls.MetroLabel RozsahLabel;
        private MetroFramework.Controls.MetroTextBox IntervalTextBox;
        private MetroFramework.Controls.MetroTextBox rozsahOdTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox rozsahDoTextBox;
        private MetroFramework.Controls.MetroLabel stredniHodnotaLabel;
        private MetroFramework.Controls.MetroCheckBox stredniHodnotaChekBox;
        private MetroFramework.Controls.MetroLabel MaximumLabel;
        private MetroFramework.Controls.MetroLabel minimumLabel;
        private MetroFramework.Controls.MetroCheckBox maximumCheckBox;
        private MetroFramework.Controls.MetroCheckBox minimimCheckBox;
        private MetroFramework.Controls.MetroCheckBox mriskaCheckBox;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton mezniHodNastavitButton;
        private MetroFramework.Controls.MetroTextBox mezniHodMaxTextBox;
        private MetroFramework.Controls.MetroTextBox mezniHodMinTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox mezniHodCheckBox;
        private MetroFramework.Controls.MetroToggle rucDiodToggle;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton nacistBtn;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

