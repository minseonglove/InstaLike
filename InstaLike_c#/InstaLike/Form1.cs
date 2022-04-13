using System;
using System.Windows.Forms;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InstaLike
{
    public partial class Form1 : Form
    {
        private static Boolean login_flag = false;
        private static Boolean stop_flag = false;
        private static Boolean is_otp = false;
        private static Boolean otp_flag = false;
        private static Boolean is_running = false;
        private static Boolean force_stop = false;
        ChromeDriverService _service;
        IWebDriver _driver = null;
        String url = "";

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form_Closing;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!otp_flag)
                {
                    if (_driver == null)
                    {
                        _service = ChromeDriverService.CreateDefaultService();
                        _service.HideCommandPromptWindow = true;
                        _driver = new ChromeDriver(_service);

                        url = "https://www.instagram.com";
                    }
                    //로그인
                    _driver.Navigate().GoToUrl(url);
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                    var email_box = _driver.FindElement(By.Name("username"));
                    email_box.SendKeys(input_email.Text);
                    var pass_box = _driver.FindElement(By.Name("password"));
                    pass_box.SendKeys(input_pwd.Text);
                    var login_btn = _driver.FindElements(By.TagName("button"));
                    for(int i = 0; i < login_btn.Count; i++)
                    {
                        if (login_btn[i].GetAttribute("type").Equals("submit"))
                        {
                            login_btn[i].Click();
                            break;
                        }
                    }
                }
                if (!is_otp)
                {
                    lb_state.Text = "로그인 성공";
                    login_flag = true;
                }
                else
                {
                    if (otp_flag)
                    {
                        var otp_box = _driver.FindElement(By.Name("verificationCode"));
                        otp_box.SendKeys(input_otp.Text);
                        _driver.FindElement(By.TagName("button")).Click();
                        lb_state.Text = "로그인 성공";
                        login_flag = true;
                    }
                    else
                    {
                        otp_flag = true;
                        lb_state.Text = "2차 비번을 입력하세요";
                        btn_login.Text = "2차 로그인";
                    }
                }
            }
            catch (Exception E)
            {
                lb_state.Text = "로그인 실패";
            }

        }

        // 프로그램 종료
        public void Form_Closing(object sender, FormClosedEventArgs e)
        {
            lb_state.Text = "종료중";
            if(_driver != null)
                _driver.Close();
        }

        //2차비번 여부
        private void check_otp_CheckedChanged(object sender, EventArgs e)
        {
            is_otp = !is_otp;
            input_otp.Enabled = is_otp;
        }

        private void check_passLogin_CheckedChanged(object sender, EventArgs e)
        {
            login_flag = !login_flag;
            if (login_flag)
                lb_state.Text = "로그인 했다 치고";
            else
                lb_state.Text = " ";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int min_sleep = 1000;
            int max_sleep = 3000;
            int limit = 100000;
            String str = "";
            if (!Int32.TryParse(input_minWait.Text, out min_sleep))
            {
                min_sleep = 1000;
            }
            if (!Int32.TryParse(input_maxWait.Text, out max_sleep))
            {
                max_sleep = 3000;
            }
            if (!Int32.TryParse(input_limit.Text, out limit))
            {
                limit = 100000;
            }
            if (login_flag)
            {
                Random rand = new Random();
                try
                {
                    //먼저 돌리던게 있으면 강제 종료가 될 것
                    force_stop = true;
                    if (is_running)
                        lb_state.Text = "기존 작업 종료중..";
                    while (is_running) { }
                    url = "https://www.instagram.com/explore/tags/" + input_tag.Text;
                    _driver.Navigate().GoToUrl(url);
                    var image_btn = _driver.FindElement(By.CssSelector("#react-root > section > main > article > div:nth-child(3) > div > div:nth-child(1) > div:nth-child(1) > a"));
                    image_btn.Click();
                    Thread th = new Thread(() =>
                    {
                        //검색버튼으로 인한 강제 정지
                        force_stop = false;
                        //돌아가는중
                        is_running = true;
                        //일시정지
                        stop_flag = false;
                        while (limit != 0 && !force_stop)
                        {
                            str = "남은 개수 : " + limit + "개";
                            CrossThread(lb_state, str);
                            ReadOnlyCollection<IWebElement> svgs = _driver.FindElements(By.TagName("svg"));
                            IWebElement nextBtn = null;
                            bool likeCheck = false;
                            bool nextBtnCheck = false;
                            for (int i = 0; i < svgs.Count; i++)
                            {
                                string label = svgs[i].GetAttribute("aria-label");
                                if (label.Equals("좋아요") && svgs[i].GetAttribute("color").Equals("#262626"))
                                {
                                    svgs[i].FindElement(By.XPath("..")).FindElement(By.XPath("..")).FindElement(By.XPath("..")).Click();
                                    likeCheck = true;
                                }
                                else if (label.Equals("다음"))
                                {
                                    nextBtn = svgs[i].FindElement(By.XPath("..")).FindElement(By.XPath("..")).FindElement(By.XPath(".."));
                                    nextBtnCheck = true;
                                }
                                if (likeCheck && nextBtnCheck)
                                    break;
                            }
                            Thread.Sleep(min_sleep + rand.Next(max_sleep - min_sleep));
                            nextBtn.Click();
                            Thread.Sleep(min_sleep + rand.Next(max_sleep - min_sleep));
                            limit--;
                            //일지정지용 무한루프
                            while (stop_flag)
                            {
                                if (force_stop)
                                    break;
                            }
                        }
                        CrossThread(lb_state, "종료");
                        is_running = false;
                    });
                    th.Start();
                }
                catch (Exception E)
                {
                    lb_state.Text = "그런 태그 없어!";
                }
            }
            else // 로그인안함
            {
                lb_state.Text = "로그인 부터 하세요..!";
            }

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stop_flag = !stop_flag;
            if (stop_flag)
                CrossThread(btn_stop, "재개");
            else
                CrossThread(btn_stop, "멈춰!!");
        }

        public static void CrossThread(Control item, String msg)
        {
            item.Text = msg;
            if (item.InvokeRequired)
            {
                item.BeginInvoke((System.Action)(() =>
                {
                    item.Text = msg;
                }));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
