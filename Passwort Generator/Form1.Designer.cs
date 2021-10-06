
namespace Passwort_Generator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tBPasswordLenght = new System.Windows.Forms.TrackBar();
            this.lbPasswordLenght = new System.Windows.Forms.Label();
            this.btGeneratePassword = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btCopy = new System.Windows.Forms.Button();
            this.cbSpecialChars = new System.Windows.Forms.CheckBox();
            this.cbNumers = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBPasswordLenght)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(6, 188);
            this.tbPassword.MaximumSize = new System.Drawing.Size(334, 37);
            this.tbPassword.MinimumSize = new System.Drawing.Size(334, 37);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(334, 37);
            this.tbPassword.TabIndex = 0;
            // 
            // tBPasswordLenght
            // 
            this.tBPasswordLenght.LargeChange = 1;
            this.tBPasswordLenght.Location = new System.Drawing.Point(12, 89);
            this.tBPasswordLenght.Maximum = 20;
            this.tBPasswordLenght.Minimum = 8;
            this.tBPasswordLenght.Name = "tBPasswordLenght";
            this.tBPasswordLenght.Size = new System.Drawing.Size(362, 56);
            this.tBPasswordLenght.TabIndex = 3;
            this.tBPasswordLenght.Value = 12;
            this.tBPasswordLenght.ValueChanged += new System.EventHandler(this.tBPasswordLenght_ValueChanged);
            this.tBPasswordLenght.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tBPasswordLenght_MouseDown);
            // 
            // lbPasswordLenght
            // 
            this.lbPasswordLenght.AutoSize = true;
            this.lbPasswordLenght.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPasswordLenght.Location = new System.Drawing.Point(382, 89);
            this.lbPasswordLenght.Name = "lbPasswordLenght";
            this.lbPasswordLenght.Size = new System.Drawing.Size(58, 45);
            this.lbPasswordLenght.TabIndex = 2;
            this.lbPasswordLenght.Text = "12";
            // 
            // btGeneratePassword
            // 
            this.btGeneratePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btGeneratePassword.Location = new System.Drawing.Point(129, 36);
            this.btGeneratePassword.Name = "btGeneratePassword";
            this.btGeneratePassword.Size = new System.Drawing.Size(172, 47);
            this.btGeneratePassword.TabIndex = 3;
            this.btGeneratePassword.Text = "Generiere Passwort!";
            this.btGeneratePassword.UseVisualStyleBackColor = false;
            this.btGeneratePassword.Click += new System.EventHandler(this.btGeneratePassword_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(346, 214);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 29);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Schließe";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.languageToolStripMenuItem.Text = "Sprache";
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            this.deutschToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.deutschToolStripMenuItem.Text = "Deutsch";
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Hilfe";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.aboutToolStripMenuItem.Text = "Über den Passwort Generator";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(346, 175);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(94, 29);
            this.btCopy.TabIndex = 6;
            this.btCopy.Text = "Kopiere";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // cbSpecialChars
            // 
            this.cbSpecialChars.AutoSize = true;
            this.cbSpecialChars.Location = new System.Drawing.Point(24, 151);
            this.cbSpecialChars.Name = "cbSpecialChars";
            this.cbSpecialChars.Size = new System.Drawing.Size(128, 24);
            this.cbSpecialChars.TabIndex = 8;
            this.cbSpecialChars.Text = "Sonderzeichen";
            this.cbSpecialChars.UseVisualStyleBackColor = true;
            // 
            // cbNumers
            // 
            this.cbNumers.AutoSize = true;
            this.cbNumers.Location = new System.Drawing.Point(226, 151);
            this.cbNumers.Name = "cbNumers";
            this.cbNumers.Size = new System.Drawing.Size(76, 24);
            this.cbNumers.TabIndex = 9;
            this.cbNumers.Text = "Zahlen";
            this.cbNumers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 252);
            this.Controls.Add(this.cbNumers);
            this.Controls.Add(this.cbSpecialChars);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btGeneratePassword);
            this.Controls.Add(this.lbPasswordLenght);
            this.Controls.Add(this.tBPasswordLenght);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwort Generator v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.tBPasswordLenght)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TrackBar tBPasswordLenght;
        private System.Windows.Forms.Label lbPasswordLenght;
        private System.Windows.Forms.Button btGeneratePassword;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.CheckBox cbSpecialChars;
        private System.Windows.Forms.CheckBox cbNumers;
    }
}

