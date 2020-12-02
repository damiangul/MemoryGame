using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class ScoreCheck
    {
        SqlConnections sqlConnections = new SqlConnections();
        public void addScore(Label firstClicked, Label secondClicked, Label timeLabel, Label scoreLabel)
        {
            int score, time;

            if (firstClicked.Text == secondClicked.Text)
            {
                score = Convert.ToInt32(scoreLabel.Text);
                time = Convert.ToInt32(timeLabel.Text);

                if (time >= 0 && time <= 10)
                {
                    score += 100;
                }
                else if (time > 10 && time <= 20)
                {
                    score += 80;
                }
                else if (time > 20)
                    score += 60;

                scoreLabel.Text = Convert.ToString(score);
            }
        }

        public int checkForWinner(TableLayoutPanel gameBoard, Timer gameTime, TextBox nicknameTextbox, Label realTimeLabel, Label realScoreLabel)
        {
            Label label;
            string gamerNickname, gamerScore, gamerResult;
            string Output;
            int position;

            for (int i = 0; i < gameBoard.Controls.Count; i++) //Sprawdzanie czy wszystkie pola są już oznaczone
            {
                label = gameBoard.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return 0;
            }

            gameTime.Stop();

            //Dodanie wyniku gracza do bazy danych
            gamerNickname = nicknameTextbox.Text;
            gamerScore = realTimeLabel.Text;
            gamerResult = realScoreLabel.Text;
            sqlConnections.insertData(gamerNickname, gamerScore, gamerResult);

            //Dane o graczu
            Output = gamerNickname + " Czas: " + gamerScore + " Wynik: " + gamerResult;
            position = sqlConnections.getPosition(gamerNickname, gamerScore, gamerResult);


            MessageBox.Show("Wygrałeś!\n\nZnajdujesz się na " + position + " miejsciu w tabeli.\n\n" + Output);

            sqlConnections.closeConnections();
            return 1;
        }
    }
}
