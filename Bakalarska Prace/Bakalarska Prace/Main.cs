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
        public Main()
        {
            InitializeComponent();

            this.StyleManager = msmMain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void teplotaButton_Click(object sender, EventArgs e)
        {
            pravaLabel.Text = "100";
            levaLabel.Text = "0";
            pravaLabel.Location = new Point(552, 297);
            stredLabel.Text = "Výkon topení (%)";
            jmenoHodnotyLabel.Text = "Telpota: ";
            hodnotaLabel.Text = "";
            int[] x = new int[] { 1, 2, 3, 4 };

            CreateChatr(x, x, "Teplota");

        }

        private void osvetleniButton_Click(object sender, EventArgs e)
        {
            pravaLabel.Text = "Otevřené";
            pravaLabel.Location = new Point(519, 297);
            levaLabel.Text = "Zavřené";
            stredLabel.Text = "Žaluzie";
            jmenoHodnotyLabel.Text = "Osvětlení: ";
            hodnotaLabel.Text = "";

            int[] y = new int[] { 9, 5, 7, 2 };

            CreateChatr(y, y, "Osvetleni");
        }

        private void CreateChatr(int[] Xvalues, int[] Yvalues, string nazevOsy)
        {
            graf.Series[0].Name = nazevOsy;
            graf.Series[0].Points.DataBindXY(Xvalues, Yvalues);
            
            
        }
    }
}
