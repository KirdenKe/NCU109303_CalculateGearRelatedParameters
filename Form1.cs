using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NCUCalculateGearRelatedParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CreateExampleFiles_Click(object sender, EventArgs e)
        {
            NCUCalculate.CreateGearSystemExampleFile();
        }

        private void button_ReadSystemFile_Click(object sender, EventArgs e)
        {
            //using (FileStream fileStream = new FileStream(String.Format("齒輪輸入資料範例.csv"), FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sw = new StreamReader(fileStream, Encoding.Default))
            //    {
            //        var test = sw.ReadToEnd();
            //    }
            //}
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "逗點分隔檔案 (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NCUCalculate.ReadSystemFile(openFileDialog.FileName);
            }
        }

        private void button_Generatecsv_Click(object sender, EventArgs e)
        {
            textBox_output.Text = NCUCalculate.GeneratecsvFile();
        }

        private void button_Generatemd_Click(object sender, EventArgs e)
        {
            textBox_output.Text = NCUCalculate.GeneratemdText();
        }
    }
}
