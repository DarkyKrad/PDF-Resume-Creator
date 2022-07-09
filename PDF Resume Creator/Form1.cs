using SkiaSharp;
using System.Text.Json;
using System.Diagnostics;
namespace PDF_Resume_Creator
{
    public partial class Form1 : Form
    {
        private string filepath = "";
        private Resume_Data resumedata;
        public Form1()
        {

            InitializeComponent();
        }

        private void btnFP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    var fileStream = openFileDialog.OpenFile();
                    try
                    {
                     resumedata = JsonSerializer.Deserialize<Resume_Data>(fileStream);
                        Debug.WriteLine(resumedata.ToString());
                    }
                   catch (JsonException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
        }

        private void skControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}