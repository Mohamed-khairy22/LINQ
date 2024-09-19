//using System.Linq;
using System.Xml;
using static L2O___D09.ListGenerators;
namespace test_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WHERE is filrerition
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //result = from p in ProductList
            //         where p.UnitsInStock == 0
            //         select p;
            //result = ProductList.Where((p, i) => (p.UnitsInStock == 0) && (i <= 5));
            //foreach (var item in result)
            //{
            //    Console.WriteLine("unit=" + item + " ,");
            //}
            #endregion
            #region SELECT is transformation opreation
            //var result = ProductList.Select(p => p.ProductName);
            //result = from p in ProductList
            //         select p.ProductName;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);   
            //}
            var result = ProductList.Select(p => new { Id = p.ProductID, p.ProductName });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
