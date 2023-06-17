using System.Xml.Linq;

namespace Address_Book_Test_N
{
    public class ContactsData : IEquatable<ContactsData>, IComparable<ContactsData>
    {

        private string firestName;
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

        public ContactsData(string name)
        {
            firestName = name;
        }

        public int CompareTo(ContactsData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return firestName.CompareTo(other.firestName) + middleName.CompareTo(other.middleName);
        }

        public bool Equals(ContactsData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return firestName == other.firestName && middleName == other.middleName;
        }

        public override int GetHashCode()
        {
            return firestName.GetHashCode();
        }

        public override String ToString()
        {
            return "name = " + firestName + ", middlename = " + middleName;
        }

        public string FirstName
        {
            get 
            { 
                return firestName; 
            }

            set 
            { 
                firestName = value; 
            }
        }

        public string MiddleName
        {
            get 
            { 
                return middleName; 
            }
            set 
            { 
                middleName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string HomeTelephone
        {
            get { return homeTelephone; }
            set { homeTelephone = value; }
        }
        public string MobileTelephone
        {
            get { return mobileTelephone; }
            set { mobileTelephone = value; }
        }
        public string WorkTelephone
        {
            get { return workTelephone; }
            set { workTelephone = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Email2
        {
            get { return email2; }
            set { email2 = value; }
        }
        public string Email3
        {
            get { return email3; }
            set { email3 = value; }
        }
        public string Homepage
        {
            get { return homepage; }
            set { homepage = value; }
        }
        public string Birthaday
        {
            get { return birthaday; }
            set { birthaday = value; }
        }
        public string Birthmonth
        {
            get { return birthmonth; }
            set { birthmonth = value; }
        }
        public string Birthyear
        {
            get { return birthyear; }
            set { birthyear = value; }
        }

        public string Annivday
        {
            get { return annivday; }
            set { annivday = value; }
        }
        public string Annivmonth
        {
            get { return annivmonth; }
            set { annivmonth = value; }
        }
        public string Annivyear
        {
            get { return annivyear; }
            set { annivyear = value; }
        }
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public string Home
        {
            get { return home; }
            set { home = value; }
        }

    }


}
