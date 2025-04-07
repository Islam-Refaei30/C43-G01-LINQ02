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
            var sq01 = Enumerable.Range(0, 100);
            var sq02 = Enumerable.Range(0, 100);
            Console.WriteLine(sq01.SequenceEqual(sq02));
            // Return true if the two sequences are equal
            #endregion
            #endregion

        }
    }
}
