namespace Agricoler
{
    partial class Agricoler
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainBoard = new System.Windows.Forms.PictureBox();
            this.farm1blue = new System.Windows.Forms.PictureBox();
            this.farm1red = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farm1blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farm1red)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(640, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // mainLayout
            // 
            this.mainLayout.AutoSize = true;
            this.mainLayout.BackColor = System.Drawing.SystemColors.Control;
            this.mainLayout.ColumnCount = 5;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.999F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0016F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.9998F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.9998F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.9998F));
            this.mainLayout.Controls.Add(this.mainBoard, 0, 0);
            this.mainLayout.Controls.Add(this.farm1blue, 1, 0);
            this.mainLayout.Controls.Add(this.farm1red, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 24);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Size = new System.Drawing.Size(640, 460);
            this.mainLayout.TabIndex = 2;
            // 
            // mainBoard
            // 
            this.mainBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBoard.Image = global::Agricoler.Properties.Resources.main;
            this.mainBoard.Location = new System.Drawing.Point(0, 0);
            this.mainBoard.Margin = new System.Windows.Forms.Padding(0);
            this.mainBoard.Name = "mainBoard";
            this.mainLayout.SetRowSpan(this.mainBoard, 2);
            this.mainBoard.Size = new System.Drawing.Size(319, 460);
            this.mainBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainBoard.TabIndex = 0;
            this.mainBoard.TabStop = false;
            this.mainBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.mainBoard_Paint);
            // 
            // farm1blue
            // 
            this.farm1blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.farm1blue.Image = global::Agricoler.Properties.Resources.farm;
            this.farm1blue.Location = new System.Drawing.Point(319, 0);
            this.farm1blue.Margin = new System.Windows.Forms.Padding(0);
            this.farm1blue.Name = "farm1blue";
            this.farm1blue.Size = new System.Drawing.Size(128, 230);
            this.farm1blue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.farm1blue.TabIndex = 1;
            this.farm1blue.TabStop = false;
            // 
            // farm1red
            // 
            this.farm1red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.farm1red.Image = global::Agricoler.Properties.Resources.farm;
            this.farm1red.Location = new System.Drawing.Point(319, 230);
            this.farm1red.Margin = new System.Windows.Forms.Padding(0);
            this.farm1red.Name = "farm1red";
            this.farm1red.Size = new System.Drawing.Size(128, 230);
            this.farm1red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.farm1red.TabIndex = 2;
            this.farm1red.TabStop = false;
            // 
            // Agricoler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 484);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximumSize = new System.Drawing.Size(1040, 798);
            this.MinimumSize = new System.Drawing.Size(656, 522);
            this.Name = "Agricoler";
            this.Text = "Agricoler";
            this.SizeChanged += new System.EventHandler(this.Agricoler_SizeChanged);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farm1blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farm1red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.PictureBox mainBoard;
        private System.Windows.Forms.PictureBox farm1blue;
        private System.Windows.Forms.PictureBox farm1red;
    }
}

