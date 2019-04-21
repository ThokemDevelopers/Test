using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VatLibrary.Data.Entities;

namespace VatLibrary.Data
{
    public class VatlibraryContext : DbContext 
    {
        public VatlibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Books> Books { get; set; }
        public DbSet<BranchHours>   BrancHours { get; set; }
        public DbSet<CheckOut> CheckOuts { get; set; }
        public DbSet<CheckOutHistory> CheckOutHistories { get; set; }
        public DbSet<Holds> Holds { get; set; }
        public DbSet<LibraryAsset> LibraryAssets { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<LibraryBranch> LibraryBranches { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
