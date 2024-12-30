using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using TheLine.Effects;
using TheLine.Elements;
using TheLine;
using System.Drawing;
using System.Windows.Forms;

public class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public string ImageFileName { get; set; }
    public List<Effect> Effects { get; set; }
    [JsonConverter(typeof(ElementTypeDictionaryConverter))]
    public Dictionary<ElementType, int> Elements { get; set; }

    public event Action<ElementType, ElementType> OnElementChanged;

    public Character(string name, int hp, string imageFileName, List<Effect> effects = null)
    {
        Name = name;
        HP = hp;
        ImageFileName = imageFileName;
        Effects = effects ?? new List<Effect>();
        Elements = new Dictionary<ElementType, int>();
    }

    public Image GetImage()
    {
        string appDirectory = Application.StartupPath;
        string projectDirectory = Directory.GetParent(appDirectory).Parent.FullName;
        string imagePath = Path.Combine(projectDirectory, "Resources", ImageFileName);
        return File.Exists(imagePath) ? Image.FromFile(imagePath) : TheLine.Properties.Resources.Unknown;
    }

    public void ChangeElement(ElementType oldElement, ElementType newElement, int changeValue)
    {
        if (Elements.ContainsKey(oldElement))
        {
            Elements[oldElement] -= changeValue;
            if (Elements[oldElement] <= 0)
                Elements.Remove(oldElement);
        }

        if (Elements.ContainsKey(newElement))
        {
            Elements[newElement] += changeValue;
        }
        else
        {
            Elements[newElement] = changeValue;
        }

        OnElementChanged?.Invoke(oldElement, newElement);
    }
}
