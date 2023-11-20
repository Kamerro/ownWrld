namespace ownWrld
{
    partial class AddForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asDescriptionToolStripMenuItem,
            this.asParameterToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // asDescriptionToolStripMenuItem
            // 
            this.asDescriptionToolStripMenuItem.Name = "asDescriptionToolStripMenuItem";
            this.asDescriptionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asDescriptionToolStripMenuItem.Text = "as Description";
            this.asDescriptionToolStripMenuItem.Click += new System.EventHandler(this.asDescriptionToolStripMenuItem_Click);
            // 
            // asParameterToolStripMenuItem
            // 
            this.asParameterToolStripMenuItem.Name = "asParameterToolStripMenuItem";
            this.asParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asParameterToolStripMenuItem.Text = "as Parameter";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(38, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 387);
            this.panel1.TabIndex = 1;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asParameterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}