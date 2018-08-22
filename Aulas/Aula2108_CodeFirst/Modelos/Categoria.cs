using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Categoria
    {
        // chave primaria de tabela, o entity reconhece se usar (escrever) padrão como ID, ou Id ou id ou nome da classe seguida de id
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
        public string Descricao { get; set; }


        // Relacionamento Categoria <> Produto
        //icollection é uma lista simples
        public virtual ICollection<Produto> _Produtos { get; set; }
        
    }
}
