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

            }
        }
    }
}
