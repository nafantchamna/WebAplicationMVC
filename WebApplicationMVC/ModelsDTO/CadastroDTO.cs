﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.ModelsDTO
{
    public class CadastroDTO
    {
        public  string Nome { get; set; }
        public string Email  { get; set; }
        public string Senha  { get; set; }
        public DateTime DataDeNascimento  { get; set; }
    }
}