using System.Data.Entity;
using Siparis.Data.Model;

namespace Siparis.Data.Context
{
    public partial class SiparisContext : DbContext
    {
        public SiparisContext()
            : base("name=SiparisContext")
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AdressStatus> AdressStatus { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CompaniesAndAdresses> CompaniesAndAdresses { get; set; }
        public virtual DbSet<CompaniesAndNumbers> CompaniesAndNumbers { get; set; }
        public virtual DbSet<CompaniesAndSocials> CompaniesAndSocials { get; set; }
        public virtual DbSet<CompanyTypes> CompanyTypes { get; set; }
        public virtual DbSet<MediaFileTypes> MediaFileTypes { get; set; }
        public virtual DbSet<Numbers> Numbers { get; set; }
        public virtual DbSet<NumberTypes> NumberTypes { get; set; }
        public virtual DbSet<PageCategories> PageCategories { get; set; }
        public virtual DbSet<PageDetailFields> PageDetailFields { get; set; }
        public virtual DbSet<PageDetailMediaFiles> PageDetailMediaFiles { get; set; }
        public virtual DbSet<PageDetails> PageDetails { get; set; }
        public virtual DbSet<PageDetailsAndTags> PageDetailsAndTags { get; set; }
        public virtual DbSet<PageFields> PageFields { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PagesRobotsStatus> PagesRobotsStatus { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<ProductFields> ProductFields { get; set; }
        public virtual DbSet<ProductQuantities> ProductQuantities { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Seo> Seo { get; set; }
        public virtual DbSet<Socials> Socials { get; set; }
        public virtual DbSet<TagLinkTargetTypes> TagLinkTargetTypes { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<UserAndNumbers> UserAndNumbers { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersAndAdresses> UsersAndAdresses { get; set; }
        public virtual DbSet<UsersAndSocials> UsersAndSocials { get; set; }
        public virtual DbSet<UsersAndUserRoles> UsersAndUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>()
                .Property(e => e.AdressName)
                .IsFixedLength();

            modelBuilder.Entity<Addresses>()
                .Property(e => e.AdressDesc)
                .IsFixedLength();

            modelBuilder.Entity<Addresses>()
                .Property(e => e.AdressMap)
                .IsFixedLength();

            modelBuilder.Entity<Addresses>()
                .Property(e => e.AdressZipCode)
                .IsFixedLength();

            modelBuilder.Entity<Addresses>()
                .HasMany(e => e.Addresses1)
                .WithOptional(e => e.Addresses2)
                .HasForeignKey(e => e.AdressParentId);

            modelBuilder.Entity<AdressStatus>()
                .Property(e => e.StatuName)
                .IsFixedLength();

            modelBuilder.Entity<AdressStatus>()
                .Property(e => e.StatuDesc)
                .IsFixedLength();

            modelBuilder.Entity<AdressStatus>()
                .HasMany(e => e.Addresses)
                .WithOptional(e => e.AdressStatus)
                .HasForeignKey(e => e.AdressStatuId);

            modelBuilder.Entity<Comments>()
                .Property(e => e.CommentName)
                .IsFixedLength();

            modelBuilder.Entity<Comments>()
                .Property(e => e.CommentDesc)
                .IsFixedLength();

            modelBuilder.Entity<Comments>()
                .HasMany(e => e.Comments1)
                .WithOptional(e => e.Comments2)
                .HasForeignKey(e => e.CommentParentId);

            modelBuilder.Entity<Companies>()
                .Property(e => e.CompanyName)
                .IsFixedLength();

            modelBuilder.Entity<Companies>()
                .Property(e => e.CompanyDesc)
                .IsFixedLength();

            modelBuilder.Entity<Companies>()
                .Property(e => e.CompanyLogo)
                .IsFixedLength();

            modelBuilder.Entity<Companies>()
                .Property(e => e.ComponyLogo2)
                .IsFixedLength();

            modelBuilder.Entity<CompaniesAndSocials>()
                .HasMany(e => e.UsersAndSocials)
                .WithOptional(e => e.CompaniesAndSocials)
                .HasForeignKey(e => e.SocialId);

            modelBuilder.Entity<CompanyTypes>()
                .Property(e => e.CompnayTypeName)
                .IsFixedLength();

            modelBuilder.Entity<MediaFileTypes>()
                .Property(e => e.MediaFileType)
                .IsFixedLength();

            modelBuilder.Entity<MediaFileTypes>()
                .Property(e => e.MediaFileMimeExtension)
                .IsFixedLength();

            modelBuilder.Entity<Numbers>()
                .Property(e => e.Number)
                .IsFixedLength();

            modelBuilder.Entity<NumberTypes>()
                .Property(e => e.NumberType)
                .IsFixedLength();

            modelBuilder.Entity<PageCategories>()
                .Property(e => e.PageCategoryName)
                .IsFixedLength();

            modelBuilder.Entity<PageCategories>()
                .HasMany(e => e.PageCategories1)
                .WithOptional(e => e.PageCategories2)
                .HasForeignKey(e => e.PageCategoryParentId);

            modelBuilder.Entity<PageDetailFields>()
                .Property(e => e.PageDetailFieldName)
                .IsFixedLength();

            modelBuilder.Entity<PageDetailFields>()
                .Property(e => e.PageDetailFieldDesc)
                .IsFixedLength();

            modelBuilder.Entity<PageDetailMediaFiles>()
                .Property(e => e.MediaFileTitle)
                .IsFixedLength();

            modelBuilder.Entity<PageDetailMediaFiles>()
                .Property(e => e.MediaFileDesc)
                .IsFixedLength();

            modelBuilder.Entity<PageDetailMediaFiles>()
                .Property(e => e.MediaFilePath)
                .IsFixedLength();

            modelBuilder.Entity<PageDetails>()
                .Property(e => e.PageDetailTitle)
                .IsFixedLength();

            modelBuilder.Entity<PageFields>()
                .Property(e => e.PageFieldName)
                .IsFixedLength();

            modelBuilder.Entity<PageFields>()
                .Property(e => e.PageFiledDesc)
                .IsFixedLength();

            modelBuilder.Entity<Pages>()
                .Property(e => e.PageName)
                .IsFixedLength();

            modelBuilder.Entity<Pages>()
                .Property(e => e.PageTitle)
                .IsFixedLength();

            modelBuilder.Entity<Pages>()
                .Property(e => e.PageDescription)
                .IsFixedLength();

            modelBuilder.Entity<PagesRobotsStatus>()
                .Property(e => e.PageRobotStatu)
                .IsFixedLength();

            modelBuilder.Entity<PagesRobotsStatus>()
                .HasMany(e => e.Seo)
                .WithOptional(e => e.PagesRobotsStatus)
                .HasForeignKey(e => e.SeoRobotsStatuId);

            modelBuilder.Entity<ProductCategories>()
                .Property(e => e.ProductCategoryName)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategories>()
                .Property(e => e.ProductCategoryDesc)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategories>()
                .Property(e => e.ProductCategoryImg)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategories>()
                .Property(e => e.MetaKeyword)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategories>()
                .Property(e => e.MetaDesc)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategories>()
                .HasMany(e => e.ProductCategories1)
                .WithOptional(e => e.ProductCategories2)
                .HasForeignKey(e => e.ProductCategoryParentId);

            modelBuilder.Entity<ProductFields>()
                .Property(e => e.ProductFieldName)
                .IsFixedLength();

            modelBuilder.Entity<ProductFields>()
                .Property(e => e.ProductFieldDesc)
                .IsFixedLength();

            modelBuilder.Entity<ProductQuantities>()
                .Property(e => e.ProductQuantityName)
                .IsFixedLength();

            modelBuilder.Entity<ProductQuantities>()
                .Property(e => e.ProductQuantityShortName)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductName)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductDesc)
                .IsFixedLength();

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductDiscount)
                .IsFixedLength();

            modelBuilder.Entity<Roles>()
                .Property(e => e.RoleName)
                .IsFixedLength();

            modelBuilder.Entity<Roles>()
                .Property(e => e.RoleDesc)
                .IsFixedLength();

            modelBuilder.Entity<Seo>()
                .Property(e => e.SeoDescription)
                .IsFixedLength();

            modelBuilder.Entity<Seo>()
                .Property(e => e.SeoKeyword)
                .IsFixedLength();

            modelBuilder.Entity<Socials>()
                .Property(e => e.SocialMediaName)
                .IsFixedLength();

            modelBuilder.Entity<Socials>()
                .Property(e => e.SocialProfileName)
                .IsFixedLength();

            modelBuilder.Entity<Socials>()
                .Property(e => e.SocialMediaLink)
                .IsFixedLength();

            modelBuilder.Entity<Socials>()
                .Property(e => e.SocialMediaIcon)
                .IsFixedLength();

            modelBuilder.Entity<TagLinkTargetTypes>()
                .Property(e => e.LinkTarget)
                .IsFixedLength();

            modelBuilder.Entity<Tags>()
                .Property(e => e.TagName)
                .IsFixedLength();

            modelBuilder.Entity<Tags>()
                .Property(e => e.TagDesc)
                .IsFixedLength();

            modelBuilder.Entity<Tags>()
                .Property(e => e.TagLink)
                .IsFixedLength();

            modelBuilder.Entity<Tags>()
                .HasMany(e => e.PageDetailsAndTags)
                .WithOptional(e => e.Tags)
                .HasForeignKey(e => e.PageTagId);

            modelBuilder.Entity<UserDetails>()
                .Property(e => e.FieldName)
                .IsFixedLength();

            modelBuilder.Entity<UserDetails>()
                .Property(e => e.FieldDesc)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserPassword)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserEmail)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserFirstName)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserLastName)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserImage)
                .IsFixedLength();
        }
    }
}
