using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class AddSymbols
    {
        public List<string> loadSymbols(string fileName)
        {
            List<string> icons = new List<string>();

            using (var reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    icons.Add(line);
                }
            }

            return icons;
        }

        public void AssignIconsToSquares(TableLayoutPanel gameBoard, List<string> icons)
        {
            Random r = new Random();
            Label label;
            int randomNumber;

            for (int i = 0; i < gameBoard.Controls.Count; i++) //Iteracja dla każdego Panelu w aplikacji
            {
                if (gameBoard.Controls[i] is Label)
                    label = (Label)gameBoard.Controls[i];
                else
                    continue;

                randomNumber = r.Next(0, icons.Count); //Losowanie ikony na miejsce labelu
                label.Text = icons[randomNumber]; //Przypisanie labelowi ikony

                icons.RemoveAt(randomNumber); //Zapobieganie powtórzeniu się symboli. Od razu usuwane są one z listy symbolów.

            }
        }
    }
}
