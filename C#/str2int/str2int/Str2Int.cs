using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str2int
{
    public partial class Str2Int : Form
    {
        public Str2Int()
        {
            InitializeComponent();
        }

        private void Str2Int_Load(object sender, EventArgs e)
        {
            labelResult.Text = "";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = inputBox.Text;
            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    int tmp = text[i] - '0';
                    result = result * 10 + tmp;
                }
            }
            labelResult.Text = result.ToString();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
