using LINQ1.DataSources;
using LINQ1.Models;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Get all products from the "Seafood" category. Print eachproduct's name and price.
            //var result = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .Select(p => new
            //    {
            //        p.ProductName,
            //        p.UnitPrice
            //    });
            #endregion

            #region Q2. Get a list of only the product names from ProductList. Print each name.[cite: 1]

            //var result = Source.ProductList
            //    .Select(p => p.ProductName);

            #endregion

            #region Q3. Sort all products by UnitPrice (ascending). Print each product's name and price.[cite: 1]

            //var result = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .Select(p => new
            //    {
            //        p.ProductName,
            //        p.UnitPrice
            //    });

            #endregion

            #region Q4. Get all products where UnitPrice is between 10 and 30[cite: 1]

            //var result = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            #endregion

            #region Q5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.[cite: 1]

            //var result = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 && (p.Category == "Condiments" || p.Category == "Spices & Condiments"));

            #endregion

            #region Q6. Create a new anonymous type with three properties: Name, Price, StockStatus. Print the result.[cite: 1]

            //var result = Source.ProductList
            //    .Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });

            #endregion


            #region Q7. Print each product's name along with its position (1-based) in the list. Expected format: 1. Chai, 2. Chang, etc.[cite: 2]

            //var result = Source.ProductList
            //    .Select((p, index) => $"{index + 1}. {p.ProductName}");

            #endregion


            #region Q8. Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.[cite: 2]

            //var result = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            #endregion

            #region Q9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.[cite: 2]

            //var result = Source.ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .Select(p => new
            //    {
            //        p.ProductName,
            //        p.UnitsInStock
            //    });

            #endregion

            #region Q10. Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.[cite: 2]

            // var result = from c in Source.CustomerList
            //              from o in c.Orders
            //              where o.OrderDate.Year >= 1997
            //              select new
            //              {
            //                  c.CustomerID,
            //                  o.OrderDate
            //              };

            #endregion

            #region Q11. Show position number alongside ProductName[cite: 2]

            // var result = Source.ProductList
            //     .Select((p, index) => new
            //     {
            //         Position = index + 1,
            //         p.ProductName
            //     });

            #endregion

            #region Q12. Sort first by-word length and then by a case-insensitive sort of the words in an array.[cite: 2]

            //string[] Arr = { "aPPLE", "AdiDaS", "bRaNcH", "BIUeBeRrY", "CiViL", "cHeRry" };
            //var result = Arr
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w.ToLower());
            
            #endregion

            #region Q13. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.[cite: 2]

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten" };
            //var result = digits
            //    .Where(d => d.Length > 1 && d[1] == 'i')
            //    .Reverse();

            #endregion



            //foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
        }
    }
}
