namespace Stan_sGrocery
{
    public partial class StansGroceryForm : System.Windows.Forms.Form
    {
        public StansGroceryForm()
        {
            SplashForm(); // show the splash form before initializing the main form

            InitializeComponent();
            SearchButton.Enabled = false; // disable the search button until a search type is selected
            SearchMenuItem.Click += SearchButton_Click; // link the search menu item to the search button click event handler
            SearchC
        }

        string[,] customerData = new string[0, 0]; // 2D array to display customer data
        string filePath = @"C:\Users\lukeg\OneDrive\Desktop\School\4th Semester\github\Stan'sGrocery\Stan'sGrocery\Stan'sGrocery";
        //Custom Methods-------------------------------------------------------
        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm(); //instantitate the splash form
            splashForm.Show(); // show the splash form
            System.Threading.Thread.Sleep(1000);// pause the main thread for 1 seconds to allow the splash form to be visible
            splashForm.Close(); // close the splash form after 1 seconds
        }
        void SetDefaults()
        {

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
