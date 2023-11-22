namespace songsProblem
{
    internal class Program
    {
        public class Song
        {
            public string Type { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }

            public Song(string type, string name, string time) 
            { 
                Type = type;
                Name = name;
                Time = time;
            }
        }

        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> allSongs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string commandType = input[0];
                string commandSongName = input[1];
                string commandSongTime = input[2];

                Song song = new Song(commandType, commandSongName, commandSongTime);

                allSongs.Add(song);            
                
            }

            string lastCommand = Console.ReadLine();
            
            foreach (Song song in allSongs)
            {              
                if (lastCommand == song.Type)
                {
                    Console.WriteLine(song.Name);
                }
                else if (lastCommand == "all")
                {
                    Console.WriteLine(song.Name);
                }
            }                    
        }
    }
}