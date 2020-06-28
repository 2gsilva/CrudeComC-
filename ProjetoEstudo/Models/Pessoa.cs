using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEstudo.Models
{
	public class Pessoa
	{
		public int Id { get; set; }
		[Required]
		[StringLength(20)]
		public String Nome { get; set; }
		[Required]
		[StringLength(50)]
		public String Sobrenome { get; set; }
		[Required]
		public DateTime DataNasc { get; set; }
	}
}
