using System.Windows.Forms;
using Tyuiu.GoryaevTT.Sprint6.TaskReview.Lib;

namespace Tyuiu.GoryaevTT.Sprint6.TaskReview.App
{
    public partial class FormName : Form
    {
        public FormName()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        Random rn = new Random();
        public int[,] matrix;
        public string[] text; 
        private void buttonLoad_GTT(object sender, EventArgs e)
        {
            dataGridViewMatrix_GTT.ColumnCount = 25;
            dataGridViewMatrix_GTT.RowCount = 25;
            for (int i = 0; i < 25; i++)
            {
                dataGridViewMatrix_GTT.Columns[i].Width = 25;
            }
            try
            {
                string[] datas = textDataInput_GTT.Text.Split(",");
                text = datas;
                matrix = ds.array;
                for (int r = 0; r < Convert.ToInt32(textRows_GTT.Text); r++)
                {
                    for (int c = 0; c < Convert.ToInt32(textColumns_GTT.Text); c++)
                    {
                        dataGridViewMatrix_GTT.Rows[r].Cells[c].Value = matrix[r, c];
                    }
                }
            }
            catch { MessageBox.Show("введены неправильные данные"); }
        }

        private void buttonDone_GTT(object sender, EventArgs e)
        {
            try
            {
                text = textDataInput_GTT.Text.Split(",");
                int N = Convert.ToInt32(textRows_GTT.Text);
                int M = Convert.ToInt32(textColumns_GTT.Text);
                matrix = new int[N, M];
                textResult_GTT.Text = Convert.ToString(ds.result_GetMatrix(matrix, Convert.ToInt32(text[0]), Convert.ToInt32(text[1]), Convert.ToInt32(text[2]) - 1, Convert.ToInt32(text[3]) - 1, Convert.ToInt32(text[4]) - 1));
            }
            catch { MessageBox.Show("введены неправильные данные"); }
        }
    }
}
