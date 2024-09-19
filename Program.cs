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
            var result = ProductList.Where(p => p.UnitsInStock == 0);
            result = from p in ProductList
                     where p.UnitsInStock == 0
                     select p;
            result = ProductList.Where((p, i) => (p.UnitsInStock == 0) && (i <= 5));
            foreach (var item in result)
            {
                Console.WriteLine("unit=" + item + " ,");
            }
            #endregion

        }
    }
}
