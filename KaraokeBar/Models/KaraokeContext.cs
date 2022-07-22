using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace KaraokeBar.Models
{
    public partial class KaraokeContext : DbContext
    {
        public KaraokeContext()
        {
        }

        public KaraokeContext(DbContextOptions<KaraokeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Music> Musics { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<TypeOfRoom> TypeOfRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                string ConStr = config.GetConnectionString("ConStr");
                optionsBuilder.UseSqlServer(ConStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("account_pk");

                entity.ToTable("Account");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("displayName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("permission");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("payment_method");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__userName__300424B4");
            });

            modelBuilder.Entity<Music>(entity =>
            {
                entity.ToTable("Music");

                entity.Property(e => e.MusicId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("music_id");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("abbreviation");

                entity.Property(e => e.AccentedName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("accented_name");

                entity.Property(e => e.Composer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("composer");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("genre");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Lyric)
                    .HasMaxLength(255)
                    .HasColumnName("lyric");

                entity.Property(e => e.Singer)
                    .HasMaxLength(255)
                    .HasColumnName("singer");

                entity.Property(e => e.UnaccentedName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("unaccented_name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ServiceId)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("service_id");

                entity.Property(e => e.TotalPayment).HasColumnName("total_payment");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user");

                entity.HasOne(d => d.Bill)
                    .WithMany()
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__bill_id__31EC6D26");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__service_i__33D4B598");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order__user__32E0915F");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => new { e.Floor, e.RoomNumber })
                    .HasName("room_pk");

                entity.ToTable("Room");

                entity.Property(e => e.Floor).HasColumnName("floor");

                entity.Property(e => e.RoomNumber).HasColumnName("room_number");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__type__2D27B809");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("service_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RoomType).HasColumnName("room_type");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("service_name");

                entity.HasOne(d => d.RoomTypeNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.RoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service__room_ty__2A4B4B5E");
            });

            modelBuilder.Entity<TypeOfRoom>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("type_pk");

                entity.ToTable("TypeOfRoom");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("type_id");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("type_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
