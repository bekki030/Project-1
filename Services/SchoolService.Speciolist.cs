using Models;

namespace ConsoleApp1.Services;

public partial class SchoolService
{
    public void AddSpecialist(string name, string stack)
    {
        //int id;
        //if (specialists.Count > 0)
        //{
        //    id = specialists.Max(x => x.Id) + 1;
        //}
        //else
        //{
        //    id = 1;
        //}

        int id = specialists.Count > 0 ? specialists.Max(s => s.Id) + 1 : 1;
        var spec = new Specialist { Id = id, Name = name, Stack = stack };


        specialists.Add(spec);
    }
    public void UpdateSpecialist(int id, string name, string stack)
    {
        var specialist = specialists.FirstOrDefault(s => s.Id == id);
        if (specialist != null)
        {
            specialist.Name = name;
            specialist.Stack = stack;
        }
        else
        {
            Console.WriteLine("Specialist not found.");
        }
    }
    public void DeleteSpecialist(int id)
    {
        var specialist = specialists.FirstOrDefault(s => s.Id == id);
        if (specialist != null)
        {
            specialists.Remove(specialist);
        }
        else
        {
            Console.WriteLine("Specialist not found.");
        }
    }
    public void ListSpecialists()
    {
        foreach (var specialist in specialists)
        {
            Console.WriteLine($"Specialist: {specialist.Id}, Name: {specialist.Name}, Stack: {specialist.Stack}");
        }
    }

}
