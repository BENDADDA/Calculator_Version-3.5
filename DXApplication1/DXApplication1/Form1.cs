using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {


        string ff1(string str01)
        {
            string tr = "";
            for (int i = 0; i < 10 && i<str01.Length; i++)
            {
                tr += str01[i];
            }
            return tr;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double numa, numb, numr; string oper;
        private void EnterNumber(object sender, EventArgs e)
        {
          
            DevExpress.XtraEditors.SimpleButton numbers = (DevExpress.XtraEditors.SimpleButton)sender;
            if (sign ==1) { label0.Text = ""; sign = 0; }
           

                if (label0.Text == "0")
                {
                    label0.Text = numbers.Text;
                }
                else
                {
                    label0.Text += numbers.Text;
                }
                double.TryParse(label0.Text, out numb);

            
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            string t = label0.Text; int l = t.Length;
            if (l > 1)
            {
                if (t[0] == '-' && l == 2) t = "0";
                else t = t.Remove(l - 1, 1);
                label0.Text = t;

            }
            else
            {
                label0.Text = "0";
                sign = 0;
            }
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            label0.Text = "0";
            c1 = 0;
            a1 = 0;
            sign = 0;
            oper = "";
            numa = numb = numr= 0;
            
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {

            string t = label0.Text;
            if (!t.Contains('.'))
            {
                label0.Text += ".";
            }
        }
        
        private void simpleButton20_Click(object sender, EventArgs e)
        {
             string t = label0.Text;
            
             if (t != "0")
             {
                 if (t[0] != '-')
                 {
                     label0.Text = "-" + t;
                 }
                 else
                 {
                     label0.Text = t.Remove(0, 1);
                 }
             }

             double.TryParse(label0.Text, out numb);
        }

        private void clos(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sign = 0; int c1 = 0; string opr;
        private void EnterOprations(object sender, EventArgs e)
        {
           
            DevExpress.XtraEditors.SimpleButton operation = (DevExpress.XtraEditors.SimpleButton)sender;
            string t = label0.Text;
            opr = oper;
            oper = operation.Text;

            if (sign == 0)
            {
                if (c1 == 0)
                {
                    numa = numb;
                    c1++;
                }
                else if (a1 != 1 && c1 != 0)
                {
                    try
                    {

                        switch (opr)
                        {
                            case "+": { numr = numa + numb; break; }
                            case "-": { numr = numa - numb; break; }
                            case "X": { numr = numa * numb; break; }
                            case "/": { numr = numa / numb; break; }
                            default: break;
                        }
                        label0.Text = float.Parse(numr.ToString()).ToString();
                        numa = numr;
                    }
                    catch { }



                }

                else
                {
                    a1 = 0;
                    
                }
            }


            sign = 1;
    
        }
        int a1 = 0;
        private void Entero(object sender, EventArgs e)
        {

            a1 = 1;
                try
                {

                    switch (oper)
                    {
                        case "+": { numr = numa + numb; break; }
                        case "-": { numr = numa - numb; break; }
                        case "X": { numr = numa*numb; break; }
                        case "/": { numr = numa / numb; break; }
                        default: break;
                    }
                    numa = numr;

                    label0.Text = float.Parse(numr.ToString()).ToString();
                    
                }
                catch { }
           

        }

        private void gtrg(object sender, EventArgs e)
        {
           

           
           

        }

        private void keyBo(object sender, MouseEventArgs e)
        {
            
        }

        private void jkl(object sender, KeyEventArgs e)
        {
          
        }

        private void KeyBo(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.NumPad1) EnterNumber(simpleButton1, e);
            if (e.KeyCode == Keys.NumPad2) EnterNumber(simpleButton2, e);
            if (e.KeyCode == Keys.NumPad3) EnterNumber(simpleButton4, e);
            if (e.KeyCode == Keys.NumPad4) EnterNumber(simpleButton5, e);
            if (e.KeyCode == Keys.NumPad5) EnterNumber(simpleButton6, e);
            if (e.KeyCode == Keys.NumPad6) EnterNumber(simpleButton8, e);
            if (e.KeyCode == Keys.NumPad7) EnterNumber(simpleButton9, e);
            if (e.KeyCode == Keys.NumPad8) EnterNumber(simpleButton10, e);
            if (e.KeyCode == Keys.NumPad9) EnterNumber(simpleButton12, e);
            if (e.KeyCode == Keys.NumPad0) EnterNumber(simpleButton19, e);
            if (e.KeyCode == Keys.Add) EnterOprations(simpleButton14, e);
            if (e.KeyCode == Keys.Divide) EnterOprations(simpleButton25, e);
            if (e.KeyCode == Keys.Multiply) EnterOprations(simpleButton16, e);
            if (e.KeyCode == Keys.Subtract) EnterOprations(simpleButton17, e);
            if (e.KeyCode == Keys.Back) simpleButton18_Click(simpleButton18, e);
            if (e.KeyCode == Keys.Delete) simpleButton26_Click(simpleButton26, e);
            if (e.KeyCode == Keys.Oemcomma) simpleButton21_Click(simpleButton21, e);
            if (e.KeyCode == Keys.Decimal) simpleButton21_Click(simpleButton21, e);

            if (e.KeyValue == 187) Entero(simpleButton22, e);
            if (e.KeyValue == 54) simpleButton20_Click(simpleButton20, e);
            if (e.KeyCode == Keys.Escape) this.Close();


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
