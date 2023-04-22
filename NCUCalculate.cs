using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCUCalculateGearRelatedParameters
{
    internal class DeterminedValue
    {
        public double z { get; set; }//齒數
        public double mn { get; set; }//法向模數
        public double alphan { get; set; }//壓力角
        public double beta { get; set; }//螺旋角
        public double FaceWidth { get; set; }//齒面寬
        public double di { get; set; }//齒輪內孔直徑
        public double xn { get; set; }//轉位係數
        public double n { get; set; }//轉速
        public double P { get; set; }//功率
        public double Ka { get; set; }//負荷係數
        public double Qv { get; set; }//齒輪AGMA等級
        public double Ks { get; set; }//尺寸係數
        public CourseCorrection cmc { get; set; }//是否導程修正
        public double cpm { get; set; }//小齒輪安裝修正因子
        public PlaceofUseGears cma { get; set; }//齒輪使用場所選用
        public EngagementAxisAmendment ce { get; set; }//研磨製程
        public double Tc { get; set; }//潤滑油溫度
        public double v { get; set; }//齒輪的蒲松比
        public double E { get; set; }//齒輪的楊氏係數
        public double HB { get; set; }//齒輪勃氏硬度
        public double Rq { get; set; }//齒輪齒面粗糙度
        public double Kr { get; set; }//可靠度係數
        public double N { get; set; }//齒輪嚙合次數
        public bool isOnSameAxis { get; set; }//是否在同一軸上
        public string GearName { get; set; }//齒輪名字
    }
    internal class Calculate_temp
    {
        public double alphat { get; set; }//軸直角壓力角
        public double invalphawt { get; set; }//軸直角咬合壓力角的漸開線函數
        public double alphawt { get; set; }//嚙合軸向壓力角
        public double y { get; set; }//中心距修正係數
        public double a { get; set; }//中心距
        public double ha1 { get; set; }//齒輪1齒冠高
        public double ha2 { get; set; }//齒輪2齒冠高
        public double dp1 { get; set; }//齒輪1節圓直徑
        public double dp2 { get; set; }//齒輪2節圓直徑
        public double do1 { get; set; }//齒輪1外徑
        public double do2 { get; set; }//齒輪2外徑
        public double db1 { get; set; }////齒輪1基圓直徑
        public double db2 { get; set; }////齒輪2基圓直徑
        public double alpha1 { get; set; }////齒輪1齒頂壓力角
        public double alpha2 { get; set; }////齒輪2齒頂壓力角
        public double bH { get; set; }//有效齒幅
        public double hr1 { get; set; }//齒輪齒根高
        public double ht1 { get; set; }//齒輪全齒高
        public double dr1 { get; set; }//齒底圓直徑
        public double dpr1 { get; set; }//嚙合圓直徑
        public double dpr2 { get; set; }//嚙合圓直徑
        public double Wt { get; set; }//切向力
        public double Vt { get; set; }//齒輪節點切向速度
        public double Kv { get; set; }//動力係數
        public double cmc { get; set; }//導程修正因子
        public double cpf { get; set; }//小齒輪比例因子
        public double cma { get; set; }//嚙合同軸度因子
        public double ce { get; set; }//嚙合同軸度修正因子
        public double Km { get; set; }//均載係數
        public double tR { get; set; }//齒輪輪緣厚
        public double mb { get; set; }//齒輪輪緣厚與齒輪全齒高的比值
        public double Kb { get; set; }//齒厚係數
        public double St { get; set; }//彎曲應力
        public double SbT { get; set; }//理論抗彎曲強度
        public double Kl { get; set; }//壽命修正係數
        public double Kt { get; set; }//溫度修正係數
        public double Sb { get; set; }//實際抗彎曲強度
        public double Cp { get; set; }//彈性係數
        public double Ss { get; set; }//實際接觸應力
        public double mg { get; set; }//齒輪減速比
        public double Ch { get; set; }//硬度修正係數
        public double Sc { get; set; }//實際抗接觸破壞強度
        public double Nb { get; set; }//彎曲強度安全係數
        public double Nc { get; set; }//接觸強度安全係數
        public double Fn { get; set; }//正向力
        public double Fa { get; set; }//軸向力
        public double Fr { get; set; }//徑向力
        public double vp { get; set; }//小齒輪的蒲松比
        public double vg { get; set; }//大齒輪的蒲松比
        public double Ep { get; set; }//小齒輪的楊氏係數
        public double Eg { get; set; }//大齒輪的楊氏係數
        public double HBp { get; set; }//小齒輪勃氏硬度
        public double HBg { get; set; }//大齒輪勃氏硬度
        public double J { get; set; }//彎曲幾何係數
        public double I { get; set; }//接觸幾何係數
        public double epsilons { get; set; }//軸向嚙合率
        public double T { get; set; }//扭力
        public double ScT { get; set; }//理論抗接觸破壞強度
        public double CPsi { get; set; }
        public double mN { get; set; }
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double mG { get; set; }
    }
    internal class Report
    {
        public string CalculationItems { get; set; }//計算項目
        public string symbol { get; set; }//符號
        public string unit { get; set; }//單位
        public string CV { get; set; }//計算數值
    }
    public enum CourseCorrection
    {
        Modification,
        NoModification
    }
    public enum PlaceofUseGears
    {
        OpenType,
        GeneralClosedType,
        PrecisionClosedType,
        UltraPrecisionClosedType
    }
    public enum EngagementAxisAmendment
    {
        Grinding,
        NoGrinding
    }
    internal enum ErrorType
    {
        None,
        WrongType,
        WrongFile
    }
    public class NCUCalculate
    {
        static List<DeterminedValue> gear = new List<DeterminedValue>();
        public static void CreateGearSystemExampleFile()
        {
            try
            {
                using (FileStream fileStream = new FileStream(String.Format("齒輪輸入資料範例.csv"), FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fileStream, Encoding.Default))
                    {
                        sw.Write(String.Format("齒輪名字,1,,\r\n輸入項目,數值,輸入項目,數值\r\n齒數,,法向模數,\r\n壓力角,,螺旋角,\r\n齒面寬,,齒輪內孔直徑,\r\n轉位係數,,轉速,\r\n功率,,,\r\n負荷係數,,尺寸係數,\r\n是否導程修正,,研磨製程,\r\n齒輪使用場所選用,,齒輪嚙合次數,\r\n齒輪AGMA等級,,潤滑油溫度,\r\n小齒輪安裝修正因子,,可靠度係數,\r\n蒲松比,,楊氏係數,\r\n勃氏硬度,,齒面粗糙度,\r\n,,,\r\n齒輪名字,2,,\r\n輸入項目,數值,輸入項目,數值\r\n齒數,,法向模數,\r\n壓力角,,螺旋角,\r\n齒面寬,,齒輪內孔直徑,\r\n轉位係數,,,\r\n負荷係數,,尺寸係數,\r\n是否導程修正,,研磨製程,\r\n齒輪使用場所選用,,,\r\n齒輪AGMA等級,,潤滑油溫度,\r\n小齒輪安裝修正因子,,可靠度係數,\r\n蒲松比,,楊氏係數,\r\n勃氏硬度,,齒面粗糙度,\r\n,,,\r\n齒輪名字,3,,\r\n輸入項目,數值,輸入項目,數值\r\n齒數,,法向模數,\r\n壓力角,,螺旋角,\r\n齒面寬,,齒輪內孔直徑,\r\n轉位係數,,,\r\n負荷係數,,尺寸係數,\r\n是否導程修正,,研磨製程,\r\n齒輪使用場所選用,,,\r\n齒輪AGMA等級,,潤滑油溫度,\r\n小齒輪安裝修正因子,,可靠度係數,\r\n蒲松比,,楊氏係數,\r\n勃氏硬度,,齒面粗糙度,\r\n是否與上個齒輪在同一軸上,,,\r\n,,,\r\n齒輪名字,4,,\r\n輸入項目,數值,輸入項目,數值\r\n齒數,,轉位係數,\r\n齒面寬,,齒輪內孔直徑,\r\n蒲松比,,楊氏係數,\r\n勃氏硬度,,齒面粗糙度,\r\nEnd,,,\r\n"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("【錯誤】\r\n{0}", ex.Message), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ReadSystemFile(string FilePath)
        {
            gear.Clear();
            var value = new DeterminedValue();
            UInt16 GearNum = 0;
            var errorType = ErrorType.None;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath, Encoding.Default))
                {
                    while (sr.Peek() != -1)
                    {
                        var fileContent = sr.ReadLine();
                        if (fileContent.Contains("齒輪名字"))
                        {
                            value.GearName = fileContent.Split(',')[1];
                            GearNum++;
                        }
                        value = BuildGearData(fileContent, value);
                        if (GearNum == 1)
                        {
                            value.isOnSameAxis = false;
                            if(fileContent.Contains("勃氏硬度") && fileContent.Contains("齒面粗糙度"))
                            {
                                gear.Add(value);
                                value = new DeterminedValue();
                            }
                            else if (fileContent.Contains("轉位係數") && fileContent.Contains("轉速"))
                            {
                                value.xn = double.Parse(fileContent.Split(',')[1]); value.n = double.Parse(fileContent.Split(',')[3]);
                            }
                            else if(fileContent.Contains("功率"))
                            {
                                value.P = double.Parse(fileContent.Split(',')[1]);
                            }
                            else if (fileContent.Contains("齒輪使用場所選用") && fileContent.Contains("齒輪嚙合次數"))
                            {

                            }
                        }
                        else if(GearNum == 2)
                        {
                            value.isOnSameAxis = false;
                            if (fileContent.Contains("勃氏硬度") && fileContent.Contains("齒面粗糙度"))
                            {
                                gear.Add(value);
                                value = new DeterminedValue();
                            }
                        }
                        else 
                        {
                            if (fileContent.Contains("齒數") && fileContent.Contains("轉位係數"))
                            {
                                value.z = double.Parse(fileContent.Split(',')[1]); value.xn = double.Parse(fileContent.Split(',')[3]);
                            }
                            if (fileContent.Contains("End"))
                            {
                                value.isOnSameAxis = false;
                                gear.Add(value);
                            }
                            else
                            {
                                if(fileContent.Contains("是否與上個齒輪在同一軸上"))
                                {
                                    gear.Add(value);
                                    value = new DeterminedValue();
                                }  
                            }
                        }
                        if (GearNum == 0)
                            errorType = ErrorType.WrongFile;
                    }
                }
            }
            catch(Exception ex)
            {
                errorType = ErrorType.WrongType;
                MessageBox.Show(String.Format("【錯誤】\r\n{0}", ex.Message), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(errorType == ErrorType.None)
                    MessageBox.Show(String.Format("資料讀取成功"), "資料讀取完畢", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(errorType == ErrorType.WrongFile)
                    MessageBox.Show(String.Format("【錯誤】\r\n檔案格式錯誤"), "檔案格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static DeterminedValue BuildGearData(string fileContent, DeterminedValue value)
        {
            if(fileContent.Contains("齒數") && fileContent.Contains("法向模數"))
            {
                value.z = double.Parse(fileContent.Split(',')[1]); value.mn = double.Parse(fileContent.Split(',')[3]);
            }
            else if(fileContent.Contains("壓力角") && fileContent.Contains("螺旋角"))
            {
                value.alphan = double.Parse(fileContent.Split(',')[1]); value.beta = double.Parse(fileContent.Split(',')[3]);
            }
            else if (fileContent.Contains("齒面寬") && fileContent.Contains("齒輪內孔直徑"))
            {
                value.FaceWidth = double.Parse(fileContent.Split(',')[1]); value.di = double.Parse(fileContent.Split(',')[3]);
            }
            else if(fileContent.Contains("轉位係數"))
            {
                value.xn = double.Parse(fileContent.Split(',')[1]);
            }
            else if (fileContent.Contains("負荷係數") && fileContent.Contains("尺寸係數"))
            {
                value.Ka = double.Parse(fileContent.Split(',')[1]); value.Ks = double.Parse(fileContent.Split(',')[3]);
            }
            else if (fileContent.Contains("是否導程修正") && fileContent.Contains("研磨製程"))
            {
                if(fileContent.Split(',')[1].ToLower() == "true")
                    value.cmc = CourseCorrection.Modification;
                else if(fileContent.Split(',')[1].ToLower() == "false")
                    value.cmc = CourseCorrection.NoModification;
                if (fileContent.Split(',')[3].ToLower() == "true")
                    value.ce = EngagementAxisAmendment.Grinding;
                else if (fileContent.Split(',')[3].ToLower() == "false")
                    value.ce = EngagementAxisAmendment.NoGrinding;
            }
            else if(fileContent.Contains("齒輪使用場所選用"))
            {
                if (fileContent.Split(',')[1].ToLower().Replace(" ", "") == "opentype" || fileContent.Split(',')[1] == "0")
                    value.cma = PlaceofUseGears.OpenType;
                else if (fileContent.Split(',')[1].ToLower().Replace(" ", "") == "generalclosedtype" || fileContent.Split(',')[1] == "1")
                    value.cma = PlaceofUseGears.GeneralClosedType;
                else if (fileContent.Split(',')[1].ToLower().Replace(" ", "") == "precisionclosedtype" || fileContent.Split(',')[1] == "2")
                    value.cma = PlaceofUseGears.PrecisionClosedType;
                else if (fileContent.Split(',')[1].ToLower().Replace(" ", "") == "ultraprecisionclosedtype" || fileContent.Split(',')[1] == "3")
                    value.cma = PlaceofUseGears.UltraPrecisionClosedType;
            }
            else if (fileContent.Contains("齒輪AGMA等級") && fileContent.Contains("潤滑油溫度"))
            {
                value.Qv = double.Parse(fileContent.Split(',')[1]); value.Tc = double.Parse(fileContent.Split(',')[3]);
            }
            else if (fileContent.Contains("小齒輪安裝修正因子") && fileContent.Contains("可靠度係數"))
            {
                value.cpm = double.Parse(fileContent.Split(',')[1]); value.Kr = double.Parse(fileContent.Split(',')[3]);
            }
            else if (fileContent.Contains("蒲松比") && fileContent.Contains("楊氏係數"))
            {
                value.v = double.Parse(fileContent.Split(',')[1]); value.E = double.Parse(fileContent.Split(',')[3]);
            }
            else if (fileContent.Contains("勃氏硬度") && fileContent.Contains("齒面粗糙度"))
            {
                value.HB = double.Parse(fileContent.Split(',')[1]); value.Rq = double.Parse(fileContent.Split(',')[3]);
            }
            else if (fileContent.Contains("是否與上個齒輪在同一軸上"))
            {
                if (fileContent.Split(',')[1].ToLower() == "true")
                    value.isOnSameAxis = true;
                else if (fileContent.Split(',')[1].ToLower() == "false")
                    value.isOnSameAxis = false;
            }
            return value;
        }
        public static void ReadGearPair()
        {
            gear.Clear();

        }
        public static string GeneratecsvFile()
        {
            string TotalOutputText = null;
            List<Report> reports = AddReports();
            UInt16 index = 0;
            TotalOutputText = null;
            foreach (Report report in reports)
            {
                if (index == 0)
                {
                    TotalOutputText += String.Format("{0}\r\n計算項目,符號,單位,計算數值\r\n", report.CalculationItems);
                }
                else
                {
                    TotalOutputText += String.Format("{0},{1},{2},{3}\r\n", report.CalculationItems, report.symbol, report.unit, report.CV);
                }
                index++;
                if (index > 14)
                {
                    index = 0;
                }
            }
            using (FileStream fileStream = new FileStream(String.Format("齒輪計算結果.csv"), FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fileStream, Encoding.Default))
                {
                    sw.Write(TotalOutputText);
                }
            }
            return TotalOutputText;
        }
        public static string GeneratemdText()
        {
            string TotalOutputText = null;
            List<Report> reports = AddReports();
            UInt16 index = 0;
            TotalOutputText = null;
            foreach (Report report in reports)
            {
                if (index == 0)
                {
                    TotalOutputText += String.Format("| {0} |  |  |  |\r\n| -------- | -------- | -------- | -------- |\r\n| 計算項目 | 符號 | 單位 | 計算數值 |\r\n", report.CalculationItems);
                }
                else if(index == 15)
                {
                    TotalOutputText += String.Format("| {0} |  |  |  |\r\n| 計算項目 | 符號 | 單位 | 計算數值 |\r\n", report.CalculationItems);
                }
                else
                {
                    TotalOutputText += String.Format("| {0} | {1} | {2} | {3} |\r\n", report.CalculationItems, report.symbol, report.unit, report.CV);
                }
                index++;
                if (index > 29)
                {
                    index = 15;
                }
            }
            return TotalOutputText;
        }
        private static List<Report> AddReports()
        {
            List<Report> localReports = new List<Report>();
            if (gear != null)
            {
                var calculateArea = new CalculateArea();
                for (int i = 0; i < gear.Count - 1; i++)
                {
                    if (gear[i + 1].isOnSameAxis == false)
                    {
                        localReports.AddRange(calculateArea.GearPairCalculate(gear[i], gear[i + 1]));
                    }
                    else
                    {
                        gear[i + 1].n = gear[i].n; gear[i + 1].P = gear[i].P; gear[i + 1].N = gear[i].N;
                    }
                }
            }
            return localReports;
        }
    }
    internal class CalculateArea
    {
        internal Calculate_temp temp = new Calculate_temp();
        internal List<Report> GearPairCalculate(DeterminedValue gear1, DeterminedValue gear2)
        {
            List<Report> localReports = new List<Report>();
            if(gear1.n == 0)
                gear1.n = temp.n2;
            temp = new Calculate_temp();
            gear2.P = gear1.P; gear2.N = gear1.N;
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對計算", gear1.GearName, gear2.GearName), symbol = null, unit = null, CV = null });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪轉速", gear1.GearName), symbol = "n", unit = "rpm", CV = string.Format("{0:0.000}", gear1.n) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪轉速", gear2.GearName), symbol = "n", unit = "rpm", CV = string.Format("{0:0.000}", SpeedCalculation(gear1.n, gear1.z, gear2.z)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪扭矩", gear1.GearName), symbol = "T", unit = "Nmm", CV = string.Format("{0:0.000}", TorqueCalculation(gear1.P, gear1.n)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪扭矩", gear2.GearName), symbol = "T", unit = "Nmm", CV = string.Format("{0:0.000}", TorqueCalculation(gear2.P, temp.n2)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對中心距", gear1.GearName, gear2.GearName), symbol = "a", unit = "mm", CV = string.Format("{0:0.000}", CenterDistanceCalculation(gear1.alphan, gear1.beta, gear1.xn, gear2.xn, gear1.z, gear2.z, gear1.mn)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對軸向嚙合率", gear1.GearName, gear2.GearName), symbol = "eps_a", unit = "N/A", CV = string.Format("{0:0.000}", ContactRatioCalculation(gear1.beta, gear1.xn, gear2.xn, gear1.z, gear2.z, gear1.mn)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對總嚙合率", gear1.GearName, gear2.GearName), symbol = "eps_g", unit = "N/A", CV = string.Format("{0:0.000}", TotalContactRatioCalculation(gear1.beta, gear1.mn)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪接觸應力安全係數", gear1.GearName), symbol = "SHBD", unit = "N/A", CV = string.Format("{0:0.000}", ContactStressSafetyFactorCalculation(gear1.alphan, gear1.beta, gear1.z, gear2.z, gear1.mn, gear1.FaceWidth, gear1.v, gear2.v, gear1.E, gear2.E, gear1.cmc, gear1.cpm, gear1.cma, gear1.ce, temp.n1, gear1.Qv, gear1.Ka, gear1.Ks, gear1.HB, gear2.HB, gear1.Rq, gear2.Rq, gear1.Tc, gear1.Kr, gear1.N)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪接觸應力安全係數", gear2.GearName), symbol = "SHBD", unit = "N/A", CV = string.Format("{0:0.000}", ContactStressSafetyFactorCalculation(gear1.alphan, gear1.beta, gear2.z, gear1.z, gear1.mn, gear2.FaceWidth, gear2.v, gear1.v, gear2.E, gear1.E, gear1.cmc, gear1.cpm, gear1.cma, gear1.ce, temp.n2, gear2.Qv, gear1.Ka, gear1.Ks, gear2.HB, gear1.HB, gear2.Rq, gear1.Rq, gear1.Tc, gear1.Kr, gear2.N)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪彎曲應力安全係數", gear1.GearName), symbol = "SF", unit = "N/A", CV = string.Format("{0:0.000}", BendingFactorofSafetyCalculation(gear1.alphan, gear1.beta, gear1.xn, gear2.xn, gear1.z, gear2.z, gear1.mn, gear1.FaceWidth, gear1.di, gear1.Ka, gear1.Ks, gear1.HB, gear1.Kr)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}齒輪彎曲應力安全係數", gear2.GearName), symbol = "SF", unit = "N/A", CV = string.Format("{0:0.000}", BendingFactorofSafetyCalculation(gear1.alphan, gear1.beta, gear2.xn, gear1.xn, gear2.z, gear1.z, gear1.mn, gear2.FaceWidth, gear2.di, gear1.Ka, gear1.Ks, gear2.HB, gear1.Kr)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對正向力", gear1.GearName, gear2.GearName), symbol = "Fn", unit = "N", CV = string.Format("{0:0.000}", NormalForceCalculation(gear1.alphan, gear1.beta)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對軸向力", gear1.GearName, gear2.GearName), symbol = "Fa", unit = "N", CV = string.Format("{0:0.000}", AxialForceCalculation(gear1.beta)) });
            localReports.Add(new Report() { CalculationItems = String.Format("{0}及{1}齒輪對徑向力", gear1.GearName, gear2.GearName), symbol = "Fr", unit = "N", CV = string.Format("{0:0.000}", RadialForceCalculation(gear1.alphan, gear1.beta)) });
            if (localReports[12].CV == "0.000")
                localReports[12].CV = "N/A";
            if (localReports[13].CV == "0.000")
                localReports[13].CV = "N/A";
            if (localReports[14].CV == "0.000")
                localReports[14].CV = "N/A";
            return localReports;
        }
        private double SpeedCalculation(double n1, double z1, double z2)
        {
            temp.n1 = n1;
            temp.n2 = n1 / (z2 / z1);
            return temp.n2;
        }
        private double TorqueCalculation(double P, double n)
        {
            temp.T = (60.0 * P) / (2.0 * Math.PI * n) * 1000.0;
            return temp.T;
        }
        private double CenterDistanceCalculation(double alphan, double beta, double x1, double x2, double z1, double z2, double mn)
        {
            temp.alphat = Math.Atan(Math.Tan(alphan * Math.PI / 180.0) / Math.Cos(beta * Math.PI / 180.0));//軸直角壓力角
            temp.invalphawt = 2.0 * Math.Tan(alphan * Math.PI / 180.0) * ((x1 + x2) / (z1 + z2)) + (Math.Tan(temp.alphat) - temp.alphat);//軸直角咬合壓力角的漸開線函數
            temp.alphawt = InvoluteInverseFunction(temp.invalphawt);
            temp.y = (z1 + z2) / (2.0 * Math.Cos(beta * Math.PI / 180.0)) * (Math.Cos(temp.alphat) / Math.Cos(temp.alphawt) - 1.0);//中心距修正係數
            temp.a = ((z1 + z2) / (2.0 * Math.Cos(beta * Math.PI / 180.0)) + temp.y) * mn;
            return temp.a;
        }
        private double InvoluteInverseFunction(double inv)
        {
            double gr = 0.5 * (3.0 - Math.Sqrt(5.0)); //golden ratio
            double eps = 1e-5; //allowable error
            double xL = 0.1 * Math.PI / 180;
            double xR = 89.9 * Math.PI / 180;
            double x1 = (1 - gr) * xL + gr * xR;
            double x2 = gr * xL + (1 - gr) * xR;
            double f1 = InvoluteFunction(x1, inv);
            double f2 = InvoluteFunction(x2, inv);
            while (xR - xL > eps)
            {
                if (f1 < f2)
                {
                    xR = x2; x2 = x1; f2 = f1;
                    x1 = (1 - gr) * xL + gr * xR;
                    f1 = InvoluteFunction(x1, inv);
                }
                else
                {
                    xL = x1; x1 = x2; f1 = f2;
                    x2 = gr * xL + (1 - gr) * xR;
                    f2 = InvoluteFunction(x2, inv);
                }
            }
            double Involute = 0.5 * (xL + xR);
            return Involute;
        }
        private static double InvoluteFunction(double x, double tar)
        {
            return Math.Abs((Math.Tan(x) - x) - tar);
        }
        private double ContactRatioCalculation(double beta, double x1, double x2, double z1, double z2, double mn)
        {
            temp.ha1 = (1.0 + temp.y - x1) * mn;//齒輪1齒冠高
            temp.ha2 = (1.0 + temp.y - x2) * mn;//齒輪2齒冠高
            temp.dp1 = mn * z1 / Math.Cos(beta * Math.PI / 180.0);//齒輪1節圓直徑
            temp.dp2 = mn * z2 / Math.Cos(beta * Math.PI / 180.0);//齒輪2節圓直徑
            temp.do1 = temp.dp1 + 2.0 * temp.ha1;//齒輪1外徑
            temp.do2 = temp.dp2 + 2.0 * temp.ha2;//齒輪2外徑
            temp.db1 = temp.dp1 * Math.Cos(temp.alphat);//齒輪1基圓直徑
            temp.db2 = temp.dp2 * Math.Cos(temp.alphat);//齒輪2基圓直徑
            temp.alpha1 = Math.Acos(temp.db1 / temp.do1);//齒輪1齒頂壓力角
            temp.alpha2 = Math.Acos(temp.db2 / temp.do2);//齒輪2齒頂壓力角
            temp.epsilons = 1.0 / (2.0 * Math.PI) * (z1 * (Math.Tan(temp.alpha1) - Math.Tan(temp.alphawt)) + z2 * (Math.Tan(temp.alpha2) - Math.Tan(temp.alphawt)));
            return temp.epsilons;
        }
        private double TotalContactRatioCalculation(double beta, double mn)
        {
            temp.bH = temp.do1 * Math.Sin(Math.Acos(1.0 - 2.0 * temp.ha1 / temp.do1));
            double epsilonn = temp.bH * Math.Sin(beta * Math.PI / 180.0) / (mn * Math.PI);
            return temp.epsilons + epsilonn;
        }
        private double CalculateFactorI(double alphan, double beta, double z1, double z2, double mn, double F)
        {
            double do1; double do2;
            double mG = Math.Max(z1, z2) / Math.Min(z1, z2);
            double R1 = Math.Min(z1, z2) / (2.0 * Math.Cos(beta * Math.PI / 180.0));
            double R2 = Math.Max(z1, z2) / (2.0 * Math.Cos(beta * Math.PI / 180.0));
            double phi = Math.Atan(Math.Tan(alphan * Math.PI / 180.0) / Math.Cos(beta * Math.PI / 180.0)); ;
            double Rb1 = R1 * Math.Cos(phi);
            double Rb2 = R2 * Math.Cos(phi);
            if (temp.do1 < temp.do2)
            {
                do1 = temp.do1 / mn; do2 = temp.do2 / mn;
            }
            else
            {
                do1 = temp.do2 / mn; do2 = temp.do1 / mn;
            }
            double phir = Math.Acos((Rb1 + Rb2) / (temp.a / mn));
            double Px = Math.PI / Math.Sin(beta * Math.PI / 180.0);
            double mF = F / Px;
            temp.mG = mG;
            double Rm1 = 0.5 * (do1 / 2.0 + ((temp.a / mn) - do2 / 2.0));
            double C5 = Math.Pow(Math.Pow(do1 / 2.0, 2.0) - Math.Pow(Rb1, 2.0), 0.5);
            double C6 = (temp.a / mn) * Math.Sin(phir);
            double C1 = C6 - Math.Pow(Math.Pow(do2 / 2.0, 2.0) - Math.Pow(Rb2, 2.0), 0.5);
            double Z = C5 - C1;
            double rhom1 = Math.Pow(Math.Pow(Rm1, 2.0) - Math.Pow(Rb1, 2.0), 0.5);
            double rhom2 = C6 + rhom1;
            double PN = Math.PI * Math.Cos(alphan * Math.PI / 180.0);
            double Pb = 2.0 * Math.PI * Rb1 / Math.Min(z1, z2);
            double Psib = Math.Acos(PN / Pb);
            double rho1 = 0; double rho2 = 0;
            if (mF <= 1.0)
            {
                double C2 = C5 - Pb;
                rho1 = C2;
                rho2 = C6 + rho1;
                temp.CPsi = Math.Pow(1.0 - mF * (1.0 - rhom1 * rhom2 * Z / (rho1 * rho2 * PN)), 0.5);
                temp.mN = 1.0;
            }
            else if(mF > 1.0)
            {
                temp.CPsi = 1.0;
                rho1 = Math.Pow(Math.Pow(Rm1, 2.0) - Math.Pow(Rb1, 2.0), 0.5);
                rho2 = C6 + rho1;
                double mP = Z / Pb;
                if(beta == 0 && mP > 2.0)
                {
                    temp.mN = 1.0;
                }
                else
                {
                    double nr = mP - Math.Floor(mP);
                    double na = mF - Math.Floor(mF);
                    double Lmin;
                    if (na <= 1.0 - nr)
                    {
                        Lmin = (mP * F - na * nr * Px) / Math.Cos(Psib);
                    }
                    else
                    {
                        Lmin = (mP * F - (1.0 - na) * (1.0 - nr) * Px) / Math.Cos(Psib);
                    }
                    temp.mN = F / Lmin;
                }
            }
            double d = (temp.a / mn) / (mG + 1);
            temp.I = Math.Cos(phir) * Math.Pow(temp.CPsi, 2) / ((1 / rho1 + 1 / rho2) * d * temp.mN);
            return temp.I;
        }
        private double CalculateFactorJ(double alphan, double beta, double x1, double x2, double z1, double z2, double mn, double F)
        {
            double Px = Math.PI / Math.Sin(beta * Math.PI / 180.0);
            double mF = F / Px;
            double mG = Math.Max(z1, z2) / Math.Min(z1, z2);
            double R1 = Math.Min(z1, z2) / (2.0 * Math.Cos(beta * Math.PI / 180.0));
            double R2 = Math.Max(z1, z2) / (2.0 * Math.Cos(beta * Math.PI / 180.0));
            double phi = Math.Atan(Math.Tan(alphan * Math.PI / 180.0) / Math.Cos(beta * Math.PI / 180.0)); ;
            double Rb1 = R1 * Math.Cos(phi);
            double Rb2 = R2 * Math.Cos(phi);
            double do1; double do2;
            if (temp.do1 < temp.do2)
            {
                do1 = temp.do1 / mn; do2 = temp.do2 / mn;
            }
            else
            {
                do1 = temp.do2 / mn; do2 = temp.do1 / mn;
            }
            double PN = Math.PI * Math.Cos(alphan * Math.PI / 180.0);
            double Pb = 2.0 * Math.PI * Rb1 / Math.Min(z1, z2);
            double Psib = Math.Acos(PN / Pb);
            double phir = Math.Acos((Rb1 + Rb2) / (temp.a / mn));
            double Psir = Math.Atan(Math.Tan(Psib) / Math.Cos(phir));
            double KPsi = 0;
            if(mF <= 1.0 || beta == 0)
            {
                KPsi = 1.0;
            }
            else if(mF > 1.0)
            {
                KPsi = Math.Cos(Psir) * Math.Cos(beta * Math.PI / 180.0);
            }
            double rn = Math.Min(z1, z2) / 2.0;
            double rna = rn + do1 / 2.0 - R1;
            double rnb = rn * Math.Cos(alphan * Math.PI / 180.0);
            double DeltaSn = 2.0 * temp.y * mn * Math.Tan(alphan * Math.PI / 180.0);
            double xg = x1 - DeltaSn / (2.0 * Math.Tan(alphan * Math.PI / 180.0));
            double Sn = Math.PI / 2.0 + 2.0 * xg * Math.Tan(alphan * Math.PI / 180.0);
            double n = Math.Min(z1, z2) / Math.Pow(Math.Cos(beta * Math.PI / 180.0), 3.0);
            double phinL = Math.Pow(Math.Pow(rna / rnb, 2) - 1, 0.5) - Math.Tan(alphan * Math.PI / 180.0) + alphan * Math.PI / 180.0 - Sn / n;
            double phinr = Math.Asin(Math.Cos(Psib) * Math.Sin(alphan * Math.PI / 180.0));
            double rnL = rnb / Math.Cos(phinL);
            double no = 10000.0 / Math.Pow(Math.Cos(beta * Math.PI / 180.0), 3);
            double invphin__ = Math.Tan(alphan * Math.PI / 180.0) - alphan * Math.PI / 180.0 + 2.0 * (x1 + x2) * Math.Tan(alphan * Math.PI / 180.0) / (n + no);
            double phin__ = InvoluteInverseFunction(invphin__);
            double rn__ = rn * Math.Cos(alphan * Math.PI / 180.0) / Math.Cos(phin__);
            double rno = no / 2.0;
            double rno__ = rno * Math.Cos(alphan * Math.PI / 180.0) / Math.Cos(phin__);
            double rnoS = rno + temp.ha1;
            double muno = Math.Acos(rno__ * Math.Cos(Math.PI / 2.0) / rnoS) - Math.PI / 2.0;
            double invphinpo = Math.Tan(alphan * Math.PI / 180.0) - alphan * Math.PI / 180.0 + (Math.PI / 2) / (2 * rno);
            double rnbo = rno * Math.Cos(alphan * Math.PI / 180.0);
            double phins = Math.Acos(rnbo / rnoS);
            double lambdans = 2.0 * (invphinpo - Math.Tan(phins) + phins);
            double thetan = (no / n) * (muno - lambdans / 2.0 + Math.PI / no);
            double KF = rno__ * Math.Sin(Math.PI / 2.0) - rnoS * Math.Sin(Math.PI / 2.0 + muno);
            double betan = Math.PI / 2.0 - thetan;
            double etanF = rn__ * Math.Cos(thetan) + KF * Math.Sin(betan);
            double hF = rnL - etanF;
            double xinF = rn__ * Math.Sin(thetan) + KF * Math.Cos(betan);
            double SF = 2.0 * xinF;
            double Ch = 0;
            if(mF <= 1.0 || beta == 0)
            {
                Ch = 1.0;
            }
            else if(mF > 1.0)
            {
                double omega = Math.Atan(Math.Tan(beta * Math.PI / 180.0) * Math.Sin(alphan * Math.PI / 180.0));
                Ch = 1.0 / (1.0 - Math.Pow((omega / 100.0) * (1.0 - omega / 100.0), 0.5));
            }
            double Y = KPsi / ((Math.Cos(phinL) / Math.Cos(phinr)) * ((6.0 * hF) / (Math.Pow(SF, 2) * Ch) - Math.Tan(phinL) / SF));
            double H = 0.331 - 0.436 * (alphan * Math.PI / 180.0);
            double rhoF = Math.Pow(rno__ - rnoS, 2.0) / (rn__ * rno__ / (rn__ + rno__) - (rno__ - rnoS));
            double L = 0.324 - 0.492 * (alphan * Math.PI / 180.0);
            double M = 0.261 + 0.545 * (alphan * Math.PI / 180.0);
            double Kf = H + Math.Pow(SF / rhoF, L) * Math.Pow(SF / hF, M);
            temp.J = Y * temp.CPsi / (Kf * temp.mN);
            return temp.J;
        }
        private double ContactStressSafetyFactorCalculation(double alphan, double beta, double z1, double z2, double mn, double F, double v1, double v2, double E1, double E2, CourseCorrection courseCorrection, double cpm, PlaceofUseGears placeofUseGears, EngagementAxisAmendment engagementAxisAmendment, double n, double Qv, double Ka, double Ks, double HB, double HB2, double Rq1, double Rq2, double Tc, double Kr, double N)
        {
            double vp; double vg; double Ep; double Eg; double HBp; double HBg; double Rq;
            if (temp.do1 < temp.do2)
            {
                vp = v1; vg = v2;
                Ep = E1; Eg = E2;
                HBp = HB; HBg = HB2;
                Rq = Rq1;
            }
            else
            {
                vp = v2; vg = v1;
                Ep = E2; Eg = E1;
                HBp = HB2; HBg = HB;
                Rq = Rq2;
            }
            temp.Cp = Math.Sqrt(1.0 / (Math.PI * ((1.0 - Math.Pow(vp, 2.0)) / Ep + (1.0 - Math.Pow(vg, 2.0)) / Eg)));//彈性係數
            temp.dpr1 = temp.db1 / Math.Cos(temp.alphawt);//嚙合圓直徑
            temp.dpr2 = temp.db2 / Math.Cos(temp.alphawt);//嚙合圓直徑
            temp.Wt = 2 * temp.T / temp.dpr2;//切向力
            if (courseCorrection == CourseCorrection.Modification)
                temp.cmc = 0.8;
            else if (courseCorrection == CourseCorrection.NoModification)
                temp.cmc = 1.0;
            if (F / (10 * temp.dp1) > 0.05)
            {
                if (F <= 25.4)
                    temp.cpf = F / (10 * temp.dp1) - 0.025;
                else if (F > 25.4 && F <= 431.8)
                    temp.cpf = F / (10 * temp.dp1) - 0.0375 + 0.000492 * F;
                else if (F > 431.8 && F <= 1016)
                    temp.cpf = F / (10 * temp.dp1) - 0.1109 + 0.0008149 * F - 0.000000353401 * Math.Pow(F, 2.0);
            }
            else
            {
                if (F <= 25.4)
                    temp.cpf = 0.05 - 0.025;
                else if (F > 25.4 && F <= 431.8)
                    temp.cpf = 0.05 - 0.0375 + 0.000492 * F;
                else if (F > 431.8 && F <= 1016)
                    temp.cpf = 0.05 - 0.1109 + 0.0008149 * F - 0.000000353401 * Math.Pow(F, 2.0);
            }
            if (placeofUseGears == PlaceofUseGears.OpenType)
                temp.cma = 0.274 + 0.000657 * F - 0.000000118575 * Math.Pow(F, 2.0);
            else if(placeofUseGears == PlaceofUseGears.GeneralClosedType)
                temp.cma = 0.127 + 0.000622 * F - 0.000000169415 * Math.Pow(F, 2.0);
            else if(placeofUseGears == PlaceofUseGears.PrecisionClosedType)
                temp.cma = 0.0675 + 0.000504 * F - 0.00000014353 * Math.Pow(F, 2.0);
            else if(placeofUseGears == PlaceofUseGears.UltraPrecisionClosedType)
                temp.cma = 0.038 + 0.000402 * F - 0.00000012741 * Math.Pow(F, 2.0);
            if (engagementAxisAmendment == EngagementAxisAmendment.Grinding)
                temp.ce = 0.8;
            else if (engagementAxisAmendment == EngagementAxisAmendment.NoGrinding)
                temp.ce = 1.0;
            temp.Km = 1 + temp.cmc * (temp.cpf * cpm + temp.cma * temp.ce);//均載係數
            temp.Vt = n / 60.0 * (2 * Math.PI) * (temp.dp1 / 2);//齒輪節點切向速度
            if (Qv >= 6 && Qv <= 11)
            {
                double B = 0.25 * Math.Pow(12.0 - Qv, 2.0 / 3.0);
                double A = 50.0 + 56.0 * (1 - B);
                temp.Kv = Math.Pow(A / (A + Math.Sqrt(200.0 * temp.Vt)), B);//動力係數
            }
            else if (Qv <= 5)
            {
                temp.Kv = 50 / (50 + Math.Sqrt(200.0 * temp.Vt));//動力係數
            }
            temp.Ss = temp.Cp * Math.Sqrt(temp.Wt * Ka * Ks * temp.Km / temp.Kv * 1.0 / (temp.dpr1 * F * CalculateFactorI(alphan, beta, z1, z2, mn, F)));//實際接觸應力
            temp.ScT = 179.26 + 2.25453 * HB;//理論抗接觸破壞強度
            if (N <= 10000.0)
                temp.Kl = 1.47229;
            else if (N > 10000.0 && N < 10000000.0)
                temp.Kl = 2.466 * Math.Pow(N, -0.056);
            else
                temp.Kl = 1.4488 * Math.Pow(N, -0.023);//壽命修正係數
            if (HBp > 48.0)
            {
                temp.Ch = 1.0 + 0.00075 * Math.Exp(-0.052 * Rq) * (450.0 - HBg);
            }
            else
            {
                double A = 0;
                if(HBp / HBg < 1.2)
                    A = 0;
                else if (HBp / HBg >= 1.2 && HBp / HBg <= 1.7)
                    A = 0.00898 * HBp / HBg - 0.00829;
                else if (HBp / HBg > 1.7)
                    A = 0.0698;
                temp.Ch = 1.0 + A * (temp.mG - 1.0);
            }
            if (Tc < 120.0)
                temp.Kt = 1.0;
            else if (Tc >= 120.0)
                temp.Kt = 647.0 / 775.0 + 9.0 * Tc / 3100.0;
            temp.Sc = temp.Kl * temp.Ch / (temp.Kt * Kr) * temp.ScT;//實際抗接觸破壞強度
            temp.Nc = temp.Sc / temp.Ss;
            return temp.Nc;
        }
        private double BendingFactorofSafetyCalculation(double alphan, double beta, double x1, double x2, double z1, double z2, double mn, double F, double di, double Ka, double Ks, double HB, double Kr)
        {
            temp.hr1 = (1.25 - x1) * mn;//齒輪齒根高
            temp.ht1 = temp.ha1 + temp.hr1;//齒輪全齒高
            temp.dr1 = temp.dp1 - 2.0 * temp.hr1;//齒底圓直徑
            temp.tR = (temp.dr1 - di) / 2.0;//齒輪輪緣厚
            temp.mb = temp.tR / temp.ht1;
            if (temp.mb <= 1.2)
                temp.Kb = (-2.0) * temp.mb + 3.4;
            else
                temp.Kb = 1.0;
            temp.St = temp.Wt / (F * mn) * (1 / CalculateFactorJ(alphan, beta, x1, x2, z1, z2, mn, F)) * (Ka * Ks * temp.Km * temp.Kb / temp.Kv);//彎曲應力
            temp.SbT = -1.8769 + 1.14395 * HB - 0.0010412 * Math.Pow(HB, 2.0);//理論抗彎曲強度
            temp.Sb = temp.Kl / (temp.Kt * Kr) * temp.SbT;//實際抗彎曲強度
            temp.Nb = temp.Sb / temp.St;
            return temp.Nb;
        }
        private double NormalForceCalculation(double alphan, double beta)
        {
            temp.Fn = temp.Wt / Math.Cos(beta * Math.PI / 180.0) / Math.Cos(alphan * Math.PI / 180.0);//正向力
            return temp.Fn;
        }
        private double AxialForceCalculation(double beta)
        {
            temp.Fa = temp.Wt * Math.Tan(beta * Math.PI / 180.0);//軸向力
            return temp.Fa;
        }
        private double RadialForceCalculation(double alphan, double beta)
        {
            temp.Fr = temp.Wt / Math.Cos(beta * Math.PI / 180.0) * Math.Tan(alphan * Math.PI / 180.0);//徑向力
            return temp.Fr;
        }
    }
}
