using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        int startGame = 0, endGame;
        ScoreCheck scoreCheckObject = new ScoreCheck();
        SqlConnections sqlConnections = new SqlConnections();
        AddSymbols addSymbols = new AddSymbols();
        List<string> icons = new List<string>(); //Ikony w mojej aplikacji
        Label firstClicked, secondClicked; //Litery w moim projekcie są to symbole w specjalnej czcionce. Znajdują się w obiekcie Label w aplikacji.

        public MemoryGame()
        {
            InitializeComponent();
            icons = addSymbols.loadSymbols("Symbols.txt");
            addSymbols.AssignIconsToSquares(gameBoard, icons);
            sqlConnections.displayTop(topFiveTextbox);
        }

        private void startGameButton(object sender, EventArgs e)
        {
            if (nicknameTextbox.TextLength == 0) //Przeciwdziałanie sytuacji startu gry bez podania nazwy gracza
                return;

            startGame = 1;
            memoryGameTimer.Start(); 
        }

        private void resetSymbols(object sender, EventArgs e)
        {
            resetTimer.Stop();

            //reset
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void gameTimer(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(realTimeLabel.Text);
            timer += 1;
            realTimeLabel.Text = Convert.ToString(timer);
        }

        private void label_Clicked(object sender, EventArgs e)
        {
            if (startGame == 0)
                return;

            if (firstClicked != null && secondClicked != null) //Zapobieganie sytuacji, że gracz może kliknąć ikonę wiecej niż dwa razy
                return;

            Label clickedLabel = sender as Label; //(LabeL)sender ale ładniej wygląda. Jak się nie uda to pod clickedLabel będzie NULL

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black) //Przeciwdziałanie sytuacji gdy gracz chce kliknąć tą samą ikonę dwa razy.
                return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            //Naliczanie punktów
            scoreCheckObject.addScore(firstClicked, secondClicked, realTimeLabel, realScoreLabel);

            //Sprawdzanie czy juz gracz wygrał
            endGame = scoreCheckObject.checkForWinner(gameBoard, memoryGameTimer, nicknameTextbox, realTimeLabel, realScoreLabel);
            if (endGame == 1)
                Close();


            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                resetTimer.Start(); //Symbole wracają spowrotem do swojego koloru po 750ms jeżelu nie trafiliśmy symbolu
        }
    }
}
