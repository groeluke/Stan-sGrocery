namespace Stan_sGrocery
{
    partial class Form1
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
            ComboBox = new ComboBox();
            MainListBox = new ListBox();
            SuspendLayout();
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(12, 12);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(776, 33);
            ComboBox.TabIndex = 0;
            // 
            // MainListBox
            // 
            MainListBox.FormattingEnabled = true;
            MainListBox.Location = new Point(12, 51);
            MainListBox.Name = "MainListBox";
            MainListBox.Size = new Size(776, 229);
            MainListBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainListBox);
            Controls.Add(ComboBox);
            Name = "Form1";
            Text = "Stan's Grocery";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ComboBox;
        private ListBox MainListBox;
    }
}
