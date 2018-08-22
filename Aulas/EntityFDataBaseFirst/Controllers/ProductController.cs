using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFDataBaseFirst.Controllers {
    class ProductController {

        void Inserir(Product c) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(c);
            contexto.SaveChanges();
        }

        List<Product> listOfProduct() {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }

        Product BuscarPorId(int id) {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find(id);//O metodo Find só faz busca pela chave Primaria, ou seja, não busca se a chave for String
        }

        void DeleteProduct(int id) {
            Product productIsDeleting = BuscarPorId(id);
            if (productIsDeleting != null) {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(productIsDeleting);
            }
        }

        void EditarProduct(int id, Product novoDadosProduct)
        {
            Product productAntigo = BuscarPorId(id);

            if (true)
            {
                productAntigo.Name = novoDadosProduct.Name;
                productAntigo.ProductNumber = novoDadosProduct.ProductNumber;
                productAntigo.Color = novoDadosProduct.Color;
                productAntigo.ListPrice = novoDadosProduct.ListPrice;


                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                                  
                 contexto.Entry(productAntigo).State =
                 System.Data.Entity.EntityState.Modified;
                 contexto.SaveChanges();
                
            }
        }

        List<Product> PesquisarPorNome(string nome)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            //LINQ https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
            

            var lista = from c in contexto.Product
                        where c.Name == nome
                        select c;
            return lista.ToList();
            
        }
    }
}
