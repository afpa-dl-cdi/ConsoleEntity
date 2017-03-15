using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var db = new CommandeContext())
			{

			}
		}
	}
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new CommandesContext() )
            {

                /* -----------------------------
                 *         Create 
                 *         --------------------*/

                produit raquette = new produit { nom = "raquette", description = "une raquette ", prix = 10.20m };
                db.produits.Add(raquette);
                db.SaveChanges();

                /* -----------------------------
                *         Retrieve 
                *         --------------------*/
                var listeDeProduits = from prod in db.produits
                                      orderby prod.nom
                                      select prod;

                foreach (var item in listeDeProduits)
                {
                    Console.WriteLine(item.nom);
                }


                /* -----------------------------
                 *         Update 
                 *         --------------------*/

                var findRaquette = from r in db.produits
                                  where r.nom.Contains("raquette")
                                  select r;
                if (findRaquette.Count() >  0)
                {
                    var produitAModifier = new produit { id_produit = findRaquette.First().id_produit };
                    var produitOriginal = db.produits.Find(produitAModifier);
                    produitOriginal.prix += 10.0m;
                    db.SaveChanges();
                }



                /* -----------------------------
                *         Delete 
                *  --------------------*/

                // delete
                var produitToDelete = new produit { id_produit = 1 };
                db.produits.Attach(produitToDelete);
                db.produits.Remove(produitToDelete);
                db.SaveChanges();

            }
        }
    }
}
