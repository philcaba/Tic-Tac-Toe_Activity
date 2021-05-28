using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Activity
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = player 1 turn; false = player 2 turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Restart();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
           

            checking();

        }
        private void checking()
        {
            bool winner = false;

            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                winner = true;
            if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                winner = true;
            if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                winner = true;


            if (!winner)
            {
                return;
            }

                endGame();
                String who_wins = "";
                if (turn)
                    who_wins = "O";
                else
                    who_wins = "X";


                MessageBox.Show(who_wins + " wins. ");
            
        }
            
               

               
        

         private void endGame()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }

            



           
        
            






        }//endChecking


    }

