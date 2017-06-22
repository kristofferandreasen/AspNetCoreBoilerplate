using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AspNetCoreBoilerplate.Models;

namespace AspNetCoreBoilerplate.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170622182016_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreBoilerplate.Models.Item", b =>
                {
                    b.Property<int>("ItemId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });
        }
    }
}
