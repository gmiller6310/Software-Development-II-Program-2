namespace UPVApp
{
    partial class Prog2Form
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
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAddressesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParcelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.insertMenuItem,
            this.reportMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.ShortcutKeyDisplayString = "";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.ShortcutKeyDisplayString = "";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "A&bout";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // insertMenuItem
            // 
            this.insertMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressMenuItem,
            this.letterMenuItem});
            this.insertMenuItem.Name = "insertMenuItem";
            this.insertMenuItem.Size = new System.Drawing.Size(48, 20);
            this.insertMenuItem.Text = "&Insert";
            // 
            // addressMenuItem
            // 
            this.addressMenuItem.Name = "addressMenuItem";
            this.addressMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addressMenuItem.Text = "&Address";
            this.addressMenuItem.Click += new System.EventHandler(this.addressMenuItem_Click);
            // 
            // letterMenuItem
            // 
            this.letterMenuItem.Name = "letterMenuItem";
            this.letterMenuItem.Size = new System.Drawing.Size(116, 22);
            this.letterMenuItem.Text = "&Letter";
            this.letterMenuItem.Click += new System.EventHandler(this.letterMenuItem_Click);
            // 
            // reportMenuItem
            // 
            this.reportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddressesMenuItem,
            this.listParcelsMenuItem});
            this.reportMenuItem.Name = "reportMenuItem";
            this.reportMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportMenuItem.Text = "&Report";
            // 
            // listAddressesMenuItem
            // 
            this.listAddressesMenuItem.Name = "listAddressesMenuItem";
            this.listAddressesMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listAddressesMenuItem.Text = "&List Addresses";
            this.listAddressesMenuItem.Click += new System.EventHandler(this.listAddressesMenuItem_Click);
            // 
            // listParcelsMenuItem
            // 
            this.listParcelsMenuItem.Name = "listParcelsMenuItem";
            this.listParcelsMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listParcelsMenuItem.Text = "List &Parcels";
            this.listParcelsMenuItem.Click += new System.EventHandler(this.listParcelsMenuItem_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputTextBox.Location = new System.Drawing.Point(12, 27);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(502, 408);
            this.outputTextBox.TabIndex = 1;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 441);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prog2Form";
            this.Text = "Program 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddressesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listParcelsMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

