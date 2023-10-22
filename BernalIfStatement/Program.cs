namespace BernalIfStatement
{
    public class program
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            /// Write a program that evaluate

            /// If num1 is equal to num2, print num1==num2, e.g. 1==1
            if (num1 == num2) Console.WriteLine("{0}=={1}", num1, num2);
            /// if num1 greater than num 2, print num1>num2, e.g. 2>1
            if (num1 > num2) Console.WriteLine($"{num1}>{num2}");
            /// if num1 less than num2, print num1<num2, e.g. 1<2
            if (num1 < num2) Console.WriteLine($"{num1}<{num2}");
        }
    }
}




