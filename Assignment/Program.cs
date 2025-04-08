using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Assignment");
            //Console.WriteLine(ProductList[0]);

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var outOfStockProduct = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

            //if (outOfStockProduct != null)
            //{
            //    Console.WriteLine($"Product out of stock: {outOfStockProduct.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine("No product is out of stock.");
            //}

            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var expensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //if (expensiveProduct != null)
            //{
            //    Console.WriteLine($"Expensive Product: {expensiveProduct.ProductName} - ${expensiveProduct.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No product with price > 1000 found.");
            //}

            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondGreaterThanFive = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine($"Second number > 5 is: {secondGreaterThanFive}");
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int oddCount = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine($"number of odd numbers: {oddCount}");

            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var customerOrderCounts = CustomerList
            //        .Select(c => new
            //        {
            //            CustomerName = c.CustomerName,
            //            OrderCount = c.Orders.Count()
            //        });

            //foreach (var c in customerOrderCounts)
            //{
            //    Console.WriteLine($"{c.CustomerName} has {c.OrderCount} orders.");
            //}

            #endregion
            #region 3. Return a list of categories and how many products each has
            //var categoryProductCounts = ProductList
            //        .GroupBy(p => p.Category)
            //        .Select(g => new
            //        {
            //            Category = g.Key,
            //            ProductCount = g.Count()
            //        });

            //foreach (var item in categoryProductCounts)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Products: {item.ProductCount}");
            //}

            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = Arr.Sum();
            //Console.WriteLine("Total = " + total);

            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine($"Total number of characters: {totalCharacters}");
            //Console.WriteLine($"Shortest word length: {words.Min(w => w.Length)}");
            //Console.WriteLine($"Longest word length: {words.Max(w => w.Length)}");
            //Console.WriteLine($"Average word length: {words.Average(w => w.Length)}");

            #endregion
            #region 9. Get the total units in stock for each product category
            //var totalUnitsInStockByCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });

            //foreach (var item in totalUnitsInStockByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.TotalUnitsInStock}");
            //}
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var cheapestPriceByCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    });

            //foreach (var item in cheapestPriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice}");
            //}
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var cheapestProductsByCategory = from p in ProductList
            //                                 group p by p.Category into g
            //                                 let cheapestPrice = g.Min(p => p.UnitPrice)
            //                                 select new
            //                                 {
            //                                     Category = g.Key,
            //                                     Products = g.Where(p => p.UnitPrice == cheapestPrice)
            //                                 };

            //foreach (var item in cheapestProductsByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}
            #endregion

            #region 12. Get the most expensive price among each category's products
            //var mostExpensivePriceByCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        MostExpensivePrice = g.Max(p => p.UnitPrice)
            //    });

            //foreach (var item in mostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.MostExpensivePrice}");
            //}
            #endregion

            #region 13. Get the products with the most expensive price in each category
            //var mostExpensiveProductsByCategory = from p in ProductList
            //                                      group p by p.Category into g
            //                                      let mostExpensivePrice = g.Max(p => p.UnitPrice)
            //                                      select new
            //                                      {
            //                                          Category = g.Key,
            //                                          Products = g.Where(p => p.UnitPrice == mostExpensivePrice)
            //                                      };

            //foreach (var item in mostExpensiveProductsByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Price: {product.UnitPrice}");
            //    }
            //}
            #endregion

            #region 14. Get the average price of each category's products
            //var averagePriceByCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });

            //foreach (var item in averagePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");
            //}
            #endregion

            #endregion

            #region LINQ - Set Operators
            #region 1. Find the unique Category names from Product List
            //var uniqueCategories = ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //Console.WriteLine("Unique Categories:");
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names
            //var uniqueFirstLetters = ProductList
            //    .Select(p => p.ProductName[0])
            //    .Union(CustomerList.Select(c => c.CustomerName[0]))
            //    .Distinct();

            //Console.WriteLine("Unique First Letters:");
            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names
            //var commonFirstLetters = ProductList
            //    .Select(p => p.ProductName[0])
            //    .Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //Console.WriteLine("Common First Letters:");
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names
            //var productFirstLettersNotInCustomers = ProductList
            //    .Select(p => p.ProductName[0])
            //    .Except(CustomerList.Select(c => c.CustomerName[0]));

            //Console.WriteLine("Product First Letters Not in Customers:");
            //foreach (var letter in productFirstLettersNotInCustomers)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region 5. Create one sequence that contains the last three characters in each name of all customers and products, including any duplicates
            //var lastThreeCharacters = ProductList
            //    .Select(p => p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName)
            //    .Concat(CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName));

            //Console.WriteLine("Last Three Characters:");
            //foreach (var chars in lastThreeCharacters)
            //{
            //    Console.WriteLine(chars);
            //}
            #endregion

            #endregion

            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            //var firstThreeOrdersInWashington = CustomerList
            //    .Where(c => c.Region == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);

            //Console.WriteLine("First 3 Orders from Customers in Washington:");
            //foreach (var order in firstThreeOrdersInWashington)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington
            //var allButFirstTwoOrdersInWashington = CustomerList
            //    .Where(c => c.Region == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);

            //Console.WriteLine("All but the First 2 Orders from Customers in Washington:");
            //foreach (var order in allButFirstTwoOrdersInWashington)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate}");
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elementsUntilCondition = numbers
            //    .TakeWhile((n, index) => n >= index);

            //Console.WriteLine("Elements until a number is less than its position:");
            //foreach (var number in elementsUntilCondition)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 4. Get the elements of the array starting from the first element divisible by 3
            //var elementsFromFirstDivisibleByThree = numbers
            //    .SkipWhile(n => n % 3 != 0);

            //Console.WriteLine("Elements starting from the first element divisible by 3:");
            //foreach (var number in elementsFromFirstDivisibleByThree)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position
            //var elementsFromFirstLessThanPosition = numbers
            //    .SkipWhile((n, index) => n >= index);

            //Console.WriteLine("Elements starting from the first element less than its position:");
            //foreach (var number in elementsFromFirstLessThanPosition)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #endregion

            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //bool containsEi = words.Any(word => word.Contains("ei"));

            //Console.WriteLine($"Any word contains 'ei': {containsEi}");
            #endregion

            #region 2. Return a grouped list of products only for categories that have at least one product that is out of stock
            //var categoriesWithOutOfStockProducts = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0))
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });

            //Console.WriteLine("Categories with at least one product out of stock:");
            //foreach (var category in categoriesWithOutOfStockProducts)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #region 3. Return a grouped list of products only for categories that have all of their products in stock
            //var categoriesWithAllProductsInStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0))
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.ToList()
            //    });

            //Console.WriteLine("Categories with all products in stock:");
            //foreach (var category in categoriesWithAllProductsInStock)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, Units in Stock: {product.UnitsInStock}");
            //    }
            //}
            #endregion

            #endregion

            #region LINQ – Grouping Operators
            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var groupedByRemainder = numbers
                .GroupBy(n => n % 5)
                .Select(g => new
                {
                    Remainder = g.Key,
                    Numbers = g.ToList()
                });

            Console.WriteLine("Numbers grouped by remainder when divided by 5:");
            foreach (var group in groupedByRemainder)
            {
                Console.WriteLine($"Remainder: {group.Remainder}");
                foreach (var number in group.Numbers)
                {
                    Console.WriteLine($"  {number}");
                }
            }
            #endregion

            #region 2. Use group by to partition a list of words by their first letter
            string[] words = File.ReadAllLines("dictionary_english.txt");

            var groupedByFirstLetter = words
                .GroupBy(word => word[0])
                .Select(g => new
                {
                    FirstLetter = g.Key,
                    Words = g.ToList()
                });

            Console.WriteLine("Words grouped by their first letter:");
            foreach (var group in groupedByFirstLetter)
            {
                Console.WriteLine($"First Letter: {group.FirstLetter}");
                foreach (var word in group.Words)
                {
                    Console.WriteLine($"  {word}");
                }
            }
            #endregion

            #region 3. Use Group By with a custom comparer that matches words that consist of the same characters together
            string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            var groupedByAnagram = Arr
                .GroupBy(word => string.Concat(word.OrderBy(c => c)))
                .Select(g => new
                {
                    Key = g.Key,
                    Words = g.ToList()
                });

            Console.WriteLine("Words grouped by anagrams:");
            foreach (var group in groupedByAnagram)
            {
                Console.WriteLine($"Anagram Key: {group.Key}");
                foreach (var word in group.Words)
                {
                    Console.WriteLine($"  {word}");
                }
            }
            #endregion

            #endregion
        }
    }
}
