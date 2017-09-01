﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToe
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        Button button;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            ViewState["playerState"] = player.Text;
            if(ViewState["playerState"]!=null)
            {
                player.Text = ViewState["playerState"].ToString();
            }
            if (player.Text.Equals("Player1") && button.Text.Equals("-"))
            {
                button.Text = "X";
                WinningCondition(button.Text);
                player.Text = "Player2";
            }
            else if (button.Text.Equals("-"))
            {
                button.Text = "O";
                WinningCondition(button.Text);
                player.Text = "Player1";
            }
            
        }

      
        protected void WinningCondition(string mark)
        {
            if ((Button1.Text.Equals(mark) && Button2.Text.Equals(mark) && Button3.Text.Equals(mark)) ||
                    (Button4.Text.Equals(mark) && Button5.Text.Equals(mark) && Button6.Text.Equals(mark)) ||
                    (Button7.Text.Equals(mark) && Button8.Text.Equals(mark) && Button9.Text.Equals(mark)) ||
                    (Button1.Text.Equals(mark) && Button4.Text.Equals(mark) && Button7.Text.Equals(mark)) ||
                    (Button2.Text.Equals(mark) && Button5.Text.Equals(mark) && Button8.Text.Equals(mark)) ||
                    (Button3.Text.Equals(mark) && Button6.Text.Equals(mark) && Button9.Text.Equals(mark)) ||
                    (Button1.Text.Equals(mark) && Button5.Text.Equals(mark) && Button9.Text.Equals(mark))||
                    (Button3.Text.Equals(mark) && Button5.Text.Equals(mark) && Button7.Text.Equals(mark)))
            {
                if (player.Text.Equals("Player1"))
                {
                    lbl_winning.Text += "Player1 won";

                }
                else
                {
                    lbl_winning.Text += "Player2 won";
                }                }
            }
        }
       
    }
