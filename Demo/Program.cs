using System.Text.RegularExpressions;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Demo");
            //Console.WriteLine(ProductList[0]);

            List<Product> TestProduct = new List<Product>();
            #region Part 02 Elements Operator
            #region First
            // Get first element at Sequence
            //var Result = ProductList.First(); 
            //Result  = TestProduct.First(); //System.InvalidOperationException: 'Sequence contains no elements'
            //----------------------------------------
            //var Result = ProductList.First(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result);

            #endregion

            #region Last
            // Get last element at Sequence
            //var Result2 = ProductList.Last();
            //Result2 = TestProduct.Last(); //System.InvalidOperationException: 'Sequence contains no elements'
            //-------------------------------------------------
            //var Result2 = ProductList.Last(P => P.UnitsInStock == 999999);

            //Console.WriteLine(Result2);
            #endregion

            #region FirstOrDefaulr - LastOrDefault
            //var Result = TestProduct.FirstOrDefault();
            //var Result2 = TestProduct.LastOrDefault();

            //Console.WriteLine(Result?.ProductName??"No Result");
            //Console.WriteLine(Result2?.ProductName ?? "No Result");
            #endregion

            #region ElementAt - ElementAtOrDefault
            //var Result3 = ProductList.ElementAt(27);
            //Console.WriteLine(Result3?.ProductName ?? "Not Found");

            //var Result4 = ProductList.ElementAtOrDefault(77);
            //Console.WriteLine(Result4?.ProductName??"Not Found");
            #endregion

            #region Single - SingleOrDefault
            //var Result = ProductList.Single(P => P.UnitsInStock == 0);
            //System.InvalidOperationException: 'Sequence contains more than one matching 
            //Console.WriteLine(Result);

            //-----------------------------------

            //var Result2 = ProductList.SingleOrDefault(P => P.UnitsInStock == 0);
            ////if sequence is empty, return default value
            ////if sequence has more than one element, throw exception
            ////if sequence has one element, return that element
            //Console.WriteLine(Result2);


            #endregion

            #region Hybrid Syntax
            //Hybrid Syntax : Fluent Syntax + Query Syntax
            // (Query Syntax).Fluent Syntax

            //var Result = (from P in ProductList
            //              where P.UnitsInStock == 0
            //              select new 
            //              {
            //                  P.ProductID,
            //                  P.ProductName,
            //                  P.Category,
            //                  P.UnitPrice,
            //                  P.UnitsInStock
            //              }).FirstOrDefault();
            //Console.WriteLine(Result);
            #endregion
            #endregion
            #region Part 05 Generation Operators 
            //var Result = Enumerable.Range(0, 100);
            //var Result = Enumerable.Repeat(0, 100);
            //var Result = Enumerable.Repeat("dd", 100);
            //var Result = Enumerable.Repeat(new Product(), 100);
            ////------------------------------------
            //var ArryProduct = Enumerable.Empty<Product>().ToArray();
            //// Will Generate an empty array of Product
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($" {item}\t ");
            //}

            #endregion
            #region Part 07 Quantifier Operators = Return Boolean Value
            #region Any
            //Console.WriteLine(ProductList.Any());
            //// Return true if any element in the sequence

            //Console.WriteLine(ProductList.Any(P => P.UnitsInStock == 0));
            //// Return true if any element in the sequence that match the condition

            #endregion
            #region All
            //Console.WriteLine(ProductList.All(p => p.UnitsInStock == 0));
            //// Return true if all elements in the sequence that match the condition
            #endregion
            #region Contains
            //Console.WriteLine(ProductList.Contains(ProductList[0]));
            //// Return true if the sequence contains the specified element

            #endregion
            #region SequanceEqual
            //var sq01 = Enumerable.Range(0, 100);
            //var sq02 = Enumerable.Range(0, 100);
            //Console.WriteLine(sq01.SequenceEqual(sq02));
            //// Return true if the two sequences are equal
            #endregion
            #endregion
            #region Part 08 Transformation Opertors - Zip Opertor
            //List<string> Words = new List<string>() { "Ten", "Twenty", "Thirty", "Fourty" };
            //int[] Numbers = [10, 20, 30, 40, 50];
            //var Result01 = Numbers.Zip(Words);
            //// Zip operator is used to merge two sequences into one sequence
            //// The result is a sequence of tuples, where each tuple contains one element from each sequence
            //// The first element of the tuple is from the first sequence, and the second element is from the second sequence
            //// The Length of the result sequence is the same as the length of the shorter sequence

            //var Result02 = Numbers.Zip(Words, (number,word)=> $"{number}={word}");

            //var Result03 = Numbers.Zip(Words, [1, 2, 3]);
            //// The result is a sequence of tuples, where each tuple contains one element from each sequence

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //};
            #endregion
            #region Part 09 Grouping Operators[Part 01]
            #region Example 01
            //var Result = from p in ProductList
            //             group p by p.Category;
            //// The grouping operator is used to group elements in a sequence by a specified key

            //var Result02= ProductList.GroupBy(P => P.Category);

            //foreach (var Group in Result02)
            //{
            //    Console.WriteLine($"  {Group.Key}"); // Key is represent Category
            //    foreach (var Product in Group)
            //    {
            //        Console.WriteLine($"       {Product}");
            //    }
            //}

            #endregion
            #region Example 02      
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category into Group
            //             where Group.Count() > 10
            //             select new
            //             {
            //                 Category = Group.Key,
            //                 Count = Group.Count(),
            //             };
            //// Her return a sequence of anonymous type where each element contains the category and the count of elements in that category

            //Result = ProductList.Where(P => P.UnitsInStock > 0)
            //    .GroupBy(P => P.Category)
            //    .Where(p => p.Count() > 10)
            //    .Select(p => new
            //    {
            //        Category = p.Key,
            //        Count = p.Count(),
            //    });

            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #endregion
            #region Part 10 Partition Operators
            // Partition Operators is used to split a sequence into two or more sequences
            /*
             * Skip - SkipWhile - Take - TakeWhile - takeUntil - takeLast
             * skip: skips the first n elements of a sequence
             * skipWhile: skips elements of a sequence as long as a condition is true
             * take: takes the first n elements of a sequence
             * takeWhile: takes elements of a sequence as long as a condition is true
             * takeUntil: takes elements of a sequence until a condition is true
             * takeLast: takes the last n elements of a sequence
             */

            //----------------------------------------

            //var Result = ProductList.Where(p => p.UnitsInStock > 0).Take(3);
            //Result = ProductList.Where(p => p.UnitsInStock > 0).TakeLast(3);
            //Result = ProductList.Where(p => p.UnitsInStock > 0).Skip(3);
            //Result = ProductList.Where(p => p.UnitsInStock > 0).SkipLast(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------------------------

            //int[] Numbers = { 5, 0, 1, 3, 6, 9, 4 };
            ////var Result = Numbers.TakeWhile((n, i) => n > i);
            //var Result = Numbers.SkipWhile(n => n%3 != 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Part 11 Let & Into
            var Name = new List<string>() { "Islammmm", "Ahmed", "Abdo", "Rana"};

            var Result = from N in Name
                         select Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
                         //Restart Query with inroducing new range Variable : NoVowlName
                         into NoVowlName
                         where NoVowlName.Length > 3
                         select NoVowlName;
            // The into keyword is used to introduce a new range variable in the query
            
            //---------------------------------------
            
            Result = from N in Name
                     let NoVowlName = Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
                     // let here continue Query with Range Variable : NoVowlName
                     where NoVowlName.Length > 3
                     select NoVowlName;

            //--------------------------------------------------------------------------------
            Result = Name.Select(n => Regex.Replace(n, "[aeiouAEIOU]", string.Empty))
                .Where(NoVowlName => NoVowlName.Length > 3);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }

            // The let keyword is used to create a new variable in the query

            #endregion

        }
    }
}
