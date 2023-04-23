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

namespace NCUCalcGearParam
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

        private void button_GearPairCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string Gear1Name = textBox_GearName1.Text; string Gear2Name = textBox_GearName2.Text;
                double z1 = double.Parse(textBox_z1.Text); double z2 = double.Parse(textBox_z2.Text);
                double F1 = double.Parse(textBox_F1.Text); double F2 = double.Parse(textBox_F2.Text);
                double di1 = double.Parse(textBox_di1.Text); double di2 = double.Parse(textBox_di2.Text);
                double x1 = double.Parse(textBox_xn1.Text); double x2 = double.Parse(textBox_xn2.Text);
                double n = double.Parse(textBox_n.Text); double P = double.Parse(textBox_P.Text);
                double Qv1 = double.Parse(textBox_Qv1.Text); double Qv2 = double.Parse(textBox_Qv2.Text);
                double v1 = double.Parse(textBox_v1.Text); double v2 = double.Parse(textBox_v2.Text);
                double E1 = double.Parse(textBox_E1.Text); double E2 = double.Parse(textBox_E2.Text);
                double HB1 = double.Parse(textBox_HB1.Text); double HB2 = double.Parse(textBox_HB2.Text);
                double mn = double.Parse(textBox_mn.Text); double alphan = double.Parse(textBox_alphan.Text);
                double beta = double.Parse(textBox_beta.Text);
                double Ka = double.Parse(textBox_Ka.Text); double Ks = double.Parse(textBox_Ks.Text);
                CourseCorrection cmc = 0;
                if (comboBox_cmc.SelectedIndex == 0)
                    cmc = CourseCorrection.Modification;
                else if (comboBox_cmc.SelectedIndex == 1)
                    cmc = CourseCorrection.NoModification;
                EngagementAxisAmendment ce = 0;
                if (comboBox_ce.SelectedIndex == 0)
                    ce = EngagementAxisAmendment.Grinding;
                else if (comboBox_ce.SelectedIndex == 1)
                    ce = EngagementAxisAmendment.NoGrinding;
                PlaceofUseGears cma = 0;
                if (comboBox_cma.SelectedIndex == 0)
                    cma = PlaceofUseGears.OpenType;
                else if (comboBox_cma.SelectedIndex == 1)
                    cma = PlaceofUseGears.GeneralClosedType;
                else if (comboBox_cma.SelectedIndex == 2)
                    cma = PlaceofUseGears.PrecisionClosedType;
                else if (comboBox_cma.SelectedIndex == 3)
                    cma = PlaceofUseGears.UltraPrecisionClosedType;
                double N = double.Parse(textBox_NNumber.Text); double Tc = double.Parse(textBox_Tc.Text);
                double cpm = double.Parse(textBox_cpm.Text); double Kr = double.Parse(textBox_Kr.Text);
                double Rq = double.Parse(textBox_Rq.Text);
                NCUCalculate.ReadGearPair(Gear1Name, Gear2Name, z1, z2, F1, F2, di1, di2, x1, x2, n, P, Qv1, Qv2, v1, v2, E1, E2, HB1, HB2, mn, alphan, beta, Ka, Ks, cmc, ce, cma, N, Tc, cpm, Kr, Rq);
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("【錯誤】\r\n{0}", ex.Message), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ShowInstructionManual2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(2);
            textBox_guide.Text = NCUCalculate.ShowManual();
        }
    }
}
