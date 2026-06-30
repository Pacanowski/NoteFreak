using System.IO;

namespace NoteFreak

{
    public partial class Form1 : Form
    {

        bool saved = false;
        bool loaded = false;

        string openedFileName = "";

        string imported = "";
        public Form1()
        {
            InitializeComponent();

            this.Text = "NoteFreak";
        }


        


        private void OpenFile(object sender, EventArgs e)
        {

            if(loaded && !saved && !(imported == textBox.Text))
            {
                MessageBox.Show("You haven't yet saved your file! Don't forget to do that so you don't lose anything important!");
            }else 
            {

                loaded = true;
                saved = false;

                OpenFileDialog openFile = new OpenFileDialog();

                openFile.Title = "Open File";
                openFile.Filter = "Text files (.txt)|*.txt";

                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    textBox.Text = File.ReadAllText(openFile.FileName);
                    imported = textBox.Text;

                    output.Text = "Opened file : " + openFile.FileName;

                }

                openedFileName = openFile.FileName;
            }


        }


        private void SaveAs(object sender, EventArgs e)
        {

            saved = true;

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Title = "Save file as...";
            saveFile.Filter = "Text files (.txt)|*.txt";
            saveFile.FileName = "plik.txt";

            

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFile.FileName, textBox.Text);

                output.Text = "Saved file as " + saveFile.FileName;

            }

            
        }

        private void Save(object sender, EventArgs e)
        {

            if(openedFileName != "")
            {
                saved = true;

                File.WriteAllText(openedFileName, textBox.Text);

                output.Text = "Saved file as " + openedFileName;
            }

          
        }


    }

}
