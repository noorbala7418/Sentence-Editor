using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SentenceEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnter.Text = "";
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String strtxtEnter = txtEnter.Text;
                if (strtxtEnter.Contains("ی"))
                {
                    if (checkBox1.Checked)
                    {
                        strtxtEnter = strtxtEnter.Replace("ئ", "پ");
                    }
                    strtxtEnter = strtxtEnter.Replace('ی', 'ي');
                }
                Clipboard.SetDataObject(strtxtEnter, true, 1, 10);
            }
            catch (System.Runtime.InteropServices.ExternalException sr)
            {
                Thread.Sleep(15);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
