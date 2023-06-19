using System.Xml.Linq;

namespace Address_Book_Test_N
{
    public class ContactsData : IEquatable<ContactsData>, IComparable<ContactsData>
    {

        private string firstname;
        private string middleName = "";
        private string lastName = "";
        private string nickName = "";
        private string title = "";
        private string company = "";
        private string adress = "";
        private string homeTelephone = "";
        private string mobileTelephone = "";
        private string workTelephone = "";
        private string fax = "";
        private string email = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";
        private string birthaday = "";
        private string birthmonth = "";
        private string birthyear = "";
        private string annivday = "";
        private string annivmonth = "";
        private string annivyear = "";
        private string address2 = "";
        private string home = "";
        private string notes = "";

        public ContactsData (string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }

        public int CompareTo(ContactsData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return 1;
            }

            if (LastName == other.LastName)
            {
                return FirstName.CompareTo(other.FirstName);
            }

            return LastName.CompareTo(other.LastName);
        }

        public bool Equals(ContactsData other)
        {
            if (object.ReferenceEquals(other, null) || GetType() != other.GetType())
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return FirstName == other.FirstName && LastName == other.LastName;
        }


        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (FirstName != null ? FirstName.GetHashCode() : 0);
                hash = hash * 23 + (LastName != null ? LastName.GetHashCode() : 0);
                return hash;
            }
        }
        //public override int GetHashCode()
        //{

        //    return FirstName.GetHashCode() + MiddleName.GetHashCode;
        //}

        //public string ToString1()
        //{
        //    return "name = " + FirstName /*+ ", lastname = " + LastName*/;
        //}

        public override string ToString()
        {
            return $"LastName = {LastName}, FirstName = {FirstName}";
        }

        public String Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string NickName { get; set; }

        public string Title { get; set; }

        public string Company { get; set; }

        public string Adress { get; set; }
        
        public string HomeTelephone { get; set; }

        public string MobileTelephone { get; set; }
  
        public string WorkTelephone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Email2 { get; set; }

        public string Email3 { get; set; }
 
        public string Homepage { get; set; }

        public string Birthaday { get; set; }

        public string Birthmonth { get; set; }

        public string Birthyear { get; set; }

        public string Annivday { get; set; }

        public string Annivmonth { get; set; }

        public string Annivyear { get; set; }

        public string Address2 { get; set; }

        public string Notes { get; set; }

        public string Home { get; set; }

    }


}
