using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1
            //try
            //{
            //    InternationalPasport a = new InternationalPasport("Name", "123456778889", 2, 3, 2023);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            #endregion

            #region #2

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter boolean expression:");
                    string base_expression = Console.ReadLine();
                    string[] separator = { " ", ">=", "<=", "<", ">", "==", "!=" };
                    string[] arrayOfexpressions = base_expression.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    if (arrayOfexpressions.Length > 2 || arrayOfexpressions.Length <= 1)
                        throw new Exception("There are more or less than 2 operators!");

                    string without_figures = "";
                    for (int i = 0; i < base_expression.Length; i++)
                    {
                        if (!char.IsDigit(base_expression[i]) && base_expression[i] != ' ')
                        {
                            without_figures += base_expression[i];
                        }
                    }
                    if (without_figures.Length > 2 || without_figures.Length == 0)
                        throw new Exception("Invalid operator.");

                    int expression_a = Convert.ToInt32(arrayOfexpressions[0]);
                    int expression_b = Convert.ToInt32(arrayOfexpressions[1]);

                    switch (without_figures)
                    {
                        case ">":
                            if (expression_a > expression_b)
                                Console.WriteLine("True!");
                            else Console.WriteLine("False.");
                            break;
                        case "<":
                            if (expression_a < expression_b)
                                Console.WriteLine("True!");
                            else Console.WriteLine("False.");
                            break;
                        case ">=":
                            if (expression_a >= expression_b)
                                Console.WriteLine("True!");
                            else Console.WriteLine("False.");
                            break;
                        case "<=":
                            if (expression_a <= expression_b)
                                Console.WriteLine("True!");
                            else Console.WriteLine("False.");
                            break;
                        case "==":
                            if (expression_a == expression_b)
                                Console.WriteLine("True!");
                            else Console.WriteLine("False.");
                            break;
                        case "!=":
                            if (expression_a != expression_b)
                                Console.WriteLine("True!");
                            else Console.WriteLine("False.");
                            break;
                        default:
                            throw new Exception("Invalid operator.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            #endregion

        }
    }
}
