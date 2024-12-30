
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TheLine.Effects;

namespace TheLine.Characters
{
    public static class CharacterLoader
    {
        public static List<Character> LoadCharacters(string jsonFileName)
        {
            string projectDirectory = Directory.GetParent(Application.StartupPath).Parent.FullName;
            string fullPath = Path.Combine(projectDirectory, "Datas", jsonFileName);
            var jsonData = File.ReadAllText(fullPath);
            return JsonConvert.DeserializeObject<List<Character>>(jsonData);
        }
    }
}
