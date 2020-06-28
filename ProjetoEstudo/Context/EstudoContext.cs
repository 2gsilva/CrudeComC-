using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjetoEstudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstudo.Context
{
	public class EstudoContext : DbContext
	{
		public EstudoContext(DbContextOptions<EstudoContext> options) : base(options)
		{ }

		public DbSet<Pessoa> Pessoas { get; set; }
		
	}
}
