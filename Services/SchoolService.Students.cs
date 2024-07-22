using Models;

namespace ConsoleApp1.Services
{
    public partial class SchoolService
    {
        public void AddStudents(string name)
        {
            int id = students.Count > 0 ? students.Max(st => st.Id) + 1 : 1;
            students.Add(new Students { Id = id, Name = name });
        }
        public void UpdateStudents(int id, string name)
        {
            var student = students.FirstOrDefault(st => st.Id == id);
            if (student != null)
            {
                student.Name = name;
            }
            else
                Console.WriteLine("Students not found");
        }
        public void DeleteStudents(int id)
        {
            var student = students.FirstOrDefault(st => st.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            else
                Console.WriteLine("Student not found");
        }
        public void ListStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Students: {student.Id}, Name: {student.Name}");
            }
        }
    }
}
