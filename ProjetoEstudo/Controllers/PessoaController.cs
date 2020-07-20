using Microsoft.AspNetCore.Mvc;
using ProjetoEstudo.Context;
using ProjetoEstudo.Dao;
using ProjetoEstudo.Models;
using System.Collections.Generic;

namespace ProjetoEstudo.Controllers
{
	public class PessoaController : Controller
	{
		private readonly EstudoContext _context;

		public PessoaController(EstudoContext context) 
		{
			_context = context;
		}
				
		public IActionResult CadPessoa()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Inserir(Pessoa pessoa)
		{ 
		
		PessoaDao pessoaDao = new PessoaDao(_context);
		pessoaDao.Incluir(pessoa);
			
			return RedirectToAction(nameof(CadPessoa));
		}

		[HttpGet]
		public IActionResult ConsPessoa()
		{
			IEnumerable<Pessoa> getPessoas = new PessoaDao(_context).Consultar();

			return View(getPessoas);
		}

	}
}
