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
            Name = name;
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

        public String Id { get; set; }

        public string Name { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

    }

}