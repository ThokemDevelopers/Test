using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VatLibrary.Data.Entities
{
    public class CheckOutHistory
    {
        public int Id { get; set; }

        [Required]
        public LibraryAsset LibraryAsset  { get; set; }

        [Required]
        public LibraryCard LibraryCard { get; set; }

        public DateTime  CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
    }
}
