using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Aplicacao_web_ds_eve.Models
{
    public class Cliente
    {
       
        
            [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
            [Display(Name = "Nome do usuário")]
            public string NomeCli { get; set; }

            [Required(ErrorMessage = "Código inválido", AllowEmptyStrings = false)]
            public int CodCli { get; set; }

            [Required(ErrorMessage = "Informe um endereço válido", AllowEmptyStrings = false)]
            [Display(Name = "Informe seu endereço")]
            [StringLength(50, MinimumLength = 20)]
            public string Endereco { get; set; }

            [Required(ErrorMessage = "Informe um telefone válido", AllowEmptyStrings = false)]
            [Display(Name = "Informe seu telefone")]
            [DisplayFormat(DataFormatString = "{9,c}")]
            public string Telefone { get; set; }

            [Required(ErrorMessage = "Informe um email válido", AllowEmptyStrings = false)]
            [RegularExpression("@\"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\" ")]
            public string Email { get; set; }

            [Required(ErrorMessage = "O CPF é obrigatório", AllowEmptyStrings = false)]
            [Display(Name = "Informe seu CPF")]
            [StringLength(12, MinimumLength = 12)]
            public int Cpf { get; set; }

            [Required(ErrorMessage = "A data de nascimento é obrigatória", AllowEmptyStrings = false)]
            [Display(Name = "Informe sua data de nascimento")]
            [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
            public DateTime Datanasc { get; set; }
        
    
}
}