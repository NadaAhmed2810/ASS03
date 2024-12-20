using System.Globalization;
using System.Text;

namespace ASS03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop statements
            ////freq and heard to maintainability
            //Console.WriteLine("1T");
            //Console.WriteLine("2T");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);


            ////time 3*n+2 less performance and best to cleancode and maintainability
            //for(int i=1;i<=10;i++)
            //    Console.WriteLine($"{i} T");


            #endregion
            #region For _For each
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //continue
            //for (int i = 0; i < Numbers.Length; i++) {
            //    Numbers[i] += 10;
            // if (Numbers[i] == 5) break;
            //    Console.WriteLine(Numbers[i]);
            //}
            ////take copy from array
            //class implement interface iEnumerable
            //Array
            //foreach (int Num in Numbers) {
            //    //Num += 10;
            //    Console.WriteLine(Num + 10);
            //}     
            #endregion
            #region While_Do While
            //int Num;
            //bool flag=false;
            //do {
            //    Console.Write("Enter Even Number:");
            //   // Num = int.Parse(Console.ReadLine());
            //    flag =int.TryParse(Console.ReadLine(), out Num);
            //} while (Num%2==1 || !flag);
            //Console.WriteLine($"{Num} is Even ");
            //int Number = 3;
            //bool flag=false;
            //while (Number%2==1 || !flag)
            //{
            //    Console.Write("Enter Even Number: ");
            //    flag=int.TryParse(Console.ReadLine(),out Number);
            //}
            //Console.WriteLine($"{Number} Is Even");

            #endregion
            #region String
            //class => Reference  type
            //Immutable  data type
            //array of char
            //act as value
            //string Name;
            //Name = new string("Ahmed");
            //Name = "Ahmed";
            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //string Name01 = "Ahmed";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //Name01 = "Nada";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"{Name01} Has HC: {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"{Name02} Has HC: {Name02.GetHashCode()}");
            //string message = "Hello";
            //Console.WriteLine(message.GetHashCode());
            //message += "Route";
            //Console.WriteLine(message.GetHashCode());
            #endregion
            #region StringBuilder
            //linked list of char 
            //amenable 
            //StringBuilder sb = new StringBuilder("Hello");
            //sb = "ahmed";//to convert string
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append(" Route");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            #endregion
            #region stringBuilder method
            //StringBuilder sb = new StringBuilder("Welcome");
            //sb.Append("TO Route");
            //sb.AppendLine(" Mostafa");//append string + new line
            //sb.AppendLine("Hany");
            //sb.Remove(0,7);
            //sb.Insert(0,"Hello");
            //int age = 10;
            //string name = "Ali";
            //sb.AppendFormat("Name : {0}, Age : {1}",name,age);
            //sb.AppendJoin('/', "mostafa", "hany", "mohammed");
            //Console.WriteLine(sb);
            #endregion
            #region
            #endregion
            #region
            #endregion
            #region
            #endregion
            #region
            #endregion
        }
    }
}
