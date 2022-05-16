using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.IO.Compression;

namespace KRXextractor_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            textBox_outputFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void checkbox_defaultSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_defaultSave.Checked)
            {
                button_outputFolder.Enabled = false;
            } else
            {
                button_outputFolder.Enabled = true;
            }
        }

        private void button_extract_Click(object sender, EventArgs e)
        {
            // Checks and balances. Checks at least.
            if(textBox_selectedFile.Text.Length < 1)
            {
                MessageBox.Show("Kérem válasszon ki egy fájlt!", "Hiba");
                return;
            }

            string new_folder_name = textBox_selectedFile.Text.Split('\\').Last().Split('.')[0];
            string new_folder_temp = new_folder_name + "_TEMP";

            if(Directory.Exists(Path.Combine(textBox_outputFolder.Text, new_folder_name)))
            {
                MessageBox.Show("Nem tudtam létrehozni a mappát mert ezen a néven már létezik egy! Kérem törölje, vagy módosítsa a mentés helyét!", "Hiba");
                return;
            }
            Directory.CreateDirectory(Path.Combine(textBox_outputFolder.Text, new_folder_temp));

            if (Directory.Exists(Path.Combine(textBox_outputFolder.Text, new_folder_name)))
            {
                MessageBox.Show("Nem tudtam létrehozni az ideiglenes mappát mert ezen a néven már létezik egy! Kérem törölje, vagy módosítsa a mentés helyét!", "Hiba");
                return;
            }
            Directory.CreateDirectory(Path.Combine(textBox_outputFolder.Text, new_folder_temp));

            // Unzipping the KRX archive to the TEMP folder
            ZipFile.ExtractToDirectory(textBox_selectedFile.Text, Path.Combine(textBox_outputFolder.Text, new_folder_temp));

            // Sorting and copying the attachments
            int attachment_counter = 1;
            foreach (var attachment_dir in Directory.GetDirectories(Path.Combine(textBox_outputFolder.Text, new_folder_temp, "KRX", "OCD", "Payload")))
            {
                Directory.CreateDirectory(Path.Combine(textBox_outputFolder.Text, new_folder_name, $"csatolmany_{attachment_counter}"));
                foreach (var attachment in Directory.GetFiles(Path.Combine(textBox_outputFolder.Text, new_folder_temp, "KRX", "OCD", "Payload", attachment_dir)))
                {
                    File.Copy(attachment, Path.Combine(textBox_outputFolder.Text, new_folder_name, $"csatolmany_{attachment_counter}", attachment.Split('\\').Last()));
                    attachment_counter++;
                }
            }
            File.Copy(Path.Combine(textBox_outputFolder.Text, new_folder_temp, "KRX", "OCD", "Metalayer", "KULDEMENY_META.xml"), Path.Combine(textBox_outputFolder.Text, new_folder_name, "META.xml"));

            // Deleting TEMP folder
            Directory.Delete(Path.Combine(textBox_outputFolder.Text, new_folder_temp), true);

            MessageBox.Show("A kért csatolmány kitömörítésre került!", "Siker");
        }

        private void button_filePicker_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "KRX állományok (*.krx)|*.krx|Minden állomány (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_selectedFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void button_outputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox_outputFolder.Text = fbd.SelectedPath;
                } else
                {
                    textBox_outputFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                }
            }
        }

        private void textBox_selectedFile_TextChanged(object sender, EventArgs e)
        {
            textBox_selectedFile.SelectionStart = textBox_selectedFile.Text.Length;
            textBox_selectedFile.SelectionLength = 0;
        }

        private void textBox_outputFolder_TextChanged(object sender, EventArgs e)
        {
            textBox_outputFolder.SelectionStart = textBox_outputFolder.Text.Length;
            textBox_outputFolder.SelectionLength = 0;
        }
    }
}
