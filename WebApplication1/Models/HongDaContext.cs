using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class HongDaContext : DbContext
    {
        public HongDaContext()
        {
        }

        public HongDaContext(DbContextOptions<HongDaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bankinfo> Bankinfos { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Hred> Hreds { get; set; }
        public virtual DbSet<Hredinfo> Hredinfos { get; set; }
        public virtual DbSet<Hredlog> Hredlogs { get; set; }
        public virtual DbSet<Hright> Hrights { get; set; }
        public virtual DbSet<Hrole> Hroles { get; set; }
        public virtual DbSet<Hsale> Hsales { get; set; }
        public virtual DbSet<Hsaleslog> Hsaleslogs { get; set; }
        public virtual DbSet<Huser> Husers { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HongDa;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bankinfo>(entity =>
            {
                entity.ToTable("bankinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("bank_address");

                entity.Property(e => e.BankCard).HasColumnName("bank_card");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserNick)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_nick");
            });

            modelBuilder.Entity<House>(entity =>
            {
                entity.Property(e => e.FloorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Floor_Id");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Group_Id");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Group_Name");

                entity.Property(e => e.HId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("H_Id");

                entity.Property(e => e.UnitId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Unit_Id");
            });

            modelBuilder.Entity<Hred>(entity =>
            {
                entity.ToTable("hred");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Allcount).HasColumnName("allcount");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.RedCount).HasColumnName("red_count");

                entity.Property(e => e.RedId).HasColumnName("red_id");

                entity.Property(e => e.RsetRed).HasColumnName("rset_red");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Hredinfo>(entity =>
            {
                entity.ToTable("hredinfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Isf)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("isf");

                entity.Property(e => e.RedCount).HasColumnName("red_count");

                entity.Property(e => e.RedId).HasColumnName("red_id");

                entity.Property(e => e.ResetDays).HasColumnName("reset_days");
            });

            modelBuilder.Entity<Hredlog>(entity =>
            {
                entity.ToTable("hredlog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addsub)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("addsub");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.DescInfo)
                    .HasColumnType("text")
                    .HasColumnName("desc_info");

                entity.Property(e => e.OldCount).HasColumnName("old_count");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("type");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Hright>(entity =>
            {
                entity.ToTable("hright");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("info");

                entity.Property(e => e.Lv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("lv");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Hrole>(entity =>
            {
                entity.ToTable("hrole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("info");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Hsale>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .HasColumnName("End_Date");

                entity.Property(e => e.Family).HasMaxLength(50);

                entity.Property(e => e.FamilyCount)
                    .HasMaxLength(50)
                    .HasColumnName("Family_Count");

                entity.Property(e => e.HouseId).HasColumnName("House_Id");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Card");

                entity.Property(e => e.Job).HasMaxLength(50);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .HasColumnName("Pay_Type");

                entity.Property(e => e.Phone1).HasMaxLength(50);

                entity.Property(e => e.Phone2).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Hsaleslog>(entity =>
            {
                entity.ToTable("Hsaleslog");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(50)
                    .HasColumnName("Id_Card");

                entity.Property(e => e.Info).HasMaxLength(50);

                entity.Property(e => e.OldCount).HasColumnName("Old_Count");

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasMaxLength(50)
                    .HasColumnName("Start_date");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Huser>(entity =>
            {
                entity.ToTable("huser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isf).HasColumnName("isf");

                entity.Property(e => e.LastDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_date");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserNick)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_nick");

                entity.Property(e => e.UserPhone)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_phone");

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_pwd");
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RateFloat).HasColumnName("Rate_Float");

                entity.Property(e => e.RateName)
                    .HasMaxLength(100)
                    .HasColumnName("Rate_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
