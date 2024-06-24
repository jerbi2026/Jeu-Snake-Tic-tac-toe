using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (bestfriend.Checked && machine.Checked)
                MessageBox.Show("you have to choose only one box");
            else
            {
                if (bestfriend.Checked && !machine.Checked)
                {
                    Form best_friend_xo = new face_1_bestie();
                    best_friend_xo.Show();
                }
                else
                {
                    if (!bestfriend.Checked && machine.Checked)
                    {
                        Form machine_xo = new mach_face_1();
                        machine_xo.Show();
                    }
                    else
                        MessageBox.Show("you have to choose one of them!");
                }
                    
            }
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void annul_btn_Click(object sender, EventArgs e)
        {
            machine.Checked = false;
            bestfriend.Checked = false;
        }
    }
}
