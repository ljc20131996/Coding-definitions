using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AT1_Wiki_App
{
    public partial class DefinitionForm : Form
    {
        public string[,] codingTerms;
            
        public DefinitionForm()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void LoadCodingTerms(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                codingTerms = new string[lines.Length, 4];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split('\t');

                    if (columns.Length == 4)
                    {
                        for (int j = 0; j < Math.Min(columns.Length, 4); j++)
                        {
                            codingTerms[i, j] = columns[j];
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Text file - Incomplete data in line {i + 1} Expected 4 columns, found {columns.Length}.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading from file... {ex.Message}");
            }
        }

        public void DefinitionForm_Load(object sender, EventArgs e)
        {

        }

        private void Definition_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatagoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StructureTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DefinitionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditInfo_Click(object sender, EventArgs e)
        {
            if (NameListView.SelectedItems.Count > 0)
            {
                int selectedIndex = NameListView.SelectedItems[0].Index;
                codingTerms[selectedIndex, 0] = NameTextBox.Text;
                codingTerms[selectedIndex, 1] = CatagoryTextBox.Text;
                codingTerms[selectedIndex, 2] = StructureTextBox.Text;
                codingTerms[selectedIndex, 3] = DefinitionTextBox.Text;

                NameListView.Items[selectedIndex].Text = codingTerms[selectedIndex, 0];
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files (*.dat)|*.dat";
            saveFileDialog.Title = "Save Data File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCodingTerms(saveFileDialog.FileName);
                MessageBox.Show("Entry edited and saved successfully.");
            }
        }

        private void SaveCodingTerms(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, codingTerms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to .dat file... {ex.Message}");
            }
        }

        private void ClearInfo_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = string.Empty;
            CatagoryTextBox.Text = string.Empty;
            StructureTextBox.Text = string.Empty;
            DefinitionTextBox.Text = string.Empty;
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            if (NameListView.SelectedItems.Count > 0)
            {
                int selectedIndex = NameListView.SelectedItems[0].Index;

                RemoveEntry(selectedIndex);

                NameListView.Items.RemoveAt(selectedIndex);

                NameTextBox.Text = string.Empty;
                CatagoryTextBox.Text = string.Empty;
                StructureTextBox.Text = string.Empty;
                DefinitionTextBox.Text = string.Empty;
                MessageBox.Show("Entry removed successfully, make sure you click save edit to save the changes!");
            }
            else
            {
                MessageBox.Show("Please select an entry to remove.");
            }
        }

        private void RemoveEntry(int index)
        {
            int numRows = codingTerms.GetLength(0);
            string[,] newArray = new string[numRows - 1, 4];

            int newArrayIndex = 0;
            for (int i = 0; i < numRows; i++)
            {
                if (i != index)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        newArray[newArrayIndex, j] = codingTerms[i, j];
                    }
                    newArrayIndex++;
                }
            }

            codingTerms = newArray;
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NameListView.Items.Count - 1; i++)
            {
                for (int j = 0; j < NameListView.Items.Count - 1 - i; j++)
                {
                    string item1 = NameListView.Items[j].Text;
                    string item2 = NameListView.Items[j + 1].Text;

                    if (string.Compare(item1, item2) > 0)
                    {
                        NameListView.Items[j].Text = item2;
                        NameListView.Items[j + 1].Text = item1;

                        SwapCodingTerms(j, j + 1);
                    }
                }
            }

            MessageBox.Show("List sorted successfully.");
        }

        private void SwapCodingTerms(int index1, int index2)
        {
            for (int j = 0; j < 4; j++)
            {
                string temp = codingTerms[index1, j];
                codingTerms[index1, j] = codingTerms[index2, j];
                codingTerms[index2, j] = temp;
            }
        }
    
        private void InitializeListView()
        {
            for (int i = 0; i < codingTerms.GetLength(0); i++)
            {
                NameListView.Items.Add(codingTerms[i, 0]);
            }
        }

        private void AttachEventHandlers()
        {
            NameListView.SelectedIndexChanged += NameListView_SelectedIndexChanged;
        }

        private void NameListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameListView.SelectedItems.Count > 0)
            {
                int selectedIndex = NameListView.SelectedItems[0].Index;
                NameTextBox.Text = codingTerms[selectedIndex, 0];
                CatagoryTextBox.Text = codingTerms[selectedIndex, 1];
                StructureTextBox.Text = codingTerms[selectedIndex, 2];
                DefinitionTextBox.Text  = codingTerms[selectedIndex, 3];
            }
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            ClearDataFields();
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            openFileDiaglog.Filter = "Binary Files (*.dat)|*.dat";
            openFileDiaglog.Title = "Open Data File";

            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                string tempTxtFilePath = ConvertDatToTxt(openFileDiaglog.FileName);

                if (tempTxtFilePath != null)
                {
                    LoadCodingTerms(tempTxtFilePath);
                    File.Delete(tempTxtFilePath);
                    InitializeListView();
                    MessageBox.Show("Great Success");
                }

                else
                {
                    MessageBox.Show("Conversion failed");
                }
            }
        }

        private void ClearDataFields()
        {
            NameListView.Clear();
            NameTextBox.Text = string.Empty;
            CatagoryTextBox.Text = string.Empty;
            StructureTextBox.Text = string.Empty;
            DefinitionTextBox.Text = string.Empty;
        }

        private string ConvertDatToTxt(string datFilePath)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream datFileStream = new FileStream(datFilePath, FileMode.Open))
                {
                    string[,] loadedData = (string[,])formatter.Deserialize(datFileStream);
                    string tempTxtFilePath = Path.GetTempFileName();
                    using (StreamWriter txtWriter = new StreamWriter(tempTxtFilePath))
                    {
                        for (int i = 0; i < loadedData.GetLength(0); i++)
                        {
                            for(int j = 0; j < loadedData.GetLength(1); j++)
                            {
                                txtWriter.Write($"{loadedData[i, j]}");
                                if (j < loadedData.GetLength(1) - 1)
                                    txtWriter.Write("\t");
                            }
                            txtWriter.WriteLine();
                        }
                    }
                    Console.WriteLine("Conversion from .dat to .txt successfull.");
                    return tempTxtFilePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting: {ex.Message}");
                return null;
            }
        }

        private void AddInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(CatagoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(StructureTextBox.Text) &&
                !string.IsNullOrWhiteSpace(DefinitionTextBox.Text))
            {
                int newRow = codingTerms.GetLength(0);
                string[,] newArray = new string[newRow + 1, 4];
                for (int i = 0; i < newRow; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        newArray[i, j] = codingTerms[i, j];
                    }
                }

                newArray[newRow, 0] = NameTextBox.Text;
                newArray[newRow, 1] = CatagoryTextBox.Text;
                newArray[newRow, 2] = StructureTextBox.Text;
                newArray[newRow, 3] = DefinitionTextBox.Text;

                codingTerms = newArray;
                NameListView.Items.Add(codingTerms[newRow, 0]);
                MessageBox.Show("Entry added successfully. make sure you click save edit to save the changes!");
            }
            else
            {
                MessageBox.Show("Please fill in all fields to add a new entry.");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = SearchTextBox.Text;
            Search(searchTerm);
        }
        private void Search(string searchTerm)
        {
            NameListView.SelectedItems.Clear();

            foreach (ListViewItem item in NameListView.Items)
            {
                if (item.Text.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    item.Selected = true;
                    item.Focused = true;
                    NameListView.EnsureVisible(item.Index);
                    return; 
                }
            }
            MessageBox.Show("No matching entry found.");
        }
    }

    static class ProgramApp
    {
        [STAThread]
        static void MainApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DefinitionForm());
        }
    }
}
