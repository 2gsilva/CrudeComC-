using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEstudo.Context;
using ProjetoEstudo.Dao;
using ProjetoEstudo.Models;

namespace ProjetoEstudo.Controllers
{
	public class PessoaController : Controller
	{
		private EstudoContext _context;

		public PessoaController(EstudoContext context) 
		{
			_context = context;
		}
		
		//[HttpPost]
		public IActionResult PessoaView(Pessoa pessoa)
		{
						
			PessoaDao pessoaDao = new PessoaDao(_context);

			pessoaDao.incluir(pessoa);

			return View();
		}
	}
}
