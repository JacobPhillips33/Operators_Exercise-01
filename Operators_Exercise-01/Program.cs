using System;

namespace Operators_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region/*===================================================   Mathematical Operators   ======================================================*/

            int x = 10;
            int y = 20;

            // DONE: Add 20 to x and 60 to y, print them out to the console, then AddSpace()
            x += 20;
            y += 60;
            // DONE: x = 30
            // DONE: y = 80

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // DONE: Subtract 10 from x and 70 from y, print them out to the console, then AddSpace()
            x -= 10;
            y -= 70;
            // DONE: x = 20
            // DONE: y = 10

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // DONE: Multiply x by 3 and y by 2, print them out to the console, then AddSpace()
            x *= 3;
            y *= 2;
            // DONE: x = 60
            // DONE: y = 20

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // TODO: Divide x by 6 and y by 1, print them out to the console, then AddSpace()
            x /= 6;
            y /= 1;
            // DONE: x = 10
            // DONE: y = 20

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // DONE: Modulus x by 3 and y by 3, print them out to the console, then AddSpace()
            x %= 3;
            y %= 3;
            // DONE: x = 1
            // DONE: y = 2

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // DONE: Pre-increment x and y, print them out to the console, then AddSpace()
            ++x;
            y++;
            // DONE: x = 2
            // DONE: y = 3

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // Thought Experiment: What will the value of x and y be after going through this pre/post increment operation?
            x = ++x;
            y = y++;
            // DONE: x = 3
            // DONE: y = 3

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // Thought Experiment: What will the value of x and y be after going thought the pre/post increment again, only slightly changed up a bit?
            x++;
            ++y;
            // DONE: x = 4
            // DONE: y = 4

            Console.WriteLine(x);
            Console.WriteLine(y);

            AddSpace();

            // Thought Experiment: What will be the value of x, y, and z that is written to the console?
            int z = --y + ++x;
            // DONE: x = 5
            // DONE: y = 3
            // DONE: z = 8

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            AddSpace();

            #endregion

            #region/*===================================================   Relational Operators   ======================================================*/

            bool conditionalValue = false;
            int a = 10;
            int b = 11;

            bool first = true;
            bool second = true;

            // Thought Experiment: What is the value of the variable conditionalValue after the == operator?
            Console.WriteLine(conditionalValue = first == second);
            // DONE: conditionalValue = True

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the != operator?
            Console.WriteLine(conditionalValue = first != second);
            // DONE: conditionalValue = False

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the > operator?
            Console.WriteLine(conditionalValue = a > b);
            // DONE: conditionalValue = False

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the < operator?
            Console.WriteLine(conditionalValue = a < b);
            // DONE: conditionalValue = True

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the >= operator?
            Console.WriteLine(conditionalValue = a >= b);
            // DONE: conditionalValue = False

            AddSpace();

            // Thought Experiment: What is the value of the variable conditionalValue after the <= operator?
            Console.WriteLine(conditionalValue = a <= b);
            // DONE: conditionalValue = True

            AddSpace();

            #endregion

            #region/*===================================================   Logical Operators   ======================================================*/
            //From above:
            // int a = 10;
            // int b = 11;
            // bool first = true;
            // bool second = true;

            // Thought Experiement: What is the value of the variable conditionalValue with the logical operator
            Console.WriteLine(conditionalValue = a < b && ++a == b);
            // DONE: conditionalValue = True

            AddSpace();

            // Thought Experiement: What is the value of the variable conditionalValue with the logical operator
            Console.WriteLine(conditionalValue = a++ == b || first == second);
            // DONE: conditionalValue = True

            AddSpace();

            first = false;
            second = true;
            // Thought Experiement: What is the value of the variable conditionalValue with the logical operator
            Console.WriteLine(conditionalValue = !second == first && a >= --b);
            // DONE: conditionalValue = True

            AddSpace();

            #endregion

            #region/*===================================================   Assignment Operators   ======================================================*/

            double total = 0; // Simple assignment operator =
            double var1 = 10.50; // Simple assignment operator =
            double var2 = 3.25; // Simple assignment operator =

            // DONE: use the Simple Assignment operator to add var1 and var2 and then assign the sum to the total variable
            Console.WriteLine(total = var1 + var2);
            // DONE: total = 13.75

            AddSpace();

            // Thought Experiment: What's the result doing the same operation, but replacing the Simple Assignment operator with the Add Assignment operator?
            Console.WriteLine(total += var1 + var2);
            // DONE: total = 27.5

            AddSpace();

            // DONE: use the Subtract Assignment operator to subtract total from var1 
            Console.WriteLine(total -= var1);
            // DONE: total = 17

            AddSpace();

            // DONE: use the Multiply Assignment operator to multiply total by var2
            Console.WriteLine(total *= var2);
            // DONE: total = 55.25

            AddSpace();

            // DONE: use the Division Assignment operator to divide total by 5
            Console.WriteLine(total /= 5);
            // DONE: total = 11.05

            AddSpace();

            // DONE: use the Modulus Assignment operator to modulo the total by 11.05
            Console.WriteLine(total %= 11.05);
            // DONE: total = 0

            AddSpace();

            #endregion

            #region/*===================================================   Ternary Operators   ======================================================*/
            string finalString = "";
            string str1 = $"String 1";
            string str2 = $"String 2";
            int intTotal = 0;
            int int1 = 1;
            int int2 = 2;

            // DONE: use the Ternary operator to shorten this if/else statement with syntax sugar
            /*
            if (finalString.Length == 0)
            {
                finalString = str1;
            }
            else
            {
                finalString = str2;
            }
            */
            Console.WriteLine(finalString = finalString.Length == 0 ? str1 : str2);
            // DONE: finalString = String 1

            AddSpace();

            // DONE: use the Ternary operator to shorten this if statement with syntax sugar
            /*
            if (int1 + int2 > intTotal)
            {
                intTotal = int1 + int2;
            }
            else
            {
                intTotal = int1 - int2;
            }
            */
            Console.WriteLine(intTotal = int1 + int2 > intTotal ? int1 + int2 : int1 - int2);
            // DONE: intTotal = 3

            AddSpace();

            // Thought Experiment: What will be the value of finalString after the Ternary operation?
            Console.WriteLine(finalString = finalString != null && finalString.Length != 0 ? str1[7].ToString() : str2[7].ToString());
            // DONE: finalString = 1

            #endregion
        }

        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
