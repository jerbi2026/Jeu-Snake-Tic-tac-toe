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
    public partial class face_1_bestie : Form
    {
        public face_1_bestie()
        {
            InitializeComponent();
        }

        private void back_ret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form jeu_bestfriend = new jeu_bestie();
            jeu_bestfriend.Show();
        }
    }
}
