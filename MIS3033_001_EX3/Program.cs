// MIS 3033 001 Exercise
// Fenix Strickland


// add xinglong.ju@ou.edu as the collaborator on GitHub
// 

//****************************************************
// 1.Add a new student's information
// 2.Show all the students' information
// 3. Show one student's information for an given Student ID
// 4. Edit one student's information for an given Student ID
// 5. Delete one student's information for an given Student ID
// 6. Show the student's information with highest grade
// 7. Show the average grade of all the students
// Press other keys to exit
//****************************************************

//Enter your option: 

//Add a new student
//Enter the ID: 
//Enter the name: 
//Enter the grade:

//protected override void OnConfiguring(DbContextOptionsBuilder options)
//{

//    options.UseSqlite(@"Data Source=Students.db");
//}
using MIS3033_001_EX3;
using MIS3033_001_EX3.Data;

using StuDBCon _db = new StuDBCon();

string userChoiceStr;

do
{
    Console.WriteLine("*********************************************");
    Console.WriteLine("Menu options: ");
    Console.WriteLine("1.Add a new student's information");
    Console.WriteLine("2.Show all the students' informaion");
    Console.WriteLine("3.Show one student's information for a given Student ID");
    Console.WriteLine("4.Edit one student's information for a given Student ID");
    Console.WriteLine("5.Delete one student's information for a given Student ID");
    Console.WriteLine("6.Show the student's information with highest grade");
    Console.WriteLine("7.Show the average grade of all students");
    Console.WriteLine("Prerss other keys to exit");
    Console.WriteLine("*********************************************");

    Console.Write("Enter your option: ");
    userChoiceStr = Console.ReadLine();

    if (userChoiceStr == "1")
    {
        Console.WriteLine("Add a new student");
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter grade: ");
        string gradeStr = Console.ReadLine();
        double grade = Convert.ToDouble(gradeStr);

        Student stu = new Student() { ID = id, name = name, grade = grade };
        _db.students.Add(stu);
        _db.SaveChanges();
        Console.WriteLine("New student information added to database!");
        Console.WriteLine(stu);

    }
    else if (userChoiceStr == "2")
    {
        Console.WriteLine("All the students' information");
        foreach (var stu in _db.students)
        {
            Console.WriteLine(stu);
        }
    }
    else if (userChoiceStr == "3")
    {
        Console.WriteLine("Show one student's information for a given Student ID");
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        var r = _db.students.ToList().Where(stu => stu.ID == id).ToList();
        if (r.Count > 0)
        {
            Console.WriteLine(r[0]);
        }
        else
        {
            Console.WriteLine($"NO such students with ID {id}");
        }
    }
    else if (userChoiceStr == "4")
    {
        Console.WriteLine("Edit one student's information for a given Student ID");
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        var r = _db.students.ToList().Where(stu => stu.ID == id).FirstOrDefault();
        if (r != null)
        {
            Console.WriteLine("The current information is: ");
            Console.Write(r);
            Console.Write("Enter new name: ");
            string name = Console.ReadLine();
            Console.Write("Enter new grade: ");
            string gradeStr = Console.ReadLine();
            double grade = Convert.ToDouble(gradeStr);

            r.name = name;
            r.grade = grade;

            _db.SaveChanges();
            Console.WriteLine("Save edition successfully!!");
            Console.WriteLine("The new information is: ");
            Console.WriteLine(r);

        }
    }
    else if (userChoiceStr == "5")
    {
        Console.WriteLine("Delete one student's information for a given Student ID");
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        var r = _db.students.ToList().Where(stu => stu.ID == id).FirstOrDefault();
        if (r != null)
        {
            _db.Remove(r);

            _db.SaveChanges();

            Console.WriteLine("Delete successfully!");
            Console.WriteLine("The deleted information is: ");
            Console.WriteLine(r);
        }
        else
        {
            Console.WriteLine($"NO such student with ID {id}");
        }
    }

    else if (userChoiceStr == "6")
    {
        Console.WriteLine("Show the student's information with highest grade");

        var r = _db.students.ToList().MaxBy(stu => stu.grade);
        if (r != null)
        {
            Console.WriteLine("The student with highest grade: ");
            Console.WriteLine(r);

        }
    }
    else if (userChoiceStr == "7")
    {
        Console.WriteLine("Show the average grade of all the students");

        var r = _db.students.Average(stu => stu.grade);

        string str = string.Format($"The average grade is: {r:f2}");
        Console.WriteLine(str);

    }


}
while (userChoiceStr == "1" || userChoiceStr == "2" || userChoiceStr == "3" || userChoiceStr == "4" || userChoiceStr == "5" || userChoiceStr == "6" || userChoiceStr == "7");


Console.ReadLine();
