namespace Lab4
{
    partial class Form1
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1264, 38);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "topMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMenuNew,
            this.topMenuOpen,
            this.topMenuSave,
            this.topMenuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // topMenuNew
            // 
            this.topMenuNew.Name = "topMenuNew";
            this.topMenuNew.Size = new System.Drawing.Size(240, 34);
            this.topMenuNew.Text = "New";
            this.topMenuNew.Click += new System.EventHandler(this.topMenuNew_Click);
            // 
            // topMenuOpen
            // 
            this.topMenuOpen.Name = "topMenuOpen";
            this.topMenuOpen.Size = new System.Drawing.Size(240, 34);
            this.topMenuOpen.Text = "Open";
            // 
            // topMenuSave
            // 
            this.topMenuSave.Enabled = false;
            this.topMenuSave.Name = "topMenuSave";
            this.topMenuSave.Size = new System.Drawing.Size(240, 34);
            this.topMenuSave.Text = "Save";
            // 
            // topMenuExit
            // 
            this.topMenuExit.Name = "topMenuExit";
            this.topMenuExit.Size = new System.Drawing.Size(240, 34);
            this.topMenuExit.Text = "Exit";
            this.topMenuExit.Click += new System.EventHandler(this.topMenuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMenuAdd});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(60, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // topMenuAdd
            // 
            this.topMenuAdd.Enabled = false;
            this.topMenuAdd.Name = "topMenuAdd";
            this.topMenuAdd.Size = new System.Drawing.Size(240, 34);
            this.topMenuAdd.Text = "Add";
            this.topMenuAdd.Click += new System.EventHandler(this.topMenuAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMenuNew;
        private System.Windows.Forms.ToolStripMenuItem topMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem topMenuSave;
        private System.Windows.Forms.ToolStripMenuItem topMenuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMenuAdd;
    }
}

