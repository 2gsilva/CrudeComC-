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

		public void Incluir(Pessoa pessoa)
		{
			try
			{
				_context.Pessoas.Add(pessoa);
				_context.SaveChanges();
			}
			catch (Exception ex) 
			{
				ex.GetType();
				Console.WriteLine( ex.Message);
			}
			finally
			{
				_context.Dispose();
			}
		}

		public void Excluir(int id)
		{
			try
			{
				_context.Remove(_context.Pessoas.Single(p => p.Id == id));
				_context.SaveChanges();
			}
			catch (Exception ex)
			{
				ex.GetType();
				Console.WriteLine(ex.Message);
			}
			finally
			{
				_context.Dispose();
			}
		}

		public Pessoa Consultar(String nome, String sobrenome)
		{
			try
			{
				var _pessoa = _context.Pessoas.Where(p => p.Nome == nome && p.Sobrenome == sobrenome).FirstOrDefault();
				return _pessoa;
			}
			catch (NullReferenceException ex)
			{
				ex.GetType();
				return null;
			}
			catch (Exception ex)
			{
				ex.GetType();
				return null;
			}
		}
		
		public IEnumerable<Pessoa> Obter()
		{			
			IEnumerable<Pessoa> getPessoas = null;
			try
			{
				getPessoas = _context.Pessoas.DefaultIfEmpty();
				return getPessoas;
			}
			catch(Exception ex)
			{
				ex.GetType();
				return null;
			}			
		}
	}
}
