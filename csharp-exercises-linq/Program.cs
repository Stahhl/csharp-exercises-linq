using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace csharp_exercises_linq
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Choose Module: ");
            try
            {
                ChooseModule(Int32.Parse(Console.ReadLine()));
            }
            catch
            {
                Main();
            }
        }
        static void Restart()
        {
            Console.WriteLine("\n\n------------------------------");
            Console.WriteLine("Press 'Enter' to restart: ");
            Console.Read();
            Main();
        }
        static void ChooseModule(int number)
        {
            switch (number)
            {
                case 1:
                    Module_1();
                    break;
                case 2:
                    Module_2();
                    break;
                case 3:
                    Module_3();
                    break;
                case 4:
                    Module_4();
                    break;
                case 5:
                    Module_5();
                    break;
                case 6:
                    Module_6();
                    break;
                case 7:
                    Module_7();
                    break;
                case 8:
                    Module_8();
                    break;
                case 9:
                    Module_9();
                    break;
                case 10:
                    Module_10();
                    break;
                case 11:
                    Module_11();
                    break;
                case 12:
                    Module_12();
                    break;
                case 13:
                    Module_13();
                    break;
                case 14:
                    Module_14();
                    break;
                case 15:
                    Module_15();
                    break;
                case 16:
                    Module_16();
                    break;
                case 17:
                    Module_17();
                    break;
                case 18:
                    Module_18();
                    break;
                case 19:
                    Module_19();
                    break;
                case 20:
                    Module_20();
                    break;
                case 21:
                    Module_21();
                    break;
                case 22:
                    Module_22();
                    break;
                case 23:
                    Module_23();
                    break;
                case 24:
                    Module_24();
                    break;
                case 25:
                    Module_25();
                    break;
                case 26:
                    Module_26();
                    break;
                case 27:
                    Module_27();
                    break;
                case 28:
                    Module_28();
                    break;
                case 29:
                    Module_29();
                    break;
                case 30:
                    Module_30();
                    break;
                default:
                    Console.WriteLine("Couldnt find module: " + number);
                    Console.ReadKey();
                    Main();
                    break;
            }
        }
        static void Module_30()
        {
            //Write a program in C# Sharp to arrange the distinct elements in the list in ascending order.  
            Tuple<List<Item_mast>, List<Purchase>> test = tupleTest();
            List<Item_mast> itemlist = test.Item1;

            Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : ");
            Console.Write("\n----------------------------------------------------------------\n");

            //.Distinct() removes duplicates
            var items = (from c in itemlist select c.ItemDes).Distinct().OrderBy(x => x);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Restart();
        }
        static void Module_29()
        {
            string[] cities =
                 {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };

            Console.Write("\nLINQ : Split a collection of strings into some groups  : ");
            Console.Write("\n-------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI', \n");
            Console.Write("                   'AMSTERDAM','ABU DHABI','PARIS','NEW YORK' \n");
            Console.Write("\nHere is the group of cities : \n\n");

            var citySplit = from i in Enumerable.Range(0, cities.Length)
                            group cities[i] by i / 3;

            foreach (var city in citySplit)
            {
                Console.WriteLine(string.Join(" ", city.ToArray()));
                Console.WriteLine("-- here is a group of cities --\n");
            }

            Restart();
        }
        static void Module_28()
        {
            //Write a program in C# Sharp to display the list of items in the array 
            //according to the length of the string then by name in ascending order.

            #region List
            List<string> cities = new List<string>();
            cities.Add("ASDF");
            cities.Add("AADF");
            cities.Add("AAAF");
            cities.Add("AAAA");
            cities.Add("ROME");
            cities.Add("PARIS");
            cities.Add("LONDON");
            cities.Add("ZURICH");
            cities.Add("NAIROBI");
            cities.Add("ABU DHABI");
            cities.Add("AMSTERDAM");
            cities.Add("NEW DELHI");
            cities.Add("CALIFORNIA");
            #endregion

            //Order first by string length then by alphabetical order
            var cityOrder = cities
                .OrderBy(str => str.Length)
                .ThenBy(str => str);

            foreach (string city in cityOrder)
                Console.WriteLine(city);

            Restart();
        }
        static void Module_27()
        {
            //Write a program in C# Sharp to generate a Right Outer Join between two data sets.
            Tuple<List<Item_mast>, List<Purchase>> test = tupleTest();
            List<Item_mast> itemlist = test.Item1;
            List<Purchase> purchlist = test.Item2;
            #region fluff
            Console.Write("\nLINQ : Generate a Left Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");
            #endregion

            var rightOuterJoin = from p in purchlist
                                 join i in itemlist
                                 on p.ItemId equals i.ItemId
                                 into a
                                 from b in a.DefaultIfEmpty()
                                 select new
                                 {
                                     itid = b.ItemId,
                                     itdes = b.ItemDes,
                                     prqty = p.PurQty
                                 };

            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in rightOuterJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }

            Restart();
        }
        static void Module_26()
        {
            //Write a program in C# Sharp to generate a Left Join between two data sets.
            Tuple<List<Item_mast>, List<Purchase>> test = tupleTest();
            List<Item_mast> itemlist = test.Item1;
            List<Purchase> purchlist = test.Item2;
            #region fluff
            Console.Write("\nLINQ : Generate a Left Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");
            #endregion

            var leftOuterJoin = from itm in itemlist
                                join prch in purchlist on itm.ItemId equals prch.ItemId into a
                                from b in a.DefaultIfEmpty(new Purchase())
                                select new
                                {
                                    itid = itm.ItemId,
                                    itdes = itm.ItemDes,
                                    prqty = b.PurQty
                                };

            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in leftOuterJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }

            Restart();
        }
        static void Module_25()
        {
            //Write a program in C# Sharp to generate an Inner Join between two data sets.

            Tuple<List<Item_mast>, List<Purchase>> test = tupleTest();
            List<Item_mast> itemlist = test.Item1;
            List<Purchase> purchlist = test.Item2;

            #region fluff
            Console.Write("\nLINQ : Generate a Left Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");
            #endregion

            var innerJoin = from itm in itemlist
                            join prch in purchlist on itm.ItemId equals prch.ItemId //ID in itemlist == ID in purchlist
                            select new
                            {
                                itid = itm.ItemId,
                                itdes = itm.ItemDes,
                                prqty = prch.PurQty
                            };
            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in innerJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }

            Restart();
        }
        static void Module_24()
        {
            //Write a program in C# Sharp to generate a Cartesian Product of three sets.

            char[] charset1 = { 'X', 'Y', 'Z' };
            int[] numset1 = { 1, 2, 3 };
            string[] colorset1 = { "Green", "Orange" };

            Console.Write("\nLINQ : Generate a Cartesian Product of three sets : ");
            Console.Write("\n------------------------------------------------\n");

            var cartesianProduct = from letterList in charset1
                                   from numberList in numset1
                                   from colorList in colorset1
                                   select new { letterList, numberList, colorList };

            Console.Write("The Cartesian Product are : \n\n");
            foreach (var productItem in cartesianProduct)
            {
                Console.WriteLine(productItem);
            }

            Restart();
        }
        static void Module_23()
        {
            //Write a program in C# Sharp to generate a Cartesian Product of two sets.
            char[] charset1 = { 'X', 'Y', 'Z' };
            int[] numset1 = { 1, 2, 3, 4 };

            Console.Write("\nLINQ : Generate a Cartesian Product of two sets : ");
            Console.Write("\n------------------------------------------------\n");

            var cartesianProduct = from letterList in charset1
                                   from numberList in numset1
                                   select new { letterList, numberList };

            Console.Write("The Cartesian Product are : \n\n");
            foreach (var productItem in cartesianProduct)
            {
                Console.WriteLine(productItem);
            }
            Restart();
        }
        static void Module_22()
        {
            //Write a program in C# Sharp to find the strings for a specific minimum length.

            string[] stringArray = new string[] { "this", "is", "a", "string" };

            Console.WriteLine("Elements in the array: \n");
            foreach (string s in stringArray)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine("\nType the minimum length of the string you want to find: ");
            int stringLength = Int32.Parse(Console.ReadLine());

            var correctStrings = from s in stringArray
                                where s.Length >= stringLength
                                orderby s
                                select s;
            Console.WriteLine("\nThe strings of the correct length are: \n");
            foreach (string s in correctStrings)
            {
                Console.WriteLine(s);
            }

            Restart();
        }
        static void Module_21()
        {
            //Write a program in C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove.

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write("\nLINQ : Remove range of items from list by passing start index and number of elements to delete  : ");
            Console.Write("\n------------------------------------------------------------------------------------------------\n");

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.RemoveRange(1, 3);

            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing the three items starting from the item index 1 from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Restart();
        }
        static void Module_20()
        {
            //Write a program in C# Sharp to Remove Items from List by passing the item index.

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write("\nLINQ : Remove Items from List by passing item index  : ");
            Console.Write("\n--------------------------------------------------\n");

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.RemoveAt(3);

            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing item index 3 from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Restart();
        }
        static void Module_19()
        {
            //Write a program in C# Sharp to Remove Items from List by passing filters

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write("\nLINQ : Remove Items from List by passing filters  : ");
            Console.Write("\n--------------------------------------------------\n");

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.RemoveAll(en => en == "q");


            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing item 'q' from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Restart();
        }
        static void Module_18()
        {
            //Write a program in C# Sharp to Remove Items from List by creating an object internally by filtering.

            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write("\nLINQ : Remove Items from List by creating object internally by filtering  : ");
            Console.Write("\n--------------------------------------------------------------------------\n");

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine("Char: {0} ", tchar);
            }

            listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing the item 'p' from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine("Char: {0} ", rChar);
            }

            Restart();
        }
        static void Module_17()
        {
            //NOT USING LINQ LUL
            //Write a program in C# Sharp to Remove Items from List using remove function by passing the object.
            char[] letters = new char[] {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'e',
            's',
            't',
            'u',
            'x',
            'x',
            'y',
            'z',
            'å',
            'ä',
            'ö',
        };
            List<string> letterList = new List<string>();

            foreach (char c in letters)
            {
                letterList.Add(c.ToString());
            }

            Console.WriteLine("Characters in the list: ");
            foreach (string s in letterList)
            {
                Console.Write(s);
            }

            Console.WriteLine("\n\nEnter a string to remove: ");
            string remove = Console.ReadLine();

            foreach (char c in remove)
            {
                if(letterList.Contains(c.ToString()))
                {
                    letterList.Remove(c.ToString());
                }
            }

            Console.WriteLine("\nCharacters in the list after removal: ");
            foreach (string s in letterList)
            {
                Console.Write(s);
            }

            Restart();
        }
        static void Module_16()
        {
            //Write a program in C# Sharp to Calculate Size of File using LINQ. Go to the editor
            //Expected Output:
            //The Average file size is 3.4 MB

            string[] dirfiles = Directory.GetFiles("C:/Users/ArvidAcademy/Documents/Visual Studio Projects/csharp-exercises-linq/csharp-exercises-linq/Files1");
            // there are three files in the directory abcd are :
            // abcd.txt, simple_file.txt and xyz.txt

            Console.Write("\nLINQ : Calculate the Size of File : ");
            Console.Write("\n------------------------------------\n");


            var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average(); //KB
            var avgFsizeRounded = Math.Round(avgFsize / 10, 1); //MB
            Console.WriteLine($"There are {dirfiles.Length} files in the folder");
            Console.WriteLine("The Average file size is: " + avgFsize + "_" + avgFsizeRounded);
            foreach (var item in dirfiles)
            {
                FileInfo fileInfo = new FileInfo(item);
                Console.WriteLine("Filesize: " + fileInfo.Length);
            }
            Restart();
        }
        static void Module_15()
        {
            //Write a program in C# Program to Count File Extensions and Group it using LINQ. Go to the editor

            //Test Data:
            //The files are: 
            //aaa.frx, bbb.TXT, xyz.dbf,abc.pdf, aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt

            //Expected Output:
            //Here is the group of extension of the files:
            //1 File(s) with.frx Extension
            //3 File(s) with.txt Extension
            //1 File(s) with.dbf Extension
            //2 File(s) with.pdf Extensionx
            //1 File(s) with.frt Extension
            //1 File(s) with.xml Extension
            string[] stringArray = new string[] {
                "aaa.frx",
                "bbb.TXT",
                "xyz.dbf",
                "abc.pdf",
                "aaaa.PDF",
                "xyz.frt",
                "abc.xml",
                "ccc.txt",
                "zzz.txt"
            };

            //Path.GetExtension(file) returns the file extension of file e.g. '.txt'. 
            //TrimStart('.') removes the dot at the beginning of the extension e.g. 'txt'.

            var fGrp = stringArray.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
            .GroupBy(z => z, (fExt, extCtr) => new
            {
                Extension = fExt,
                Count = extCtr.Count()
            });

            foreach (var m in fGrp)
                Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);

            Restart();
        }
        static void Module_14()
        {
            List<Student> studentList = Student.GetStudents();
            //group students by their property GrPoint into the group 'g' 
            //students with the same GrPoint are added to the same group
            //order g by its key (Student.StuId)
            //add the group to a 'List<Student>'
            //add the list of students to a 'List<List<Student>>'
            var selectedStudents = (from stu in studentList
                                    group stu by stu.GrPoint
                                    into g
                                    orderby g.Key descending 
                                    select new
                                    {
                                        studentRecord = g.ToList()
                                    }).ToList();

            Console.WriteLine("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
            int selection = Int32.Parse(Console.ReadLine());

            //choose one group of students
            //print out every student in that group 
            selectedStudents[selection - 1].studentRecord
                    .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));

            Restart();
        } 
        static void Module_13()
        {
            //Write a program in C# Sharp to convert a string array to a string.
            //Input 3 strings for the array :
            //Element[0] : cat
            //Element[1] : dog
            //Element[2] : rat
            //Expected Output:
            //Here is the string below created with elements of the above array :
            //cat, dog, rat

            int nbElements = 0;
            string[] stringArray;
            string result;
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter number of elements in the array: ");
            nbElements = Int32.Parse(Console.ReadLine());

            stringArray = new string[nbElements];

            for (int i = 0; i < nbElements; i++)
            {
                Console.WriteLine("Enter a string: ");
                stringArray[i] = Console.ReadLine();
            }
            foreach (var item in stringArray)
            {
                sb.Append($"{item}, ");
            }
            result = sb.ToString();
            Console.WriteLine("String created with the array: ");
            Console.WriteLine(result);
            Restart();
        }
        static void Module_12()
        {
            //Write a program in C# Sharp to find the uppercase letters in a string.
            Console.WriteLine("Input a string: ");

            string s = Console.ReadLine();

            var upperCaseLetters = s.ToCharArray()
                .Where(x => String.Equals(x.ToString(), Char.ToUpper(x).ToString(), StringComparison.Ordinal));

            Console.WriteLine($"Uppercase letters in {s} are: ");
            foreach (var item in upperCaseLetters)
            {
                Console.Write(item);
            }

            Restart();
        }
        static void Module_11()
        {
            //Write a program in C# Sharp to display the top n-th records.

            //The members of the list are :
            //5, 7, 13, 24, 6, 9, 8, 7

            //How many records you want to display ? : 3

            //The top 3 records from the list are:
            //24, 13, 9

            int[] data = new int[] { 5, 7, 13, 24, 6, 9, 8, 7 };
            List<int> highscores = new List<int>();

            int max = 0;

            foreach (var value in data)
            {
                highscores.Add(value);
            }

            highscores = highscores.OrderByDescending(i => i).ToList();

            Console.WriteLine("Numbers of records to display: ");
            max = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The top {max} highscors are: ");
            foreach (var item in highscores.Take(max))
            {
                Console.WriteLine(item);
            }
            Restart();
        }
        static void Module_10()
        {
            //Write a program in C# Sharp to Accept the members of a list through the keyboard 
            //and display the members more than a specific value.

            int numberOfMembers, max;
            List<int> memberList = new List<int>();

            Console.WriteLine("Enter number of members: ");
            numberOfMembers = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMembers; i++)
            {
                Console.WriteLine($"Enter number for member #{i}");
                memberList.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter max value: ");
            max = Int32.Parse(Console.ReadLine());

            List<int> filteredList = memberList.FindAll(x => x > max);
            Console.WriteLine($"The members with a higher value than {max} are: ");
            foreach (var mem in filteredList)
            {
                Console.WriteLine(mem);
            }
            Restart();
        }
        static void Module_9()
        {
            //Write a program in C# Sharp to create a list of numbers and display the numbers greater than 80 as output.

            //data
            int[] data = new int[] { 555, 777, 55, 77, 80, 81, 1337, -1337 };
            int max = 0;

            try
            {
                Console.WriteLine("The data is: 555, 777, 55, 77, 80, 81, 1337, -1337 ");
                Console.WriteLine("Mata in ett heltal: ");
                max = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Something went wrong: ");
                Module_9();
            }

            var numbers = from num in data
                          where num > max
                          select num;

            Console.WriteLine("Numbers over {0} are: ", max);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Restart();
        }
        static void Module_8()
        {
            //Write a program in C# Sharp to find the string which starts and ends with a specific character.
            //Test Data: the cities are: 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'

            //data
            string[] cities = new string[] {
                "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "PTESTS"
            };

            char first = new char();
            char last = new char();

            try
            {
                Console.WriteLine("Mata in två bokstäver: ");
                string s = Console.ReadLine().ToUpper();
                first = s[0];
                last = s[1];
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Something went wrong: ");
                Module_8();
            }

            var result = from x in cities
                         where x.StartsWith(first)
                         where x.EndsWith(last)
                         select x;

            Console.WriteLine("Cities that matched {0} and {1} is: ", first, last);
            foreach (var city in result)
            {
                Console.WriteLine(city);
            }

            Restart();
        }
        static void Module_7()
        {
            //Write a program in C# Sharp to display numbers, 
            //multiplication of number with frequency and frequency of a number of giving array.
            //Test Data:
            //The numbers in the array are:
            //5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2
            //Expected Output :
            //Number Number*Frequency Frequency

            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            Console.Write("\nLINQ : Display numbers, number*frequency and frequency : ");
            Console.Write("\n-------------------------------------------------------\n");
            Console.Write("The numbers in the array are : \n");
            Console.Write("  5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n\n");


            var m = from x in nums
                    group x by x into y
                    select y;
            Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
            Console.Write("------------------------------------------------\n");

            foreach (var arrEle in m)
            {
                Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
            }

            Restart();
        }
        static void Module_6()
        {
            //Write a program in C# Sharp to display the name of the days of a week.
            //Expected Output:
            //Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

            string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var days = from d in weekDays
                       select d;

            Console.WriteLine("Weekdays: ");
            foreach (var d in days)
            {
                Console.Write($"{d}, ");
            }

            Restart();
        }
        static void Module_5()
        {
            //Write a program in C# Sharp to display the characters and frequency of character from giving string.
            //Test Data:
            //Input the string: apple
            //Expected Output:
            //The frequency of the characters are :
            //Character a: 1 times
            //Character p: 2 times
            //Character l: 1 times
            //Character e: 1 times
            Console.WriteLine("Enter a string: ");
            string word = Console.ReadLine();

            var letters = from s in word
                          group s by s into w
                          select w;

            foreach (var item in letters)
            {
                Console.WriteLine($"Character: {item.Key} appears {item.Count()} of times");
            }
            Restart();
        }
        static void Module_4()
        {
            //Write a program in C# Sharp to display the number and frequency of number from giving array. Go to the editor
            //Expected Output:
            //The number and the Frequency are :
            //Number 5 appears 3 times
            //Number 9 appears 2 times
            //Number 1 appears 1 times

            //data
            int[] n1 = new int[] { 5, 5, 5, 17, 1, 1, 1, -18, 5 };

            //query
            var numbers = from num in n1
                          group num by num into multi
                          select multi;
            //
            foreach (var item in numbers)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times");
            }
            Restart();
        }
        static void Module_3()
        {
            //Write a program in C# Sharp to find the number of an array and the square of each number. Go to the editor
            //Expected Output:
            //{ Number = 9, SqrNo = 81 }
            //{ Number = 8, SqrNo = 64 }
            //{ Number = 6, SqrNo = 36 }
            //{ Number = 5, SqrNo = 25 }

            // code from DevCurry.com
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
            Console.Write("\n------------------------------------------------------------------------\n");

            var sqNo = from Number in arr1
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo }; //If the square of Number > 20 add Number and its squre to the anon type sqNo

            foreach (var a in sqNo)
                Console.WriteLine(a);

            Restart();
        }
        static void Module_2()
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.Go to the editor
            //Expected Output:
            //The numbers within the range of 1 to 11 are:
            //1 3 6 9 10

            int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            Console.Write("\nLINQ : Using multiple WHERE clause to find the positive numbers within the list : ");
            Console.Write("\n-----------------------------------------------------------------------------");

            var nQuery =
            from VrNum in n1
            where VrNum > 0
            where VrNum < 12
            select VrNum;
            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
            foreach (var VrNum in nQuery)
            {
                Console.Write("{0}  ", VrNum);
            }
            Restart();
        }
        static void Module_1()
        {
            //Write a program in C# Sharp to shows how the three parts of a query operation execute. Go to the editor
            //Expected Output:
            //The numbers which produce the remainder 0 after divided by 2 are:
            //0 2 4 6 8

            //  The first part is Data source.
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Basic structure of LINQ : ");
            Console.WriteLine("---------------------------");

            // The second part is Query creation.
            // nQuery is an IEnumerable<int>
            var nQuery =
                from VrNum in n1 //Check each value in the array n1
                where (VrNum % 2) == 0 //If this is true
                select VrNum; //Add it to nQuery

            // The third part is Query execution.
            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach (int VrNum in nQuery)
            {
                Console.Write("{0} ", VrNum);
            }
            Restart();
        }
        static Tuple<List<Item_mast>, List<Purchase>> tupleTest()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " },
           new Item_mast { ItemId = 6, ItemDes = "Biscuit  " },
            };

            List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            return Tuple.Create(itemlist, purchlist); ;
        }
    }
    public class Student
    {
        List<Student> stulist = new List<Student>();

        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public int StuId { get; set; }

        public static List<Student> GetStudents()
        {
            List<Student> stulist = new List<Student>();
            stulist.Add(new Student { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Student { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Student { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Student { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Student { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Student { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Student { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Student { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Student { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Student { StuId = 10, StuName = "Jenny", GrPoint = 750 });
            return stulist;
        }

    }
    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }
    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }
}
