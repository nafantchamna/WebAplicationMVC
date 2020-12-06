using log4net;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplicationMVC.ModelsDTO;

namespace WebApplicationMVC.Repository
{
    public class CadastroRepository
    {

        private static ILog ilog; 
        private Database DB;

            public CadastroRepository()
        {
            DB = new Database(WebConfigurationManager.AppSettings["DB"]);
        }
        public void SalvarUsuario(CadastroDTO cadastro)
        {
            try
            {

                string insert = @" insert into Usuarios (Nome,Email,Senha,DataDeNascimento) values()";
                int v = DB.Execute(insert, new { cadastro.Nome, cadastro.Email, cadastro.Senha, cadastro.DataDeNascimento });

            }
            catch (Exception ex)
            {
                log.ErrorFormat("Erro ao consultar banco de dados!!\n Error: {0}", ex);
                throw;
            }
        }

    }
}