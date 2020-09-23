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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //ログイン後は自分が何アカウントでログインしたかを考える必要がないようになっている
        //
        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            //シルバーなら割引率 0
            //ゴールドら割引率 20
            //プラチナなら割引率 40

            if (SilverRadioButton.Checked)
            {
                LoginInfo.Member = new SilverMember();
            }
            else if (GoldRadioButton.Checked)
            {
                LoginInfo.Member = new GoldMember();
            }
            else
            {
                LoginInfo.Member = new PlatinumMember();
            }

            using (var f = new Form1())
            {
                f.ShowDialog();
            }

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
