using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TheLine.Characters;

namespace TheLine
{
    public partial class CharacterSelection : Form
    {
        private List<Character> characterList = new List<Character>();
        public CharacterSelection()
        {
            InitializeComponent();
            //InitCharacters();

            characterList = CharacterLoader.LoadCharacters("characters.json");
            characterList.ForEach(character => AddCharacter(character));
        }
        public void AddCharacter(Character character)
        {
            CharacterDescription characterDescription = new CharacterDescription(character);
            characterDescription.Dock = DockStyle.Top;
            panelCharacters.Controls.Add(characterDescription);
            characterDescription.OnSelection += (s, e) =>
            {
                NewRun newRun = new NewRun(character);
                newRun.Show();
                this.Hide();
            };
        }
    }
}
