namespace Stan_sGrocery
{
    public partial class StansGroceryForm : System.Windows.Forms.Form
    {
        public StansGroceryForm()
        {
            SplashForm(); // show the splash form when the main form is instantiated
            InitializeComponent();
            SetDefaults(); // set the defaults to load when the form starts

            string filePath = "..\\..\\..\\grocery.txt";
            FileToArray(filePath); // load the data from the file into the 2D array
            DisplayData(); // display the data in the list box


            SearchButton.Enabled = false; // disable the search button until a search type is selected
            SearchMenuItem.Click += SearchButton_Click; // link the search menu item to the search button click event handler
            ExitMenuItem.Click += ExitButton_Click; // link the exit menu item to the exit button click event handler


        }

        string[,] customerData = new string[0, 0]; // 2D array to display customer data
        string filePath = "..\\..\\..\\grocery.txt"; // file path to the grocery data file
        //Custom Methods-------------------------------------------------------

        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm(); //instantitate the splash form
            splashForm.Show(); // show the splash form
            System.Threading.Thread.Sleep(1000);// pause the main thread for 1 seconds to allow the splash form to be visible
            splashForm.Close(); // close the splash form after 1 seconds
        }
        private void SetDefaults()
        {
            FilterByAisleRadioButton.Checked = true;
        }

        int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }

        string CleanField(string input)
        {
            return input
                .Replace("\"", "") // remove quotes
                .Replace("$", "") // remove dollar signs
                .Replace("#", "") // remove hash symbols
                .Replace("%", "") // remove percent signs
                .Replace("ITM", "") // remove "ITM" prefix
                .Replace("LOC", "") // remove "LOC" prefix
                .Replace("CAT", "") // remove "CAT" prefix
                .Trim(); // remove leading and trailing whitespace
        }

        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[3, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(',');

                    if (temp.Length >= 3)
                    {
                        for (int i = 0; i < temp.Length && i < 4; i++)
                        {
                            _customerData[i, counter] = CleanField(temp[i]);
                        }
                    }

                    counter++;
                } while (!testFile.EndOfStream);
            }

            this.customerData = _customerData;
        }

        void DisplayData()
        {
            string[,] data = this.customerData;
            string formattedRow = "";
            int filterColumn = 2;

            MainListBox.Items.Clear();

            switch (true)
            {
                case bool when FilterByCategoryRadioButton.Checked:
                    filterColumn = 2;
                    break;
                case bool when FilterByAisleRadioButton.Checked:
                    filterColumn = 1;
                    break;
                    //default:
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] == null && (data[filterColumn, row] == SearchComboBox.SelectedItem.ToString() || SearchComboBox.SelectedIndex == 0))
                    {
                        formattedRow = $"{data[0, row],-25} {data[1, row],-5} {data[2, row],-25}";
                        // format by row
                    }
                }
                if (formattedRow == "")
                {

                    if (formattedRow.Contains(SearchTextBox.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        MainListBox.Items.Add(formattedRow);
                    }
                    else
                    {

                    }

                }
            }
        }

        void LoadFilterComboBox()
        {
            int column = 1;
            SearchComboBox.Items.Clear();

            switch (true)
            {
                case bool when FilterByAisleRadioButton.Checked:
                    column = 1;
                    break;
                case bool when FilterByCategoryRadioButton.Checked:
                    column = 2;
                    break;
                    //default:
            }

            for (int row = 0; (row < this.customerData.GetUpperBound(1)); row++)
            {
                if (this.customerData[column, row] != null && SearchComboBox.Items.Contains(this.customerData[column, row]) != true)
                {

                    SearchComboBox.Items.Add(this.customerData[column, row]); //add city 
                }
            }
            SearchComboBox.Items.Add("~Select~");
            SearchComboBox.Sorted = true;
            SearchComboBox.SelectedIndex = 0;

        }

        //Event handler--------------------------------------------------------

        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {
            SearchButton_Click(sender, e);
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
            SearchComboBox.SelectedIndex = 0;
            DisplayData();
            SearchTextBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilterByAisleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }

        private void FilterByCategoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }
    }
}
