using System.Collections.Generic;
namespace Address_Book_Test_N
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData(string name)
        {
            this.name = name;
        }


        public int CompareTo(GroupData other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Name.CompareTo(other.Name);
        }
        public bool Equals(GroupData other) 
        {
            if (object.ReferenceEquals(other, null))
            {
                return false ;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }

        public override int GetHashCode() 
        {
            return name.GetHashCode();
        }

        public override String ToString()
        {
            return "name = " + name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        public string Footer
        {
            get { return footer; }
            set { footer = value; }
        }
    }

}