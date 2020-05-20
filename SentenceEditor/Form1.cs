using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentenceEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            String strtxtEnter =Convert.ToString(txtEnter.Text);
            char[] chrTxtEnter = strtxtEnter.ToCharArray();

            if (strtxtEnter.Equals("") == false)
            {
                for (int i = 0; i < chrTxtEnter.Length; i++)
                {
                    if (chrTxtEnter[i] == 'ی')
                    {
                        chrTxtEnter[i] = 'ي';
                    }
                }
                strtxtEnter = new string(chrTxtEnter);
                resultLable.Text = strtxtEnter.ToString();
                Clipboard.SetText(strtxtEnter);
                resultLable.Text = "در کلیپ بورد ذخیره شد. میتوانید پیست کنید";
            }
            else
            {
                resultLable.Text ="شما چیزی ننوشتید که بخوام تبدیل کنم";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEnter.Text = "";                
        }
    }
}
