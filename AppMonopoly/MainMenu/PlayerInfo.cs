﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class PlayerInfo : Form
    {
        private static string[] playerNames = new string[4]; // Making an array of 4 players
        private static string[] PlayerSprit = new string[4]; // Making an array of 4 players
        private static string[] PlayerMoney = new string[4]; // Making an array of 4 players
        private int ToExit = 0; //The Loop Var unitl to exit.
        private int NextPlayer = 0; //What player we are in.
        //private PictureBox[] pictures = new PictureBox[4];

        public PlayerInfo()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu  mm = new MainMenu();
            mm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Close the Programe
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PlayerBox1.Text == "")
            {
                MessageBox.Show("Enter Something"); 
            }
            else if (!(RDSmile.Checked || RdSim.Checked || RDCry.Checked || RDLove.Checked))
            {
                MessageBox.Show("Pick a Sprite");
            }
            else if (ToExit < 3)
            {

                GetUserInputs();
                NextPlayer++;
                ToExit++;

            }
            else
            {
               
                GetUserInputs();
                this.Hide();
                GameBoard gb = new GameBoard();
                gb.ShowDialog();

            }
           

        }

        public string GetUserInputs() //Method to Get User Inputs Form a One Text Box and 4 CheckBox.
        {

           int PlayerNumber = 0; //Method to Get User Inputs Form a One Text Box and 4 CheckBox.

            PlayerNumber = (NextPlayer + 2);
           playerNames[NextPlayer] = PlayerBox1.Text;
           PlayerBox1.Text = null;
           lblWhatPlayer.Text = PlayerNumber.ToString();

            //This Code Below is to Check what Button is clicked 
            if (RDSmile.Checked)
            {
                PlayerSprit[NextPlayer] = RDSmile.Text;
                RDSmile.Visible = false;
                RDSmile.Checked = false;
            }
            else if (RdSim.Checked)
            {
                PlayerSprit[NextPlayer] = RdSim.Text;
                RdSim.Visible = false;
                RdSim.Checked = false;
            }
            else if (RDCry.Checked)
            {
                PlayerSprit[NextPlayer] = RDCry.Text;

                RDCry.Visible = false;
                RDCry.Checked = false;
            }
            else if (RDLove.Checked)
            {
                PlayerSprit[NextPlayer] = RDLove.Text;
                RDLove.Visible = false;
                RDLove.Checked = false;
            }

            PlayerMoney[NextPlayer] = "1500"; //Set Players Money

            return "";
          
            
        }

        public static string[] getplayernames()  //Method to call the array PlayerName
        {
            
            return playerNames;
        }

        public static string[] getPlayerSprit() //Method to call the array PlayerSprit
        {
            return PlayerSprit;

        }

        public static string[] getPlayerMoney() //Method to call the array PlayerMoney
        {

            return PlayerMoney;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


