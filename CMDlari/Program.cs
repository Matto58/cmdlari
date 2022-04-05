public class cmdlari
{
    public class app
    {
        public int sweet = 3;
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

            return "Známka: " + grade;
        }
        public static string grades2avg(string n, bool minus)
        {
            double average = 0;
            bool mistake = false;
            int n2 = int.Parse(n);
            
            for (int i = 0; i < n2; i++)
            {
                mistake = false;
                Console.WriteLine("Zadejte známku " + (i + 1) + ":");
                string grade = Console.ReadLine();
                int grade2 = int.Parse(grade);

                /* First version with weight:
                   if (grade > 5 || grade < 1 || weight > 10 || weight < 1) {
                       Console.WriteLine("Zadejte prosím platnou známku (1-5) nebo váhu (1-10)");
                       i--;
                   } else {
                       average += grade * weight;
                       n3 += weight;
                   }
                */
                // Latest version:
                if (minus) 
                {
                    if (grade == "1")
                    {
                        average += 1;
                    }
                    else if (grade == "1-")
                    {
                        average += 1.5;
                    }
                    else if (grade == "2")
                    {
                        average += 2;
                    }
                    else if (grade == "2-")
                    {
                        average += 2.5;
                    }
                    else if (grade == "3")
                    {
                        average += 3;
                    }
                    else if (grade == "3-")
                    {
                        average += 3.5;
                    }
                    else if (grade == "4")
                    {
                        average += 4;
                    }
                    else if (grade == "4-")
                    {
                        average += 4.5;
                    }
                    else if (grade == "5")
                    {
                        average += 5;
                    }
                    else
                    {
                        Console.WriteLine("Zadejte prosím platnou známku (1-5).");
                        i--;
                        mistake = true;
                    }
                }
                else
                {
                    if (grade2 > 5 || grade2 < 1)
                    {
                        Console.WriteLine("Zadejte prosím platnou známku (1-5).");
                        i--;
                        mistake = true;
                    }
                    else
                    {
                        average += grade2;
                    }
                }

            }
            if (n2 != 0)
            {
                average /= n2;
                return average.ToString();
            }
            else
            {
                return "Bylo zadáno menší číslo než 1";
            }


        }
        public static void Main(string[] args)
        {
            info.version iv = new info.version();
            app App = new app();
            if (args.Length == 0)
            {
                Console.WriteLine("CMDláři " + iv.id);

                Console.WriteLine("Použití: cmdlari [jazyk] [příkaz] [parametry]");
                Console.WriteLine("Jazyky: čeština, angličtina, němčina");
                Console.WriteLine("Příkazy:\nprůměr na známku (-pz/--prumer-na-znamku)\nznámky na průměr (-zp/--znamky-na-prumer)\nznámky na průměr s mínusem (-zpm/--znamky-na-prumer-s-minusem)\n");
                Console.WriteLine("Parametry:\n[průměr známek] (-pz/--prumer-na-znamku)\n[počet známek] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n");

                Console.WriteLine("Usage: cmdlari [command] [parameters]");
                Console.WriteLine("Languages: Czech, English, German");
                Console.WriteLine("Commands:\naverage to grade (-pz/--prumer-na-znamku)\ngrades to average (-zp/--znamky-na-prumer)\ngrades to average with minus (-zpm/--znamky-na-prumer-s-minusem)\n");
                Console.WriteLine("Parameters:\n[average grade] (-pz/--prumer-na-znamku)\n[number of grades] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n");
                
                Console.WriteLine("Verwendung: cmdlari [Befehl] [Parameter]");
                Console.WriteLine("Sprache: Tschechisch, Englisch, Deutsch");
                Console.WriteLine("Befehle:\nDurchschnitt zu Note (-pz/--prumer-na-znamku)\nNoten zu Durchschnitt (-zp/--znamky-na-prumer)\nNoten zu Durchschnitt mit Minus (-zpm/--znamky-na-prumer-s-minusem)\n");
                Console.WriteLine("Parameter:\n[Durchschnitt Note] (-pz/--prumer-na-znamku)\n[Anzahl Noten] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n");
            }
            else
            {
                if (args[0] == "-cz")
                {
                    Console.Write("Vítejte v CMDlářích, ");
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
                        case 2:
                            Console.Write("verze ");
                            break;
                    }
                    Console.Write(iv.major + "." + iv.minor + "." + iv.patch + "\n");
                    Console.WriteLine("Sestavení " + iv.build + ", identifikátor " + iv.id + "\n");
                    if (args.Length == 0)
                    {
                        Console.WriteLine("Použití: cmdlari [příkaz] [parametry]");
                        Console.WriteLine("Příkazy:\nprůměr na známku (-pz/--prumer-na-znamku)\nznámky na průměr (-zp/--znamky-na-prumer)\nznámky na průměr s mínusem (-zpm/--znamky-na-prumer-s-minusem)\n");
                        Console.WriteLine("Parametry:\n[průměr známek] (-pz/--prumer-na-znamku)\n[počet známek] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n");

                    }
                    else if (args.Length < App.sweet && args.Length != 0)
                    {
                        Console.WriteLine("Není zadáno dostatek argumentů");
                        return;
                    }
                    else if (args.Length > App.sweet)
                    {
                        Console.WriteLine("Zadáno příliš mnoho argumentů");
                        return;
                    }
                    else
                    {
                        if (args[1] == "--prumer-na-znamku" || args[1] == "-pz")
                        {
                            Console.WriteLine(avg2grade(args[2]));
                        }
                        else if (args[1] == "--znamky-na-prumer" || args[1] == "-zp")
                        {
                            Console.WriteLine(grades2avg(args[2], false));
                        }
                        else if (args[1] == "--znamky-na-prumer-s-minusem" || args[1] == "-zpm") {
                            Console.WriteLine(grades2avg(args[2], true));
                        }
                        else
                        {
                            Console.WriteLine("Neznámý argument");
                        }
                    } 
                }
                else if (args[0] == "-en")
                {
                    Console.Write("Welcome to CMDlari, ");
                    if (iv.dev)
                    {
                        Console.Write("development ");
                    }
                    switch (iv.type)
                    {
                        case 0:
                            Console.Write("alpha ");
                            break;
                        case 1:
                            Console.Write("beta ");
                            break;
                        case 2:
                            Console.Write("version ");
                            break;
                    }
                    Console.Write(iv.major + "." + iv.minor + "." + iv.patch + "\n");
                    Console.WriteLine("Build " + iv.build + ", identifier " + iv.id + "\n");
                    if (args.Length == 0)
                    {
                        Console.WriteLine("Usage: cmdlari [command] [parameters]");
                        Console.WriteLine("Commands:\naverage to grade (-pz/--prumer-na-znamku)\ngrades to average (-zp/--znamky-na-prumer)\ngrades to average with minus (-zpm/--znamky-na-prumer-s-minusem)\n");
                        Console.WriteLine("Parameters:\n[average grade] (-pz/--prumer-na-znamku)\n[number of grades] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n");

                    }
                    else if (args.Length < App.sweet && args.Length != 0)
                    {
                        Console.WriteLine("Not enough arguments");
                        return;
                    }
                    else if (args.Length > App.sweet)
                    {
                        Console.WriteLine("Too many arguments");
                        return;
                    }
                    else
                    {
                        if (args[1] == "--prumer-na-znamku" || args[1] == "-pz")
                        {
                            Console.WriteLine(avg2grade(args[2]));
                        }
                        else if (args[1] == "--znamky-na-prumer" || args[1] == "-zp")
                        {
                            Console.WriteLine(grades2avg(args[2], false));
                        }
                        else if (args[1] == "--znamky-na-prumer-s-minusem" || args[1] == "-zpm")
                        {
                            Console.WriteLine(grades2avg(args[2], true));
                        }
                        else
                        {
                            Console.WriteLine("Unknown argument");
                        }
                    }
                }
                else if (args[0] == "-de")
                {
                    Console.Write("Willkommen in CMDlari, ");
                    if (iv.dev)
                    {
                        Console.Write("Entwickler ");
                    }
                    switch (iv.type)
                    {
                        case 0:
                            Console.Write("alpha ");
                            break;
                        case 1:
                            Console.Write("beta ");
                            break;
                        case 2:
                            Console.Write("Version ");
                            break;
                    }
                    Console.Write(iv.major + "." + iv.minor + "." + iv.patch + "\n");
                    Console.WriteLine("Build " + iv.build + ", Identifier " + iv.id + "\n");
                    if (args.Length == 0)
                    {
                        Console.WriteLine("Verwendung: cmdlari [Befehl] [Parameter]");
                        Console.WriteLine("Befehle:\nDurchschnitt zu Note (-pz/--prumer-na-znamku)\nNoten zu Durchschnitt (-zp/--znamky-na-prumer)\nNoten zu Durchschnitt mit Minus (-zpm/--znamky-na-prumer-s-minusem)\n");
                        Console.WriteLine("Parameter:\n[Durchschnitt Note] (-pz/--prumer-na-znamku)\n[Anzahl Noten] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n");

                    }
                    else if (args.Length < App.sweet && args.Length != 0)
                    {
                        Console.WriteLine("Nicht genug Argumente");
                        return;
                    }
                    else if (args.Length > App.sweet)
                    {
                        Console.WriteLine("Zu viele Argumente");
                        return;
                    }
                    else
                    {
                        if (args[1] == "--prumer-na-znamku" || args[1] == "-pz")
                        {
                            Console.WriteLine(avg2grade(args[2]));
                        }
                        else if (args[1] == "--znamky-na-prumer" || args[1] == "-zp")
                        {
                            Console.WriteLine(grades2avg(args[2], false));
                        }
                        else if (args[1] == "--znamky-na-prumer-s-minusem" || args[1] == "-zpm")
                        {
                            Console.WriteLine(grades2avg(args[2], true));
                        }
                        else
                        {
                            Console.WriteLine("Unbekannter Befehl");
                        }
                    }
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
            public int minor = 2;
            public int patch = 0;
            public int build = 16;
            public int id = 220405;
        }
    }
    public class lang {
        public class CZ_cs {
            public string welcome = "Vítejte v CMDlářích, ";
            public string build = "Sestavení ";
            public string alpha = "alfa ";
            public string beta = "beta ";
            public string release = "verze ";
            public string dev = "vývojářská ";
            public string argfew = "Není zadáno dostatek argumentů";
            public string argmany = "Zadáno příliš mnoho argumentů";
            public string argunk = "Neznámý argument";
            public string cmds = "Příkazy:\nprůměr na známku (-pz/--prumer-na-znamku)\nznámky na průměr (-zp/--znamky-na-prumer)\nznámky na průměr s mínusem (-zpm/--znamky-na-prumer-s-minusem)\n";
            public string parameters = "Parametry:\n[průměr známek] (-pz/--prumer-na-znamku)\n[počet známek] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n";
        }
        public class US_en {
            public string welcome = "Welcome to CMDláři, ";
            public string build = "Build ";
            public string alpha = "alpha ";
            public string beta = "beta ";
            public string release = "version ";
            public string dev = "developer ";
            public string argfew = "Not enough arguments";
            public string argmany = "Too many arguments";
            public string argunk = "Unknown argument";
            public string cmds = "Commands:\naverage to grade (-pz/--prumer-na-znamku)\ngrades to average (-zp/--znamky-na-prumer)\ngrades to average with minus (-zpm/--znamky-na-prumer-s-minusem)\n";
            public string parameters = "Parameters:\n[average grade] (-pz/--prumer-na-znamku)\n[number of grades] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n";
        }
        public class DE_de {
            public string welcome = "Willkommen in CMDlari, ";
            public string build = "Build ";
            public string alpha = "alpha ";
            public string beta = "beta ";
            public string release = "version ";
            public string dev = "Entwickler ";
            public string argfew = "Nicht genug Argumente";
            public string argmany = "Zu viele Argumente";
            public string argunk = "Unbekanntes Argument";
            public string cmds = "Befehle:\nDurchschnitt zu Note (-pz/--prumer-na-znamku)\nNoten zu Durchschnitt (-zp/--znamky-na-prumer)\nNoten zu Durchschnitt mit Minus (-zpm/--znamky-na-prumer-s-minusem)\n";
            public string parameters = "Parameter:\n[Durchschnitt Note] (-pz/--prumer-na-znamku)\n[Anzahl Noten] (-zp/--znamky-na-prumer/--zpm/--znamky-na-prumer-s-minusem)\n";
        }
    }
}