﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
   
    public partial class GameOverForm : Form
    {
        private int score;
        public GameOverForm(int score)
        {
            InitializeComponent();
            this.score = score;
            label1.Text = "Score: " + score;
            label2.Text = "Level: " + score / 10;
            label3.Text = "Lines " + score;
     }
    }
}