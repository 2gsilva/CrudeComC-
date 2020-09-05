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
			var _pessoa = pessoaDao.Consultar(pessoa.Nome, pessoa.Sobrenome);

			if (_pessoa != null)
			{
				ViewData["Mensagem"] = "Falha";
				return View("Views/Pessoa/CadPessoa.cshtml");
			}
			else
			{
				ViewData["Mensagem"] = "Sucesso";
				pessoaDao.Incluir(pessoa);
				return View("Views/Pessoa/CadPessoa.cshtml");
			}
		}

		public IActionResult Excluir(int id)
		{
			PessoaDao pessoaDao = new PessoaDao(_context);
			pessoaDao.Excluir(id);

			return RedirectToAction(nameof(ObterPessoas));
		}

		[HttpGet]
		public IActionResult ObterPessoas()
		{
			IEnumerable<Pessoa> getPessoas = new PessoaDao(_context).Obter();
			if (getPessoas == null)
			{
				ViewBag["Mensagem"] = "Não foram encontrados registros";
				return ViewBag["Mensagem"];
			}
			else
			{ 
			return View(getPessoas);
			}
		}

	}
}
