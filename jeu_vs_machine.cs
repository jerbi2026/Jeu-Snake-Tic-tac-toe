using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_tic_tac_toe
{
    public partial class jeu_vs_machine : Form
    {
        public string verif = "";
        public jeu_vs_machine()
        {
            InitializeComponent();
        }
        public int gagner()
        {
            int win = 0;
            if (n1.Text == n2.Text && n3.Text == n2.Text && n1.Text != "*")
            {
                win = 1;
                n1.ForeColor = Color.Green;
                n3.ForeColor = Color.Green;
                n2.ForeColor = Color.Green;

            }
            if (n4.Text == n5.Text && n5.Text == n6.Text && n4.Text != "*")
            {
                win = 1;
                n4.ForeColor = Color.Green;
                n5.ForeColor = Color.Green;
                n6.ForeColor = Color.Green;

            }
            if (n7.Text == n8.Text && n8.Text == n9.Text && n7.Text != "*")
            {
                win = 1;
                n7.ForeColor = Color.Green;
                n8.ForeColor = Color.Green;
                n9.ForeColor = Color.Green;
            }
            if (n1.Text == n4.Text && n4.Text == n7.Text && n1.Text != "*")
            {
                win = 1;
                n1.ForeColor = Color.Green;
                n4.ForeColor = Color.Green;
                n7.ForeColor = Color.Green;
            }
            if (n5.Text == n2.Text && n8.Text == n2.Text && n5.Text != "*")
            {
                win = 1;
                n5.ForeColor = Color.Green;
                n8.ForeColor = Color.Green;
                n2.ForeColor = Color.Green;
            }
            if (n3.Text == n6.Text && n3.Text == n9.Text && n3.Text != "*")
            {
                win = 1;
                n3.ForeColor = Color.Green;
                n6.ForeColor = Color.Green;
                n9.ForeColor = Color.Green;
            }
            if (n1.Text == n5.Text && n5.Text == n9.Text && n1.Text != "*")
            {
                win = 1;
                n1.ForeColor = Color.Green;
                n5.ForeColor = Color.Green;
                n9.ForeColor = Color.Green;
            }
            if (n5.Text == n3.Text && n3.Text == n7.Text && n5.Text != "*")
            {
                win = 1;
                n5.ForeColor = Color.Green;
                n3.ForeColor = Color.Green;
                n7.ForeColor = Color.Green;
            }

            return win;
        }
        public void choix_machine()
        {

            List<Button> buttons = new List<Button> { n1, n2, n3, n4, n5, n6, n7, n8, n9 };
            if (n1.Text == n2.Text && n3.Text == "*" && n1.Text != "*")
            {
                n3.Text = "O";
                n3.ForeColor = Color.Blue;
                n3.BackColor = Color.LawnGreen;
                verif = "O";
            }
            else
            {
                if (n1.Text == n3.Text && n2.Text == "*" && n1.Text != "*")
                {
                    n2.Text = "O";
                    n2.ForeColor = Color.Blue;
                    n2.BackColor = Color.LawnGreen;
                    verif = "O";
                }
                else
                {
                    if (n3.Text == n2.Text && n1.Text == "*" && n2.Text != "*")
                    {
                        n1.Text = "O";
                        n1.ForeColor = Color.Blue;
                        n1.BackColor = Color.LawnGreen;
                        verif = "O";
                    }

                    else
                    {
                        if (n4.Text == n5.Text && n6.Text == "*" && n5.Text != "*")
                        {
                            n6.Text = "O";
                            n6.ForeColor = Color.Blue;
                            n6.BackColor = Color.LawnGreen;
                            verif = "O";
                        }
                        else
                        {
                            if (n4.Text == n6.Text && n5.Text == "*" && n6.Text != "*")
                            {
                                n5.Text = "O";
                                n5.ForeColor = Color.Blue;
                                n5.BackColor = Color.LawnGreen;
                                verif = "O";
                            }
                            else
                            {
                                if (n5.Text == n6.Text && n4.Text == "*" && n5.Text != "*")
                                {
                                    n4.Text = "O";
                                    n4.ForeColor = Color.Blue;
                                    n4.BackColor = Color.LawnGreen;
                                    verif = "O";
                                }
                                else
                                {
                                    if (n7.Text == n8.Text && n9.Text == "*" && n7.Text != "*")
                                    {
                                        n9.Text = "O";
                                        n9.ForeColor = Color.Blue;
                                        n9.BackColor = Color.LawnGreen;
                                        verif = "O";
                                    }
                                    else
                                    {
                                        if (n7.Text == n9.Text && n8.Text == "*" && n7.Text != "*")
                                        {
                                            n8.Text = "O";
                                            n8.ForeColor = Color.Blue;
                                            n8.BackColor = Color.LawnGreen;
                                            verif = "O";
                                        }
                                        else
                                        {
                                            if (n9.Text == n8.Text && n7.Text == "*" && n8.Text != "*")
                                            {
                                                n7.Text = "O";
                                                n7.ForeColor = Color.Blue;
                                                n7.BackColor = Color.LawnGreen;
                                                verif = "O";
                                            }
                                            else
                                            {
                                                if (n1.Text == n4.Text && n7.Text == "*" && n4.Text != "*")
                                                {
                                                    n7.Text = "O";
                                                    n7.ForeColor = Color.Blue;
                                                    n7.BackColor = Color.LawnGreen;
                                                    verif = "O";
                                                }
                                                else
                                                {
                                                    if (n7.Text == n1.Text && n4.Text == "*" && n1.Text != "*")
                                                    {
                                                        n4.Text = "O";
                                                        n4.ForeColor = Color.Blue;
                                                        n4.BackColor = Color.LawnGreen;
                                                        verif = "O";
                                                    }
                                                    else
                                                    {
                                                        if (n7.Text == n4.Text && n1.Text == "*" && n4.Text != "*")
                                                        {
                                                            n1.Text = "O";
                                                            n1.ForeColor = Color.Blue;
                                                            n1.BackColor = Color.LawnGreen;
                                                            verif = "O";
                                                        }
                                                        else
                                                        {
                                                            if (n2.Text == n5.Text && n8.Text == "*" && n5.Text != "*")
                                                            {
                                                                n8.Text = "O";
                                                                n8.ForeColor = Color.Blue;
                                                                n8.BackColor = Color.LawnGreen;
                                                                verif = "O";
                                                            }
                                                            else
                                                            {
                                                                if (n2.Text == n8.Text && n5.Text == "*" && n8.Text != "*")
                                                                {
                                                                    n5.Text = "O";
                                                                    n5.ForeColor = Color.Blue;
                                                                    n5.BackColor = Color.LawnGreen;
                                                                    verif = "O";
                                                                }
                                                                else
                                                                {
                                                                    if (n8.Text == n5.Text && n2.Text == "*" && n5.Text != "*")
                                                                    {
                                                                        n2.Text = "O";
                                                                        n2.ForeColor = Color.Blue;
                                                                        n2.BackColor = Color.LawnGreen;
                                                                        verif = "O";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (n3.Text == n6.Text && n9.Text == "*" && n6.Text != "*")
                                                                        {
                                                                            n9.Text = "O";
                                                                            n9.ForeColor = Color.Blue;
                                                                            n9.BackColor = Color.LawnGreen;
                                                                            verif = "O";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (n3.Text == n9.Text && n6.Text == "*" && n3.Text != "*")
                                                                            {
                                                                                n6.Text = "O";
                                                                                n6.ForeColor = Color.Blue;
                                                                                n6.BackColor = Color.LawnGreen;
                                                                                verif = "O";
                                                                            }
                                                                            else
                                                                            {
                                                                                if (n6.Text == n9.Text && n3.Text == "*" && n6.Text != "*")
                                                                                {
                                                                                    n3.Text = "O";
                                                                                    n3.ForeColor = Color.Blue;
                                                                                    n3.BackColor = Color.LawnGreen;
                                                                                    verif = "O";
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (n1.Text == n5.Text && n9.Text == "*" && n5.Text != "*")
                                                                                    {
                                                                                        n9.Text = "O";
                                                                                        n9.ForeColor = Color.Blue;
                                                                                        n9.BackColor = Color.LawnGreen;
                                                                                        verif = "O";
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (n9.Text == n5.Text && n1.Text == "*" && n5.Text != "*")
                                                                                        {
                                                                                            n1.Text = "O";
                                                                                            n1.ForeColor = Color.Blue;
                                                                                            n1.BackColor = Color.LawnGreen;
                                                                                            verif = "O";
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (n1.Text == n9.Text && n5.Text == "*" && n1.Text != "*")
                                                                                            {
                                                                                                n5.Text = "O";
                                                                                                n5.ForeColor = Color.Blue;
                                                                                                n5.BackColor = Color.LawnGreen;
                                                                                                verif = "O";
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (n3.Text == n5.Text && n7.Text == "*" && n5.Text != "*")
                                                                                                {
                                                                                                    n7.Text = "O";
                                                                                                    n7.ForeColor = Color.Blue;
                                                                                                    n7.BackColor = Color.LawnGreen;
                                                                                                    verif = "O";
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (n7.Text == n5.Text && n3.Text == "*" && n5.Text != "*")
                                                                                                    {
                                                                                                        n3.Text = "O";
                                                                                                        n3.ForeColor = Color.Blue;
                                                                                                        n3.BackColor = Color.LawnGreen;
                                                                                                        verif = "O";
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (n3.Text == n7.Text && n5.Text == "*" && n7.Text != "*")
                                                                                                        {
                                                                                                            n5.Text = "O";
                                                                                                            n5.ForeColor = Color.Blue;
                                                                                                            n5.BackColor = Color.LawnGreen;
                                                                                                            verif = "O";
                                                                                                        }

                                                                                                        else
                                                                                                        {
                                                                                                            if (n1.Text == n9.Text && n6.Text == "*" && n1.Text != "*")
                                                                                                            {
                                                                                                                n6.Text = "O";
                                                                                                                n6.ForeColor = Color.Blue;
                                                                                                                n6.BackColor = Color.LawnGreen;
                                                                                                                verif = "O";
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (n3.Text == n7.Text && n4.Text == "*" && n3.Text != "*")
                                                                                                                {
                                                                                                                    n4.Text = "O";
                                                                                                                    n4.ForeColor = Color.Blue;
                                                                                                                    n4.BackColor = Color.LawnGreen;
                                                                                                                    verif = "O";
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (n8.Text == n1.Text && n1.Text == "*" && n4.Text != "*")
                                                                                                                    {
                                                                                                                        n4.Text = "O";
                                                                                                                        n4.ForeColor = Color.Blue;
                                                                                                                        n4.BackColor = Color.LawnGreen;
                                                                                                                        verif = "O";


                                                                                                                    }
                                                                                                                    else
                                                                                                                    {

                                                                                                                        if (n5.Text == "*")
                                                                                                                        {
                                                                                                                            n5.Text = "O";
                                                                                                                            n5.ForeColor = Color.Blue;
                                                                                                                            n5.BackColor = Color.LawnGreen;
                                                                                                                            verif = "O";
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (n1.Text == "*")
                                                                                                                            {
                                                                                                                                n1.Text = "O";
                                                                                                                                n1.ForeColor = Color.Blue;
                                                                                                                                n1.BackColor = Color.LawnGreen;
                                                                                                                                verif = "O";
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (n3.Text == "*")
                                                                                                                                {
                                                                                                                                    n3.Text = "O";
                                                                                                                                    n3.ForeColor = Color.Blue;
                                                                                                                                    n3.BackColor = Color.LawnGreen;
                                                                                                                                    verif = "O";
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (n7.Text == "*")
                                                                                                                                    {
                                                                                                                                        n7.Text = "O";
                                                                                                                                        n7.ForeColor = Color.Blue;
                                                                                                                                        n7.BackColor = Color.LawnGreen;
                                                                                                                                        verif = "O";
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (n9.Text == "*")
                                                                                                                                        {
                                                                                                                                            n9.Text = "O";
                                                                                                                                            n9.ForeColor = Color.Blue;
                                                                                                                                            n9.BackColor = Color.LawnGreen;
                                                                                                                                            verif = "O";
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            foreach (Button x in buttons)
                                                                                                                                            {
                                                                                                                                                if (x.Text == "*")
                                                                                                                                                {
                                                                                                                                                    x.Text = "O";
                                                                                                                                                    x.ForeColor = Color.Blue;
                                                                                                                                                    x.BackColor = Color.LawnGreen;
                                                                                                                                                    verif = "O";
                                                                                                                                                    break;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }

                                                                                                                    }
                                                                                                                }

                                                                                                            }
                                                                                                        }

                                                                                                    }


                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }   
    }
        private void n1_Click(object sender, EventArgs e)
        {
            int gagne;
            if(n1.Text=="*")
            {
                if(verif=="" || verif=="O")
                {
                    n1.Text = "X";
                    n1.ForeColor = Color.Red;
                    n1.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                            choix_machine();
                            gagne = gagner();
                            if (gagne == 1)
                            {
                                label2.ForeColor = Color.Green;
                                MessageBox.Show("congrats to the computer ");
                                n1.Enabled = false;
                                n2.Enabled = false;
                                n3.Enabled = false;
                                n4.Enabled = false;
                                n5.Enabled = false;
                                n6.Enabled = false;
                                n7.Enabled = false;
                                n8.Enabled = false;
                                n9.Enabled = false;

                            }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n2_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n2.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n2.Text = "X";
                    n2.ForeColor = Color.Red;
                    n2.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n3.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n3.Text = "X";
                    n3.ForeColor = Color.Red;
                    n3.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
               
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n4.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n4.Text = "X";
                    n4.ForeColor = Color.Red;
                    n4.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n5.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n5.Text = "X";
                    n5.ForeColor = Color.Red;
                    n5.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n6.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n6.Text = "X";
                    n6.ForeColor = Color.Red;
                    n6.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
               
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n7_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n7.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n7.Text = "X";
                    n7.ForeColor = Color.Red;
                    n7.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n8_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n8.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n8.Text = "X";
                    n8.ForeColor = Color.Red;
                    n8.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void n9_Click(object sender, EventArgs e)
        {
            int gagne;
            if (n9.Text == "*")
            {
                if (verif == "" || verif == "O")
                {
                    n9.Text = "X";
                    n9.ForeColor = Color.Red;
                    n9.BackColor = Color.LawnGreen;
                    verif = "X";
                    gagne = gagner();
                    if (gagne == 1)
                    {
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("congrats to the player ");
                        n1.Enabled = false;
                        n2.Enabled = false;
                        n3.Enabled = false;
                        n4.Enabled = false;
                        n5.Enabled = false;
                        n6.Enabled = false;
                        n7.Enabled = false;
                        n8.Enabled = false;
                        n9.Enabled = false;

                    }
                    else
                    {
                        choix_machine();
                        gagne = gagner();
                        if (gagne == 1)
                        {
                            label2.ForeColor = Color.Green;
                            MessageBox.Show("congrats to the computer ");
                            n1.Enabled = false;
                            n2.Enabled = false;
                            n3.Enabled = false;
                            n4.Enabled = false;
                            n5.Enabled = false;
                            n6.Enabled = false;
                            n7.Enabled = false;
                            n8.Enabled = false;
                            n9.Enabled = false;

                        }
                    }
                }
                
            }
            else
                MessageBox.Show("it's not empty");
        }

        private void res_btn_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button> { n1, n2, n3, n4, n5, n6, n7, n8, n9 };
            foreach (Button x in buttons)
            {
                x.Text = "*";
                x.ForeColor = Color.Black;
                x.BackColor = Color.White;
                x.Enabled = true;
            }
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Blue;
            verif = "";
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
