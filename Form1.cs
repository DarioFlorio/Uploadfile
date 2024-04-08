namespace Uploadfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string targetPath = @"C:\Users\dario\OneDrive\Desktop\testfolder";
                    // Ensure the directory exists
                    if (!Directory.Exists(targetPath))
                    {
                        MessageBox.Show("The target folder does not exist.");
                        return; // Exit the method if the folder doesn't exist
                    }
                    try
                    {
                        File.Copy(openFileDialog.FileName, Path.Combine(targetPath, Path.GetFileName(openFileDialog.FileName)), true);
                        MessageBox.Show("File uploaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }
    }
}
