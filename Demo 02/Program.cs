using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day02
{
    class Program
    {
        //Entery Point
        static void Main(string[] args)
        {
            #region Revision
            //Console.WriteLine("Hello, World!");
            #endregion

            #region Variable Declaration

            // Variable Declaration
            // Datatype VariableName;

            //int Number; // Declare Variable
            // Allocate UnInitialized 4 bytes at memory

            //Console.WriteLine(Number); // Invalid

            //Number = 10;

            // Variable      
            // 1. Name     : Number
            // 2. Datatype : int
            // 3. Size     : 4 bytes
            // 4. Value    : 5
            // 5. Address  : 0xF3A

            //Console.WriteLine(Number); //  10

            // int Number = 5; // Declaration and Initialization for the number

            //int Number01;
            //int Number02;
            //int Number03;

            //int Number01 = 2, Number02 = 3, Number03;

            //Console.WriteLine(Number01); // 2
            //Number01 = 7;
            //Console.WriteLine(Number01);
            //Console.WriteLine(Number03); // Invalid Unassigned

            // FirstName  // Pascal Case
            // firstName // camel Case 
            // first_name // Kebab Case  
            #endregion

            #region Value Type (Stack)
            // Datatype (Value Type) : Stack

            // Declare Variable

            //int Number; // Value Type
            //// Alocate 4 unitialized bytes at stack
            //// int : C# Keyword
            // BCL : Int32

            //Int32 Number02;

            //Number = 12;

            //Console.WriteLine(Number02);

            //X = Y; // 10
            //Console.WriteLine(X);
            //Y++;
            //Console.WriteLine(X);
            #endregion

            #region Reference Type (Heap)
            //Point P01;
            //// Declare reference from Type Point
            //// P01 : Can refer to Object From Type 'Point'
            //// 8 Bytes Allocated at Stack
            //// 0 Bytes Allocated at Heap

            //Console.WriteLine(P01);

            //Console.WriteLine(P01.x); // Invalid


            //P01 = new Point(); // Has 2 Reference 
            /// 1. Allocate Required Number of Bytes in Heap (Object Size + CLR Overhead Variables)
            /// 2. Initialize (cross out) Allocated Bytes With Default Value Of Its Datatype
            /// 3. Call User-Defined Constructor if exists
            /// 4. Assign The  Object Address to The Refernce 'P01'
            /// 

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P01.y);
            //Console.WriteLine(P01); // Day02.Point

            //Point P02 = new Point(); // Unreachable Object

            //P02.x = 10;

            //Console.WriteLine(P01.x);
            //Console.WriteLine(P02.x);

            //P01 = P02;

            //Console.WriteLine("P01.x : " + P01.x);
            //Console.WriteLine("P02.x : " + P02.x);
            #endregion

            #region Object

            object O1;
            // Declare For Reference From Type 'Object'
            // O1 : Can refer To Instance From Type 'Object' Or Any Type Inherited From Object

            //O1 = new object();
            //O1 = 1;
            //O1 = 'A';
            //O1 = 1.2;
            //O1 = true;
            //O1 = new Point();

            //Console.WriteLine(O1.GetHashCode()); // Id : Indicate For the Address Of The Object

            ////Console.WriteLine(O1); // Day02.Point

            //Point P01 = new Point();
            //Console.WriteLine(P01.GetHashCode());
            //Console.WriteLine(P01.ToString()); // Day02.Point
            //P01.GetType();
            //P01.GetHashCode();
            //P01.Equals();

            #endregion

            #region Value Type Casting
            // Casting : Convert From Any DataType to Any DataType
            #region Implicit Casting

            //int x = 88;
            //double y = /*(double)*/ x; // Implicit Casting (safe casting)
            //Console.WriteLine(y);


            //int X = 12; // 4 Bytes
            //long Y; // 8 Bytes
            //Y = /*(long)*/ X; // Implicit Casting (safe casting)
            //Console.WriteLine(Y);

            #endregion

            #region Explicit Casting

            //double x = 88.22;
            //int y = (int) x; // Explicit Casting (unsafe casting)
            //Console.WriteLine(y);

            //long X = 122222222222222; // too long for an int // overflow // runtime error
            //int Y = (int) X; // Explicit Casting (unsafe casting)

            ////Console.WriteLine(Y); // Random Value


            #endregion

            #region Parse
            // Parse : function

            //Console.WriteLine("Enter your age:  ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter your GPA:  ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Your age is " + Age);
            //Console.WriteLine("Your GPA is " + GPA);
            #endregion

            #region Convert

            // Convert : Class

            //Console.WriteLine("Enter your age:  ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter your GPA:  ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Your age is " + Age);
            //Console.WriteLine("Your GPA is " + GPA);

            #endregion

            #region TryParse

            //Console.WriteLine("Enter your age:  ");
            //int Age;
            //bool Flag = int.TryParse(Console.ReadLine(), out Age);

            ////Console.WriteLine("enter your GPA:  ");
            ////double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("Flag : " + Flag);

            #endregion


            #endregion

            #region Fractions and Discard

            // 2.2 -> Double
            // int x = 17;

            //double X = 1.5;
            //decimal Y = 1.5m;
            //float Z = 1.5f;

            //long num = 10_000_000; // Discard _ just readability
            //Console.WriteLine(num);
            #endregion

            #region Operators

            #region Unary Operators
            // Works on one Operand (Variable) ++ --

            // int X = 10;

            // ++
            // Print then increment [Postfix]
            //Console.WriteLine(X++); // 10
            //Console.WriteLine(X); // 11
            // Increment then print [Prefix]
            //Console.WriteLine(++X); // 11

            // --
            // Decrement then print [Prefix]
            //Console.WriteLine(--X); //9
            // Print then Decrement [Postfix]
            //Console.WriteLine(X--); // 10
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary Operators
            // Works on Two Operands (Variables)
            // + = / * %


            //int num1 = 4, num2 = 2;
            //int Sum, Mul, Sub, Div, Mod;
            //Sum = num1 + num2; // 4 + 2 = 6
            //Mul = num1 * num2; // 4 * 2 = 8
            //Sub = num1 - num2; // 4 - 2 = 2
            //Div = num1 / num2; // 4 / 2 = 2
            //Mod = num1 % num2; // 4 % 2 = 0
            //Console.WriteLine("Sum = " + Sum);
            //Console.WriteLine("Mul = " + Mul);
            //Console.WriteLine("Sub = " + Sub);
            //Console.WriteLine("Div = " + Div);
            //Console.WriteLine("Mod = " + Mod);
            #endregion

            #region Assignment Operators
            //int x;
            //x = 4;
            //x += 2; // x = x + 2 = 6
            //x -= 2; // x = x - 2 = 2
            //x *= 2; // x = x * 2 = 8
            //x /= 2; // x = x / 2 = 2
            //x %= 2; // x = x % 2 = 0
            #endregion

            #region Relational Operators [Comparison]

            //int x = 6, y = 5;

            //Console.WriteLine(x == y); // false
            //Console.WriteLine(x != y); // true
            //Console.WriteLine(x > y); // true
            //Console.WriteLine(x < y); // false
            //Console.WriteLine(x >= y); // true
            //Console.WriteLine(x <= y); // false

            #endregion

            #region Logical Operators [And, or, not]

            //Console.WriteLine(!false); // true -> Not
            //Console.WriteLine(false && true); // false -> AND short circut
            //Console.WriteLine(true || false); // true -> OR short circut


            #endregion

            #region Bitwise Operators

            //Console.WriteLine(!false); // true -> Not
            //Console.WriteLine(false & true); // false -> AND long circut
            //Console.WriteLine(true | false ); // true -> OR long circut

            #endregion

            #region Ternary Operator

            //bool Flag = 4 > 2 ? true : false;
            //Console.WriteLine(Flag);

            //string Result = 5 < 2 ? "Correct" : "Not Correct";
            //Console.WriteLine(Result);

            #endregion

            #endregion

            #region Operator Priority

            /*
            1. Unary Operator (Prefix)
            2. Round Braces ()
            3. * / %
            4. + -
            */

            // int a = 20, b = 10, c = 15, d = 5, result;
            // result = (a + b) * c / d;    // (30) * 15 / 5 = 90
            // result = (a + b) * (c / d);  // (30) * (3) = 90
            // result = a + (b * c) / d;    // 20 + (150) / 5 = 20 + 30 = 50
            // result = ++d * b + (a - c);  // 6 * 10 + (5) = 60 + (5) = 65
            // result = a + --d;            // 20 + 4 = 24
            // result = a + d--;            // 20 + 5 = 25
            #endregion

        }
    }
}
