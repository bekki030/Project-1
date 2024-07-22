using Models;
using Newtonsoft.Json;

namespace ConsoleApp1.Services
{
    public partial class SchoolService
    {
            string jsonPathGroup = "C:\\My works\\groups.json";
        public void AddGroup(string name)
        {
            int id = groups.Count > 0 ? groups.Max(g => g.Id) + 1 : 1;
            groups.Add(new Models.Group { Id = id, Name = name });
            string updatedJson = JsonConvert.SerializeObject(groups);
            File.WriteAllText(jsonPathGroup, updatedJson);
        }
        public void UpdateGroup(int id, string name)
        {
            var groups = this.groups.FirstOrDefault(g => g.Id == id);
            if (groups != null)
            {
                groups.Name = name;
            }
            else
                Console.WriteLine("Group not found");
        }
        public void DeleteGroup(int id)
        {
            var group = this.groups.FirstOrDefault(g => g.Id == id);
            if (group != null)
            {
                this.groups.Remove(group);
            }
            else
                Console.WriteLine("Group not found");
        }
        public List<Group> JsonReadGroup()
        {
            //string jsonPath = "C:\\My works\\groups.json";
            string jsonString = File.ReadAllText(jsonPath);
            groups = JsonConvert.DeserializeObject<List<Group>>(jsonString);
            return groups;

        }
        public void ListGroup()
        {
            groups = JsonReadGroup();
            foreach (var group in groups)
            {
                Console.WriteLine($"Group: {group.Id}, Name: {group.Name}");
            }
        }
    }
}
