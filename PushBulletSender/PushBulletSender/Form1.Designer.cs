namespace PushBulletSender
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SendBodyTB = new MetroFramework.Controls.MetroTextBox();
            this.SendTitleTB = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TokenTB = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SearchTimer1 = new System.Windows.Forms.Timer(this.components);
            this.SearchTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SearchTimer3 = new System.Windows.Forms.Timer(this.components);
            this.SearchTimer4 = new System.Windows.Forms.Timer(this.components);
            this.SearchCB1 = new System.Windows.Forms.CheckBox();
            this.Search1HTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Search1MTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchCB2 = new System.Windows.Forms.CheckBox();
            this.SearchCB3 = new System.Windows.Forms.CheckBox();
            this.SearchCB4 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Search2MTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Search2HTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Search3MTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Search3HTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Search4MTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Search4HTB = new System.Windows.Forms.TextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.metroTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.metroButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. 캡쳐확인";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "1. 캡쳐할 앱플레이어 이름을 정확하게 입력 한다.\r\n2. 입력후 화면 얻기 버튼으로 정상적으로 캡쳐가 되는지 확인한다.\r\n3. 화면을 잘 받아오" +
    "면 \"설정\" 으로 넘어간다.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(162, 23);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(154, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "피크 앱플레이어 1.2.3";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "캡쳐할 프로그램 이름 : ";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 52);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(292, 38);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "화면 얻기";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.SendBodyTB);
            this.tabPage2.Controls.Add(this.SendTitleTB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TokenTB);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. 설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(18, 419);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(303, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "프로그램 종료시 Token 값 및 캡쳐 프로그램명 저장";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.9",
            "0.8",
            "0.7",
            "0.6",
            "0.5",
            "0.4",
            "0.3",
            "0.2",
            "0.1"});
            this.comboBox1.Location = new System.Drawing.Point(490, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 20);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "0.8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "찾을 이미지 유사도 : ";
            // 
            // SendBodyTB
            // 
            this.SendBodyTB.Location = new System.Drawing.Point(365, 125);
            this.SendBodyTB.Multiline = true;
            this.SendBodyTB.Name = "SendBodyTB";
            this.SendBodyTB.Size = new System.Drawing.Size(325, 125);
            this.SendBodyTB.TabIndex = 10;
            // 
            // SendTitleTB
            // 
            this.SendTitleTB.Location = new System.Drawing.Point(478, 69);
            this.SendTitleTB.Name = "SendTitleTB";
            this.SendTitleTB.Size = new System.Drawing.Size(212, 23);
            this.SendTitleTB.TabIndex = 9;
            this.SendTitleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "전송 메세지 제목 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "전송할 메세지 : ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(156, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "캡쳐화면 포함 전송";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(156, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "메세지만 전송";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "PushBullet Token : ";
            // 
            // TokenTB
            // 
            this.TokenTB.Location = new System.Drawing.Point(138, 388);
            this.TokenTB.Name = "TokenTB";
            this.TokenTB.Size = new System.Drawing.Size(215, 23);
            this.TokenTB.TabIndex = 3;
            this.TokenTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 96);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(18, 18);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(108, 50);
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "찾을 이미지 선택";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.metroButton3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(718, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. 실행";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "상태 : ";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(24, 32);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(80, 50);
            this.metroButton3.TabIndex = 0;
            this.metroButton3.Text = "알림 실행";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SearchTimer1
            // 
            this.SearchTimer1.Interval = 1000;
            // 
            // SearchTimer2
            // 
            this.SearchTimer2.Interval = 1000;
            // 
            // SearchTimer3
            // 
            this.SearchTimer3.Interval = 1000;
            // 
            // SearchTimer4
            // 
            this.SearchTimer4.Interval = 1000;
            // 
            // SearchCB1
            // 
            this.SearchCB1.AutoSize = true;
            this.SearchCB1.Checked = true;
            this.SearchCB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchCB1.Location = new System.Drawing.Point(23, 27);
            this.SearchCB1.Name = "SearchCB1";
            this.SearchCB1.Size = new System.Drawing.Size(82, 16);
            this.SearchCB1.TabIndex = 2;
            this.SearchCB1.Text = "탐색시간 1";
            this.SearchCB1.UseVisualStyleBackColor = true;
            // 
            // Search1HTB
            // 
            this.Search1HTB.Location = new System.Drawing.Point(137, 25);
            this.Search1HTB.Name = "Search1HTB";
            this.Search1HTB.Size = new System.Drawing.Size(41, 21);
            this.Search1HTB.TabIndex = 3;
            this.Search1HTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "시";
            // 
            // Search1MTB
            // 
            this.Search1MTB.Location = new System.Drawing.Point(207, 25);
            this.Search1MTB.Name = "Search1MTB";
            this.Search1MTB.Size = new System.Drawing.Size(41, 21);
            this.Search1MTB.TabIndex = 5;
            this.Search1MTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "분";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.SearchCB4);
            this.groupBox1.Controls.Add(this.Search4MTB);
            this.groupBox1.Controls.Add(this.SearchCB2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.SearchCB3);
            this.groupBox1.Controls.Add(this.Search4HTB);
            this.groupBox1.Controls.Add(this.SearchCB1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Search2MTB);
            this.groupBox1.Controls.Add(this.Search3MTB);
            this.groupBox1.Controls.Add(this.Search1HTB);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Search3HTB);
            this.groupBox1.Controls.Add(this.Search1MTB);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Search2HTB);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(408, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "탐색 알림(만드는중)";
            // 
            // SearchCB2
            // 
            this.SearchCB2.AutoSize = true;
            this.SearchCB2.Checked = true;
            this.SearchCB2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchCB2.Location = new System.Drawing.Point(23, 55);
            this.SearchCB2.Name = "SearchCB2";
            this.SearchCB2.Size = new System.Drawing.Size(82, 16);
            this.SearchCB2.TabIndex = 8;
            this.SearchCB2.Text = "탐색시간 2";
            this.SearchCB2.UseVisualStyleBackColor = true;
            // 
            // SearchCB3
            // 
            this.SearchCB3.AutoSize = true;
            this.SearchCB3.Checked = true;
            this.SearchCB3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchCB3.Location = new System.Drawing.Point(23, 83);
            this.SearchCB3.Name = "SearchCB3";
            this.SearchCB3.Size = new System.Drawing.Size(82, 16);
            this.SearchCB3.TabIndex = 9;
            this.SearchCB3.Text = "탐색시간 3";
            this.SearchCB3.UseVisualStyleBackColor = true;
            // 
            // SearchCB4
            // 
            this.SearchCB4.AutoSize = true;
            this.SearchCB4.Checked = true;
            this.SearchCB4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchCB4.Location = new System.Drawing.Point(23, 110);
            this.SearchCB4.Name = "SearchCB4";
            this.SearchCB4.Size = new System.Drawing.Size(82, 16);
            this.SearchCB4.TabIndex = 10;
            this.SearchCB4.Text = "탐색시간 4";
            this.SearchCB4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "분";
            // 
            // Search2MTB
            // 
            this.Search2MTB.Location = new System.Drawing.Point(207, 52);
            this.Search2MTB.Name = "Search2MTB";
            this.Search2MTB.Size = new System.Drawing.Size(41, 21);
            this.Search2MTB.TabIndex = 10;
            this.Search2MTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "시";
            // 
            // Search2HTB
            // 
            this.Search2HTB.Location = new System.Drawing.Point(137, 52);
            this.Search2HTB.Name = "Search2HTB";
            this.Search2HTB.Size = new System.Drawing.Size(41, 21);
            this.Search2HTB.TabIndex = 8;
            this.Search2HTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "분";
            // 
            // Search3MTB
            // 
            this.Search3MTB.Location = new System.Drawing.Point(207, 79);
            this.Search3MTB.Name = "Search3MTB";
            this.Search3MTB.Size = new System.Drawing.Size(41, 21);
            this.Search3MTB.TabIndex = 14;
            this.Search3MTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "시";
            // 
            // Search3HTB
            // 
            this.Search3HTB.Location = new System.Drawing.Point(137, 79);
            this.Search3HTB.Name = "Search3HTB";
            this.Search3HTB.Size = new System.Drawing.Size(41, 21);
            this.Search3HTB.TabIndex = 12;
            this.Search3HTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(254, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 19;
            this.label15.Text = "분";
            // 
            // Search4MTB
            // 
            this.Search4MTB.Location = new System.Drawing.Point(207, 106);
            this.Search4MTB.Name = "Search4MTB";
            this.Search4MTB.Size = new System.Drawing.Size(41, 21);
            this.Search4MTB.TabIndex = 18;
            this.Search4MTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "시";
            // 
            // Search4HTB
            // 
            this.Search4HTB.Location = new System.Drawing.Point(137, 106);
            this.Search4HTB.Name = "Search4HTB";
            this.Search4HTB.Size = new System.Drawing.Size(41, 21);
            this.Search4HTB.TabIndex = 16;
            this.Search4HTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(82, 144);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(144, 35);
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "탐색 알림 실행";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 547);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PushBulletSender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox TokenTB;
        private MetroFramework.Controls.MetroTextBox SendBodyTB;
        private MetroFramework.Controls.MetroTextBox SendTitleTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox SearchCB4;
        private System.Windows.Forms.TextBox Search4MTB;
        private System.Windows.Forms.CheckBox SearchCB2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox SearchCB3;
        private System.Windows.Forms.TextBox Search4HTB;
        private System.Windows.Forms.CheckBox SearchCB1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Search2MTB;
        private System.Windows.Forms.TextBox Search3MTB;
        private System.Windows.Forms.TextBox Search1HTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Search3HTB;
        private System.Windows.Forms.TextBox Search1MTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Search2HTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer SearchTimer1;
        private System.Windows.Forms.Timer SearchTimer2;
        private System.Windows.Forms.Timer SearchTimer3;
        private System.Windows.Forms.Timer SearchTimer4;
    }
}

