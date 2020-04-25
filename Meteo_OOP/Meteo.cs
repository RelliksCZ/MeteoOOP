using System;
using System.Collections.Generic;
using System.Text;

namespace Meteo_OOP
{
    class Meteo
    {
        public void All()
        {
            string option = "";
            do
            {
                string[] week = new string[] { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
                string plus = "";
                string minus = "";
                string spaces = "";
                string minspaces = "";
                string space = "";
                string mindays = "(";
                string maxdays = "(";

                double average = 0;

                int temnum = 0;
                int[] Celcious = new int[7];
                int minnum = 1000;
                int maxnum = Celcious[0];


                for (int i = 0; i < week.Length; i++)
                {
                    Console.Write("Add tempeture in " + week[i] + ": ");
                    Celcious[i] = int.Parse(Console.ReadLine());
                    average += Celcious[i];
                }
                for (int i = 0; i < week.Length; i++)
                {
                    if (minnum > Celcious[i])
                    {
                        minnum = Celcious[i];
                    }
                    if (maxnum < Celcious[i])
                    {
                        maxnum = Celcious[i];
                    }
                }
                Console.WriteLine("\n=======================================\n");

                for (int z = 0; z > minnum; z--)
                {
                    spaces = spaces + " ";
                }

                for (int i = 0; i < 7; i++)
                {

                    if (Celcious[i] >= 0)
                    {
                        for (int z = 0; z < Celcious[i]; z++)
                        {
                            plus = plus + "+";
                        }
                        Console.WriteLine("{0}:     {1}|{2} {3}", week[i], spaces, plus, Celcious[i]);
                        plus = "";
                    }
                    else
                    {
                        if (Celcious[i] > -10)
                        {
                            space = " ";
                        }
                        else
                        {
                            space = "";
                        }
                        for (int z = Celcious[i]; z > minnum; z--)
                        {
                            minspaces = minspaces + " ";
                        }

                        for (int z = 0; z > Celcious[i]; z--)
                        {
                            minus = minus + "-";
                        }
                        Console.WriteLine("{0}:{1}{2} {3} {4}|", week[i], minspaces, space, Celcious[i], minus);
                        minus = "";
                        minspaces = "";
                    }
                }
                foreach (int i in Celcious)
                {
                    if (i == maxnum)
                    {
                        if (maxdays == "(")
                        {
                            maxdays = maxdays + String.Format(week[temnum]);
                        }
                        else
                        {
                            maxdays = maxdays + String.Format(", " + week[temnum]);
                        }
                    }
                    else if (i == minnum)
                    {
                        if (mindays == "(")
                        {
                            mindays = mindays + String.Format(week[temnum]);
                        }
                        else
                        {
                            mindays = mindays + String.Format(", " + week[temnum]);
                        }
                    }
                    temnum++;
                }
                Console.WriteLine("\n=======================================\n");
                Console.WriteLine("Lowest tempature: " + minnum + mindays +")");
                Console.WriteLine("Highest tempature: " + maxnum + maxdays + ")");
                Console.WriteLine("Average tempature: " + Math.Round(average / 7, 2) + " ( Mo - Su)");
                Console.WriteLine("Do you want to try again? Y/N");
                option = Console.ReadLine();
                if (option == "n")
                {
                    System.Environment.Exit(0);
                }
                else if (option == "y")
                {
                    Console.Clear();
                    option = "y";
                }
            }
            while (option == "y");
        }
    }
}
