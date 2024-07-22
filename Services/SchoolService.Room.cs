using Models;
using Newtonsoft.Json;

namespace ConsoleApp1.Services
{
    public partial class SchoolService
    {
            string jsonPathRoom = "C:\\My works\\rooms.json";
        public void AddRoom(string name)
        {
            int id = rooms.Count > 0 ? rooms.Max(t => t.Id) + 1 : 1;
            rooms.Add(new Room { Id = id, Name = name });
            string updatedJson = JsonConvert.SerializeObject(rooms);
            File.WriteAllText(jsonPathRoom, updatedJson);
        }
        public void UpdateRoom(int id, string name)
        {
            var rooms = groups.FirstOrDefault(g => g.Id == id);
            if (rooms != null)
            {
                rooms.Name = name;
            }
            else
                Console.WriteLine("Group not found");
        }
        public void DeleteRoom(int id)
        {
            var rooms = this.groups.FirstOrDefault(g => g.Id == id);
            if (rooms != null)
            {
                this.groups.Remove(rooms);
            }
            else
                Console.WriteLine("Group not found");
        }
        public List<Room> JsonReadRoom()
        {
            //string jsonPath = "C:\\My works\\rooms.json";
            string jsonString = File.ReadAllText(jsonPath);
            rooms = JsonConvert.DeserializeObject<List<Room>>(jsonString);
            return rooms;

        }
        public void ListRoom()
        {
            rooms = JsonReadRoom();
            foreach (var room in rooms)
            {
                Console.WriteLine($"Group: {room.Id}, Name: {room.Name}");
            }
        }
    }
}
