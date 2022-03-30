public class cmdlari
{
    public class app
    {
        public static string avg2grade(string avg)
        {
            double d = double.Parse(avg);
            string grade = "";
            if (d <= 1.24 && d >= 1.00)
            {
                grade = "1";
            }
            else if (d >= 1.25 && d <= 1.74)
            {
                grade = "1-";
            }
            else if (d >= 1.75 && d <= 2.24)
            {
                grade = "2";
            }
            else if (d >= 2.25 && d <= 2.74)
            {
                grade = "2-";
            }
            else if (d >= 2.75 && d <= 3.24)
            {
                grade = "3";
            }
            else if (d >= 3.25 && d <= 3.74)
            {
                grade = "3-";
            }
            else if (d >= 3.75 && d <= 4.24)
            {
                grade = "4";
            }
            else if (d >= 4.25 && d <= 4.74)
            {
                grade = "4-";
            }
            else if (d >= 4.75 && d <= 5)
            {
                grade = "5";
            }
            else if (d > 5)
            {
                grade = "Číslo větší než 5";
            }
            else if (d < 1)
            {
                grade = "Číslo menší než 1";
            }
            else
            {
                grade = "Neznámá hodnota";
            }

            return grade;
        }
        public static string grades2avg(string n)
        {
            double average = 0;
            double n3 = 0;
            bool mistake = false;
            int n2 = int.Parse(n);
            for (int i = 0; i < n2; i++)
            {
                mistake = false;
                Console.WriteLine("Zadejte známku " + (i + 1) + ", přidejte \",5\" pokud končí mínusem:");
                string grade = Console.ReadLine();
                Console.WriteLine("Zadejte váhu pro známku " + (i + 1) + ":");
                double weight = float.Parse(Console.ReadLine());

                /* Old version:
                   if (grade > 5 || grade < 1 || weight > 10 || weight < 1) {
                       Console.WriteLine("Zadejte prosím platnou známku (1-5) nebo váhu (1-10)");
                       i--;
                   } else {
                       average += grade * weight;
                       n3 += weight;
                   }
                */
                // New version:
                if (grade == "1")
                {
                    average += weight;
                }
                else if (grade == "1-")
                {
                    average += 1.5 * weight;
                }
                else if (grade == "2")
                {
                    average += 2 * weight;
                }
                else if (grade == "2-")
                {
                    average += 2.5 * weight;
                }
                else if (grade == "3")
                {
                    average += 3 * weight;
                }
                else if (grade == "3-")
                {
                    average += 3.5 * weight;
                }
                else if (grade == "4")
                {
                    average += 4 * weight;
                }
                else if (grade == "4-")
                {
                    average += 4.5 * weight;
                }
                else if (grade == "5")
                {
                    average += 5 * weight;
                }
                else
                {
                    Console.WriteLine("Zadejte prosím platnou známku (1-5).");
                    i--;
                    mistake = true;
                }

                if (!mistake)
                {
                    n3 += weight;
                }

            }
            if (n2 != 0)
            {
                average /= n2;
                return (average / n3).ToString();
            }
            else
            {
                return "Bylo zadáno menší číslo než 1";
            }


        }
        public static void Main(string[] args)
        {
            info.version iv = new info.version();
            Console.WriteLine("Vítejte v CMDlářích");
            Console.Write("Verze: ");
            if (iv.dev)
            {
                Console.Write("vývojářská ");
            }
            switch (iv.type)
            {
                case 0:
                    Console.Write("alfa ");
                    break;
                case 1:
                    Console.Write("beta ");
                    break;
                default:
                    break;
            }
            Console.Write(iv.major + "." + iv.minor + "." + iv.patch + "\n");
            Console.WriteLine("Sestavení " + iv.build + "\n");
            if (args.Length < 2)
            {
                Console.WriteLine("Není zadáno dostatek argumentů");
                return;
            }
            else if (args.Length > 2)
            {
                Console.WriteLine("Zadáno příliš mnoho argumentů");
                return;
            }
            else
            {
                if (args[0] == "--prumer-na-znamku" || args[0] == "-pz")
                {
                    Console.WriteLine(avg2grade(args[1]));
                }
                else if (args[0] == "--znamky-na-prumer" || args[0] == "-zp")
                {
                    Console.WriteLine(grades2avg(args[1]));
                }
                else
                {
                    Console.WriteLine("Neznámý argument");
                }
            }
        }
    }
    public class info
    {
        public string developer = "Matto58";
        public int year = 2022;
        public class version
        {
            public int type = 1; // 0 - alpha, 1 - beta, 2 - release
            public bool dev = false;
            public string codename = "Delfín";
            public int major = 0;
            public int minor = 1;
            public int patch = 0;
            public int build = 1;
        }
    }
}