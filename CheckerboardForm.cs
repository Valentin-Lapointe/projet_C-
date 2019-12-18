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
            PopulateFLP();
        }

        private void PopulateFLP()
        {
            int pawnNumber = 0;
            Tile[] boardTiles = new Tile[100];
            for (int i = 0; i < boardTiles.Length; i++)
            {
                boardTiles[i] = new Tile();
                boardTiles[i].Size = new Size(80, 80);
                boardTiles[i].BackColor = ColorTranslator.FromHtml("#a04f0e");

                #region Tile Names
                if (i >= 0 && i <= 9)
                {
                    boardTiles[i].Name = "A" + (i + 1);
                }
                else if (i >= 10 && i <= 19)
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
                //Console.WriteLine(boardTiles[i].Name);
                #endregion

                if (i % 2 == 0)
                {
                    if ((i >= 0 && i <= 9) || (i >= 20 && i <= 29) || (i >= 40 && i <= 49) || (i >= 60 && i <= 69) || (i >= 80 && i <= 89))
                    {
                        boardTiles[i].BackColor = ColorTranslator.FromHtml("#ffe689");
                    }
                    if (boardTiles[i].Name.StartsWith("B") || boardTiles[i].Name.StartsWith("D"))
                    {
                        pawnNumber++;
                        Pawn pawn = new Pawn();
                        pawn.Name = string.Format("P{0}", pawnNumber);
                        pawn.BackColor = ColorTranslator.FromHtml("#000000");
                        pawn.Size = new Size(61, 61);
                        pawn.Margin = new Padding(0);
                        boardTiles[i].Controls.Add(pawn);
                    }
                    if (boardTiles[i].Name.StartsWith("H") || boardTiles[i].Name.StartsWith("J"))
                    {
                        pawnNumber++;
                        Pawn pawn = new Pawn();
                        pawn.Name = string.Format("P{0}", pawnNumber);
                        pawn.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                        pawn.Size = new Size(61, 61);
                        pawn.Margin = new Padding(0);
                        boardTiles[i].Controls.Add(pawn);
                    }
                }
                else if (i % 2 != 0)
                {
                    if ((i >= 10 && i <= 19) || (i >= 30 && i <= 39) || (i >= 50 && i <= 59) || (i >= 70 && i <= 79) || (i >= 90 && i <= 99))
                    {
                        boardTiles[i].BackColor = ColorTranslator.FromHtml("#ffe689");
                    }

                    if (pawnNumber < 20)
                    {
                        if (boardTiles[i].Name.StartsWith("A") || boardTiles[i].Name.StartsWith("C")) { 
                            pawnNumber++;
                            Pawn pawn = new Pawn();
                            pawn.Name = string.Format("P{0}", pawnNumber);
                            pawn.BackColor = ColorTranslator.FromHtml("#000000");
                            pawn.Size = new Size(61, 61);
                            pawn.Margin = new Padding(0);
                            boardTiles[i].Controls.Add(pawn);
                        }
                    }
                    else if (pawnNumber < 40)
                    {
                        if(boardTiles[i].Name.StartsWith("G") || boardTiles[i].Name.StartsWith("I")){
                            pawnNumber++;
                            Pawn pawn = new Pawn();
                            pawn.Name = string.Format("P{0}", pawnNumber);
                            pawn.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                            pawn.Size = new Size(61, 61);
                            pawn.Margin = new Padding(0);
                            boardTiles[i].Controls.Add(pawn);
                        }
                    }
                }
                //flp_board.SendToBack();
                flp_board.Controls.Add(boardTiles[i]);
            }
        }

        private void pawn2_Load(object sender, EventArgs e)
        {

        }

        private void flp_board_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
