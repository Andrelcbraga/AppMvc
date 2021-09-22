using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto :Entity
    {
        public Guid FornecedorId { get; set; }
        
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(200,ErrorMessage ="O campo {0} não pode exceder {1} caracteres",MinimumLength = 2)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} não pode exceder {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }



        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Imagem { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        
        
        public DateTime DataCadastro { get; set; }
        
        
        
        public bool Ativo { get; set; }

        // para o entity framework
    
        public Fornecedor Fornecedor { get; set; }
    }
}
