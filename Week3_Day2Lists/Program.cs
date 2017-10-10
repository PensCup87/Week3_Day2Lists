using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ////CReating a new list with values
            //List<int> testScores = new List<int> { 98, 100, 76, 84, 93 };
            ////ADDING VALUES to END OF THE LIST
            //testScores.Add(80);
            //testScores.Add(99);

            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(2);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(5);
            //luckyNumbers.Add(7);
            //Console.WriteLine(luckyNumbers.Count);

            //List<string> favoriteFoods = new List<string>() { "steak", "chicken", "pasta", "gelato", "pepperoni balls" };
            ////To PRINT ELements INDIVIDUALLY
            //Console.WriteLine(favoriteFoods[2]);//pasta
            //Console.WriteLine(favoriteFoods[4]);
            //Console.WriteLine(favoriteFoods[3]);
            //Console.WriteLine(favoriteFoods.Count + " items");
            //Console.WriteLine();
            //Console.WriteLine();

            ////Created and Added to a List
            //List<string> leastFavoriteFoods = new List<string>();
            //leastFavoriteFoods.Add("tuna");
            //leastFavoriteFoods.Add("scallops");
            //leastFavoriteFoods.Add("squid");
            //leastFavoriteFoods.Add("clams/oysters");
            //Console.WriteLine(leastFavoriteFoods[0]);
            //Console.WriteLine();
            ////index 0 now holds a different value - the new value replaces the previous
            //leastFavoriteFoods[0] = "bananas";
            //Console.WriteLine(leastFavoriteFoods[0]);
            

            //List<String> favFilms = new List<string>() { "Godfather", "Caddyshack", "Ghostbusters", "Dark Knight", "Rudy" };
            ////LOOPING THROUGH LISTS
            //for(int i = 0; i < favFilms.Count; i++)
            //{
            //    Console.WriteLine(favFilms[i]);
            //}

            //favFilms.Insert(1, "Back to the Future");
            //favFilms.Insert(2, "Rocky");
            //favFilms.Insert(3, "Top Gun");


            //foreach (string film in favFilms)
            //{
            //    Console.WriteLine(film);
            //}

            ////REMOVING LIST ITEMS
            //Console.WriteLine();
            //favFilms.Remove("Ghostbusters");
            //favFilms.Remove("Back to the Future");
            //foreach (string film in favFilms)
            //{
            //    Console.WriteLine(film);
            //    Console.WriteLine();
            //    Console.WriteLine();


            //    List<string> animalList = new List<string>();
            //    animalList.Add("dog");
            //    animalList.Add("bird");
            //    animalList.Add("tiger");
            //    animalList.Add("lion");
            //    animalList.Add("sashquash");
            //    foreach(string animal in animalList)
            //    {
            //        Console.WriteLine(animal);
            //    }
            //    Console.WriteLine();

            //    List<bool> boolList = new List<bool>() { true, false, false, true, false };
            //    foreach(bool i in boolList)
            //    {
            //        if(i == true)
            //        {
            //            Console.WriteLine("Better bring an umbrella.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No Rain today, enjoy the sun.");
            //        }
            //    }

            //    List<int> numberList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5};

            //    Console.WriteLine(numberList.Contains(23));//DOES THE LIST HAVE A SPECIFIC VALUE - RETURNS TRUE/FALSE
            //    Console.WriteLine(numberList.Contains(77));
            //    Console.WriteLine(numberList.Contains(15));
            //    Console.WriteLine();
            //    numberList.Remove(27);
            //    numberList.Remove(77);
            //    numberList.Remove(32);
            //    numberList.Remove(6);
            //    Console.WriteLine(numberList.Contains(23));//DOES THE LIST HAVE A SPECIFIC VALUE - RETURNS TRUE/FALSE
            //    Console.WriteLine(numberList.Contains(77));
            //    Console.WriteLine(numberList.Contains(15));







            //    Console.WriteLine();
            //    Console.WriteLine();
            //    Console.WriteLine();


                //TUTORING 10/10
                //NESTED LOOPS - Creating a Clock
                int seconds = 0;
                int minutes = 0;
                int hours = 0;

                for(hours = 0; hours < 13; hours++)
                {
                    for(minutes = 0; minutes < 60; minutes++)
                    {
                        for(seconds = 0; seconds < 60; seconds++)
                        {
                            Console.WriteLine(hours + ":" + minutes + ":" + seconds + ":");
                        }
                    }
                }



            }
        }
    }

