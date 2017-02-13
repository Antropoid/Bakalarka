using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bakalarska_Prace
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {

        int[] y = new int[] { 9, 5, 7, 2, 5, 2, 8, 6, 3, 21, 6, 1, 4, 5, 3, 32, 1, 6, 2, 9,};
        int[] x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public Main()
        {
            InitializeComponent();

            this.StyleManager = msmMain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTrackBar1.Enabled = false;
            mezniHodNastavitButton.Enabled = false;
            mezniHodMaxTextBox.Enabled = false;
            mezniHodMinTextBox.Enabled = false;
        }

        private void teplotaButton_Click(object sender, EventArgs e)
        {
            pravaLabel.Text = "100";
            levaLabel.Text = "0";
            pravaLabel.Location = new Point(552, 297);
            //stredLabel.Text = "Výkon topení (%)";
            jmenoHodnotyLabel.Text = "Telpota: ";
            hodnotaLabel.Text = "";
            //int[] x = new int[] { 1,2,3,4 };

            CreateChatr(x, y, "Teplota");

        }

        private void osvetleniButton_Click(object sender, EventArgs e)
        {
            pravaLabel.Text = "Otevřené";
            pravaLabel.Location = new Point(519, 297);
            levaLabel.Text = "Zavřené";
            //stredLabel.Text = "Žaluzie";
            jmenoHodnotyLabel.Text = "Osvětlení: ";
            hodnotaLabel.Text = "";



            //int[] y = new int[] { 9, 5, 7, 2 };

            CreateChatr(x, y, "Osvetleni");
        }

        //Vytvoreni Grafu
        private void CreateChatr(int[] Xvalues, int[] Yvalues, string nazevOsy)
        {
            graf.Series[0].Name = nazevOsy;
            var chartArea = graf.ChartAreas[0];

            graf.Series[0].Points.DataBindXY(Xvalues, Yvalues);

            chartArea.AxisX.LineColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.White;
            chartArea.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea.AxisY.LineColor = Color.White;
            chartArea.AxisY.MajorGrid.LineColor = Color.White;
            chartArea.AxisY.LabelStyle.ForeColor = Color.White;

            chartArea.AxisX.Title = "Cas";
            chartArea.AxisX.TitleForeColor = Color.White;
            chartArea.AxisX.TitleFont = new Font("Arial", 12 , FontStyle.Bold);

            chartArea.AxisY.Title = "Data";
            chartArea.AxisY.TitleForeColor = Color.White;
            chartArea.AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 100;


            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;

            chartArea.CursorX.AutoScroll = true;
            chartArea.CursorY.AutoScroll = true;

            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisY.ScaleView.Zoomable = true;


        }

        private void graf_DoubleClick(object sender, EventArgs e)
        {
            var chartArea = graf.ChartAreas[0];
            chartArea.AxisX.ScaleView.ZoomReset(0);
            chartArea.AxisY.ScaleView.ZoomReset(0);
        }

        private void graf_MouseMove(object sender, MouseEventArgs e)
        {

            graf.Series[0].ToolTip = "Cas: #VALX\nData: #VAL";

        }


        private void stredniHodnotaRadioButton_Click(object sender, EventArgs e)
        {
            if (!stredniHodnotaChekBox.Checked)
            {
                stredniHodnotaChekBox.Checked = false;
                graf.Series.RemoveAt(1);
                stredniHodnotaLabel.Text = "0";
            }
            else
            {
                stredniHodnotaChekBox.Checked = true;
                int soucetY = 0;
                foreach (int y in y)
                {
                    soucetY = soucetY + y;
                }
                int strH = soucetY / x.Length;
                int[] strHpole = new int[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    strHpole[i] = strH;
                }
                stredniHodnotaLabel.Text = Convert.ToString(strH);
                graf.Series.Add("Stredni Hodnota");
                graf.Series[1].Name = "Stredni Hodnota";
                graf.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                graf.Series[1].Points.DataBindXY(x, strHpole);

            }


        }

        private void stredniHodnotaChekBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!stredniHodnotaChekBox.Checked)
            {
                stredniHodnotaChekBox.Checked = false;
                graf.Series.RemoveAt(1);
                stredniHodnotaLabel.Text = "0";
            }
            else
            {
                stredniHodnotaChekBox.Checked = true;
                int soucetY = 0;
                foreach (int y in y)
                {
                    soucetY = soucetY + y;
                }
                int strH = soucetY / x.Length;
                int[] strHpole = new int[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    strHpole[i] = strH;
                }
                stredniHodnotaLabel.Text = Convert.ToString(strH);
                graf.Series.Add("Stredni Hodnota");
                graf.Series[1].Name = "Stredni Hodnota";
                graf.Series[1].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
                graf.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                graf.Series[1].Points.DataBindXY(x, strHpole);

            }
        }

        private void minimimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int min;
            if (!minimimCheckBox.Checked)
            {
                minimumLabel.Text = "0";
            }
            else
            {
                min = y.Min();
                minimumLabel.Text = Convert.ToString(min);
            }
        }

        private void maximumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int max;
            if (!maximumCheckBox.Checked)
            {
                MaximumLabel.Text = "0";
            }
            else
            {
                max = y.Max();
                MaximumLabel.Text = Convert.ToString(max);
            }
        }

        private void mriskaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!mriskaCheckBox.Checked)
            {
                graf.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                graf.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            else
            {
                graf.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                graf.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            graf.ChartAreas[0].AxisX.Interval = Convert.ToDouble(IntervalTextBox.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            graf.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(rozsahOdTextBox.Text);
            graf.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(rozsahDoTextBox.Text);
        }

        private void mezniHodNastavitButton_Click(object sender, EventArgs e)
        {
            /* int[] maxRPole = new int[x.Length];
             for (int i = 0; i < x.Length; i++)
             {
                 maxRPole[i] = Convert.ToInt32(mezniHodMaxTextBox.Text);
             }

             int[] minRPole = new int[x.Length];
             for (int i = 0; i < x.Length; i++)
             {
                 minRPole[i] = Convert.ToInt32(mezniHodMinTextBox.Text);
             }

             MessageBox.Show("Překročeno maximální osvětlení", "Erroooooooooorrrrrrr", MessageBoxButtons.OK, MessageBoxIcon.Error);*/

        }
        private void mezniHodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!mezniHodCheckBox.Checked)
            {
                mezniHodNastavitButton.Enabled = false;
                mezniHodMaxTextBox.Enabled = false;
                mezniHodMinTextBox.Enabled = false;
            }
            else
            {
                mezniHodNastavitButton.Enabled = true;
                mezniHodMaxTextBox.Enabled = true;
                mezniHodMinTextBox.Enabled = true;
            }
        }

        private void rucDiodToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (!rucDiodToggle.Checked)
            {
                metroTrackBar1.Enabled = false;
            }
            else
            {
                metroTrackBar1.Enabled = true;
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            string abc;
            abc = Convert.ToString(metroDateTime1.Value.Date);
            MessageBox.Show(abc);
        }
    }

}
