namespace Linq
{
    public class MoreThan20
    {
        public void MoreThan20Meth()
        {
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            // Display a message indicating the purpose of the LINQ operation
            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : \n");

            var query = from int Number in arr1 let SquarNu = Number* Number where SquarNu > 20 orderby SquarNu ascending select new { Number, SquarNu, };
            foreach(var item in query)
            {
                Console.Write(item);
                Console.Write("\n");
            }
        }
    }
}
