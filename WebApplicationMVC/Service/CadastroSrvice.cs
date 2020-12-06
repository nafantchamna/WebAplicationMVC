using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationMVC.ModelsDTO;

namespace WebApplicationMVC.Service
{
    public class CadastroSrvice
    {

        public void SalvarUsuario(string nome, string email, string senha, DateTime nascimnto)
        {
            try
            {
                var usuario = new CadastroDTO();
                
                if (!string.IsNullOrEmpty(nome))
                    usuario.Nome = nome;

                if (!string.IsNullOrEmpty(email))
                    usuario.Email = email;

                if (!string.IsNullOrEmpty(senha))
                    usuario.Senha = senha;

                if (nascimnto.Date <= DateTime.Now.Date)
                    usuario.DataDeNascimento = nascimnto;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}