using System.IO;

namespace NoteFreak

{
    public partial class Form1 : Form
    {

        bool saved = false;
        bool loaded = false;

        string currentFileName = "C:/niepowiem.ppp";

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

                currentFileName = openFile.FileName;
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

            currentFileName = saveFile.FileName;

            
        }

        private void Save(object sender, EventArgs e)
        {

            
            if(currentFileName != "")
            {

                if (!File.Exists(currentFileName))
                {
                    SaveAs(sender, e);
                }
                else
                {
                    saved = true;

                    File.WriteAllText(currentFileName, textBox.Text);

                    output.Text = "Saved file as " + currentFileName;
                }


              
            }

          
        }


    }

}
