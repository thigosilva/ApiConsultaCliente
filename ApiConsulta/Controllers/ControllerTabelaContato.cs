using ApiConsulta.pocos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiConsulta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerTabelaContato
    {
        [HttpGet]
        public string ListarEquipamento()
        {
            ConsultaDeCliente Consulta = new ConsultaDeCliente();
            return Consulta.Listar();
        }
        [HttpPost]
        public void InsertCliente(
             string Telefone,
             string Email
             
             )
        {
            string Retorno = string.Empty;
            try
            {
                ConsultaDeCliente consulta = new ConsultaDeCliente();
                Retorno = consulta.Insert_Equipamento(
                                                            Telefone,
                                                            Email
                                                            );

            }
            catch (Exception)
            {

                throw;
            }
            //return Retorno;
        }
    }
}
