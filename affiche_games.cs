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
    public partial class affiche_games : Form
    {
        public affiche_games()
        {
            InitializeComponent();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if(!xo_btn.Checked && !snake_btn.Checked )
            {
                MessageBox.Show("veuillez choisir un jeu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(xo_btn.Checked==true  && !snake_btn.Checked)
                {
                    Form xo = new Form1();
                    xo.Show();
                }
                else
                {
                   if (!xo_btn.Checked && snake_btn.Checked==true)
                    {
                        Form snake = new snake_face_1();
                        snake.Show();
                    }
                }
            }
            
        }

        private void annul_btn_Click(object sender, EventArgs e)
        {
            
            xo_btn.Checked = false;
            snake_btn.Checked = false;

        }

        private void quitt_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
