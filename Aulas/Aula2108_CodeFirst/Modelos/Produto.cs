using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Imposto { get; set; }

        //Relacionamento Produto <> Categoria

            //aqui é chave estrangeira
        public int CategoriaID { get; set; }

        //propriedade de navegação
        public virtual Categoria _Categoria { get; set; }

    }
}
