using System.Collections;
using System.Text;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        // masked word
        private StringBuilder wordPreview = new StringBuilder(new String("?????"));

        // word generated
        private string wordGen;

        // game timer
        System.Threading.Timer timer;

        // keeps track of the current and maximum time
        private int maxTime = 180, time = 180;

        // number of rows and columns
        private const int COL_NUM = 5;
        private const int ROW_NUM = 6;

        // 2d representation of labels
        private Label[,] labels = new Label[COL_NUM, ROW_NUM];

        // tracks the current row
        private int currentRow = 0;

        // dictionary of wordle words
        private string[] words = Properties.Resources.wordle.Split("\n");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pickWord();
            startTimer();
            initLabels();
        }

        private void initLabels()
        {
            for (int row = 0; row < ROW_NUM; row++)
            {
                for (int col = 0; col < COL_NUM; col++)
                {
                    Label lbl = genLabel();
                    labels[col, row] = lbl;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
        }

        private Label genLabel() {
            Label lbl = new Label();
            lbl.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lbl.ForeColor = Color.Black;
            lbl.Size = new Size(50, 50);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BackColor = Color.WhiteSmoke;
            lbl.Margin = new Padding(5);
            lbl.BorderStyle = BorderStyle.FixedSingle;

            return lbl;
        }

        private void startTimer()
        {
            this.timer = new System.Threading.Timer(v =>
            {
                if (time <= 0)
                {
                    isWon();
                } else
                {
                    this.time--;
                    this.timeLbl.Text = $"{(time / 60).ToString("D2")}:{(time % 60).ToString("D2")}";
                    this.progressBar.Value = Convert.ToInt16((double)time / maxTime * 100);
                }
            }, null, 0, 1000);
        }

        private void quessBtn_Click(object sender, EventArgs e)
        {
            if (guessInput.TextLength == COL_NUM && isValidWord(guessInput.Text.ToLower()))
            {
                char[] wordArr = guessInput.Text.ToUpper().ToCharArray();

                for (int i = 0; i < wordArr.Length; i++)
                {
                    labels[i, currentRow].Text = wordArr[i].ToString();
                }

                checkGuess();
                currentRow++;

                isWon();
                guessInput.Clear();
            }
        }

        private void pickWord()
        {
            wordGen = words[new Random().Next(words.Length)].ToUpper();
            guessWord.Text = wordPreview.ToString();
            Console.WriteLine(wordGen);
        }

        private void checkGuess()
        {
            ArrayList foundLetters = new ArrayList();

            for (int i = 0; i < COL_NUM; i++)
            {
                Label lbl = labels[i, currentRow];
                lbl.ForeColor = Color.White;

                if (lbl.Text.Equals(wordGen[i].ToString()))
                {
                    // the letter position is correct
                    lbl.BackColor = ColorTranslator.FromHtml("#6ca965");
                    foundLetters.Add(lbl.Text);

                    updateGuessWord(i, wordGen[i]);
                } else lbl.BackColor = ColorTranslator.FromHtml("#787c7f");
            }

            for (int i = 0; i < COL_NUM; i++)
            {
                Label lbl = labels[i, currentRow];
                if (wordGen.Contains(lbl.Text.ToString()) && !foundLetters.Contains(lbl.Text.ToString()))
                {
                    lbl.BackColor = ColorTranslator.FromHtml("#c8b653");
                }
            }
        }

        private void isWon()
        {
            if (wordGen.Trim().Equals(guessInput.Text.ToUpper().Trim()))
            {
                guessWord.BackColor = ColorTranslator.FromHtml("#6ca965");
                timer.Dispose();

                // Create and show the frmGameOver form on the UI thread
                this.Invoke(new Action(() =>
                {
                    Form frmGameOver = new frmGameOver(this, wordGen);
                    frmGameOver.Show();
                }));
            } else if (currentRow == ROW_NUM)
            {
                timer.Dispose();

                // Create and show the frmGameOver form on the UI thread
                this.Invoke(new Action(() =>
                {
                    Form frmGameOver = new frmGameOver(this, wordGen, true);
                    frmGameOver.Show();
                }));
                guessWord.BackColor = ColorTranslator.FromHtml("#DC2626");
            }
        }

        private bool isValidWord(string word)
        {
            foreach (string rawWord in words)
            {
                if (rawWord.Trim().Equals(word))
                {
                    return true;
                }
            }

            return false;
        }

        private void updateGuessWord(int index, char c)
        {
            wordPreview[index] = c;
            guessWord.Text = wordPreview.ToString();
        }
    }
}