using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7
{
    public partial class QUIZPANDA : Form
    {
        public QUIZPANDA()
        {
            InitializeComponent();
        }
        public string outputHuruf;
        private void btnConvert_Click(object sender, EventArgs e)
        {
            outputOrganizer();
        }

        public void outputOrganizer()
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabet = alpha.ToCharArray();
            string str = txtBoxInputKalimat.Text.ToUpper();
            char[] ch = str.ToCharArray();
            int cek = txtBoxHuruf2.Text[0] - txtBoxIHuruf1.Text[0];
            outputHuruf = "";
            lblOutput.Text = "";
            txtBoxInputKalimat.Text.ToUpper();
            txtBoxInputKalimat.Text = txtBoxInputKalimat.Text;
            txtBoxIHuruf1.Text = txtBoxHuruf2.Text;
            txtBoxHuruf2.Text = txtBoxHuruf2.Text;
            if (cek < 0)
            {
                cek += 26;
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    outputHuruf += ch[i];
                }
                for (int j = 0; j < 26; j++)
                {
                    if (ch[i] == alphabet[j])
                    {
                        outputHuruf += alphabet[j + cek];
                    }
                }
            }
            lblOutput.Text = outputHuruf.ToUpper();
        }
        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
    }