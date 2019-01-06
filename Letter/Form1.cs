using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letter
{
    public partial class Form1 : Form
    {

        string FilePath = "";
        bool HasFile = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void ChooseFileClick(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                if (Path.GetExtension(file) == ".txt")
                {
                    try
                    {
                        string text = File.ReadAllText(file);
                        size = text.Length;
                        FilePath = file;
                    }
                    catch (IOException)
                    {
                    }
                    PathTextBox.Text = FilePath;
                    HasFile = true;

                }
                else
                {
                    //error not text
                }

            }

        }

        private void CountCharacters(object sender, EventArgs e)
        {
            if (HasFile) {
                Debug.Print("Counting");
                string TextToProcess = File.ReadAllText(FilePath);
                char[] TextToProcessArray = TextToProcess.ToArray();

                List<LetterCountClass> LetterCountList = new List<LetterCountClass>();

                Debug.Print("To Count" + TextToProcessArray.Count().ToString());

                

                for (int CurrentLetter = 0; CurrentLetter < TextToProcessArray.Count(); CurrentLetter++)
                {
                    
                    char CurrentCharacterToCount = TextToProcessArray[CurrentLetter].ToString().ToLower().ToCharArray()[0];
                    Debug.Print(CurrentLetter.ToString() + "-"+ CurrentCharacterToCount);

                    bool LetterInList = false;

                    for (int ListPosition = 0; ListPosition < LetterCountList.Count(); ListPosition++)
                    {
                        if (LetterCountList[ListPosition].Letter == CurrentCharacterToCount) {
                            LetterCountList[ListPosition].AddCount();
                            LetterInList = true;
                        }
                    }

                    if (!LetterInList) {
                        LetterCountList.Add(new LetterCountClass(CurrentCharacterToCount,1));
                    }

                }

                for (int ListPosition = 0; ListPosition < LetterCountList.Count(); ListPosition++)
                {
                    Debug.Print(LetterCountList[ListPosition].Letter.ToString() + "-" + LetterCountList[ListPosition].TimesSeen.ToString() + "\n" );
                }

                DisplayCharacters(LetterCountList);

            }
        }

        private void DisplayCharacters(List<LetterCountClass> LetterList) {

            while (CharacterCountTextFlowBox.Controls.Count > 0)
            {
                CharacterCountTextFlowBox.Controls[0].Dispose();
            }

            for (int CurrentListPos = 0; CurrentListPos < LetterList.Count(); CurrentListPos++)
            {
                Label CharacterCountText = new Label();
                CharacterCountText.Text = LetterList[CurrentListPos].Letter.ToString() + "-" + LetterList[CurrentListPos].TimesSeen.ToString();
                CharacterCountText.Parent = CharacterCountTextFlowBox;
                CharacterCountTextFlowBox.Controls.Add(CharacterCountText);
            }

        }


        public class LetterCountClass {
            public char Letter { get; set; }
            public int TimesSeen { get; set; }

            public LetterCountClass(char letter, int timesSeen)
            {
                Letter = letter;
                TimesSeen = timesSeen;
            }

            public int AddCount()
            {
                TimesSeen++;
                return TimesSeen;
            }
        }

    }
}
