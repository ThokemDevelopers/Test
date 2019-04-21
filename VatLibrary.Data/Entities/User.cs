using System;
using System.Collections.Generic;
using System.Text;

namespace VatLibrary.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Telephone { get; set; }

        public virtual LibraryCard LibraryCard { get; set; }
       public virtual LibraryBranch HomeLibrayBranch { get; set; }
    }
}
