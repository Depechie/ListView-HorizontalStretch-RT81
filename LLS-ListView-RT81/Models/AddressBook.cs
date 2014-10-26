using System.Collections.Generic;
using System.Linq;

namespace LLS_ListView_RT81.Models
{
    public class AddressBook
    {
        private static List<AddressBook> _dummyList = new List<AddressBook>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public AddressBook(string firstName, string lastName, string address, string phone)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
        }

        public static List<AddressBook> GetDummyData()
        {
            if (!_dummyList.Any())
            {
                _dummyList.Add(new AddressBook ("Joe", "Smith", "US", "48579347594"));
                _dummyList.Add(new AddressBook("Jim", "Johnson", "UK", "3423423423"));
                _dummyList.Add(new AddressBook("Mary", "Robert", "India", "9384394793"));
                _dummyList.Add(new AddressBook("Patricia", "James", "France", "9384394793"));
                _dummyList.Add(new AddressBook("Linda", "Williams", "Italy", "9384394793"));
                _dummyList.Add(new AddressBook("David", "Jones", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Elizabeth", "Martinez", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Richard", "Robinson", "Germany", "9384394793"));
                _dummyList.Add(new AddressBook("Charles", "Clark", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Joseph", "Rodriguez", "France", "9384394793"));
                _dummyList.Add(new AddressBook("Susan", "Lewis", "Italy", "9384394793"));
                _dummyList.Add(new AddressBook("Thomas", "Lee", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Margaret", "Walker", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Christopher", "Hall", "UK", "9384394793"));
                _dummyList.Add(new AddressBook("Lisa", "Allen", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Daniel", "Young", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Paul", "Hernandez", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Karen", "King", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Ruth", "Wright", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Steven", "Lopez", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Edward", "Hill", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Sharon", "Scott", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Brian", "Green", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Michelle", "Ramos", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Ronald", "Mason", "India", "9384394793"));
                _dummyList.Add(new AddressBook("Laura", "Crawford", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Anthony", "Burns", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Sarah", "Gordon", "India", "9384394793"));
                _dummyList.Add(new AddressBook("Kevin", "Hunter", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Kimberly", "Tucker", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Jason", "Dixon", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Deborah", "Mills", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Matthew", "Warren", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Jessica", "Nichols", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Gary", "Knight", "US", "9384394793"));
                _dummyList.Add(new AddressBook("Shirley", "Ferguson", "US", "9384394793"));
            }

            return _dummyList;
        }
    }
}
