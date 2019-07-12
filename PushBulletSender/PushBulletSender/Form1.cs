using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using PushbulletSharp;
using OpenCvSharp;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PushBulletSender
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region DllImport
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

        // ini 파싱
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                                        int size, string filePath);
        #endregion

        // 화면 캡쳐용
        Bitmap bmp = null;
        // 찾을 이미지용1
        Bitmap pic2 = null;
        // 이미지 찾았는지 확인용
        bool pic2search = false;
        // 핸들
        IntPtr findwindow = IntPtr.Zero;
        Graphics GraphicsData = null;
        bool FindEnd = false;

        // PushBullet 메세지용
        public void MsgPush(string Token, string title, string Msg)
        {
            PushbulletClient Client = new PushbulletClient(Token);

            try
            {
                var current = Client.CurrentUsersInformation();

                PushbulletSharp.Models.Requests.PushNoteRequest reqeust = new PushbulletSharp.Models.Requests.PushNoteRequest()
                {
                    Email = current.Email,
                    Title = title,
                    Body = Msg
                };

                var response = Client.PushNote(reqeust);
            }
            catch (Exception)
            {
                MessageBox.Show("MsgPush 함수 오류, 제목과 내용을 작성 하세요.");
                timer1.Stop();
            }

            timer1.Stop();
        }

        // PushBullet 이미지 첨부 메세지용
        public void ImageMsgPush(string Token, string Msg, string ImagePath)
        {
            try
            {
                PushbulletClient Client = new PushbulletClient(Token);
                var current = Client.CurrentUsersInformation();

                using (var fileStream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    PushbulletSharp.Models.Requests.PushFileRequest reqeust = new PushbulletSharp.Models.Requests.PushFileRequest
                    {
                        Email = current.Email,
                        FileName = Path.GetFileName(ImagePath),
                        FileType = "image/png",
                        FileStream = fileStream,
                        Body = Msg
                    };
                    var response = Client.PushFile(reqeust);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ImageMsgPush 함수 오류. 내용을 작성 하세요.");
                timer1.Stop();
            }

            timer1.Stop();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox1.Text == null)
                    return;

                // 핸들 찾기
                findwindow = FindWindow(null, metroTextBox1.Text);

                // 핸들이 있다면
                if (findwindow != IntPtr.Zero)
                {
                    // 핸들 Graphics 가져오기
                    GraphicsData = Graphics.FromHwnd(findwindow);

                    // 핸들 크기 밎 위치 가져오기
                    Rectangle rect = Rectangle.Round(GraphicsData.VisibleClipBounds);

                    // 화면 캡쳐 
                    bmp = new Bitmap(rect.Width, rect.Height);

                    // 화면 못얻어오면 에러 메세지 보내기
                    if (rect.Width == 0 && rect.Height == 0)
                    {
                        MessageBox.Show("비트맵 생성 에러");
                        return;
                    }

                    // 캡쳐한 화면에서 Hdc 얻기
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        IntPtr hdc = g.GetHdc();
                        PrintWindow(findwindow, hdc, 0x3); // 0x2 모든창, 0x3 제목줄 없는 창
                        g.ReleaseHdc(hdc); // 사용 해제
                    }

                    pictureBox1.Image = bmp; // 캡쳐 이미지 확인용

                }
                else
                {
                    // 못 찾았다면
                    MessageBox.Show("캡쳐할 프로그램을 찾지 못했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("캡쳐할 화면을 못찾았습니다.\r\n최소화 상태에서는 캡쳐가 불가능 합니다.");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pic2 = new Bitmap(openFileDialog1.FileName);
                    pictureBox2.Image = pic2;
                }
                catch
                {
                    MessageBox.Show("정상적인 미끼 이미지를 넣으세요.");
                    return;
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic2search == false)
            {
                GetScreen();
                var ppic2 = pic2.Clone();

                searchIMG1(bmp, (Bitmap)ppic2);

                pic2search = true;
                bmp.Dispose();
            }
            else
            {
                GetScreen();
                pic2search = false;
                bmp.Dispose();
            }
        }
        
        public void GetScreen()
        {
            try
            {
                if (!FindEnd)
                {
                    findwindow = FindWindow(null, metroTextBox1.Text);
                    FindEnd = true;
                }

                if (findwindow != IntPtr.Zero)
                {
                    // Graphics 가져오기
                    GraphicsData = Graphics.FromHwnd(findwindow);

                    // 크기 밎 위치 가져오기
                    Rectangle rect = Rectangle.Round(GraphicsData.VisibleClipBounds);

                    // 비트맵 
                    bmp = new Bitmap(rect.Width, rect.Height);

                    // 화면 못얻어오면 에러 메세지 보내기
                    if (rect.Width == 0 && rect.Height == 0)
                    {
                        MessageBox.Show("비트맵 생성 에러");
                        return;
                    }

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        IntPtr hdc = g.GetHdc();
                        PrintWindow(findwindow, hdc, 0x3);
                        g.ReleaseHdc(hdc);
                    }
                }
                else
                {
                    //MessageBox.Show("못찾음");
                }
            }
            catch
            {
                return;
            };
        }
        
        public void searchIMG1(Bitmap screen_img, Bitmap find_img)
        {
            try
            {
                // 스크린 이미지
                using (Mat ScreenMat = OpenCvSharp.Extensions.BitmapConverter.ToMat(screen_img))
                // 찾을 이미지
                using (Mat FindMat = OpenCvSharp.Extensions.BitmapConverter.ToMat(find_img))
                // 템플릿 매칭
                using (Mat res = ScreenMat.MatchTemplate(FindMat, TemplateMatchModes.CCoeffNormed))
                {
                    double minval, maxval = 0;
                    OpenCvSharp.Point minloc, maxloc;
                    Cv2.MinMaxLoc(res, out minval, out maxval, out minloc, out maxloc);

                    if (maxval >= Convert.ToDouble(comboBox1.Text))
                    {
                        label10.Text = "상태 : " + "이미지 찾음. 메세지 전송";

                        if (radioButton1.Checked)
                        {
                            MsgPush(TokenTB.Text, SendTitleTB.Text, SendBodyTB.Text);
                        }
                        else if (radioButton2.Checked)
                        {
                            screen_img.Save(Application.StartupPath + "\\1.PNG");
                            ImageMsgPush(TokenTB.Text, SendBodyTB.Text, Application.StartupPath + "\\1.PNG");
                        }

                        ScreenMat.Release();
                        FindMat.Release();
                        res.Release();
                        GraphicsData.Dispose();
                        bmp.Dispose();
                        screen_img.Dispose();
                        
                    }
                    else
                    {
                        label10.Text = "상태 : " + "이미지 찾는중.";
                    }
                }
            }
            catch(Exception ex)
            {
                if(ex.Message == "값은 null일 수 없습니다.\r\n매개 변수 이름: accessToken")
                {
                    label10.Text = "토큰값을 입력하지 않았습니다.";
                }

                label10.Text = "이미지 찾기 에러. 찾을 이미지가 PNG 파일인지 확인하세요.";
                return;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder retToken = new StringBuilder();
            StringBuilder retProg = new StringBuilder();

            GetPrivateProfileString("PushBullet", "Token", "", retToken, 100, Application.StartupPath + "\\Settings.ini");
            GetPrivateProfileString("Program", "Name", "", retProg, 100, Application.StartupPath + "\\Settings.ini");

            TokenTB.Text = retToken.ToString();
            metroTextBox1.Text = retProg.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string file = Application.StartupPath + "\\Settings.ini";

            if (checkBox1.Checked)
            {
                if (File.Exists(file))
                {
                    WritePrivateProfileString("PushBullet", "Token", TokenTB.Text, file);
                    WritePrivateProfileString("Program", "Name", metroTextBox1.Text, file);
                }
                else
                {
                    StreamWriter textWrite = File.CreateText(file);
                    textWrite.WriteLine("[PushBullet]");
                    textWrite.WriteLine("Token=" + TokenTB.Text);
                    textWrite.WriteLine("[Program]");
                    textWrite.WriteLine("Name=" + metroTextBox1.Text);

                    textWrite.Dispose();
                }
            }
            else
            {
                if (File.Exists(file))
                {
                    WritePrivateProfileString("PushBullet", "Token", "", file);
                    WritePrivateProfileString("Program", "Name", "", file);
                }
                else
                {
                    StreamWriter textWrite = File.CreateText(file);
                    textWrite.WriteLine("[PushBullet]");
                    textWrite.WriteLine("Token=");
                    textWrite.WriteLine("[Program]");
                    textWrite.WriteLine("Name=");
                    textWrite.Dispose();
                }
            }

        }
    }
}
