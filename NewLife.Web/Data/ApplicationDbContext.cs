using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newlife.Web.Core.Models;
using System.Reflection.Emit;

namespace NewLife.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CoachAttachment>()
               .HasOne(ca => ca.Coach).WithMany(c => c.Attachments).HasForeignKey(ca => ca.CoachId);

            builder.Entity<OfferAttachment>()
              .HasOne(oa => oa.Offer).WithMany(o => o.Attachments).HasForeignKey(oa => oa.OfferId);

            base.OnModelCreating(builder);


        }


        public DbSet<Coach> Coaches { get; set; }
        public DbSet<CoachAttachment> CoachAttachments { get; set; }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<OfferAttachment> OfferAttachments { get; set; }

        public DbSet<StaticPage> StaticPages { get; set; }
        public DbSet<Article> Articles { get; set; }


    }
}