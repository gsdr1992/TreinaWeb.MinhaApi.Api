﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TreinaWeb.MinhaApi.Api.HATEOAS;

namespace TreinaWeb.MinhaApi.Api.DTOs
{
    public class AlunoDTO : RestResource
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "o nome do aluno é obrigatório")]
        [StringLength(maximumLength:20, MinimumLength =2, ErrorMessage = "O nome do aluno deve conter entre 2 e 20 caracteres")]
        public string Nome { get; set; }

        [MaxLength(100, ErrorMessage = "O endereço deve conter no máximo 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "A mensalidade é obrigatória")]
        [Range(0.01, 9999.00, ErrorMessage = "A mensalidade deve estar entre R$ 0,01 e R$ 9999,99")]
        public decimal Mensalidade { get; set; }
    }
}