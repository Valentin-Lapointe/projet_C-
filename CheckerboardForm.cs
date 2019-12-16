using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersClient
{
    public partial class CheckerboardForm : Form
    {
        public CheckerboardForm()
        {
            InitializeComponent();
        }

        private void CheckerboardForm_Load(object sender, EventArgs e)
        {
            populateFLP();
        }

        private void populateFLP()
        {
            List<string> testNom = new List<string>();

            Tile[] boardTiles = new Tile[100];
            for (int i = 0; i < boardTiles.Length; i++)
            {
                boardTiles[i] = new Tile();
                boardTiles[i].BackColor = System.Drawing.ColorTranslator.FromHtml("#a04f0e");
                if (i % 2 == 0)
                {
                    if ((i >= 0 && i <= 9) || (i >= 20 && i <= 29) || (i >= 40 && i <= 49) || (i >= 60 && i <= 69) || (i >= 80 && i <= 89))
                    {
                        boardTiles[i].BackColor = System.Drawing.ColorTranslator.FromHtml("#ffe689");
                    }
                }
                else if (i % 2 != 0)
                {
                    if ((i >= 10 && i <= 19) || (i >= 30 && i <= 39) || (i >= 50 && i <= 59) || (i >= 70 && i <= 79) || (i >= 90 && i <= 99))
                    {
                        boardTiles[i].BackColor = System.Drawing.ColorTranslator.FromHtml("#ffe689");
                    }
                }
                flp_board.Controls.Add(boardTiles[i]);

                //Tiles names
                if (i >= 0 && i <= 9)
                {
                    boardTiles[i].Name = "A" + (i + 1);
                }else if (i >= 10 && i <= 19)
                {
                    boardTiles[i].Name = "B" + (i - 9);
                }
                else if (i >= 20 && i <= 29)
                {
                    boardTiles[i].Name = "C" + (i - 19);
                }
                else if (i >= 30 && i <= 39)
                {
                    boardTiles[i].Name = "D" + (i - 29);
                }
                else if (i >= 40 && i <= 49)
                {
                    boardTiles[i].Name = "E" + (i - 39);
                }
                else if (i >= 50 && i <= 59)
                {
                    boardTiles[i].Name = "F" + (i - 49);
                }
                else if (i >= 60 && i <= 69)
                {
                    boardTiles[i].Name = "G" + (i - 59);
                }
                else if (i >= 70 && i <= 79)
                {
                    boardTiles[i].Name = "H" + (i - 69);
                }
                else if (i >= 80 && i <= 89)
                {
                    boardTiles[i].Name = "I" + (i - 79);
                }
                else if (i >= 90 && i <= 99)
                {
                    boardTiles[i].Name = "J" + (i - 89);
                }
                Console.WriteLine(boardTiles[i].Name);
            }
        }
    }
}
