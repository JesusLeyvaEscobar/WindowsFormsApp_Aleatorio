using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Aleatorio
{
    public partial class Form1 : Form
    {
        int vAleat1 = 0, vAleat2 = 0, vAleat3 = 0;
        int num1, num2, num3;
        int i=1, j=1, k=1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonONOFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            
            Random aleat1 = new Random();
            num1 = aleat1.Next(15) + 10;
            num2 = aleat1.Next(15) + 40;
            num3 = aleat1.Next(15) + 70;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            //Generar un numero aleatorio
            //Basado en ese poner la imagen correspondiente al orden
            Random aleat1 = new Random();
            vAleat1 = aleat1.Next(15);
            switch (vAleat1)
            {
                case 0:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._1_Banana;
                    break;
                case 1:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._2_Cereza;
                    break;
                case 2:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._3_Fresa;
                    break;
                case 3:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._4_Pera;
                    break;
                case 4:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._5_Mora;
                    break;
                case 5:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._6_Granada;
                    break;
                case 6:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._7_Papaya;
                    break;
                case 7:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._8_Sandia;
                    break;
                case 8:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._9_Melon;
                    break;
                case 9:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._10_Coco;
                    break;
                case 10:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._11_Mango;
                    break;
                case 11:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._12_Pina;
                    break;
                case 12:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._13_Guayaba;
                    break;
                case 13:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._14_Guanabana;
                    break;
                case 14:
                    pictureBoxFrutas1.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._15_Palta;
                    break;
            }

            vAleat2 = aleat1.Next(15);
            switch (vAleat2)
            {
                case 0:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._1_Banana;
                    break;
                case 1:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._2_Cereza;
                    break;
                case 2:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._3_Fresa;
                    break;
                case 3:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._4_Pera;
                    break;
                case 4:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._5_Mora;
                    break;
                case 5:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._6_Granada;
                    break;
                case 6:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._7_Papaya;
                    break;
                case 7:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._8_Sandia;
                    break;
                case 8:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._9_Melon;
                    break;
                case 9:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._10_Coco;
                    break;
                case 10:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._11_Mango;
                    break;
                case 11:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._12_Pina;
                    break;
                case 12:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._13_Guayaba;
                    break;
                case 13:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._14_Guanabana;
                    break;
                case 14:
                    pictureBoxFrutas2.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._15_Palta;
                    break;
            }

            vAleat3 = aleat1.Next(15);
            switch (vAleat3)
            {
                case 0:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._1_Banana;
                    break;
                case 1:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._2_Cereza;
                    break;
                case 2:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._3_Fresa;
                    break;
                case 3:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._4_Pera;
                    break;
                case 4:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._5_Mora;
                    break;
                case 5:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._6_Granada;
                    break;
                case 6:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._7_Papaya;
                    break;
                case 7:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._8_Sandia;
                    break;
                case 8:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._9_Melon;
                    break;
                case 9:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._10_Coco;
                    break;
                case 10:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._11_Mango;
                    break;
                case 11:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._12_Pina;
                    break;
                case 12:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._13_Guayaba;
                    break;
                case 13:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._14_Guanabana;
                    break;
                case 14:
                    pictureBoxFrutas3.Image =
                        WindowsFormsApp1_Aleatorio.Properties.Resources._15_Palta;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i<= num1)
                i++;
            else
                i = 1;
            if (i == num1) timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (j <= num2)
                j++;
            else
                j = 1;
            if (j == num2) timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (k <= num3)
                k++;
            else
                k = 1;
            if (k == num3) timer3.Stop();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

    }
}
