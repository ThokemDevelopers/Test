using System;
using System.Collections.Generic;
using System.Text;

namespace VatLibrary.Data.Entities
{
    public class LibraryCard
    {
        public int Id { get; set; }
        public Decimal Fees { get; set; }
        public DateTime DateCreated { get; set; }

        public IEnumerable<CheckOut> CheckOuts { get; set; }
    }
}
