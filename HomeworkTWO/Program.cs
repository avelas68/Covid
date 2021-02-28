using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeworkTWO
{

    class Program
    {

        public static List<MyCity> listOfCities = new List<MyCity>();
        public static String[] lines;
        public static String cityname;
        public static String pop;
        public static List<String> NewCity = new List<String>();
        public static int numberChoice;
        public static String date;



        static public void Add()
        {
            using var db = new AppDbContext();
            {

                int number = 332;
                number++;

                string Choice = Convert.ToString(number);
                Console.WriteLine("Please enter the name of the city");
                cityname = Console.ReadLine();
                Console.WriteLine("Please indicate population count");
                pop = Console.ReadLine();

                var city = new MyCity
                {
                    Name = cityname,
                    Population = Convert.ToInt32(pop),
                    //id = number,
                    Date = date
                };
                //MyCity newCity = new MyCity(cityname, Convert.ToInt32(pop), date);
                db.Cities.Add(city);
                db.SaveChanges();

                listOfCities.Add(city);
            }

        }
        static public string ShowMainMenu()
        {
            Console.WriteLine("Local COVID - Main Menu");

            Console.WriteLine("c) List all cities");
            Console.WriteLine("i) Import data");
            Console.WriteLine("x) Exit");
            Console.Write("Please enter your choice: ");
            return Console.ReadLine();
        }

        static private void ImportData(string pathToFile, string date)
        {


            using var db = new AppDbContext();
            //Get all lines from the file
            lines = File.ReadAllLines(pathToFile);
            //Store information about cities
            foreach (var line in lines.Skip(1))
            {

                String a = line.Replace("\"", "");

                string[] nums = a.Split(new char[] { ',' });
                var city = new MyCity
                {
                    Name = nums[1],
                    Population = Convert.ToInt32(nums[11]),
                    Cases = Convert.ToInt32(nums[2]),
                    Deaths = Convert.ToInt32(nums[5]),
                    Tested = Convert.ToInt32(nums[8]),
                    Date = date

                };
                db.Cities.Add(city);
                // MyCity city = new MyCity(nums[1], Convert.ToInt32(nums[11]), Convert.ToInt32(nums[2]), Convert.ToInt32(nums[5]), Convert.ToInt32(nums[8]), date);
                listOfCities.Add(city);
            }
            db.SaveChanges();

        }

        static void ListAllCities()
        {
            Console.WriteLine("Local COVID - Cities");
            Console.WriteLine("a) Add a city");
            Console.WriteLine("m) Back to Main Menu");
            Console.WriteLine("x) Exit");
            int counter = 1;
            bool previousEncounter = false;
            for (int i = 0; i < listOfCities.Count; i++)
            {
                previousEncounter = false;
                for (int j = 0; j < i; j++)
                    if (listOfCities[i].Name.Equals(listOfCities[j].Name))
                    {
                        previousEncounter = true;
                        break;
                    }
                if (!previousEncounter)
                    Console.WriteLine($"{counter++}) {listOfCities[i].Name}");

            }
            if (cityname != null)
                for (int i = 0; i < NewCity.Count; i++)
                {
                    Console.Write(counter++);
                    Console.Write(") ");
                    Console.WriteLine(NewCity[i]);
                }

        }

        static void displayInformationAboutCity(int cityIndex)
        {
            if (cityIndex >= 332)
            {
                MyCity city = listOfCities[cityIndex];
                Console.Write(city.Name);
                Console.Write("(Population: ");
                Console.Write(city.Population);
                Console.WriteLine(")");
            }
            else
            {
                string nameOfCity = listOfCities[cityIndex].Name;
                Console.WriteLine($"Local COVID - {nameOfCity}(Population: {listOfCities[cityIndex].Population})");
                Console.WriteLine("Date\t\tCases\tDeaths\tTested");

                foreach (var city in listOfCities)
                {
                    if (city.Name.Equals(nameOfCity))
                    {
                        Console.WriteLine($"{city.Date}\t{city.Cases}\t{city.Deaths}\t{city.Tested}");
                    }
                }
            }

        }

        static void Main(string[] args)
        {

            var db = new AppDbContext();
            {
                //var clearQuery = from c in db.Cities
                //                 select c;

                //foreach (var city in clearQuery)
                //    db.Cities.Remove(city);
                //db.SaveChanges();

                string choice = null;
                do
                {

                    if (choice != "c")
                        choice = ShowMainMenu();

                    if (choice.Equals("x"))
                        System.Environment.Exit(0);
                    if (choice.Equals("i"))
                    {
                        Console.Write("Enter the path to the file: ");
                        string pathToFile = Console.ReadLine();

                        Console.Write("Enter the date: ");
                        date = Console.ReadLine();
                        ImportData(pathToFile, date);
                    }
                    if (choice.Equals("c"))
                    {
                        ListAllCities();
                        Console.Write("Please enter your choice: ");
                        choice = Console.ReadLine();
                        //If input is a number
                        try
                        {

                            if (choice == "a")
                            {
                                Add();
                                ListAllCities();
                                // db.cities.Add(city);

                            }
                            if (choice != "m" || choice != "x" || choice != "a")
                            {
                                numberChoice = Convert.ToInt32(choice);


                                displayInformationAboutCity(numberChoice - 1);
                                //Display details about this city

                            }
                        }
                        catch (Exception)
                        {

                        }
                        if (choice != "m")
                        {
                            Console.WriteLine("c) Back to Cities");
                            Console.WriteLine("m) Back to Main Menu");
                            Console.WriteLine("x) Exit");
                            Console.Write("Please enter your choice: ");
                            choice = Console.ReadLine();
                        }
                        if (choice.Equals("x"))
                            System.Environment.Exit(0);

                    }
                    db.SaveChanges();
                } while (choice.Equals("i") || choice.Equals("m") || choice.Equals("c"));

                return;

            }
        }

    }

}
