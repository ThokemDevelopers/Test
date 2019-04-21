using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VatLibrary.Data.Entities
{
    public class Books : LibraryAsset
    {
        [Required]
        public string ISBN  { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string  DeweyIndex { get; set; }
    }
}
