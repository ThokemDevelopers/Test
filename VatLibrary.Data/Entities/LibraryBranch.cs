using System;
using System.Collections.Generic;
using System.Text;

namespace VatLibrary.Data.Entities
{
    public class LibraryBranch
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<LibraryAsset> LibraryAssets { get; set; }


    }
}
