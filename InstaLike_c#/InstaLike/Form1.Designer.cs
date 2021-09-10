
namespace InstaLike
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_otp = new System.Windows.Forms.TextBox();
            this.check_otp = new System.Windows.Forms.CheckBox();
            this.input_tag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_minWait = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_maxWait = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.input_limit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lb_state = new System.Windows.Forms.Label();
            this.check_passLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(12, 167);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 314);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(14, 62);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(250, 21);
            this.input_email.TabIndex = 4;
            // 
            // input_pwd
            // 
            this.input_pwd.Location = new System.Drawing.Point(12, 101);
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.Size = new System.Drawing.Size(252, 21);
            this.input_pwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "OTP";
            // 
            // input_otp
            // 
            this.input_otp.Enabled = false;
            this.input_otp.Location = new System.Drawing.Point(12, 140);
            this.input_otp.Name = "input_otp";
            this.input_otp.Size = new System.Drawing.Size(252, 21);
            this.input_otp.TabIndex = 7;
            // 
            // check_otp
            // 
            this.check_otp.AutoSize = true;
            this.check_otp.Location = new System.Drawing.Point(93, 171);
            this.check_otp.Name = "check_otp";
            this.check_otp.Size = new System.Drawing.Size(70, 16);
            this.check_otp.TabIndex = 8;
            this.check_otp.Text = "2차 비번";
            this.check_otp.UseVisualStyleBackColor = true;
            this.check_otp.CheckedChanged += new System.EventHandler(this.check_otp_CheckedChanged);
            // 
            // input_tag
            // 
            this.input_tag.Location = new System.Drawing.Point(12, 209);
            this.input_tag.Name = "input_tag";
            this.input_tag.Size = new System.Drawing.Size(252, 21);
            this.input_tag.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tag";
            // 
            // input_minWait
            // 
            this.input_minWait.Location = new System.Drawing.Point(12, 248);
            this.input_minWait.Name = "input_minWait";
            this.input_minWait.Size = new System.Drawing.Size(110, 21);
            this.input_minWait.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "쉬는시간(msec)";
            // 
            // input_maxWait
            // 
            this.input_maxWait.Location = new System.Drawing.Point(148, 248);
            this.input_maxWait.Name = "input_maxWait";
            this.input_maxWait.Size = new System.Drawing.Size(116, 21);
            this.input_maxWait.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "~";
            // 
            // input_limit
            // 
            this.input_limit.Location = new System.Drawing.Point(12, 287);
            this.input_limit.Name = "input_limit";
            this.input_limit.Size = new System.Drawing.Size(252, 21);
            this.input_limit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "리미트";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(93, 314);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 17;
            this.btn_stop.Text = "멈춰!!";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lb_state
            // 
            this.lb_state.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_state.AutoSize = true;
            this.lb_state.Location = new System.Drawing.Point(110, 360);
            this.lb_state.Name = "lb_state";
            this.lb_state.Size = new System.Drawing.Size(33, 12);
            this.lb_state.TabIndex = 18;
            this.lb_state.Text = "State";
            this.lb_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // check_passLogin
            // 
            this.check_passLogin.AutoSize = true;
            this.check_passLogin.Location = new System.Drawing.Point(169, 171);
            this.check_passLogin.Name = "check_passLogin";
            this.check_passLogin.Size = new System.Drawing.Size(104, 16);
            this.check_passLogin.TabIndex = 19;
            this.check_passLogin.Text = "로긴 했다 치고";
            this.check_passLogin.UseVisualStyleBackColor = true;
            this.check_passLogin.CheckedChanged += new System.EventHandler(this.check_passLogin_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 404);
            this.Controls.Add(this.check_passLogin);
            this.Controls.Add(this.lb_state);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.input_limit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_maxWait);
            this.Controls.Add(this.input_minWait);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_tag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.check_otp);
            this.Controls.Add(this.input_otp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_pwd);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "Insta2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_otp;
        private System.Windows.Forms.CheckBox check_otp;
        private System.Windows.Forms.TextBox input_tag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_minWait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_maxWait;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_limit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lb_state;
        private System.Windows.Forms.CheckBox check_passLogin;
    }
}

