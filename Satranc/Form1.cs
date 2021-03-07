using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8]; //8satır 8 sütun array tanımladık
            int top = 0;
            int left = 0;   //top ve left'ten mesafe için değişkenler

            for (int i = 0; i < buttons.GetUpperBound(0); i++)  //Upperbound yani soldaki 8 değeri
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)    //Upperbound sağdaki 8 değeri
                {
                    buttons[i, j] = new Button();   //i ve j değerleri için yeni bir buton
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;

                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;    //left ve top ilk değerleri 0 yani sol üstten başlayacak
                    left += 50;   //soldan 50 ileri attık

                    
                    this.Controls.Add(buttons[i, j]);

                }

                top += 50; //toptan 50 aşağı attık
                left = 0; // lefti de tekrar başa aldık

            }
            for (int k = 0; k < buttons.GetUpperBound(0); k = k + 2)
            {
                for (int l = 0; l < buttons.GetUpperBound(1); l = l + 2)
                {
                    buttons[k, l].BackColor = Color.Black;
                }
            }
            for (int k = 1; k < buttons.GetUpperBound(0); k = k + 2)
            {
                for (int l = 0; l < buttons.GetUpperBound(1); l = l + 2)
                {
                    buttons[k, l].BackColor = Color.White;                              //bu kadar kod yerine if ((i+j)%2 == 0)
                                                                                                                //{
                                                                                                                //buttons[i,j].BackColor = Color.Black;
                }                                                                                               //}
                                                                                                                //else { buttons[i,j].BackColor = Color.White; }        //yazabilirdik.
            }
            for (int k = 1; k < buttons.GetUpperBound(0); k = k + 2)
            {
                for (int l = 1; l < buttons.GetUpperBound(1); l = l + 2)
                {
                    buttons[k, l].BackColor = Color.Black;
                }
            }
           
            for (int k = 0; k < buttons.GetUpperBound(0); k = k + 2)
            {
                for (int l = 1; l < buttons.GetUpperBound(1); l = l + 2)
                {
                    buttons[k, l].BackColor = Color.White;
                }
            }
        }
    }
}
