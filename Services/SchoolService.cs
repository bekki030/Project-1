using Models;
using Group = Models.Group;

namespace ConsoleApp1.Services;

public partial class SchoolService
{
    private List<Specialist> specialists = new List<Specialist>();
    private List<Teacher> teachers = new List<Teacher>();
    private List<Students> students = new List<Students>();
    private List<Group> groups = new List<Group>();
    private List<Room> rooms = new List<Room>();
    public Dictionary<int, Teacher> dict = new Dictionary<int, Teacher>();
    public void AttachSpecialistToTeacher(int teacherId, int specialistId)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var specialist = specialists.FirstOrDefault(s => s.Id == specialistId);

        if (teacher == null || specialist == null)
        {
            Console.WriteLine("Invalid teacher or specialist ID.");
            return;
        }

        var teacherSpecialist = new TeacherSpecialist
        {
            TeacherId = teacherId,
            Teacher = teacher,
            SpecialistId = specialistId,
            Specialist = specialist
        };

        teacher.TeacherSpecialists.Add(teacherSpecialist);
        specialist.TeacherSpecialists.Add(teacherSpecialist);
    }
    public void AttachTeacherToRoomGroup(int roomId, int groupId, int teacherId,string startTime,string endTime)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var group = groups.FirstOrDefault(g => g.Id == groupId);
        var room = rooms.FirstOrDefault(r => r.Id == roomId);

        if (teacher == null || group == null || room == null)
        {
            Console.WriteLine("Invalid teacher or Room or Group ID.");
            return;
        }
        var roomTeacherGroup = new RoomTeacherGroup
        {
            TeacherId = teacherId,
            Teacher = teacher,
            Group = group,
            GroupId = groupId,
            Room = room,
            RoomId = roomId,
            StartTime = startTime,
            EndTime = endTime
        };
        room.RoomTeacherGroup.Add(roomTeacherGroup);
        group.RoomTeacherGroup.Add(roomTeacherGroup);
        teacher.RoomTeacherGroup.Add(roomTeacherGroup);
    }
    public void AttachRoomTeacherGroupStudent(int roomId, int groupId, int teacherId, int studentId, RoomTeacherGroup roomTeacherGroupStudent)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var group = groups.FirstOrDefault(g => g.Id == groupId);
        var room = rooms.FirstOrDefault(r => r.Id == roomId);
        var student = students.FirstOrDefault(s => s.Id == studentId);
        if (teacher == null || group == null || room == null || student == null)
        {
            Console.WriteLine("Invalid teacher or Room or Group or Student ID.");
            return;
        }
        var roomTeacherGroupStudent1 = new RoomTeacherGroupStudent
        {
            TeacherId = teacherId,
            Teacher = teacher,
            Group = group,
            GroupId = groupId,
            Room = room,
            RoomId = roomId,
            Students = student,
            StudentId = studentId
        };
        room.roomTeacherGroupStudent.Add(roomTeacherGroupStudent1);
        group.roomTeacherGroupStudent.Add(roomTeacherGroupStudent1);
        teacher.roomTeacherGroupStudent.Add(roomTeacherGroupStudent1);
        student.roomTeacherGroupStudent.Add(roomTeacherGroupStudent1);
    }
    public void Report()
    {
        if (teachers.Count > 0)
        {
            int count = 1;
            foreach (var teacher in teachers)
            {
                dict[count] = teacher;
                Console.WriteLine($"{count++}.{teacher.Name} : {teacher.RoomTeacherGroup.Count}");
            }
        }
    }
    public void FullTable(int teacherId)
    {
        int count = 1;
        var teacher = dict[teacherId];
        foreach (var roomgroup in teacher.RoomTeacherGroup)
        {
            Console.WriteLine($"{count++}. Group: {roomgroup.Group.Name},   Room: {roomgroup.Room.Name},  Time: {roomgroup.StartTime} - {roomgroup.EndTime}");
        }
    }

    public void GetList()
    {
        if (teachers.Count > 0)
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher: {teacher.Name}");
                foreach (var ts in teacher.TeacherSpecialists)
                {
                    Console.WriteLine($"  Specialist: {ts.Specialist.Name}, Stack: {ts.Specialist.Stack}");
                }
            }
        else
            Console.WriteLine("Teacher lis is empty.");
    }
    public void RoomTeacherGroupList()
    {
        if (rooms.Count > 0)
        {
            foreach (var rooms in rooms)
            {
                Console.WriteLine($"Room: {rooms.Name}");

                foreach (var tch in rooms.RoomTeacherGroup)
                {
                    Console.WriteLine($" Teacher: {tch.Teacher.Name}");
                }
                foreach (var gr in rooms.RoomTeacherGroup)
                {
                    Console.WriteLine($"  Group: {gr.Group.Name}");
                }
            }
        }
        else
        {
            Console.WriteLine("Room lis is empty.");
        }
    }
    public void RoomTeacherGroupStudentList()
    {
        if (rooms.Count > 0)
        {
            foreach (var rooms in rooms)
            {
                Console.WriteLine($"Room: {rooms.Name}");

                foreach (var tch in rooms.RoomTeacherGroup)
                {
                    Console.WriteLine($" Teacher: {tch.Teacher.Name}");
                }
                foreach (var gr in rooms.RoomTeacherGroup)
                {
                    Console.WriteLine($"  Group: {gr.Group.Name}");
                }
                foreach (var st in rooms.RoomTeacherGroup)
                {
                    Console.WriteLine($"  Student: {st.Student.Name}");
                }
            }
        }
        else
        {
            Console.WriteLine("Room lis is empty.");
        }
    }
    public void AttachExam(int roomId, int groupId, int teacherId, string startOn, string endOn)
    {
        var teacher = teachers.FirstOrDefault(t => t.Id == teacherId);
        var group = groups.FirstOrDefault(g => g.Id == groupId);
        var room = rooms.FirstOrDefault(r => r.Id == roomId);

        if (teacher == null || group == null || room == null)
        {
            Console.WriteLine("Invalid teacher or Room or Group ID.");
            return;
        }
        var exam = new Exam
        {
            TeacherId = teacherId,
            Teacher = teacher,
            Group = group,
            GroupId = groupId,
            Room = room,
            RoomId = roomId,
            StartOn = startOn,
            EndOn = endOn
        };
        room.Exams.Add(exam);
        group.Exams.Add(exam);
        teacher.Exams.Add(exam);
    }
    public void GetExam()
    {
        if (rooms.Count > 0)
        {
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room: {room.Name}");
                foreach (var gr in room.Exams)
                {
                    Console.WriteLine($"Group: {gr.Group.Name}");
                    Console.WriteLine($"Room: {gr.Room.Name}");
                    Console.WriteLine($"Teacher: {gr.Teacher.Name}");
                    Console.WriteLine($"Start On: {gr.StartOn} End On: {gr.EndOn}");
                }
            }
        }
        else
            Console.WriteLine("Room list is empty");
    }
}
