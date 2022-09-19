using System;
using System.Text;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
            /*
            string testString = "This is testing string.";
            List<string> stringList = new List<string>();

            Console.WriteLine(testString.Substring(8,7));
            Console.WriteLine(testString.ToUpper());
            Console.WriteLine(testString.Replace("t","T"));
            
            stringList = testString.Split(" ").ToList();
            
            StringBuilder sb = new StringBuilder("This is testing string.");
            sb.Replace("t", "T");
            Console.WriteLine(sb.ToString());
            */

            
            //task1
             Console.WriteLine("task1");

            string example = "In a dishwasher far, far away";

            example.Replace("dishwasher", "galaxy");

            // I would like to replace "dishwasher" with "galaxy" in this `example` variable
            // but there is an issue in the code above
            // Please fix it for me!

            // Expected output: In a galaxy far, far away
            Console.WriteLine(example);
            
             Console.WriteLine("task2");
            //task2
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it in more than one way using different string functions!

            url = url.Insert(5,":");
            url = url.Replace("bots","odds");
               // (url.Replace("bots", "odds");

            Console.WriteLine(url);
            
             Console.WriteLine("task3");
            //task3
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it!
            // Insert the words "always takes longer than" between the words "It" and "you"
            // using the StringBuilder class!


            StringBuilder sb = new StringBuilder(quote);
            sb.Insert(quote.IndexOf("you"), "always takes longer than ");

            Console.WriteLine(sb);
            
             Console.WriteLine("task4");
            //task4
            string todoText = "- Buy milk\n";
            // Add "My todo:" to the beginning of the `todoText`
            // Add " - Download games" to the end of the `todoText`
            // Add " - Diablo" to the end of the `todoText` applying indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            ////      - Diablo

            //todoText = todoText.Insert(1, "My todo:\n");
            //todoText = todoText.Insert(todoText.Length, "- Download games\n");
            //todoText = todoText.Insert(todoText.PadRight(10) + todoText.Length, "- Diablo\n");
            todoText = String.Concat("My todo:\n",todoText.PadRight(0), "- Download games\n", "- Diablo\n".PadLeft(15));

            Console.WriteLine(todoText);
            
             Console.WriteLine("task5");
            //task5
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            string reversed = "";

            string Reverse(string toBeReversed)
            {
                for (int i = toBeReversed.Length; i > 0; i--)
                {
                    reversed += toBeReversed[i - 1];

                }

                return reversed;
            }
            // Create a method that can reverse a string which is passed as q parameter
            // Pass the `toBeReversed` variable to this method to check if it works well
            // At first, solve this task using the `String.Chars[Int32]` property, e.g. `toBeReversed[0]`
            // Try other solutions when you are done
            Console.WriteLine("result of function");
            Console.WriteLine(Reverse(toBeReversed));

            
            
            //task6
            
             Console.WriteLine("task6");
            
            List<string> names = new List<string>();
            Console.WriteLine(names.Count());

            names.Add("William");
            if (names.Count() > 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine(names.Count());
            Console.WriteLine(names[2]);

            foreach (string name in names)
            {
                Console.WriteLine(name);

            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + " " + names[i]);

            }
            
            names.RemoveAt(1);
            foreach (string name in names)
            {
                Console.WriteLine(name);

            }

            names.Clear();
            Console.WriteLine(names.Count());

            

            //task7
             Console.WriteLine("task7");
            Dictionary<int, string> dic = new Dictionary<int, string>();
            
            if (dic.Count() == 0)
            {
                Console.WriteLine("empty");
            } else
            {
                Console.WriteLine("populated");
            }

            dic.Add(97, "a");
            dic.Add(98,"b");
            dic.Add(99, "c");
            dic.Add(65, "A");
            dic.Add(66, "B");
            dic.Add(67, "C");

            
            foreach (KeyValuePair<int, string> kvp in dic)
                Console.Write(kvp.Key);

            Console.WriteLine();

            foreach (KeyValuePair<int, string> kvp in dic)
                Console.Write(kvp.Value);

            dic.Add(68, "D");

            Console.WriteLine(dic.Count());
            Console.WriteLine(dic[99]);

            dic.Remove(97);

            if (!dic.ContainsKey(100))
            {
                Console.WriteLine("false");
            }

            dic.Clear();
            Console.WriteLine(dic.Count());
            

            //task8
             Console.WriteLine("task8");
            List<string> listA = new List<string> { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> listB = listA;

            if (listA.Contains("Durian"))
            {
                Console.WriteLine("true");
            }

            listB.Remove("Durian");
            listA.Insert(3, "Kiwifruit");

            Console.WriteLine(listA.Count() + " compared " +listB.Count());
            Console.WriteLine(listA.IndexOf("Avocado"));
            Console.WriteLine(listB.IndexOf("Durian"));

            listB.AddRange(new string[] { "Passion fruit", "Pomelo" });

            Console.WriteLine(listA[2]);

            foreach (var item in listA)
            {
                Console.Write(item + ",") ;
            }

            Console.WriteLine();    
            foreach (var item in listB)
            {
                Console.Write(item + ",");
            }
            
            Console.WriteLine("task9");
            //task9
            Dictionary<string, string> dic2 = new Dictionary<string, string> ();
            dic2.Add("978-1-60309-452-8","A Letter to Jo");
            dic2.Add("978-1-60309-459-7", "Lupus");
            dic2.Add("978-1-60309-444-3", "Red Panda and Moon Bear");
            dic2.Add("978-1-60309-461-0", "The Lab");

       

            foreach (KeyValuePair<string, string> item in dic2)
            {
                Console.WriteLine(item.Value + " (ISBN:" + item.Key.ToString() + ")");
            }

            dic2.Remove("978-1-60309-444-3");
            dic2.Remove("The Lab");

            dic2.Add("978-1-60309-450-4", "They Called Us Enemy");
            dic2.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            if (dic2.ContainsKey("478-0-61159-424-8"))
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine(dic2["978-1-60309-453-5"]);
            
            //task10
            Console.WriteLine("task10");
            List<int> listS = new List<int> {500, 1000, 1250, 175, 800, 120};


            Console.WriteLine(listS.Sum());
            Console.WriteLine(listS.Max());
            Console.WriteLine(listS.Min());
            Console.WriteLine(listS.Average());
            

            //task11
            Console.WriteLine("task11");

            string person = "";
            Dictionary<string, string> dic3 = new Dictionary<string, string> { 
                { "William A. Lathan", "405-709-1865" } ,
                {"John K. Miller",  "402-247-8568" },
                {"Hortensia E. Foster", "606-481-6467" },
                {"Amanda D. Newland", "319-243-5613" },
                {"Brooke P. Askew", "307-687-2982" }       
            };

            Console.WriteLine(dic3["John K. Miller"]);

            foreach (var pair in dic3)
            {
                if (pair.Value == "307-687-2982")
                {
                    person = pair.Key;
                }
            }
            Console.WriteLine(person);

            if (!dic3.ContainsKey("Chris E.Myers"))
            {
                Console.WriteLine("No");
            }
            else
                Console.Write("Yes");

            
            //task12
            Console.WriteLine("task12");

            List<string> listSh = new List<string> { "eggs", "milk", "fish", "apples", "bread", "chicken" };

            if (listSh.Contains("milk"))
                Console.WriteLine("yes");
            else Console.WriteLine("no");

            if (listSh.Contains("bananas"))
                Console.WriteLine("yes");
            else Console.WriteLine("no");
            
            //task13
            Console.WriteLine("task13");
            Dictionary<string, int> dic4 = new Dictionary<string, int> {
                {"Eggs", 200} ,
                {"Milk", 200 },
                {"Fish", 400 },
                {"Apples", 150 },
                {"Bread", 50 },
                {"Chicken", 550 }
            };

            Console.WriteLine(dic4["Fish"]);
            int maxP = 0;
            double sumP = 0;
            int counterP = 0;
            bool exactP = false;
            int minP = 0;
            string cheapesP = "";

            foreach (int value in dic4.Values)
            {
                if (value > maxP)
                {
                    maxP = value;
                }

                sumP += value;

                if (value < 300)
                {
                    counterP++;
                }

                if (value == 125)
                {
                    exactP = true;
                }

            }



            Console.WriteLine("the fish is: " + maxP + "!!!!");
            Console.WriteLine(sumP / dic4.Count());
            Console.WriteLine(counterP);
            Console.WriteLine(exactP);


            foreach (KeyValuePair<string, int> item in dic4)
            {

               for (int i = 0; i < dic4.Count(); i++)
                {
                    if (item.Value < maxP)
                    {
                        maxP = item.Value;
                        cheapesP = item.Key;
                    }

                }

            }

            Console.WriteLine(cheapesP);

            
            //task14
            Console.WriteLine("task14");
            Dictionary<string, int> dic5 = new Dictionary<string, int> {
                {"Eggs", 200} ,
                {"Milk", 200 },
                {"Fish", 400 },
                {"Apples", 150 },
                {"Bread", 50 },
                {"Chicken", 550 }
            };


            foreach (KeyValuePair<string, int> item in dic5)
            {
                if (item.Value <= 200)
                {
                    Console.WriteLine(item.Key);
                }

            }

            foreach (KeyValuePair<string, int> item in dic5)
            {
                if (item.Value > 150)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }

            }

                     
            //task15
            Console.WriteLine("task15");
            Dictionary<string, double> dicP = new Dictionary<string, double> {
                {"Milk", 1.07} ,
                {"Rice", 1.59 },
                {"Eggs", 3.14 },
                {"Cheese", 12.60 },
                {"Chicken breasts", 9.40 },
                {"Apples", 2.31 },
                {"Tomato", 2.58 },
                {"Potato", 1.75 },
                {"Onion", 1.10 }
            };

            Dictionary<string, int> dicB = new Dictionary<string, int> {
                {"Milk", 3} ,
                {"Rice", 2 },
                {"Eggs", 2 },
                {"Cheese", 1 },
                {"Chicken breasts", 4 },
                {"Apples", 1 },
                {"Tomato", 2 },
                {"Potato", 1}
            };

            Dictionary<string, int> dicA = new Dictionary<string, int> {
                {"Rice", 1 },
                {"Eggs", 5 },
                {"Chicken breasts", 2 },
                {"Apples", 1 },
                {"Tomato", 10 }
            };


            double sumB = 0;
            double sumA = 0;

            int prodQB = 0;
            int prodQA = 0;

            foreach (KeyValuePair<string, int> item in dicB)
            {

                sumB = sumB + item.Value * dicP[item.Key];
                prodQB += item.Value;

            }

            foreach (KeyValuePair<string, int> item in dicA)
            {

                sumA = sumA + item.Value * dicP[item.Key];
                prodQA += item.Value;
            }


            Console.WriteLine(sumB);
            Console.WriteLine(sumA);

            string[] products = { "Rice", "Potato", "Ham", "Apples" };

            foreach (string product in products)
            {

                if (!dicB.ContainsKey(product) && !dicA.ContainsKey(product))
                {
                    Console.WriteLine($"noone bought {product}");
                }
                else if (dicB.ContainsKey(product) && !dicA.ContainsKey(product))
                {
                    Console.WriteLine($"Bob bought more {product}");
                } 
                else if (!dicB.ContainsKey(product) && dicA.ContainsKey(product))
                {
                    Console.WriteLine($"Bob bought more {product}");
                } 
                else if (dicB[product] < dicA[product])
                {
                    Console.WriteLine($"Bob bought more {product}");
                }
                else if (dicB[product] > dicA[product])
                {
                    Console.WriteLine($"Bob bought more {product}");
                }
                else if (dicB[product] == dicA[product])
                {
                    Console.WriteLine($"Both bought the same of {product}");
                }

            }

            if (dicB.Count() > dicA.Count())
            {
                Console.WriteLine("Bob bought more different items");
            } else if (dicB.Count() < dicA.Count())
            {
                Console.WriteLine("Bob bought more different items");
            } else
            {
                Console.WriteLine("the same");
            }

            if (prodQB > prodQA)
            {
                Console.WriteLine("Bob bought more items");
            }
            else if (prodQB < prodQA)
            {
                Console.WriteLine("Alice bought more items");
            }
            else
            {
                Console.WriteLine("noone");
            }



        }



    }
    }