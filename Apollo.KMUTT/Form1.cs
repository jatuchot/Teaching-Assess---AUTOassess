using HtmlAgilityPack;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Apollo.KMUTT
{
    public partial class Form1 : Form
    {
        bool ckListLecturersLoad = false;
        bool countAppIcon = false;
        int typeAssess = 0;
        int countHref = 0;
        int iconApp = 0;
        
        ArrayList arrayApollo = new ArrayList();

        public Form1()
        {
            InitializeComponent();

            ckListLecturersLoad = false;
            typeAssess = 0;
            countHref = 0;
            iconApp = 0;

            checkedListLecturers.Enabled = false;
            btnSTDAssess.Enabled = false;

            txtIndexAjan.Enabled = false;
            txtNameAjan.Enabled = false;
            txtEnableAjan.Enabled = false;
            txtMaxScoreAjan.Enabled = false;
            txtMinScoreAjan.Enabled = false;
            txtCommentAjan.Enabled = false;
            btnConfigAjan.Enabled = false;

            webApollo.ScriptErrorsSuppressed = true;
            webApollo.Navigate("https://apollo.kmutt.ac.th/newassess-std/Default.aspx");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;

            if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("กรุณากรอกรหัสนักศึกษาหรือรหัสผ่านของท่าน ? :)", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                webApollo.Document.GetElementById("txtUsername").SetAttribute("value", txtUsername.Text);
                webApollo.Document.GetElementById("txtPassword").SetAttribute("value", txtPassword.Text);
                webApollo.Document.GetElementById("btnLogin").InvokeMember("Click");

                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - เริ่มระบบล็อกอิน รหัส "+ txtUsername.Text);
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;

                tLoginApollo.Start();

                btnLogin.Enabled = false;
            }
        }

        private void tLoginApollo_Tick(object sender, EventArgs e)
        {
            try
            {
                if (webApollo.Document.GetElementById("lblMsg") != null && webApollo.Document.GetElementById("lblMsg").InnerText == "ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง")
                {
                    tLoginApollo.Stop(); // Stop !

                    listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - รหัสผิดกรุณาลองใหม่");
                    listStatusBox.TopIndex = listStatusBox.Items.Count - 1;

                    txtUsername.Enabled = true;
                    txtPassword.Enabled = true;

                    webApollo.Navigate("https://apollo.kmutt.ac.th/newassess-std/Default.aspx");
                    MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านไม่ถูกต้อง กรุณาลองใหม่ ? :)", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnLogin.Enabled = true;
                }
                else
                {
                    listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ล็อกอินสำเร็จ !");
                    listStatusBox.TopIndex = listStatusBox.Items.Count - 1;

                    tCPreviousApollo.Start();
                    tLoginApollo.Stop();
                }
            }
            catch
            {
                // Maybe not use!
            }
        }

        private void tCPreviousApollo_Tick(object sender, EventArgs e)
        {
            if(webApollo.Url.ToString() == "https://apollo.kmutt.ac.th/newassess-std/CheckPrevious.aspx")
            {
                tCPreviousApollo.Stop();
                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ยืนยันตัวตน !");
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
                webApollo.Document.GetElementById("btnCheckPrevious").InvokeMember("Click");
                tChooseLecturers.Start();
            }
        }

        private void tChooseLecturers_Tick(object sender, EventArgs e)
        {
            if (webApollo.Url.ToString() == "https://apollo.kmutt.ac.th/newassess-std/CheckStudy.aspx")
            {
                tChooseLecturers.Stop();

                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - เรียกรายชื่ออาจารย์ !");
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
                try
                {
                    string studyLecturers = null;
                    bool checkLecturers = false;
                    bool checkSections = false;
                    int iLecturers = 0;
                    int iSections = 0;
                    int iEnd = 0;
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(webApollo.DocumentText);
                    foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
                    {
                        foreach (HtmlNode row in table.SelectNodes("tr"))
                        {
                            foreach (HtmlNode cell in row.SelectNodes("th|td"))
                            {
                                if (checkSections == true)
                                {
                                    iSections = iSections + 1;
                                    if (iSections == 1)
                                    {
                                        iSections = 0;
                                        checkSections = false;
                                        studyLecturers = studyLecturers + " - Section : " + cell.InnerText;
                                    }
                                }

                                if (checkLecturers == true)
                                {
                                    iLecturers = iLecturers + 1;
                                    if (iLecturers == 3)
                                    {
                                        iLecturers = 0;
                                        checkLecturers = false;
                                        studyLecturers = studyLecturers + " - Lecturers : " + cell.InnerText;

                                        checkedListLecturers.Items.Add(studyLecturers);

                                        arrayApollo.Add(iEnd + "|" + cell.InnerText + "|");

                                        HtmlElement cbLecturers = webApollo.Document.GetElementById("ChkBoxStudy" + iEnd);
                                        if (cbLecturers != null)
                                        {
                                            string vLecturers = cbLecturers.GetAttribute("checked");
                                            if (vLecturers == "True")
                                            {
                                                checkedListLecturers.SetItemCheckState(iEnd, CheckState.Checked);
                                                arrayApollo[iEnd] = arrayApollo[iEnd] + "1|0|3|";
                                            }
                                            else
                                                arrayApollo[iEnd] = arrayApollo[iEnd] + "0|0|3|";
                                        }
                                        iEnd = iEnd + 1;
                                        studyLecturers = null;
                                    }
                                }

                                if (cell.InnerText != null && cell.InnerText.Length == 6 && cell.InnerText != "Module" && cell.InnerText != "&nbsp;")
                                {
                                    checkLecturers = true;
                                    checkSections = true;

                                    studyLecturers = studyLecturers + cell.InnerText;
                                }
                                else
                                    continue;
                            }
                        }
                    }
                }
                catch
                {
                    // Maybe not!
                }
                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - เรียกรายชื่ออาจารย์เสร็จสิ้น !");
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
            }

            ckListLecturersLoad = true;
            checkedListLecturers.Enabled = true;
            btnSTDAssess.Enabled = true;
            txtMaxScoreAjan.Enabled = true;
            txtMinScoreAjan.Enabled = true;
            txtCommentAjan.Enabled = true;
            btnConfigAjan.Enabled = true;
        }

        private void checkedListLecturers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(ckListLecturersLoad == true)
            {
                try
                {
                    HtmlElement cbLecturers = webApollo.Document.GetElementById("ChkBoxStudy" + checkedListLecturers.SelectedIndex);
                    if (cbLecturers != null)
                    {
                        string vLecturers = cbLecturers.GetAttribute("checked");
                        webApollo.Document.GetElementById("ChkBoxStudy" + checkedListLecturers.SelectedIndex).InvokeMember("Click");
                    }
                }
                catch
                {
                    // Maybe not use!
                }
            }
        }

        private void btnSTDAssess_Click(object sender, EventArgs e)
        {
            btnSTDAssess.Enabled = false;
            txtMaxScoreAjan.Enabled = false;
            txtMinScoreAjan.Enabled = false;
            txtCommentAjan.Enabled = false;
            btnConfigAjan.Enabled = false;

            webApollo.Document.GetElementById("btnConfirm").InvokeMember("Click");
            listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - เริ่มต้นระบบประเมิณอาจารย์ !");
            listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
            tClickAssess.Start();
        }

        private void checkFinishAssess()
        {
            if(countAppIcon == false)
            { 
                HtmlElementCollection iImg = webApollo.Document.GetElementsByTagName("img");
                foreach (HtmlElement iHtml in iImg)
                {
                    string ckContains = iHtml.OuterHtml;
                    if (ckContains.Contains("images/icon/app_48.png"))
                    {
                        iconApp = iconApp + 1;
                    }
                }
                countAppIcon = true;
            }
            if (iconApp <= 1  && countAppIcon == true)
            {
                tClickAssess.Stop();
                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ประเมิณอาจารย์เสร็จสิ้น !");
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
                MessageBox.Show("ประเมิณอาจารย์เสร็จสิ้น!", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tClickAssess_Tick(object sender, EventArgs e)
        {
            if (webApollo.Url.ToString() == "https://apollo.kmutt.ac.th/newassess-std/STDAssess.aspx")
            {
                HtmlElementCollection lAssess = webApollo.Document.GetElementsByTagName("a");
                if (lAssess == null)
                {
                    // Maybe not use!
                }
                else
                {
                    checkFinishAssess();

                    foreach (HtmlElement iLink in lAssess)
                    {
                        string titleAssess = iLink.GetAttribute("href");
                        webApollo.Navigate(titleAssess);
                        typeAssess = 0;
                        tClickAssess.Stop();
                        tCheckType.Start();
                    }
                }
            }
        }

        private void autoCheckBoxAssess()
        {
            countHref = countHref + 1;

            listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ดำเนินการลิ้ง " + webApollo.Url.ToString());
            listStatusBox.TopIndex = listStatusBox.Items.Count - 1;

            HtmlElement nameLecturers = webApollo.Document.GetElementById("txtMasterName");
            if (nameLecturers != null)
            {
                string nLecturers = nameLecturers.GetAttribute("value");
                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ประเมิณ " + nLecturers);
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
            }

            pictureLecturers.ImageLocation = webApollo.Document.GetElementById("Image1").GetAttribute("src");

            int maxScore = 3;
            int minScore = 0;

            int iiLoop = 0;
            bool ckFound = false;
            for (int jLoop = 0; jLoop < arrayApollo.Count; jLoop++)
            {
                iiLoop = 0;
                string[] lecturersList = arrayApollo[jLoop].ToString().Split('|');
                foreach (string lecturers in lecturersList)
                {
                    if (iiLoop == 1)
                    {
                        string[] lName = webApollo.Document.GetElementById("txtMasterName").GetAttribute("value").Split('/');
                        lName[0] = lName[0].Remove(lName[0].Length - 1);
                        if (lecturers == lName[0])
                        {
                            ckFound = true;
                        }
                    }
                    if (iiLoop == 3 && ckFound == true)
                        maxScore = Int32.Parse(lecturers);
                    if (iiLoop == 4 && ckFound == true)
                        minScore = Int32.Parse(lecturers);
                    if (iiLoop == 5 && ckFound == true)
                    {
                        webApollo.Document.GetElementById("COMMENT").SetAttribute("value", lecturers);
                        break;
                    }
                    iiLoop = iiLoop + 1;
                }
                if (ckFound == true)
                    break;
            }

            int iLoop = 0;
            Random rnd = new Random();
            for (iLoop = 0; iLoop < typeAssess + 1; iLoop++)
            {
                int dicePoint = rnd.Next(maxScore, minScore);
                try
                {
                    HtmlElement radioPoint = webApollo.Document.GetElementById("RBL" + iLoop + "_" + dicePoint);
                    if(radioPoint == null)
                    {
                        webApollo.Document.GetElementById("SAVE").InvokeMember("Click");
                        tSavePoint.Start();
                    }
                    else
                        radioPoint.InvokeMember("Click");
                }
                catch
                {
                    // Maybe not use!
                }
            }

            iconApp = iconApp - 1;

            listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ประเมิณอาจารย์คนนี้เสร็จแล้ว");
            listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
        }

        private void tCheckType_Tick(object sender, EventArgs e)
        {
            if (webApollo.ReadyState == WebBrowserReadyState.Complete)
            {
                string wUrl = webApollo.Url.ToString();
                if (wUrl.Contains("PBL00001"))
                    typeAssess = 23;
                else if (wUrl.Contains("THE00001"))
                    typeAssess = 18;
                else if (wUrl.Contains("COM00001"))
                    typeAssess = 20;
                tCheckType.Stop();

                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ทำการเช็คชนิด(ชนิด: " + typeAssess + " )");
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;

                autoCheckBoxAssess();
            }
        }

        private void tSavePoint_Tick(object sender, EventArgs e)
        {
            if (webApollo.ReadyState == WebBrowserReadyState.Complete)
            {
                tSavePoint.Stop();
                listStatusBox.Items.Add(DateTime.Now.ToString("h:mm:ss tt") + " - ประเมิณอาจารย์คนถัดไป");
                listStatusBox.TopIndex = listStatusBox.Items.Count - 1;
                tClickAssess.Start();
            }
        }

        private void btnConfigAjan_Click(object sender, EventArgs e)
        {
            if (txtMinScoreAjan.TextLength == 0 || txtMaxScoreAjan.TextLength == 0)
            {
                MessageBox.Show("กรุณากรอกคะแนนด้วยจร้า ? :)", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int MinScore = 6 - Int32.Parse(txtMinScoreAjan.Text);
                int MaxScore = 6 - Int32.Parse(txtMaxScoreAjan.Text);

                if (MinScore < MaxScore)
                {
                    MessageBox.Show("กรุณากรอกคะแนนให้ต่ำสุดน้อยกว่ามากสุด", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MinScore < 0 || MinScore > 5)
                {
                    MessageBox.Show("กรุณากรอกคะแนน 1 - 6 เท่านั้น", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (MaxScore < 0 || MaxScore > 5)
                {
                    MessageBox.Show("กรุณากรอกคะแนน 1 - 6 เท่านั้น", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    arrayApollo[Int32.Parse(txtIndexAjan.Text)] = txtIndexAjan.Text + "|" + txtNameAjan.Text + "|" + txtEnableAjan.Text + "|" + MaxScore.ToString() + "|" + MinScore.ToString() + "|" + txtCommentAjan.Text;
                    MessageBox.Show("ตั้งค่าอาจารย์" + txtNameAjan.Text + "สำเร็จ", ": Auto Assess Apollo :", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkedListLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iLoop = 0;
            txtIndexAjan.Text = checkedListLecturers.SelectedIndex.ToString();
            string[] lecturersList = arrayApollo[checkedListLecturers.SelectedIndex].ToString().Split('|');
            foreach (string lecturers in lecturersList)
            {
                if (iLoop == 1)
                    txtNameAjan.Text = lecturers;
                if (iLoop == 2)
                    txtEnableAjan.Text = lecturers;
                if (iLoop == 3)
                    txtMaxScoreAjan.Text = Convert.ToString(6 - Int32.Parse(lecturers));
                if (iLoop == 4)
                    txtMinScoreAjan.Text = Convert.ToString(6 - Int32.Parse(lecturers));
                if (iLoop == 5)
                    txtCommentAjan.Text = lecturers;
                iLoop = iLoop + 1;
            }
        }
    }
}