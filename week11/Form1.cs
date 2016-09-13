using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace week11
{
    public partial class Form1 : Form
    {
        // The delimiter and file will not be changeable within the program
        const char DELIM = ',';
        const string FILE = @"Friends.txt";

        // The FilesStream and Reader are declared here to allow all of the form to access them
        FileStream infile;
        StreamReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void enterFriendButton_Click(object sender, EventArgs e)
        {
            // The enter friend button creates a new Friend object and saves it to the file

            Friend newFriend = new Friend();

            try
            {
                newFriend.FirstName = firstNameBox.Text;
                newFriend.PhoneNumber = phoneNumberBox.Text;
                newFriend.Month = Convert.ToInt32(monthBox.Text);
                newFriend.Day = Convert.ToInt32(dayBox.Text);
                newFriend.LastName = lastNameBox.Text;
                SaveFriend(newFriend); // The SaveFirend method contains all the functionality to save the object
            }
            catch (FormatException)
            {
                // The only errors that are possible are Format Exceptions caused by entering values that cannot be converted to ints for month or day
                MessageBox.Show("The values entered for Day or Month are not valid\nThe entries must be numeric only", "Entry Error");
            }

            // The boxes are cleared if the entry is accepted
            firstNameBox.Clear();
            phoneNumberBox.Clear();
            monthBox.Clear();
            dayBox.Clear();
            lastNameBox.Clear();
        }

        private void readButton_Click(object sender, EventArgs e)
        {

            allFriendsListBox.Items.Clear(); // The list box is cleared before trying to display entered friends

            allFriendsListBox.Items.AddRange(GetFriendDescription(reader).ToArray()); // The results from the method are added to the listbox

            infile.Seek(0, SeekOrigin.Begin); // The pointer is reset to the beginning of the file
        }

        private void reminderButton_Click(object sender, EventArgs e)
        {
            reminderListBox.Items.Clear(); // The list box is cleared before assigning more values to it

            try
            {
                // The GetFriendDescription method is overloaded to search for month using an integer
                reminderListBox.Items.AddRange(GetFriendDescription(reader, Convert.ToInt32(searchMonthBox.Text)).ToArray());

                infile.Seek(0, SeekOrigin.Begin); // The pinter is reset to the beginning of the file
            }

            catch (FormatException)
            {
                // The user can cause a Format Exception if the value entered into the month search box is not a number
                MessageBox.Show("The value entered for Month must be a number", "Month entry Error");
            }

            searchMonthBox.Clear(); // The entry text box is cleared after use
        }

        void SaveFriend(Friend friend)
        {
            // This method accepts a Friend object and saves it to the file
            try
            {
                FileStream outfile = new FileStream(FILE, FileMode.Append, FileAccess.Write); // A FileStream is declared and set to write

                StreamWriter writer = new StreamWriter(outfile);
                writer.WriteLine(friend.ToString()); // The fields from the friend object are saved with ToString()
                MessageBox.Show("Wrote " + friend.ToString() + " to file", "File Written"); // A confirmation is displayed to the user

                writer.Close(); // The Close() method ensures the Stream is flushed
                outfile.Close();
            }

            catch (Exception)
            {
                // The user is presented with an error message if the saving fails
                MessageBox.Show("There was an error saving to file,\nPlease confirm it is available", "Save Error");
            }
        }


        List<string> GetFriendDescription(StreamReader reader)
        {
            // This method is used with the Read button to display all of the saved Friends
            string friendDescription = ""; // This string is used to store each ToString before it is added to the list
            List<string> friendList = new List<string>(); // This list is returned after it is populate with string

            string recordIn; // This string is used to store the strings as they are read from the file
            string[] fields; // This string array is used to store the separated strings before they are formatted and added to the list

            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);

                // The rcords are formatting beofre being saved to the list
                friendDescription = string.Format("{0,-10} {1,-10} {2,-7} {3,2}/{4,-2}", fields[0], fields[1], fields[2], fields[3], fields[4]);
                friendList.Add(friendDescription);

                recordIn = reader.ReadLine();
            }

            return friendList;
        }

        List<string> GetFriendDescription(StreamReader reader, int month)
        {
            // This overloaded version of the GetFriendDescription method is identical to the other version except that it accepts an integer and uses it
            // to only display friends with a month that matches
            string friendDescription = "";
            List<string> friendStringList = new List<string>();

            string recordIn;
            string[] fields;


            recordIn = reader.ReadLine();
            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);

                if (Convert.ToInt32(fields[3]) == month) // This if statements compares the users entered value to the months of the friends birthday
                {
                    friendDescription = string.Format("{0,-10} {1,-10} {2,-7} {3,2}/{4,-2}", fields[0], fields[1], fields[2], fields[3], fields[4]);
                    friendStringList.Add(friendDescription);
                }
                recordIn = reader.ReadLine();
            }

            return friendStringList;
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            // The list boxes are cleared whenever the user operates the tab control
            allFriendsListBox.Items.Clear();
            reminderListBox.Items.Clear();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method creates a reader whenever tabs other than the entry tab are activated
            if (tabControl.SelectedIndex == 1 || tabControl.SelectedIndex == 2)
            {
                if (reader == null)
                {
                    infile = new FileStream(FILE, FileMode.OpenOrCreate, FileAccess.Read);
                    reader = new StreamReader(infile);
                }
            }
            else {
                if (reader != null)
                {
                    // The reader and file are closed whenever the first tab is selected, which it the tab that does the writing

                    reader.Close();
                    reader = null;
                    infile.Close();
                }
            }
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            // This exit method is operated by all exit buttons
            Close();
        }
    }
}
