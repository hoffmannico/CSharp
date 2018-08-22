using System.Data.Entity;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    //tem q erdar da dbcontext (vem do entity)
    public class Contexto : DbContext
    {
        //construtor para passar para o construtor do dbcontext indicar string de conexao

        public Contexto() : base("nomeStringConexao")
        {

        }

        DbSet<Categoria> Categorias { get; set; }
        DbSet<Produto> Produtos { get; set; }

    }
}
