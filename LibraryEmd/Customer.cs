

namespace LibraryEmd
{
    public class Customer
    {
        public string CustomerName { get; set; }

        public string CreateFullName(string firstName, string lastName)
        {
            //return firstName + " " + lastName;
            CustomerName = $"{firstName} {lastName}";
            return CustomerName;
        }
    }
}
