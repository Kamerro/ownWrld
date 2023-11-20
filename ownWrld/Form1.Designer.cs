namespace ownWrld
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Strip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Strip
            // 
            this.Strip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewParameterToolStripMenuItem,
            this.removeParameterToolStripMenuItem,
            this.checkParameterToolStripMenuItem,
            this.modifyParameterToolStripMenuItem});
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(96, 24);
            this.Strip.Text = "Parameters";
            this.Strip.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Strip_DropDownItemClicked);
            // 
            // addNewParameterToolStripMenuItem
            // 
            this.addNewParameterToolStripMenuItem.Name = "addNewParameterToolStripMenuItem";
            this.addNewParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewParameterToolStripMenuItem.Text = "Add new parameter";
            // 
            // removeParameterToolStripMenuItem
            // 
            this.removeParameterToolStripMenuItem.Name = "removeParameterToolStripMenuItem";
            this.removeParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeParameterToolStripMenuItem.Text = "Remove parameter";
            // 
            // checkParameterToolStripMenuItem
            // 
            this.checkParameterToolStripMenuItem.Name = "checkParameterToolStripMenuItem";
            this.checkParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkParameterToolStripMenuItem.Text = "Check parameter";
            // 
            // modifyParameterToolStripMenuItem
            // 
            this.modifyParameterToolStripMenuItem.Name = "modifyParameterToolStripMenuItem";
            this.modifyParameterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifyParameterToolStripMenuItem.Text = "Modify parameter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Strip;
        private System.Windows.Forms.ToolStripMenuItem addNewParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyParameterToolStripMenuItem;
    }
}

