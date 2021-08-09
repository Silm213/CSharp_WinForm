using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Round();
        }

        string PlayerTurn = "O";
        int scoreX = 0, scoreO = 0;

        private void Round() 
        {
            b_1.Text = " ";
            b_2.Text = " ";
            b_3.Text = " ";
            b_4.Text = " ";
            b_5.Text = " ";
            b_6.Text = " ";
            b_7.Text = " ";
            b_8.Text = " ";
            b_9.Text = " ";
            PlayerTurn = "O";
            label_o_score.Text = "O: " + scoreO.ToString();
            label_x_score.Text = "X: " + scoreX.ToString();
            buttonStatus(true);
            turn.Text = "Tura:" + PlayerTurn;
        }

        private void player_turn()
        {
            if (b_1.Text == PlayerTurn && b_2.Text == PlayerTurn && b_3.Text == PlayerTurn ||
                b_4.Text == PlayerTurn && b_5.Text == PlayerTurn && b_6.Text == PlayerTurn ||
                b_7.Text == PlayerTurn && b_8.Text == PlayerTurn && b_9.Text == PlayerTurn ||
                b_1.Text == PlayerTurn && b_4.Text == PlayerTurn && b_7.Text == PlayerTurn ||
                b_2.Text == PlayerTurn && b_5.Text == PlayerTurn && b_8.Text == PlayerTurn ||
                b_3.Text == PlayerTurn && b_6.Text == PlayerTurn && b_9.Text == PlayerTurn ||
                b_1.Text == PlayerTurn && b_5.Text == PlayerTurn && b_9.Text == PlayerTurn ||
                b_3.Text == PlayerTurn && b_5.Text == PlayerTurn && b_7.Text == PlayerTurn)
            {
                if (PlayerTurn == "X")
                {
                    scoreX++;
                    label_x_score.Text = "X: " + scoreX.ToString();      
                }
                else
                {
                    scoreO++;
                    label_o_score.Text = "O: " + scoreO.ToString();
                }

                buttonStatus(false);
            }

            if (PlayerTurn == "X")
            {
                PlayerTurn = "O";
                turn.Text = "Tura:" + PlayerTurn;
            }
            else
            {
                PlayerTurn = "X";
                turn.Text = "Tura:" + PlayerTurn;
            }

        }

        private void buttonStatus(bool b_status)
        {
            b_1.Enabled = b_status;
            b_2.Enabled = b_status;
            b_3.Enabled = b_status;
            b_4.Enabled = b_status;
            b_5.Enabled = b_status;
            b_6.Enabled = b_status;
            b_7.Enabled = b_status;
            b_8.Enabled = b_status;
            b_9.Enabled = b_status;
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            b_1.Text = PlayerTurn;
            player_turn();
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            b_2.Text = PlayerTurn;
            player_turn();
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            b_3.Text = PlayerTurn;
            player_turn();
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            b_4.Text = PlayerTurn;
            player_turn();
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            b_5.Text = PlayerTurn;
            player_turn();
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            b_6.Text = PlayerTurn;
            player_turn();
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            b_7.Text = PlayerTurn;
            player_turn();
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            b_8.Text = PlayerTurn;
            player_turn();
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            b_9.Text = PlayerTurn;
            player_turn();
        }

        private void b_restart_Click(object sender, EventArgs e)
        {
            Round();
        }

        private void b_newgame_Click(object sender, EventArgs e)
        {
            scoreO = 0;
            scoreX = 0;
            Round();
        }
    }
}
