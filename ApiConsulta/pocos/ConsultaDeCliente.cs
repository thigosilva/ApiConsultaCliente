using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConsulta.pocos
{
    public class ConsultaDeCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        internal string Listar()
        {
            throw new NotImplementedException();
        }

        internal string Insert_Equipamento(string nome, string sobrenome, string idade)
        {
            throw new NotImplementedException();
        }

        internal string Insert_Equipamento(string telefone, string email)
        {
            throw new NotImplementedException();
        }
    }
    public class TabelaContatos  
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        
    }
}
