namespace GRSG
{
    partial class GRSG
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exportResultsMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.levelListbox = new System.Windows.Forms.ListBox();
            this.restrictionsListbox = new System.Windows.Forms.ListBox();
            this.killsListbox = new System.Windows.Forms.ListBox();
            this.collectablesListbox = new System.Windows.Forms.ListBox();
            this.boundsListbox = new System.Windows.Forms.ListBox();
            this.levelButton = new System.Windows.Forms.Button();
            this.restrictionsButton = new System.Windows.Forms.Button();
            this.killsButton = new System.Windows.Forms.Button();
            this.collectablesButton = new System.Windows.Forms.Button();
            this.boundsButton = new System.Windows.Forms.Button();
            this.randomizeAllButton = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportResultsMSI});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(649, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // exportResultsMSI
            // 
            this.exportResultsMSI.Name = "exportResultsMSI";
            this.exportResultsMSI.Size = new System.Drawing.Size(93, 20);
            this.exportResultsMSI.Text = "Export Results";
            this.exportResultsMSI.Click += new System.EventHandler(this.exportResultsMSI_Click);
            // 
            // levelListbox
            // 
            this.levelListbox.FormattingEnabled = true;
            this.levelListbox.Location = new System.Drawing.Point(12, 27);
            this.levelListbox.Name = "levelListbox";
            this.levelListbox.Size = new System.Drawing.Size(120, 238);
            this.levelListbox.TabIndex = 1;
            // 
            // restrictionsListbox
            // 
            this.restrictionsListbox.FormattingEnabled = true;
            this.restrictionsListbox.Location = new System.Drawing.Point(138, 27);
            this.restrictionsListbox.Name = "restrictionsListbox";
            this.restrictionsListbox.Size = new System.Drawing.Size(120, 238);
            this.restrictionsListbox.TabIndex = 2;
            // 
            // killsListbox
            // 
            this.killsListbox.FormattingEnabled = true;
            this.killsListbox.Location = new System.Drawing.Point(264, 27);
            this.killsListbox.Name = "killsListbox";
            this.killsListbox.Size = new System.Drawing.Size(120, 238);
            this.killsListbox.TabIndex = 3;
            // 
            // collectablesListbox
            // 
            this.collectablesListbox.FormattingEnabled = true;
            this.collectablesListbox.Location = new System.Drawing.Point(390, 27);
            this.collectablesListbox.Name = "collectablesListbox";
            this.collectablesListbox.Size = new System.Drawing.Size(120, 238);
            this.collectablesListbox.TabIndex = 3;
            // 
            // boundsListbox
            // 
            this.boundsListbox.FormattingEnabled = true;
            this.boundsListbox.Location = new System.Drawing.Point(516, 27);
            this.boundsListbox.Name = "boundsListbox";
            this.boundsListbox.Size = new System.Drawing.Size(120, 238);
            this.boundsListbox.TabIndex = 4;
            // 
            // levelButton
            // 
            this.levelButton.Location = new System.Drawing.Point(12, 271);
            this.levelButton.Name = "levelButton";
            this.levelButton.Size = new System.Drawing.Size(120, 23);
            this.levelButton.TabIndex = 5;
            this.levelButton.Text = "RNG Level";
            this.levelButton.UseVisualStyleBackColor = true;
            this.levelButton.Click += new System.EventHandler(this.levelButton_Click);
            // 
            // restrictionsButton
            // 
            this.restrictionsButton.Location = new System.Drawing.Point(138, 271);
            this.restrictionsButton.Name = "restrictionsButton";
            this.restrictionsButton.Size = new System.Drawing.Size(120, 23);
            this.restrictionsButton.TabIndex = 6;
            this.restrictionsButton.Text = "RNG Restrictions";
            this.restrictionsButton.UseVisualStyleBackColor = true;
            this.restrictionsButton.Click += new System.EventHandler(this.restrictionsButton_Click);
            // 
            // killsButton
            // 
            this.killsButton.Location = new System.Drawing.Point(264, 271);
            this.killsButton.Name = "killsButton";
            this.killsButton.Size = new System.Drawing.Size(120, 23);
            this.killsButton.TabIndex = 7;
            this.killsButton.Text = "RNG Kills";
            this.killsButton.UseVisualStyleBackColor = true;
            this.killsButton.Click += new System.EventHandler(this.killsButton_Click);
            // 
            // collectablesButton
            // 
            this.collectablesButton.Location = new System.Drawing.Point(390, 271);
            this.collectablesButton.Name = "collectablesButton";
            this.collectablesButton.Size = new System.Drawing.Size(120, 23);
            this.collectablesButton.TabIndex = 8;
            this.collectablesButton.Text = "RNG Collectables";
            this.collectablesButton.UseVisualStyleBackColor = true;
            this.collectablesButton.Click += new System.EventHandler(this.collectablesButton_Click);
            // 
            // boundsButton
            // 
            this.boundsButton.Location = new System.Drawing.Point(516, 271);
            this.boundsButton.Name = "boundsButton";
            this.boundsButton.Size = new System.Drawing.Size(120, 23);
            this.boundsButton.TabIndex = 9;
            this.boundsButton.Text = "RNG Bounds";
            this.boundsButton.UseVisualStyleBackColor = true;
            this.boundsButton.Click += new System.EventHandler(this.boundsButton_Click);
            // 
            // randomizeAllButton
            // 
            this.randomizeAllButton.Location = new System.Drawing.Point(12, 329);
            this.randomizeAllButton.Name = "randomizeAllButton";
            this.randomizeAllButton.Size = new System.Drawing.Size(120, 23);
            this.randomizeAllButton.TabIndex = 10;
            this.randomizeAllButton.Text = "RNG All";
            this.randomizeAllButton.UseVisualStyleBackColor = true;
            this.randomizeAllButton.Click += new System.EventHandler(this.randomizeAllButton_Click);
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(464, 341);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(173, 13);
            this.creditsLabel.TabIndex = 11;
            this.creditsLabel.Text = "GRSG developed by redyellowchef";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(138, 329);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh Lists";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // GRSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(649, 363);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.randomizeAllButton);
            this.Controls.Add(this.boundsButton);
            this.Controls.Add(this.collectablesButton);
            this.Controls.Add(this.killsButton);
            this.Controls.Add(this.restrictionsButton);
            this.Controls.Add(this.levelButton);
            this.Controls.Add(this.boundsListbox);
            this.Controls.Add(this.collectablesListbox);
            this.Controls.Add(this.killsListbox);
            this.Controls.Add(this.restrictionsListbox);
            this.Controls.Add(this.levelListbox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "GRSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghostrunner Speedrun Generator";
            this.Load += new System.EventHandler(this.GRSG_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportResultsMSI;
        private System.Windows.Forms.ListBox levelListbox;
        private System.Windows.Forms.ListBox restrictionsListbox;
        private System.Windows.Forms.ListBox killsListbox;
        private System.Windows.Forms.ListBox collectablesListbox;
        private System.Windows.Forms.ListBox boundsListbox;
        private System.Windows.Forms.Button levelButton;
        private System.Windows.Forms.Button restrictionsButton;
        private System.Windows.Forms.Button killsButton;
        private System.Windows.Forms.Button collectablesButton;
        private System.Windows.Forms.Button boundsButton;
        private System.Windows.Forms.Button randomizeAllButton;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}

