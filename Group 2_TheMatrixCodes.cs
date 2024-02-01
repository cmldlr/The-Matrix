using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            double a1, a2, a3, b1, b2, b3, c1, c2, c3;
            Console.WriteLine("Matrix Format(3x3):");

            //  Console.WriteLine(); --> I used it to leave a line space on the console
            Console.WriteLine();

            Console.WriteLine("| a1  b1  c1 |");
            Console.WriteLine("| a2  b2  c2 |");
            Console.WriteLine("| a3  b3  c3 |");
            //  Console.WriteLine(); --> I used it to leave a line space on the console
            Console.WriteLine();



            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1)Please enter the matrix elements");

            Console.Write("a1=");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b1=");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c1=");
            c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a2=");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b2=");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c2=");
            c2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a3=");
            a3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b3=");
            b3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c3=");
            c3 = Convert.ToDouble(Console.ReadLine());

            // string format --->  we used it to keep the large values entered in a more smooth way on the console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ");
            Console.WriteLine("Entered Matrix:");
            Console.WriteLine(string.Format("{0,-2} {1,-5}   {2,-5}   {3,-5} {4,1}", "| ", a1, b1, c1, "|"));
            Console.WriteLine(string.Format("{0,-2} {1,-5}   {2,-5}   {3,-5} {4,1}", "| ", a2, b2, c2, "|"));
            Console.WriteLine(string.Format("{0,-2} {1,-5}   {2,-5}   {3,-5} {4,1}", "| ", a3, b3, c3, "|"));

            //  Console.WriteLine(); -->I used it to leave a line space on the console
            Console.WriteLine();

            //sumrow1=sum of elements in the first row
            //other variables means like sumrow1
            double sumrow1 = a1 + b1 + c1;
            double sumrow2 = a2 + b2 + c2;
            double sumrow3 = a3 + b3 + c3;
            double sumcol1 = a1 + a2 + a3;
            double sumcol2 = b1 + b2 + b3;
            double sumcol3 = c1 + c2 + c3;
            double pridiag = a1 + b2 + c3;


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("2)Sum of 1.Row: " + sumrow1);
            Console.WriteLine("  Sum of 2.Row: " + sumrow2);
            Console.WriteLine("  Sum of 3.Row: " + sumrow3);

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("3)Sum of 1.Column: " + sumcol1);
            Console.WriteLine("  Sum of 2.Column: " + sumcol2);
            Console.WriteLine("  Sum of 3.Column: " + sumcol3);

            Console.WriteLine(" ");


            //I showed what numbers were collected on the console
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("4)Sum of primary diagonal: " + "(" + a1 + ")+(" + b2 + ")+(" + c3 + ")=" + pridiag);

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("5)Transpose of the Matrix:");

            Console.WriteLine(" ");

            Console.WriteLine(string.Format("{0,-2} {1,-5}   {2,-5}   {3,-5} {4,1}", "| ", a1, a2, a3, "|"));
            Console.WriteLine(string.Format("{0,-2} {1,-5}   {2,-5}   {3,-5} {4,1}", "| ", b1, b2, b3, "|"));
            Console.WriteLine(string.Format("{0,-2} {1,-5}   {2,-5}   {3,-5} {4,1}", "| ", c1, c2, c3, "|"));

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("6)Determinant of the matrix: ");

            Console.WriteLine(" ");

            //I showed the determinat process on the console
            Console.WriteLine("((" + a1 + " * " + b2 + " * " + c3 + ")" + " + " + "(" + a2 + " * " + b3 + " * " + c1 + ")" + " + " + "(" + a3 + " * " + b1 + " * " + c2 + "))"
                + " - " + "((" + c1 + " * " + b2 + " * " + a3 + ")" + " + " + "(" + c2 + " * " + b3 + " * " + a1 + ")" + " + " + "(" + c3 + " * " + b1 + " * " + a2 + "))");
            double deter1sonuc = ((a1 * b2 * c3) + (a2 * b3 * c1) + (a3 * b1 * c2));
            double deter2sonuc = ((c1 * b2 * a3) + (c2 * b3 * a1) + (c3 * b1 * a2));

            Console.WriteLine("= " + "(" + deter1sonuc + ")" + " - " + "(" + deter2sonuc + ")");
            double deter3sonuc = (deter1sonuc - deter2sonuc);

            Console.WriteLine("= " + deter3sonuc);
            Console.WriteLine();


            //OPERATİON B

            //first article of operation B

            //An Identity Matrix has 1s on the main diagonal and 0s everywhere else
            Console.ForegroundColor = ConsoleColor.Green;
            if (a1 == 1 && b2 == 1 && c3 == 1 && b1 == 0 && c1 == 0 && a2 == 0 && c2 == 0 && a3 == 0 && b3 == 0)
            {
                Console.WriteLine("7)Identity matrix: Yes");
            }
            else
            {
                Console.WriteLine("7)Identity matrix: No");
            }

            //second article of operation B

            //A scalar matrix is a special kind of diagonal matrix. It is a diagonal matrix with equal-valued elements along the diagonal
            Console.ForegroundColor = ConsoleColor.Red;
            if ((a1 == b2) && (b2 == c3) && (a1 == c3) && b1 == 0 && c1 == 0 && a2 == 0 && c2 == 0 && a3 == 0 && b3 == 0)
            {
                Console.WriteLine("8)Scalar matrix: Yes");
            }
            else
            {
                Console.WriteLine("8)Scalar matrix: No");
            }

            //third article of operatıon B

            //It is type of square matrix which has all the non-diagonal elements equal to zero
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (b1 == 0 && c1 == 0 && a2 == 0 && c2 == 0 && a3 == 0 && b3 == 0)
            {
                Console.WriteLine("9)Diagonal matrix: Yes");
            }
            else
            {
                Console.WriteLine("9)Diagonal matrix: No");
            }

            //fourth article of operation B

            //zero-one matrix is all its elements are either zero or one.
            Console.ForegroundColor = ConsoleColor.Blue;
            if ((a1 == 1 || a1 == 0) && (a2 == 1 || a2 == 0) && (a3 == 1 || a3 == 0) && (b1 == 1 || b1 == 0)
                && (b2 == 1 || b2 == 0) && (b3 == 1 || b3 == 0) && (c1 == 1 || c1 == 0) && (c2 == 1 || c2 == 0) && (c3 == 1 || c3 == 0))
            {
                Console.WriteLine("10)Zero-one matrix: Yes");
            }
            else
            {
                Console.WriteLine("10)Zero-one matrix: No");
            }


            //fifth article of operation B

            //If the transpose of a matrix is equal to itself, that matrix is said to be symmetric.
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (a2 == b1 && a3 == c1 && b3 == c2)
            {
                Console.WriteLine("11)Symmetric matrix: Yes");
            }
            else
            {
                Console.WriteLine("11)Symmetric matrix: No");
            }

            //sixth article of operation B

            //A permutation matrix is the result of repeatedly interchanging the rows and columns of an identity matrix. 
            Console.ForegroundColor = ConsoleColor.White;
            if (a1 == 1 && a2 == 0 && a3 == 0 && b1 == 0 && b2 == 1 && b3 == 0 && c1 == 0 && c2 == 0 && c3 == 1)
            {
                Console.WriteLine("12)Permutation matrix: Yes");
            }

            else if (a1 == 1 && a2 == 0 && a3 == 0 && b1 == 0 && b2 == 0 && b3 == 1 && c1 == 0 && c2 == 1 && c3 == 0)
            {
                Console.WriteLine("12)Permutation matrix: Yes");
            }

            else if (a1 == 0 && a2 == 1 && a3 == 0 && b1 == 0 && b2 == 0 && b3 == 1 && c1 == 1 && c2 == 0 && c3 == 0)
            {
                Console.WriteLine("12)Permutation matrix: Yes");
            }

            else if (a1 == 0 && a2 == 0 && a3 == 1 && b1 == 0 && b2 == 1 && b3 == 0 && c1 == 1 && c2 == 0 && c3 == 0)
            {
                Console.WriteLine("12)Permutation matrix: Yes");
            }

            else if (a1 == 0 && a2 == 1 && a3 == 0 && b1 == 1 && b2 == 0 && b3 == 0 && c1 == 0 && c2 == 0 && c3 == 1)
            {
                Console.WriteLine("12)Permutation matrix: Yes");
            }

            else if (a1 == 0 && a2 == 0 && a3 == 1 && b1 == 1 && b2 == 0 && b3 == 0 && c1 == 0 && c2 == 1 && c3 == 0)
            {
                Console.WriteLine("12)Permutation matrix: Yes");
            }

            else
            {
                Console.WriteLine("12)Permutation matrix: No");
            }



            //OPERATİON C

            //First article of Operation C

            double row1_min, row2_min, row3_min, colown1_max, colown2_max, colown3_max, maxmin, minmax;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if ((a1 <= b1) && (a1 <= c1))
            {
                row1_min = a1;
            }

            else if ((b1 <= a1) && (b1 <= c1))
            {
                row1_min = b1;
            }
            else
            {
                row1_min = c1;
            }


            if ((a2 <= b2) && (a2 <= c2))
            {
                row2_min = a2;
            }
            else if ((b2 <= a2) && (b2 <= c2))
            {
                row2_min = b2;
            }
            else
            {
                row2_min = c2;
            }

            if ((a3 <= b3) && (a3 <= c3))
            {
                row3_min = a3;
            }
            else if ((b3 <= a3) && (b3 <= c3))
            {
                row3_min = b3;
            }
            else
            {
                row3_min = c3;
            }

            Console.WriteLine("13)Minimum values of the each row ( " + row1_min + " | " + row2_min + " | " + row3_min + " ) ");

            //Second article of the operation C
            Console.ForegroundColor = ConsoleColor.Yellow;
            if ((a1 >= a2) && (a1 >= a3))
            {
                colown1_max = a1;
            }
            else if ((a2 >= a1) && (a2 >= a3))
            {
                colown1_max = a2;
            }
            else
            {
                colown1_max = a3;
            }

            if ((b1 >= b2) && (b1 >= b3))
            {
                colown2_max = b1;
            }
            else if ((b2 >= b1) && (b2 >= b3))
            {
                colown2_max = b2;
            }
            else
            {
                colown2_max = b3;
            }

            if ((c1 >= c2) && (c1 >= c3))
            {
                colown3_max = c1;

            }
            else if ((c2 >= c1) && (c2 >= c3))
            {
                colown3_max = c2;
            }
            else
            {
                colown3_max = c3;
            }


            Console.WriteLine("14)Maximum values of each column ( " + colown1_max + " | " + colown2_max + " | " + colown3_max + " ) ");

            //Thirth article of the operation C
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if ((row1_min >= row2_min) && (row1_min >= row3_min))
            {
                maxmin = row1_min;
            }

            else if ((row2_min >= row1_min) && (row2_min >= row3_min))
            {
                maxmin = row2_min;
            }
            else
            {
                maxmin = row3_min;
            }

            Console.WriteLine("15)Minimum of maximum values of each row: " + maxmin);

            //Fourth article of the operation C
            Console.ForegroundColor = ConsoleColor.Magenta;
            if ((colown1_max <= colown2_max) && (colown1_max < colown3_max))
            {
                minmax = colown1_max;
            }

            else if ((colown2_max <= colown1_max) && (colown2_max <= colown3_max))
            {
                minmax = colown2_max;
            }
            else
            {
                minmax = colown3_max;
            }

            Console.WriteLine("16)Minimum of maximum values of each column: " + minmax);

            //Fifth article of the operation C
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (maxmin < minmax)
            {
                Console.WriteLine("17)Compare maxmin to minmax: maxmin<minmax");

            }
            else if (maxmin > minmax)
            {
                Console.WriteLine("17)Compare maxmin to minmax: maxmin>minmax");
            }
            else
            {

                Console.WriteLine("17)Compare maxmin to minmax: maxmin=minmax");

            }


            Console.WriteLine();

            //OPERATİON D

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Matrix Format for Gauss Elimination");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("| a1  b1  c1  d1 |");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("| a2  b2  c2  d2 |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("| a3  b3  c3  d3 |");

            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("18.Enter the matrix for Gauss Elimination Method");


            double d1, d2, d3;


            Console.Write("a1=");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b1=");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c1=");
            c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("d1=");
            d1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a2=");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b2=");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c2=");
            c2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("d2=");
            d2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a3=");
            a3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b3=");
            b3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c3=");
            c3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("d3=");
            d3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            //when a1 is equal to zero, we continued the operations by swapping  the first row and the second row.
            double temp;

            if (a1 == 0 && a2 != 0)
            {
                temp = a2;
                a2 = a1;
                a1 = temp;
                temp = b2;
                b2 = b1;
                b1 = temp;
                temp = c2;
                c2 = c1;
                c1 = temp;
                temp = d2;
                d2 = d1;
                d1 = temp;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("swapping two rows== " + "R1---->R2  &  R2---->R1");
            }
            //when a1 is equal to zero, we continued the operations by swapping  the first row and the third row.
            else if (a1 == 0 && a3 != 0)
            {
                temp = a3;
                a3 = a1;
                a1 = temp;
                temp = b3;
                b3 = b1;
                b1 = temp;
                temp = c3;
                c3 = c1;
                c1 = temp;
                temp = d3;
                d3 = d1;
                d1 = temp;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("swapping two rows== " + "R1---->R3  &  R3---->R1");
            }

            // If a1, a2 and a3 equal to zero,then we can't D group operations with 3*4 matrix. .So I asked the user to enter repeat values.
            else if (a1 == 0 && a2 == 0 && a3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("THİS A ERROR!!!!!!" + "a1, a2, and a3 cannot all be equal to zero at the same time.please enter the correct values.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Entered Matrix=");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", a1, b1, c1, d1, "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", a2, b2, c2, d2, "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", a3, b3, c3, d3, "|"));
            Console.WriteLine();

            //first step=equalizing a1 to one

            if (a1 != 1)
            {

                b1 = b1 / a1;
                c1 = c1 / a1;
                d1 = d1 / a1;
                a1 = a1 / a1;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("first step===>r1/" + "(" + a1 + ")" + "--->r1");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //second step=equalizing a2 to zero
            if (a2 != 0)
            {
                b2 = -a2 * b1 + b2;
                c2 = -a2 * c1 + c2;
                d2 = -a2 * d1 + d2;
                a2 = -a2 * a1 + a2;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("second step===>r1*" + "(" + -a2 + ")" + "+r2--->r2");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //third step=equalizing a3 to zero
            if (a3 != 0)
            {
                b3 = -a3 * b1 + b3;
                c3 = -a3 * c1 + c3;
                d3 = -a3 * d1 + d3;
                a3 = -a3 * a1 + a3;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("third step===>r1*" + "(" + -a3 + ")" + "+r3--->r3");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //fourth step=equalizing b2 to one
            if (b2 != 1)
            {
                c2 = c2 / b2;
                d2 = d2 / b2;
                b2 = b2 / b2;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("fourth step ===>r2/" + "(" + b2 + ")" + "--->r2");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //fifth step=equalizing b1 to zero
            if (b1 != 0)
            {
                c1 = -b1 * c2 + c1;
                d1 = -b1 * d2 + d1;
                b1 = -b1 * b2 + b1;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("fifth step ===>r2*" + "(" + -b1 + ")" + "+r1--->r1");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //sixth step=equalizing b3 to zero
            if (b3 != 0)
            {
                c3 = -b3 * c2 + c3;
                d3 = -b3 * d2 + d3;
                b3 = -b3 * b2 + b3;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("sixth step ===>r2*" + "(" + -b3 + ")" + "+r3--->r3");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //seventh step=equalizing c3 to one
            if (c3 != 1)
            {
                d3 = d3 / c3;
                c3 = c3 / c3;

            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("seventh step ===>r3/" + "(" + c3 + ")" + "--->r3");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //eighth  step=equalizing c1 to zero

            if (c1 != 0)
            {
                d1 = -c1 * d3 + d1;
                c1 = -c1 * c3 + c1;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("eighth step ===>r3*" + "(" + -c1 + ")" + "+r1--->r1");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //ninth step=equalizing c2 to zero

            if (c2 != 0)
            {
                d2 = -c2 * d3 + d2;
                c2 = -c2 * c3 + c2;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ninth step ===>r3*" + "(" + -c2 + ")" + "+r2--->r2");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a1, 3), Math.Round(b1, 3), Math.Round(c1, 3), Math.Round(d1, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a2, 3), Math.Round(b2, 3), Math.Round(c2, 3), Math.Round(d2, 3), "|"));
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(string.Format("{0,-2}  {1,-6}   {2,-6}   {3,-6}  {4,-6}  {5,1}", "|", Math.Round(a3, 3), Math.Round(b3, 3), Math.Round(c3, 3), Math.Round(d3, 3), "|"));
            Console.WriteLine();

            //tenth step= find the x,y and z

            double x, y, z;

            x = d1;
            y = d2;
            z = d3;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("20.The value of unknowns (x, y, z)");
            Console.WriteLine("x=" + Math.Round(x, 3));
            Console.WriteLine("y=" + Math.Round(y, 3));
            Console.WriteLine("z=" + Math.Round(z, 3));

            Console.ReadLine();
        }
    }
}
