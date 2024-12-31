using OOP_01.Enums;

namespace OOP_01.Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PART01 Try all what we have learned in the lecture.
            #region person
            //Person person = new Person();
            //person.Id = 1;
            //person.Name = "sara";
            //person.Gender = Gender.Female;
            //Console.WriteLine(person.Gender);
            #endregion
            #region Grade
            //Grade grade = Grade.A;
            //if(grade == Grade.A)
            //{
            //    Console.WriteLine("Excelant");
            //}
            //else if (grade == Grade.B)
            //{
            //    Console.WriteLine("VeryGood");
            //}
            //else if (grade == Grade.C)
            //{
            //    Console.WriteLine("Good");
            //}
            //else 
            //{
            //    Console.WriteLine("GoodLuckNextTime");
            //}
            #endregion
            #region Ex02
            //Student student = new Student();
            //bool isparsed;
            //Console.WriteLine("please enter student data :");
            //Console.WriteLine("Id => ");
            //int id;
            //do
            //{
            //    isparsed = int.TryParse(Console.ReadLine(), out id);
            //    if (!isparsed)
            //        Console.WriteLine("Invalid input");

            //} while (!isparsed);
            //student.Id = id;

            //Console.WriteLine("Name => ");
            //student.Name = Console.ReadLine();

            //Console.WriteLine("Gender => ");
            //object gender;
            //do
            //{
            //    isparsed = Enum.TryParse(typeof(Gender),Console.ReadLine(),true,out gender);
            //    if (!isparsed)
            //        Console.WriteLine("Invalid input");

            //} while (!isparsed);
            //student.Gender = (Gender)gender;

            //Console.WriteLine("Grade => ");
            //object grade;
            //do
            //{
            //    isparsed = Enum.TryParse(typeof(Grade), Console.ReadLine(), true, out grade);
            //    if (!isparsed)
            //        Console.WriteLine("Invalid input");

            //} while (!isparsed);
            //student.Grade = (Grade)grade;

            //Console.WriteLine("Branch => ");
            //object branch;
            //do
            //{
            //    isparsed = Enum.TryParse(typeof(Branch), Console.ReadLine(),true ,out branch);
            //    if (!isparsed)
            //        Console.WriteLine("Invalid input");
            //} while (!isparsed);
            //student.Branch = (Branch)branch;

            //Console.WriteLine($"student details: Id ={student.Id} , Name ={student.Name} ,Gender ={student.Gender}, Grade ={student.Grade},Branch {student.Branch }");
            #endregion
            
            // PART 02
            #region Q01 WeekDays
            //Console.WriteLine("Days of the week:");
            //foreach (string day in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Q02 seasons 
            //Console.WriteLine("Enter a season :");
            //string Input;
            //Season season = (Season)Enum.Parse(typeof(Season), Console.ReadLine(), true);
            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //}
            #endregion
            #region Q03 Permissions
            //Person person = new Person();
            //person.Id = 1;
            //person.permissions = person.permissions | permissions.Read;
            //person.permissions = person.permissions | permissions.Write;
            //Console.WriteLine($"Permissions after adding Read and Write: {person.permissions}");

            //person.permissions = person.permissions & permissions.Write;
            //Console.WriteLine($"Permissions after Remove Write: {person.permissions}");

            //bool WritePermission = (person.permissions & permissions.Write) == permissions.Write;
            //Console.WriteLine($"Has Write Permission: {WritePermission}");
            #endregion
            #region Q04 Colors
            //Console.WriteLine("Enter a color name :");
            //string userColor = Console.ReadLine();

            //try
            //{
            //    Colors color = (Colors)Enum.Parse(typeof(Colors), userColor, true);
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //catch 
            //{
            //    Console.WriteLine($"{userColor} is not a primary color.");
            //}
            #endregion
        }
    }
}
