namespace Classes
{
    internal class Customer
    {
        //field
        // public string FirstName;
        //property
        public int Id { get; set; }

        private string _firstName;
        public string FirstName
        {
            get; set;
            //get
            //{
            //    return "Mrs."+_firstName;
            //}
            //set
            //{
            //    _firstName = value;
            //}
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
