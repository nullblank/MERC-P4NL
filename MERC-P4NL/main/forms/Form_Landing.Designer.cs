namespace MERC_P4NL.main.forms
{
    partial class Form_Landing
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
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            newsToolStripMenuItem = new ToolStripMenuItem();
            shopToolStripMenuItem = new ToolStripMenuItem();
            contractsToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            quarterMasterControllsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Lucida Console", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, servicesToolStripMenuItem, quarterMasterControllsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(741, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, editToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 20);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            viewToolStripMenuItem.ForeColor = Color.White;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(180, 22);
            viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            logoutToolStripMenuItem.ForeColor = Color.White;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newsToolStripMenuItem, shopToolStripMenuItem, contractsToolStripMenuItem, inventoryToolStripMenuItem });
            servicesToolStripMenuItem.ForeColor = Color.FromArgb(30, 30, 30);
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(73, 20);
            servicesToolStripMenuItem.Text = "Services";
            // 
            // newsToolStripMenuItem
            // 
            newsToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            newsToolStripMenuItem.ForeColor = Color.White;
            newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            newsToolStripMenuItem.Size = new Size(180, 22);
            newsToolStripMenuItem.Text = "News";
            // 
            // shopToolStripMenuItem
            // 
            shopToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            shopToolStripMenuItem.ForeColor = Color.White;
            shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            shopToolStripMenuItem.Size = new Size(180, 22);
            shopToolStripMenuItem.Text = "Shop";
            // 
            // contractsToolStripMenuItem
            // 
            contractsToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            contractsToolStripMenuItem.ForeColor = Color.White;
            contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            contractsToolStripMenuItem.Size = new Size(180, 22);
            contractsToolStripMenuItem.Text = "Contracts";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.BackColor = Color.FromArgb(30, 30, 30);
            inventoryToolStripMenuItem.ForeColor = Color.White;
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(180, 22);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // quarterMasterControllsToolStripMenuItem
            // 
            quarterMasterControllsToolStripMenuItem.Name = "quarterMasterControllsToolStripMenuItem";
            quarterMasterControllsToolStripMenuItem.Size = new Size(185, 20);
            quarterMasterControllsToolStripMenuItem.Text = "Quarter Master Controlls";
            // 
            // Form_Landing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(741, 494);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form_Landing";
            Text = "Form_Landing";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem newsToolStripMenuItem;
        private ToolStripMenuItem shopToolStripMenuItem;
        private ToolStripMenuItem contractsToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem quarterMasterControllsToolStripMenuItem;
    }
}