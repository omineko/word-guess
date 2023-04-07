using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGameOver : Form
    {

        public string word;
        public bool isGameOver;

        public frmGameOver(string word, bool isGameOver = false)
        {
            InitializeComponent();
            this.word = word;
            this.isGameOver = isGameOver;
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                title.Text = "GAME OVER";
                title.ForeColor = ColorTranslator.FromHtml("#DC2626");
            } else
            {
                title.Text = "YOU WIN";
                title.ForeColor = ColorTranslator.FromHtml("#6ca965");
            }

            yourWord.Text = word;
        }
    }
}
