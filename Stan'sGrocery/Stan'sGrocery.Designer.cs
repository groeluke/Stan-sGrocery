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
            SearchComboBox = new ComboBox();
            MainListBox = new ListBox();
            ExitButton = new Button();
            SearchButton = new Button();
            TopMenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            SearchMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            ContextMenuStrip = new ContextMenuStrip(components);
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            ToolTip = new ToolTip(components);
            searchToolStripMenuItem = new ToolStripMenuItem();
            TopMenuStrip.SuspendLayout();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // SearchComboBox
            // 
            SearchComboBox.Font = new Font("Source Code Pro", 9F);
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(12, 303);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(472, 35);
            SearchComboBox.TabIndex = 0;
            SearchComboBox.SelectedIndexChanged += SearchComboBox_SelectedIndexChanged;
            // 
            // MainListBox
            // 
            MainListBox.Font = new Font("Source Code Pro", 9F);
            MainListBox.FormattingEnabled = true;
            MainListBox.Location = new Point(12, 48);
            MainListBox.Name = "MainListBox";
            MainListBox.Size = new Size(776, 220);
            MainListBox.TabIndex = 1;
            MainListBox.SelectedIndexChanged += MainListBox_SelectedIndexChanged;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(642, 285);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(146, 70);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(490, 285);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(146, 70);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "&Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem, HelpMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SearchMenuItem, ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(54, 29);
            FileMenuItem.Text = "File";
            // 
            // SearchMenuItem
            // 
            SearchMenuItem.Name = "SearchMenuItem";
            SearchMenuItem.Size = new Size(166, 34);
            SearchMenuItem.Text = "Search";
            SearchMenuItem.Click += SearchMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(166, 34);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem });
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(65, 29);
            HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(164, 34);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { searchToolStripMenuItem1, exitToolStripMenuItem1, searchToolStripMenuItem });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(137, 100);
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
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(136, 32);
            searchToolStripMenuItem.Text = "Search";
            // 
            // StansGroceryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(SearchButton);
            Controls.Add(ExitButton);
            Controls.Add(MainListBox);
            Controls.Add(SearchComboBox);
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

        private ComboBox SearchComboBox;
        private ListBox MainListBox;
        private Button ExitButton;
        private Button SearchButton;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem SearchMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem searchToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolTip ToolTip;
        private ToolStripMenuItem searchToolStripMenuItem;
    }
}
