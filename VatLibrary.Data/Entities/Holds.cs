using System;
using System.Collections.Generic;
using System.Text;

namespace VatLibrary.Data.Entities
{
    public class Holds
    {
        public int Id { get; set; }
        public LibraryAsset LibraryAsset { get; set; }
        public LibraryCard LibraryCard { get; set; }

        public DateTime HoldPlaced { get; set; }
    }
}
