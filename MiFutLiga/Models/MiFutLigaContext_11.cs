using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MiFutLiga.Models
{
    public partial class MiFutLigaContext_11 : IdentityDbContext<IdentityUser>
    {
        public MiFutLigaContext_11()
        {
        }

        public MiFutLigaContext_11(DbContextOptions<MiFutLigaContext_11> options)
            : base(options)
        {
        }

       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8U49RG5\\MSSQLSERVER2016;Database=MiFutLiga;User ID=sa;Password=123");
            }
        }

       

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
