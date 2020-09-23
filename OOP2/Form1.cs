using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //※　これでログイン情報が取得できる。
            //　テストデータに接続するか？本番環境に接続するかをの判断に利用できる
            this.Text = LoginInfo.Member.GetName();
        }

        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(InputTextBox.Text);
            ResultLabel.Text = (value * LoginInfo.Member.Rate).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new Form2())
            {
                f.ShowDialog();
            }
        }
    }
}
