﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testApp
{
    public partial class PingPong : Form
    {
        private int _speedVer = 5, _speedHor = 5, _platformSpeed = 15;

        private void PingPong_Load(object sender, EventArgs e)
        {

        }

        private int _score = 0;


        public PingPong()
        {
            InitializeComponent();
            //Cursor.Hide();
        }
        private void PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
            else if(e.KeyCode == Keys.A && Platform.Left > GamePanel.Left || e.KeyCode == Keys.Left && Platform.Left > GamePanel.Left)
            {
                Platform.Left -= _platformSpeed;
            }
            else if (e.KeyCode == Keys.D && Platform.Right < GamePanel.Right || e.KeyCode == Keys.Right && Platform.Right < GamePanel.Right)
            {
                Platform.Left += _platformSpeed;
            }

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            GameBall.Left -= _speedHor;
            GameBall.Top -= _speedVer;
            if(GameBall.Top <= GamePanel.Top)
            {
                _speedVer *= -1;
            }
            if (GameBall.Bottom >= GamePanel.Bottom)
            {
                timer.Enabled = false;
            }
            if(GameBall.Right >= GamePanel.Right)
            {
                _speedHor *= -1;
            }
            if (GameBall.Left <= GamePanel.Left)
            {
                _speedHor *= -1;
            }

            if(GameBall.Bottom >= Platform.Top && 
                GameBall.Left >= Platform.Left && GameBall.Right <= Platform.Right)
            {
                _speedVer *= -1;
                _score++;
            }
        }

    }
}
