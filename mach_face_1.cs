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
    public partial class mach_face_1 : Form
    {
        public mach_face_1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form face_2_mach = new jeu_vs_machine();
            face_2_mach.Show();
        }

        private void back_ret_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
