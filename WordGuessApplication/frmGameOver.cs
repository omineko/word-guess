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

        private string word;
        private bool isGameOver;
        private Form form1;

        public frmGameOver(Form form1, string word, bool isGameOver = false)
        {
            InitializeComponent();
            this.form1 = form1;
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
                title.Text = "SPLENDID";
                title.ForeColor = ColorTranslator.FromHtml("#6ca965");
            }

            yourWord.Text = word;
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            form1.Close();
            this.Close();
        }
    }
}
