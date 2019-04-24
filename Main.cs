using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCreating a Dictionary of Student Details.\n");
            Console.WriteLine("===============================================================================\n");


            MyDictionary<Details> details = new MyDictionary<Details>();
            Console.WriteLine("\nFollowing students available in Data Structure\n");
            Console.WriteLine("\n");
            details.set(00158268, new Details("John", 00158268, 3.5, "Computer Science", "john@gmail.com"));
            Console.WriteLine("\n");
            details.set(00158300, new Details("Sam", 00158300, 4, "Medical Science", "sam@gmail.com"));
            Console.WriteLine("\n");
            details.set(00159754, new Details("Clara", 00159754, 3.7, "Computer Science", "clara@gmail.com"));
            Console.WriteLine("\n");
            details.set(00168754, new Details("Tracy", 00168754, 3.0, "Dental Science", "tracy@gmail.com"));
            Console.WriteLine("\n");
            details.set(00152380, new Details("Stephanie", 00152380, 3.3, "Mathematics", "stephanie@gmail.com"));
            Console.WriteLine("\n");

            while (true){
                Console.WriteLine("\nDo you want to add more student details?Enter Y or N.\n"); 
                string add = Console.ReadLine();
                if (add == "Y") { 
                    Console.WriteLine("\nStudent ID:\n");
                    string id = Console.ReadLine();
                    Console.WriteLine("\nStudent name:\n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nStudent GPA:\n");
                    string gpa = Console.ReadLine();
                    Console.WriteLine("\nStudent Major:\n");
                    string major = Console.ReadLine();
                    Console.WriteLine("\nStudent Email:\n");
                    string email = Console.ReadLine();
                    details.set(Convert.ToInt32(id), new Details(name, Convert.ToInt32(id), Convert.ToDouble(gpa), major, email));
                }
                else 
                    break;
            }


            // get details
            while (true)
            {
                Console.WriteLine("\nDo you want to retrieve student details? Enter Y or N.\n");
                string add = Console.ReadLine();
                if (add == "Y")
                {
                    Console.WriteLine("\nEnter Student ID:\n");
                    string id = Console.ReadLine();
                    details.get(Convert.ToInt32(id));
                }
                else
                    break;
            }
        }
    }
}
