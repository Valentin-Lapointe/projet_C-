namespace CheckersClient
{
    partial class CheckerboardForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_board = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_board
            // 
            this.flp_board.Location = new System.Drawing.Point(16, 17);
            this.flp_board.Margin = new System.Windows.Forms.Padding(4);
            this.flp_board.MaximumSize = new System.Drawing.Size(800, 800);
            this.flp_board.MinimumSize = new System.Drawing.Size(800, 800);
            this.flp_board.Name = "flp_board";
            this.flp_board.Size = new System.Drawing.Size(800, 800);
            this.flp_board.TabIndex = 0;
            this.flp_board.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_board_Paint);
            // 
            // CheckerboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 981);
            this.Controls.Add(this.flp_board);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1150, 1028);
            this.Name = "CheckerboardForm";
            this.Text = "Checkerboard";
            this.Load += new System.EventHandler(this.CheckerboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_board;
    }
}

