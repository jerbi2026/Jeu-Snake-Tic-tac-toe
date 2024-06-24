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
    public partial class snake_face_1 : Form
    {
        public snake_face_1()
        {
            InitializeComponent();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form face_1 = new  jeu_snake();
            face_1.Show();
        }
    }
}
