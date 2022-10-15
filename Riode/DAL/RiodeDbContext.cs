using System;
using Microsoft.EntityFrameworkCore;
using Riode.Models;

namespace Riode.DAL
{
	public class RiodeDbContext : DbContext
	{
		public RiodeDbContext(DbContextOptions<RiodeDbContext> options) :base(options)
		{
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<Badge> Badges { get; set; }
		public DbSet<ProductBadge> ProductBadges { get; set; }
		

	}
}

