using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstudo
{
    public class Util
    {
        public string Messagem { get;}
        public bool Sucesso { get; }

        public Util( string mensagem, bool sucesso) 
        {
            this.Messagem = mensagem;
            this.Sucesso = sucesso;
            
        }
 
    }
}
