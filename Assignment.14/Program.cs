using Assignment._14.DataSources;
using Assignment._14.Models;
using static Assignment._14.DataSources.Source;
namespace Assignment._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //var result=ProductList.Where(p => p.Category== "Seafood").Select(p=> new { p.ProductName,p.UnitPrice});
            //foreach (var p in result)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
            #region Question02
            //PrintList(ProductList.Select(p=>p.ProductName));
            #endregion
        }
        static void PrintList<T>(IEnumerable<T> List)
        {
            foreach (T element in List)
            {
                Console.WriteLine(element);
            }
        }
    }
}
