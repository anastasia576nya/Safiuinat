using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace ddd.Models;

public partial class Ispr2522SafiulinaAdObContext : DbContext
{
    public Ispr2522SafiulinaAdObContext()
    {
    }

    public Ispr2522SafiulinaAdObContext(DbContextOptions<Ispr2522SafiulinaAdObContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<CategoriaProduct> CategoriaProducts { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<NameProduct> NameProducts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<StatusOrder> StatusOrders { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;port=3306;uid=ISPr25-22_SafiulinaAD;password=ISPr25-22_SafiulinaAD;database=ISPr25-22_SafiulinaAD_ob", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Idaddress).HasName("PRIMARY");

            entity.ToTable("address");

            entity.Property(e => e.Idaddress).HasColumnName("idaddress");
            entity.Property(e => e.AddressName)
                .HasMaxLength(45)
                .HasColumnName("address_name");
        });

        modelBuilder.Entity<CategoriaProduct>(entity =>
        {
            entity.HasKey(e => e.IdcategoriaProduct).HasName("PRIMARY");

            entity.ToTable("categoria_product");

            entity.Property(e => e.IdcategoriaProduct).HasColumnName("idcategoria_product");
            entity.Property(e => e.CategoriaProductName)
                .HasMaxLength(45)
                .HasColumnName("categoria_product_name");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Idmanufacturer).HasName("PRIMARY");

            entity.ToTable("manufacturer");

            entity.Property(e => e.Idmanufacturer).HasColumnName("idmanufacturer");
            entity.Property(e => e.ManufacturerName)
                .HasMaxLength(45)
                .HasColumnName("manufacturer_name");
        });

        modelBuilder.Entity<NameProduct>(entity =>
        {
            entity.HasKey(e => e.IdnameProduct).HasName("PRIMARY");

            entity.ToTable("name_product");

            entity.Property(e => e.IdnameProduct).HasColumnName("idname_product");
            entity.Property(e => e.NameProduct1)
                .HasMaxLength(45)
                .HasColumnName("name_product");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Idorders).HasName("PRIMARY");

            entity.ToTable("orders");

            entity.HasIndex(e => e.AddresId, "fk addres_id_idx");

            entity.HasIndex(e => e.SnpUserId, "fk snp_user_id_idx");

            entity.HasIndex(e => e.StatusId, "fk status_id_idx");

            entity.Property(e => e.Idorders).HasColumnName("idorders");
            entity.Property(e => e.AddresId).HasColumnName("addres_id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DataDelivery).HasColumnName("data_delivery");
            entity.Property(e => e.DataOrders).HasColumnName("data_orders");
            entity.Property(e => e.SnpUserId).HasColumnName("snp_user_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");

            entity.HasOne(d => d.Addres).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AddresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk addres_id");

            entity.HasOne(d => d.SnpUser).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SnpUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk snp_user_id");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk status_id");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.IdorderDetails).HasName("PRIMARY");

            entity.ToTable("order_details");

            entity.HasIndex(e => e.OrderId, "FK_order_details_orders");

            entity.HasIndex(e => e.ArticleProduct, "FK_order_details_products");

            entity.Property(e => e.IdorderDetails).HasColumnName("idorder_details");
            entity.Property(e => e.ArticleProduct)
                .HasMaxLength(45)
                .HasColumnName("article_product");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.OrderId).HasColumnName("order_id");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_order_details_orders");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Idproduct).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.Article, "article");

            entity.HasIndex(e => e.CategoriaProductId, "categoria_product_id_idx");

            entity.HasIndex(e => e.ManufactuterId, "fk supplier_id_idx");

            entity.HasIndex(e => e.ProductNameId, "product_name_id_idx");

            entity.HasIndex(e => e.SupplierId, "supplier_id_idx");

            entity.Property(e => e.Idproduct).HasColumnName("idproduct");
            entity.Property(e => e.Article)
                .HasMaxLength(45)
                .HasColumnName("article");
            entity.Property(e => e.CategoriaProductId).HasColumnName("categoria_product_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.ManufactuterId).HasColumnName("manufactuter_id");
            entity.Property(e => e.Photo)
                .HasMaxLength(45)
                .HasColumnName("photo");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductNameId).HasColumnName("product_name_id");
            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.Unit)
                .HasMaxLength(45)
                .HasColumnName("unit");

            entity.HasOne(d => d.CategoriaProduct).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoriaProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("categoria_product_id");

            entity.HasOne(d => d.Manufactuter).WithMany(p => p.Products)
                .HasForeignKey(d => d.ManufactuterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("manufactuter_id");

            entity.HasOne(d => d.ProductName).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductNameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("product_name_id");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supplier_id");
        });

        modelBuilder.Entity<StatusOrder>(entity =>
        {
            entity.HasKey(e => e.IdstatusOrder).HasName("PRIMARY");

            entity.ToTable("status_order");

            entity.Property(e => e.IdstatusOrder).HasColumnName("idstatus_order");
            entity.Property(e => e.StatusOrderName)
                .HasMaxLength(45)
                .HasColumnName("status_order_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Idsupplier).HasName("PRIMARY");

            entity.ToTable("supplier");

            entity.Property(e => e.Idsupplier).HasColumnName("idsupplier");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(45)
                .HasColumnName("supplier_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.UserRoleId, "fk user_role_id_idx");

            entity.Property(e => e.Iduser)
                .ValueGeneratedNever()
                .HasColumnName("iduser");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(45)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPatronoimic)
                .HasMaxLength(45)
                .HasColumnName("user_patronoimic");
            entity.Property(e => e.UserRoleId).HasColumnName("user_role_id");
            entity.Property(e => e.UserSurname)
                .HasMaxLength(45)
                .HasColumnName("user_surname");

            entity.HasOne(d => d.UserRole).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk user_role_id");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.IduserRole).HasName("PRIMARY");

            entity.ToTable("user_role");

            entity.Property(e => e.IduserRole).HasColumnName("iduser_role");
            entity.Property(e => e.UserRoleName)
                .HasMaxLength(45)
                .HasColumnName("user_role_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
