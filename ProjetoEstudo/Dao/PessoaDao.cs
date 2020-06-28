using ProjetoEstudo.Context;
using ProjetoEstudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstudo.Dao
{
	public class PessoaDao
	{
		private readonly EstudoContext _context;
		
		public PessoaDao (EstudoContext context) 
		{
			_context = context;
		}

		public void incluir(Pessoa pessoa)
		{
			_context.Pessoas.Add(pessoa);
			_context.SaveChanges();
		}
		
	}
}
