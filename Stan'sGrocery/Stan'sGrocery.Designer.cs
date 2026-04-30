namespace Stan_sGrocery
{
    partial class StansGroceryForm
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
            components = new System.ComponentModel.Container();
            ComboBox = new ComboBox();
            MainListBox = new ListBox();
            ExitButton = new Button();
            SearchButton = new Button();
            TopMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            ToolTip = new ToolTip(components);
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBox
            // 
            ComboBox.Font = new Font("Source Code Pro", 9F);
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(12, 303);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(472, 35);
            ComboBox.TabIndex = 0;
            // 
            // MainListBox
            // 
            MainListBox.Font = new Font("Source Code Pro", 9F);
            MainListBox.FormattingEnabled = true;
            MainListBox.Location = new Point(12, 48);
            MainListBox.Name = "MainListBox";
            MainListBox.Size = new Size(776, 220);
            MainListBox.TabIndex = 1;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(642, 285);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 70);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(490, 285);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(146, 70);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "&Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(270, 34);
            aboutToolStripMenuItem.Text = "About";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(270, 34);
            searchToolStripMenuItem.Text = "Search";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { searchToolStripMenuItem1, exitToolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(137, 68);
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.Size = new Size(136, 32);
            searchToolStripMenuItem1.Text = "Search";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(136, 32);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // StansGroceryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(SearchButton);
            Controls.Add(ExitButton);
            Controls.Add(MainListBox);
            Controls.Add(ComboBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "StansGroceryForm";
            Text = "Stan's Grocery";
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBox;
        private ListBox MainListBox;
        private Button ExitButton;
        private Button SearchButton;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolTip ToolTip;
    }
}
