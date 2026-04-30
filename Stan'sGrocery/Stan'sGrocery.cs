namespace Stan_sGrocery
{
    public partial class StansGroceryForm : System.Windows.Forms.Form
    {
        public StansGroceryForm()
        {
            SplashForm(); // show the splash form before initializing the main form

            InitializeComponent();
        }
        //Custom Methods-------------------------------------------------------
        void SetDefaults()
        {

        }

        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm(); //instantitate the splash form
            splashForm.Show(); // show the splash form
            System.Threading.Thread.Sleep(1000);// pause the main thread for 1 seconds to allow the splash form to be visible
            splashForm.Close(); // close the splash form after 1 seconds
        }

        //Event handler--------------------------------------------------------

        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            this.Show(); // show the main form before showing the about form
            AboutForm aboutForm = new AboutForm(); // instantiate the about form
            aboutForm.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
