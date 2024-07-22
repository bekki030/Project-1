using Models;
using Newtonsoft.Json;
using static System.Reflection.Metadata.BlobBuilder;
using System.Net;

namespace ConsoleApp1.Services
{
    public partial class SchoolService
    {
        string jsonPath = "C:\\My works\\teacher.json";
        public void AddTeacher(string name)
        {
            int id = teachers.Count > 0 ? teachers.Max(t => t.Id) + 1 : 1;
            teachers.Add(new Teacher { Id = id, Name = name });
            string updatedJson = JsonConvert.SerializeObject(teachers);
            File.WriteAllText(jsonPath, updatedJson);
        }
        public void UpdateTeacher(int id, string name)
        {
            var teacher = teachers.FirstOrDefault(t => t.Id == id);
            if (teacher != null)
            {
                teacher.Name = name;
                string updatedJson = JsonConvert.SerializeObject(teachers);
                File.WriteAllText(jsonPath, updatedJson);
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }
        public void DeleteTeacher(int id)
        {
            var teacher = teachers.FirstOrDefault(t => t.Id == id);
            if (teacher != null)
            {
                teachers.Remove(teacher);
            }
            else
            {
                Console.WriteLine("Teacher not found.");
            }
        }
        public List<Teacher> JsonRead()
        {
            string jsonPath = "C:\\My works\\teacher.json";
            string jsonString = File.ReadAllText(jsonPath);
            teachers = JsonConvert.DeserializeObject<List<Teacher>>(jsonString);
            return teachers;

        }

        public void ListTeachers()
        {
            teachers = JsonRead();
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Teacher: {teacher.Id}, Name: {teacher.Name}");
            }
        }

        internal object AttachRoomGroupTeacher(int attRId, int attGId, int arrTId)
        {
            throw new NotImplementedException();
        }

        internal void AttachRoomTeacherGroupStudent(int attTId, int attSId)
        {
            throw new NotImplementedException();
        }

        internal void AttachRoomTeacherGroupStudent(int attTeId, int attSpId, int attSTId)
        {
            throw new NotImplementedException();
        }

        internal void AttachTeacherToRoomGroup(int attRId, int attGId, int arrTId)
        {
            throw new NotImplementedException();
        }

        internal void Booking()
        {
            throw new NotImplementedException();
        }
    }
}
