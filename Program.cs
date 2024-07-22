using ConsoleApp1.Services;

public static class Program
{
    static void Main(string[] args)
    {
        var schoolService = new SchoolService();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Specialist Operations");
            Console.WriteLine("2. Teacher Operations");
            Console.WriteLine("3. Student Operations");
            Console.WriteLine("4. Group Operations");
            Console.WriteLine("5. Room Operations");
            Console.WriteLine("6. Connections");
            Console.WriteLine("7. Report");
            Console.WriteLine("8. Exam");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    SpecialistOperations(schoolService);
                    Console.Clear();
                    break;
                case "2":
                    TeacherOperations(schoolService);
                    Console.Clear();
                    break;
                case "3":
                    StudentOperations(schoolService);
                    Console.Clear();
                    break;
                case "4":
                    GroupOperations(schoolService);
                    Console.Clear();
                    break;
                case "5":
                    RoomOperations(schoolService);
                    Console.Clear();
                    break;
                case "6":
                    Connections(schoolService);
                    Console.Clear();
                    break;
                case "7":
                    Report(schoolService);
                    Console.Clear();
                    break;
                case "8":
                    Exam(schoolService);
                    Console.Clear();
                    break;
                case "9":
                    exit = true;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    Console.Clear();
                    break;
            }
        }
    }
    static void SpecialistOperations(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Add Specialist");
            Console.WriteLine("2. Update Specialist");
            Console.WriteLine("3. Delete Specialist");
            Console.WriteLine("4. List Specialists");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Specialist Name: ");
                    var sName = Console.ReadLine();
                    Console.Write("Enter Specialist Stack: ");
                    var stack = Console.ReadLine();
                    schoolService.AddSpecialist(sName, stack);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Specialist Id: ");
                    var sId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Specialist Name: ");
                    var newSName = Console.ReadLine();
                    Console.Write("Enter Specialist Stack: ");
                    var newStack = Console.ReadLine();
                    schoolService.UpdateSpecialist(sId, newSName, newStack);
                    Console.Clear();
                    break;
                case "3":
                    Console.Write("Enter Specialist Id: ");
                    var deleteSId = int.Parse(Console.ReadLine());
                    schoolService.DeleteSpecialist(deleteSId);
                    Console.Clear();
                    break;
                case "4":
                    schoolService.ListSpecialists();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
    static void TeacherOperations(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Add Teacher");
            Console.WriteLine("2. Update Teacher");
            Console.WriteLine("3. Delete Teacher");
            Console.WriteLine("4. List Teachers");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Teacher Name: ");
                    var tName = Console.ReadLine();
                    schoolService.AddTeacher(tName);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Teacher Id: ");
                    var tId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Teacher Name: ");
                    var newTName = Console.ReadLine();
                    schoolService.UpdateTeacher(tId, newTName);
                    Console.Clear();
                    break;
                case "3":
                    Console.Write("Enter Teacher Id: ");
                    var deleteTId = int.Parse(Console.ReadLine());
                    schoolService.DeleteTeacher(deleteTId);
                    Console.Clear();
                    break;
                case "4":
                    schoolService.ListTeachers();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
    static void StudentOperations(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. List Students");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Student Name: ");
                    var stName = Console.ReadLine();
                    schoolService.AddStudents(stName);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Student Id: ");
                    var stId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    var newStName = Console.ReadLine();
                    schoolService.UpdateStudents(stId, newStName);
                    Console.Clear();
                    break;
                case "3":
                    Console.Write("Enter Student Id: ");
                    var deleteStId = int.Parse(Console.ReadLine());
                    schoolService.DeleteStudents(deleteStId);
                    Console.Clear();
                    break;
                case "4":
                    schoolService.ListStudents();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
    static void GroupOperations(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Add Group");
            Console.WriteLine("2. Update Group");
            Console.WriteLine("3. Delete Group");
            Console.WriteLine("4. List Groups");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Group Name: ");
                    var gName = Console.ReadLine();
                    schoolService.AddGroup(gName);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Group Id: ");
                    var gId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Group Name: ");
                    var newGName = Console.ReadLine();
                    schoolService.UpdateGroup(gId, newGName);
                    Console.Clear();
                    break;
                case "3":
                    Console.Write("Enter Group Id: ");
                    var deleteGId = int.Parse(Console.ReadLine());
                    schoolService.DeleteGroup(deleteGId);
                    Console.Clear();
                    break;
                case "4":
                    schoolService.ListGroup();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
    static void RoomOperations(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Add Room");
            Console.WriteLine("2. Update Room");
            Console.WriteLine("3. Delete Room");
            Console.WriteLine("4. List Room");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Room Name: ");
                    var rName = Console.ReadLine();
                    schoolService.AddRoom(rName);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Room Id: ");
                    var rId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Group Name: ");
                    var newRName = Console.ReadLine();
                    schoolService.UpdateRoom(rId, newRName);
                    Console.Clear();
                    break;
                case "3":
                    Console.Write("Enter Room Id: ");
                    var deleteRId = int.Parse(Console.ReadLine());
                    schoolService.DeleteRoom(deleteRId);
                    Console.Clear();
                    break;
                case "4":
                    schoolService.ListRoom();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
    static void Connections(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Attach Specialist to Teacher");
            Console.WriteLine("2. Attach Room, Group and Teacher");
            Console.WriteLine("3. Get List Teacher and Specialist");
            Console.WriteLine("4. Booking");
            Console.WriteLine("5. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Teacher Id: ");
                    var attTId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Specialist Id: ");
                    var attSId = int.Parse(Console.ReadLine());
                    schoolService.AttachSpecialistToTeacher(attTId, attSId);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Write("Enter Room Id: ");
                    var attRId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Group Id: ");
                    var attGId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Teacher Id: ");
                    var arrTId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Start time: ");
                    var stTime = Console.ReadLine();
                    Console.Write("Enter End time: ");
                    var endTime = Console.ReadLine();
                    schoolService.AttachTeacherToRoomGroup(attRId, attGId, arrTId, stTime, endTime);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    schoolService.GetList();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    schoolService.RoomTeacherGroupList();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "5":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
    static void Report(SchoolService schoolService)
    {
        schoolService.Report();
        Console.Write("Enter Teacher Id: ");
        var tId = int.Parse(Console.ReadLine());
        schoolService.FullTable(tId);
        Console.ReadKey();
        Console.Clear();
    }
    static void Exam(SchoolService schoolService)
    {
        bool back = false;
        while (!back)
        {
            Console.WriteLine("1. Attach exam");
            Console.WriteLine("2. Get list exam");
            Console.WriteLine("3. Back");
            Console.Write("Choose an option: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Room Id: ");
                    var attRId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Group Id: ");
                    var attGId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Teacher Id: ");
                    var arrTId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Start On: ");
                    var stOn = Console.ReadLine();
                    Console.Write("Enter End On: ");
                    var endOn = Console.ReadLine();
                    schoolService.AttachExam(attRId, attGId, arrTId, stOn, endOn);
                    Console.WriteLine("Successfully added");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    schoolService.GetExam();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Incorrect, please try again");
                    break;
            }
        }
    }
}


//using ConsoleApp1.Services;
//public static class Program
//{
//    static void Main(string[] args)
//    {
//        var schoolService = new SchoolService();
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("1. Specialist Operations");
//            Console.WriteLine("2. Teacher Operations");
//            Console.WriteLine("3. Student Operations");
//            Console.WriteLine("4. Group Operations");
//            Console.WriteLine("5. Room Operations");
//            Console.WriteLine("6. Connections");
//            Console.WriteLine("7. Report");
//            Console.WriteLine("8. Exit");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();
//            Console.Clear();
//            switch (choice)
//            {
//                case "1":
//                    SpecialistOperations(schoolService);
//                    Console.Clear();
//                    break;
//                case "2":
//                    TeacherOperations(schoolService);
//                    Console.Clear();
//                    break;
//                case "3":
//                    StudentOperations(schoolService);
//                    Console.Clear();
//                    break;
//                case "4":
//                    GroupOperations(schoolService);
//                    Console.Clear();
//                    break;
//                case "5":
//                    RoomOperations(schoolService);
//                    Console.Clear();
//                    break;
//                case "6":
//                    Connections(schoolService);
//                    Console.Clear();
//                    break;
//                case "7":
//                    Report(schoolService);
//                    Console.Clear();
//                    break;
//                case "8":
//                    exit = true;
//                    Console.Clear();
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    Console.Clear();
//                    break;
//            }
//        }
//    }

//    static void SpecialistOperations(SchoolService schoolService)
//    {
//        bool back = false;
//        while (!back)
//        {
//            Console.WriteLine("1. Add Specialist");
//            Console.WriteLine("2. Update Specialist");
//            Console.WriteLine("3. Delete Specialist");
//            Console.WriteLine("4. List Specialists");
//            Console.WriteLine("5. Back");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();


//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter Specialist Name: ");
//                    var sName = Console.ReadLine();
//                    Console.Write("Enter Specialist Stack: ");
//                    var stack = Console.ReadLine();
//                    schoolService.AddSpecialist(sName, stack);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "2":
//                    Console.Write("Enter Specialist Id: ");
//                    var sId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Specialist Name: ");
//                    var newSName = Console.ReadLine();
//                    Console.Write("Enter Specialist Stack: ");
//                    var newStack = Console.ReadLine();
//                    schoolService.UpdateSpecialist(sId, newSName, newStack);
//                    Console.Clear();
//                    break;
//                case "3":
//                    Console.Write("Enter Specialist Id: ");
//                    var deleteSId = int.Parse(Console.ReadLine());
//                    schoolService.DeleteSpecialist(deleteSId);
//                    Console.Clear();
//                    break;
//                case "4":
//                    schoolService.ListSpecialists();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "5":
//                    back = true;
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    break;
//            }
//        }
//    }

//    static void TeacherOperations(SchoolService schoolService)
//    {
//        bool back = false;
//        while (!back)
//        {
//            Console.WriteLine("1. Add Teacher");
//            Console.WriteLine("2. Update Teacher");
//            Console.WriteLine("3. Delete Teacher");
//            Console.WriteLine("4. List Teachers");
//            Console.WriteLine("5. Back");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter Teacher Name: ");
//                    var tName = Console.ReadLine();
//                    schoolService.AddTeacher(tName);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "2":
//                    Console.Write("Enter Teacher Id: ");
//                    var tId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Teacher Name: ");
//                    var newTName = Console.ReadLine();
//                    schoolService.UpdateTeacher(tId, newTName);
//                    Console.Clear();
//                    break;
//                case "3":
//                    Console.Write("Enter Teacher Id: ");
//                    var deleteTId = int.Parse(Console.ReadLine());
//                    schoolService.DeleteTeacher(deleteTId);
//                    Console.Clear();
//                    break;
//                case "4":
//                    schoolService.ListTeachers();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "5":
//                    back = true;
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    break;
//            }
//        }
//    }


//    static void StudentOperations(SchoolService schoolService)
//    {
//        bool back = false;
//        while (!back)
//        {
//            Console.WriteLine("1. Add Student");
//            Console.WriteLine("2. Update Student");
//            Console.WriteLine("3. Delete Student");
//            Console.WriteLine("4. List Students");
//            Console.WriteLine("5. Back");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter Student Name: ");
//                    var stName = Console.ReadLine();
//                    schoolService.AddStudents(stName);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "2":
//                    Console.Write("Enter Student Id: ");
//                    var stId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Student Name: ");
//                    var newStName = Console.ReadLine();
//                    schoolService.UpdateStudents(stId, newStName);
//                    Console.Clear();
//                    break;
//                case "3":
//                    Console.Write("Enter Student Id: ");
//                    var deleteStId = int.Parse(Console.ReadLine());
//                    schoolService.DeleteStudents(deleteStId);
//                    Console.Clear();
//                    break;
//                case "4":
//                    schoolService.ListStudents();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "5":
//                    back = true;
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    break;
//            }
//        }
//    }

//    static void GroupOperations(SchoolService schoolService)
//    {
//        bool back = false;
//        while (!back)
//        {
//            Console.WriteLine("1. Add Group");
//            Console.WriteLine("2. Update Group");
//            Console.WriteLine("3. Delete Group");
//            Console.WriteLine("4. List Groups");
//            Console.WriteLine("5. Back");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter Group Name: ");
//                    var gName = Console.ReadLine();
//                    schoolService.AddGroup(gName);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "2":
//                    Console.Write("Enter Group Id: ");
//                    var gId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Group Name: ");
//                    var newGName = Console.ReadLine();
//                    schoolService.UpdateGroup(gId, newGName);
//                    Console.Clear();
//                    break;
//                case "3":
//                    Console.Write("Enter Group Id: ");
//                    var deleteGId = int.Parse(Console.ReadLine());
//                    schoolService.DeleteGroup(deleteGId);
//                    Console.Clear();
//                    break;
//                case "4":
//                    schoolService.ListGroup();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "5":
//                    back = true;
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    break;
//            }
//        }
//    }


//    static void RoomOperations(SchoolService schoolService)
//    {
//        bool back = false;
//        while (!back)
//        {
//            Console.WriteLine("1. Add Room");
//            Console.WriteLine("2. Update Room");
//            Console.WriteLine("3. Delete Room");
//            Console.WriteLine("4. List Room");
//            Console.WriteLine("5. Back");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter Room Name: ");
//                    var rName = Console.ReadLine();
//                    schoolService.AddRoom(rName);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "2":
//                    Console.Write("Enter Room Id: ");
//                    var rId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Group Name: ");
//                    var newRName = Console.ReadLine();
//                    schoolService.UpdateRoom(rId, newRName);
//                    Console.Clear();
//                    break;
//                case "3":
//                    Console.Write("Enter Room Id: ");
//                    var deleteRId = int.Parse(Console.ReadLine());
//                    schoolService.DeleteRoom(deleteRId);
//                    Console.Clear();
//                    break;
//                case "4":
//                    schoolService.ListRoom();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "5":
//                    back = true;
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    break;
//            }
//        }
//    }

//    static void Connections(SchoolService schoolService)
//    {
//        bool back = false;
//        while (!back)
//        {
//            Console.WriteLine("1. Attach Specialist to Teacher");
//            Console.WriteLine("2. Attach Room, Group and Teacher");
//            Console.WriteLine("3. Get List Teacher and Specialist");
//            Console.WriteLine("4. Room and Teacher and Group List");
//            Console.WriteLine("5. Attach Room, Group and Teacher and Student");
//            Console.WriteLine("6. Back");
//            Console.Write("Choose an option: ");
//            var choice = Console.ReadLine();


//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Enter Teacher Id: ");
//                    var attTId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Specialist Id: ");
//                    var attSId = int.Parse(Console.ReadLine());
//                    schoolService.AttachSpecialistToTeacher(attTId, attSId);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "2":
//                    Console.Write("Enter Room Id: ");
//                    var attRId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Group Id: ");
//                    var attGId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Teacher Id: ");
//                    var arrTId = int.Parse(Console.ReadLine());
//                    schoolService.AttachTeacherToRoomGroup(attRId, attGId, arrTId);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "3":
//                    schoolService.GetList();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "4":
//                    schoolService.RoomTeacherGroupList();
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "5":
//                    Console.Write("Enter Teacher Id: ");
//                    var attTeId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Specialist Id: ");
//                    var attSpId = int.Parse(Console.ReadLine());
//                    Console.Write("Enter Student id: ");
//                    var attSTId = int.Parse(Console.ReadLine());
//                    schoolService.AttachRoomTeacherGroupStudent(attTeId, attSpId,attSTId);
//                    Console.WriteLine("Successfully added");
//                    Console.ReadKey();
//                    Console.Clear();
//                    break;
//                case "6":
//                    back = true;
//                    break;
//                default:
//                    Console.WriteLine("Incorrect, please try again");
//                    break;
//            }
//        }
//    }
//    public static void Report(SchoolService schoolService)
//    {
//        schoolService.Report();
//        Console.ReadKey();
//        Console.Clear();
//    }

//}

