using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace minihra
{
    public partial class Form1 : Form
    {
        Random náhoda = new Random();

        //souřadnice, poloměr a aktuální barva kuličky:
        int x, y;
            int poloměr = 5;
        Color barva = Color.Transparent; //na začátku průhledná

        //možné barvy kuličky
        Color barvaNezasažené = Color.CornflowerBlue;
        Color barvaZasažené = Color.Tomato;
        public Form1()
        {
            InitializeComponent();
        }

        private void casovac_Tick(object sender, EventArgs e)
        {
            //stanovím meze, ve kterých se mlže nacházet střed
            //kuličky tak, aby kulička byla celá uvnitř
            int minX = poloměr;
            int maxX = panel1.Width - poloměr - 1;
            int minY = poloměr;
            int maxY = panel1.Height - poloměr - 1;

            //připravím novou kuličku
            x = náhoda.Next(minX, maxX + 1);
            y = náhoda.Next(minY, maxY + 1);
            barva = barvaNezasažené;
            panel1.Refresh();

            //aktualizuji počítadlo kuliček (zvětším o 1)
            int početKuliček = Convert.ToInt32(poleKulicek.Text);
            početKuliček++;
            poleKulicek.Text = početKuliček.ToString();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            //nakreslím kuličku se středem v bodě [x, y] a barvou barva

            int xLH = x - poloměr;
            int yLH = y - poloměr;
            int šířka = 2 * poloměr;
            int výška = šířka;
            Brush štětec = new SolidBrush(barva);
            kp.FillEllipse(štětec, xLH, yLH, šířka, výška);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Pokud byla poslední kulička již zasažena, ignoruji myš
            if (barva != barvaNezasažené)
                return;

            //vyhodnotím, zda došlo k zásahu

            int rozdílX = e.X - x;
            int rozdílY = e.Y - y;
            double vzdálenostOdStředu = Math.Sqrt(rozdílX * rozdílX + rozdílY * rozdílY);
            bool zásah = vzdálenostOdStředu <= poloměr;

            if (zásah) //pokud ano, ...
            {
                //přebarvím kuličku
                barva = barvaZasažené;
                panel1.Refresh();

                //a aktualizuji počítadlo zásahů (zvětším o 1)
                int početZásahů = Convert.ToInt32(poleZasahu.Text);
                početZásahů++;
                poleZasahu.Text = početZásahů.ToString();
            }
        }
    }
}
