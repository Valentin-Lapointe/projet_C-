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
            
        }

        private void flp_board_Paint(object sender, PaintEventArgs e)
        {
            int pawnNumber = 0;
            Tile[] boardTiles = new Tile[100];

            for (int i = 0; i < boardTiles.Length; i++)
            {
                boardTiles[i] = new Tile();

                // Couleur marron
                boardTiles[i].BackColor = ColorTranslator.FromHtml("#a04f0e");

                #region Adressage du damier

                if (i >= 0 && i <= 9)
                {
                    boardTiles[i].Name = string.Format("A{0}", i + 1);
                }
                else if (i >= 10 && i <= 19)
                {
                    boardTiles[i].Name = string.Format("B{0}", i - 9);
                }
                else if (i >= 20 && i <= 29)
                {
                    boardTiles[i].Name = string.Format("C{0}", i - 19);
                }
                else if (i >= 30 && i <= 39)
                {
                    boardTiles[i].Name = string.Format("D{0}", i - 29);
                }
                else if (i >= 40 && i <= 49)
                {
                    boardTiles[i].Name = string.Format("E{0}", i - 39);
                }
                else if (i >= 50 && i <= 59)
                {
                    boardTiles[i].Name = string.Format("F{0}", i - 49);
                }
                else if (i >= 60 && i <= 69)
                {
                    boardTiles[i].Name = string.Format("G{0}", i - 59);
                }
                else if (i >= 70 && i <= 79)
                {
                    boardTiles[i].Name = string.Format("H{0}", i - 69);
                }
                else if (i >= 80 && i <= 89)
                {
                    boardTiles[i].Name = string.Format("I{0}", i - 79);
                }
                else if (i >= 90 && i <= 99)
                {
                    boardTiles[i].Name = string.Format("J{0}", i - 89);
                }

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
                        pawn.BackColor = Color.Black;
                        pawn.Side = 0;
                        pawn.Localization = boardTiles[i].Name;
                        boardTiles[i].Controls.Add(pawn);
                        boardTiles[i].Filled = true;
                    }
                    if (boardTiles[i].Name.StartsWith("H") || boardTiles[i].Name.StartsWith("J"))
                    {
                        pawnNumber++;
                        Pawn pawn = new Pawn();
                        pawn.Name = string.Format("P{0}", pawnNumber);
                        pawn.BackColor = Color.White;
                        pawn.Side = 1;
                        pawn.Localization = boardTiles[i].Name;
                        boardTiles[i].Controls.Add(pawn);
                        boardTiles[i].Filled = true;
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
                        if (boardTiles[i].Name.StartsWith("A") || boardTiles[i].Name.StartsWith("C"))
                        {
                            pawnNumber++;
                            Pawn pawn = new Pawn();
                            pawn.Name = string.Format("P{0}", pawnNumber);
                            pawn.BackColor = Color.Black;
                            pawn.Side = 0;
                            pawn.Localization = boardTiles[i].Name;
                            boardTiles[i].Controls.Add(pawn);
                            boardTiles[i].Filled = true;
                        }
                    }
                    else if (pawnNumber < 40)
                    {
                        if (boardTiles[i].Name.StartsWith("G") || boardTiles[i].Name.StartsWith("I"))
                        {
                            pawnNumber++;
                            Pawn pawn = new Pawn();
                            pawn.Name = string.Format("P{0}", pawnNumber);
                            pawn.BackColor = Color.White;
                            pawn.Side = 1;
                            pawn.Localization = boardTiles[i].Name;
                            boardTiles[i].Controls.Add(pawn);
                            boardTiles[i].Filled = true;
                        }
                    }
                }
                flp_board.Controls.Add(boardTiles[i]);

                // Parcoure tous les contrôles de la case
                bool exist = false;
                foreach (Control c in boardTiles[i].Controls)
                {
                    // Regarde le type du control, pour déterminer si c'est un pion
                    if (c.GetType() == typeof(Pawn))
                    {
                        // Le rend cliquable (appelle la fonction click) c'est un délégué
                        c.Click += Pawn_Click;
                        exist = true;
                    }
                }
                // Si exist est faux, le click est sur la case (pas de pion)
                if (!exist && boardTiles[i].BackColor == ColorTranslator.FromHtml("#a04f0e"))
                {
                    // Rend la case cliquable
                    boardTiles[i].Click += Tile_Click;
                    boardTiles[i].IsLocked = false;
                }
            }
        }

        // Fonction créée grâce au délégué, pour le click sur la case
        // Le sender est du type case
        private void Tile_Click(object sender, EventArgs e)
        {
            Tile tile = ((Tile)sender);

            bool isClicked = false;

            if (tile.BackColor == ColorTranslator.FromHtml("#a04f0e"))
            {
                isClicked = true;
            }
            else
{

            }

            MessageBox.Show(tile.Name);
        }

        // Fonction créée grâce au délégué, pour le click sur le pion
        // Le sender est du type pion
        private void Pawn_Click(object sender, EventArgs e)
        {
            Pawn pawn = ((Pawn)sender);
            bool isClicked = false;

            if(pawn.BackColor == Color.White || pawn.BackColor == Color.Black)
            {
                pawn.BackColor = Color.Gray;
                isClicked = true;
            }
            else
            {
                isClicked = false;
                if(pawn.Side != 0)
                {
                    pawn.BackColor = Color.White;
                }
                else
                {
                    pawn.BackColor = Color.Black;
                }
            }

            MessageBox.Show(pawn.Localization);
        }
    }
}
