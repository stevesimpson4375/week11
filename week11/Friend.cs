namespace week11
{
    class Friend
    {
        // THe fields are declared here
        private string lastName;
        private string phoneNumber;
        private int month;
        private int day;
        private string firstName;

        // All of the fields have public accessors
        public string LastName
        { get { return lastName; } set { lastName = value; } }

        public string PhoneNumber
        { get { return phoneNumber; } set { phoneNumber = value; } }

        public int Month
        { get { return month; } set { month = value; } }

        public int Day
        { get { return day; } set { day = value; } }

        public string FirstName
        { get { return firstName; } set { firstName = value; } }

        public override string ToString()
        {
            // The ToString() is used to save the fields to a .txt file with a comma delimiter
            return string.Format("{0},{1},{2},{3},{4}", FirstName,LastName,PhoneNumber,Month,Day);
        }

    }
}
