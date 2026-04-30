namespace Stan_sGrocery
{
    partial class AboutForm
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
            AboutOkLabel = new Label();
            OkAboutButton = new Button();
            SuspendLayout();
            // 
            // AboutOkLabel
            // 
            AboutOkLabel.AutoSize = true;
            AboutOkLabel.Location = new Point(35, 22);
            AboutOkLabel.Name = "AboutOkLabel";
            AboutOkLabel.Size = new Size(59, 25);
            AboutOkLabel.TabIndex = 0;
            AboutOkLabel.Text = "label1";
            // 
            // OkAboutButton
            // 
            OkAboutButton.Location = new Point(215, 186);
            OkAboutButton.Name = "OkAboutButton";
            OkAboutButton.Size = new Size(95, 38);
            OkAboutButton.TabIndex = 1;
            OkAboutButton.Text = "&Ok";
            OkAboutButton.UseVisualStyleBackColor = true;
            OkAboutButton.Click += OkAboutButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 236);
            Controls.Add(OkAboutButton);
            Controls.Add(AboutOkLabel);
            Name = "AboutForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AboutOkLabel;
        private Button OkAboutButton;
    }
}