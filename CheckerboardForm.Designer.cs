namespace CheckersClient
{
    partial class CheckerboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_board = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_board
            // 
            this.flp_board.Location = new System.Drawing.Point(87, 25);
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
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.flp_board);
            this.Location = new System.Drawing.Point(100, 20);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "CheckerboardForm";
            this.Text = "CheckerboardForm";
            this.Load += new System.EventHandler(this.CheckerboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_board;
    }
}