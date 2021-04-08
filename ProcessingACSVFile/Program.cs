using System;
using System.Collections.Generic;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {

            /*      0           1               2           3           4       5       6       7       8       9      etc...
             * ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP
             * PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME
             * DEALSIZE*/
            double totalFor2003 = 0;
            double totalFor2004 = 0;
            double totalFor2005 = 0;
            double[] monthByMonth2003 = new double[12];
            double[] monthByMonth2004 = new double[12];
            double[] monthByMonth2005 = new double[12];

            string[] lines = File.ReadAllLines("sales_data_sample.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] pieces = line.Split(',');
                string status = pieces[6];
                int year = Convert.ToInt32(pieces[9]);
                int month=  Convert.ToInt32(pieces[8]);
                double sales= Convert.ToDouble(pieces[4]);

                if (status.ToLower() == "shipped")
                {
                    if (year == 2003)
                    {
                        totalFor2003 += sales;
                        monthByMonth2003[month - 1] += sales;
                    }
                    else if (year == 2004)
                    {
                        totalFor2004 += sales;
                        monthByMonth2004[month - 1] += sales;
                    }
                    else if (year == 2005)
                    {
                        totalFor2005 += sales;
                        monthByMonth2005[month - 1] += sales;
                    }
                    else
                    { }
                }
            }
            Console.WriteLine("The total sales for shipeed items in 2003 is " +totalFor2003.ToString("C"));
            Console.WriteLine("The total sales for shipeed items in 2004 is " + totalFor2004.ToString("C"));
            Console.WriteLine("The total sales for shipeed items in 2005 is " + totalFor2005.ToString("C"));
            for (int i = 0; i < monthByMonth2003.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("The January 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 1)
                {
                    Console.WriteLine("The Feburary 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 2)
                {
                    Console.WriteLine("The March 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 3)
                {
                    Console.WriteLine("The April 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 4)
                {
                    Console.WriteLine("The May 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 5)
                {
                    Console.WriteLine("The June 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 6)
                {
                    Console.WriteLine("The July 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 7)
                {
                    Console.WriteLine("The August 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 8)
                {
                    Console.WriteLine("The September 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 9)
                {
                    Console.WriteLine("The October 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else if (i == 10)
                {
                    Console.WriteLine("The November 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
                else
                {
                    Console.WriteLine("The December 2003 sales total is " + monthByMonth2003[i].ToString("C"));
                }
            }

            for (int i = 0; i < monthByMonth2004.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("The January 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 1)
                {
                    Console.WriteLine("The Feburary 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 2)
                {
                    Console.WriteLine("The March 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 3)
                {
                    Console.WriteLine("The April 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 4)
                {
                    Console.WriteLine("The May 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 5)
                {
                    Console.WriteLine("The June 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 6)
                {
                    Console.WriteLine("The July 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 7)
                {
                    Console.WriteLine("The August 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 8)
                {
                    Console.WriteLine("The September 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 9)
                {
                    Console.WriteLine("The October 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else if (i == 10)
                {
                    Console.WriteLine("The November 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
                else
                {
                    Console.WriteLine("The December 2004 sales total is " + monthByMonth2004[i].ToString("C"));
                }
            }

            for (int i = 0; i < monthByMonth2005.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("The January 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 1)
                {
                    Console.WriteLine("The Feburary 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 2)
                {
                    Console.WriteLine("The March 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 3)
                {
                    Console.WriteLine("The April 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 4)
                {
                    Console.WriteLine("The May 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 5)
                {
                    Console.WriteLine("The June 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 6)
                {
                    Console.WriteLine("The July 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 7)
                {
                    Console.WriteLine("The August 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 8)
                {
                    Console.WriteLine("The September 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 9)
                {
                    Console.WriteLine("The October 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else if (i == 10)
                {
                    Console.WriteLine("The November 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
                else
                {
                    Console.WriteLine("The December 2005 sales total is " + monthByMonth2005[i].ToString("C"));
                }
            }
        }
    }
}
