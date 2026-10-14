using System.Drawing;
using System.Xml.Linq;
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
            #region Question03
            //PrintList(ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice }));
            #endregion
            #region Question04
            //PrintList(ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30));
            #endregion
            #region Question05
            //PrintList(ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments"));
            #endregion
            #region Question06
            //PrintList(ProductList.Select(p => new { p.ProductName, p.UnitPrice, StockStatus=(p.UnitsInStock > 0) ?"Available": "Out of Stock"}));
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
