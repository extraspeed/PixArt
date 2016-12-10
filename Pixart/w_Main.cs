using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace PixArt
{
    public partial class w_Main : Form
    {
        public static string work_dir = "http://www.ru-laboratory.xyz/pixart/";
        public static int userid;
        public static int post_count;
        public static bool scroll;
        public static bool like_visible;
        private Form Zoom;
        private FlowLayoutPanel Flow_Pan;
        public static string lang = @"lang.txt";
        public static string way = @".\cash\";
        public static FormWindowState FormWin = FormWindowState.Normal;
        static System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();

        public w_Main()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            KeyPreview = true;
            scroll = false;
        }
        private void b_join_Click(object sender, EventArgs e)
        {
            SwitchControls.w_reg.Show();
            SwitchControls.w_reg.Focus();
        }
        private void b_reload_Click(object sender, EventArgs e)
        {
            ReloadImages();
        }
        private void w_Main_Load(object sender, EventArgs e)
        {
            SwitchControls.w_reg = new w_Registration(this);
            SwitchControls.img_panel = img_panel;
            SwitchControls.b_join = b_join;
            SwitchControls.b_upload = b_upload;
            SwitchControls.b_upload.Visible = false;
            SwitchControls.b_reload = b_reload;
            SwitchControls.b_reload.Visible = false;
            SwitchControls.quit = quit;
            SwitchControls.quit.Visible = false;
            SwitchControls.b_info = b_info;
            SwitchControls.b_info.Visible = false;
            SwitchControls.b_info_cancel = b_info_cancel;
            SwitchControls.b_info_cancel.Visible = false;
            SwitchControls.b_minimize = b_minimize;
            SwitchControls.b_minimize.Visible = false;
            SwitchControls.b_settings = b_settings;
            SwitchControls.b_settings.Visible = false;
            SwitchControls.close_prog = close_prog;
            SwitchControls.l_autorname = l_autorname;
            l_autorname.Visible = false;
            pa_label.Visible = false;
            notifyIcon1.Visible = false;
            set_language();

        }
        private void set_language()
        {
            SwitchControls.tt = tt;
            if (File.Exists(lang) != true)
            {
                comboBox1.SelectedIndex = 0;
                label1.Text = "Выберите язык :";
                label_input.Text = "Введите сообщение";
                b_send.Text = "Отправить";
                b_send_2.Text = "Отправить";
                thank.Text = "Спасибо за отзыв :)";
                in_way.Text = " (:Мы уже в пути";
                SwitchControls.tt.SetToolTip(b_info, "Инфо");
                SwitchControls.tt.SetToolTip(b_settings, "Настройки");
                SwitchControls.tt.SetToolTip(b_upload, "Загрузить изображения");
                SwitchControls.tt.SetToolTip(b_reload, "Обновить");
                SwitchControls.tt.SetToolTip(b_minimize, "Свернуть в трей");
                SwitchControls.tt.SetToolTip(b_feedback, "Оставить отзыв");
                SwitchControls.tt.SetToolTip(b_report, "Сообщить об ошибке");
                SwitchControls.tt.SetToolTip(b_info_cancel, "Выйти из аккаунта");
                SwitchControls.tt.SetToolTip(b_cancel_info, "Назад");
                SwitchControls.tt.SetToolTip(quit, "Завершить сеанс");
                SwitchControls.tt.SetToolTip(close_prog, "Выйти из программы");
                SwitchControls.tt.SetToolTip(b_listbox_ok, "Применить");
                SwitchControls.tt.SetToolTip(b_join, "Войти");

            }
            else
            {
                string text = System.IO.File.ReadAllText(lang);
                if (text.Contains("rus"))
                {
                    comboBox1.SelectedIndex = 0;
                    label1.Text = "Выберите язык :";
                    label_input.Text = "Введите сообщение";
                    b_send.Text = "Отправить";
                    b_send_2.Text = "Отправить";
                    thank.Text = "Спасибо за отзыв :)";
                    in_way.Text = " (:Мы уже в пути";
                    SwitchControls.tt.SetToolTip(b_info, "Инфо");
                    SwitchControls.tt.SetToolTip(b_settings, "Настройки");
                    SwitchControls.tt.SetToolTip(b_upload, "Загрузить изображения");
                    SwitchControls.tt.SetToolTip(b_reload, "Обновить");
                    SwitchControls.tt.SetToolTip(b_minimize, "Свернуть в трей");
                    SwitchControls.tt.SetToolTip(b_feedback, "Оставить отзыв");
                    SwitchControls.tt.SetToolTip(b_report, "Сообщить об ошибке");
                    SwitchControls.tt.SetToolTip(b_info_cancel, "Выйти из аккаунта");
                    SwitchControls.tt.SetToolTip(b_cancel_info, "Назад");
                    SwitchControls.tt.SetToolTip(quit, "Завершить сеанс");
                    SwitchControls.tt.SetToolTip(close_prog, "Выйти из программы");
                    SwitchControls.tt.SetToolTip(b_listbox_ok, "Применить");
                    SwitchControls.tt.SetToolTip(b_join, "Войти");
                }
                else if (text.Contains("eng"))
                {
                    comboBox1.SelectedIndex = 1;
                    label1.Text = "Select language :";
                    label_input.Text = "Input message";
                    b_send.Text = "Send";
                    b_send_2.Text = "Send";
                    thank.Text = "Thank you for feedback";
                    in_way.Text = "We'll do our best to solve the problem";
                    SwitchControls.tt.SetToolTip(b_info, "Info");
                    SwitchControls.tt.SetToolTip(b_settings, "Settings");
                    SwitchControls.tt.SetToolTip(b_upload, "Load images");
                    SwitchControls.tt.SetToolTip(b_reload, "Update");
                    SwitchControls.tt.SetToolTip(b_minimize, "Minimize to tray");
                    SwitchControls.tt.SetToolTip(b_feedback, "Get feedback");
                    SwitchControls.tt.SetToolTip(b_report, "Get error report");
                    SwitchControls.tt.SetToolTip(b_info_cancel, "Back");
                    SwitchControls.tt.SetToolTip(b_cancel_info, "Back");
                    SwitchControls.tt.SetToolTip(quit, "End current session");
                    SwitchControls.tt.SetToolTip(close_prog, "Exit");
                    SwitchControls.tt.SetToolTip(b_listbox_ok, "Apply");
                    SwitchControls.tt.SetToolTip(b_join, "Join");
                }
            }
        }
        private void w_Main_Valide(object sender, EventArgs e)
        {
            time.Interval = 1;
            time.Enabled = true;
            time.Tick += w_Main_ValidePost;
        }
        private void w_Main_ValidePost(object sender, EventArgs e)
        {
            time.Stop();
            Thread myThread = new Thread(obj =>
            {
                like_visible = false;
                post_count = 0;
                for (byte i = 0; i < 7; i++)
                {
                    try
                    {
                        string result = "";
                        ASCIIEncoding ascii = new ASCIIEncoding();
                        string data_2 = string.Format("id={0}&count={1}", i, 4);
                        byte[] bytesarr = ascii.GetBytes(data_2);
                        try
                        {
                            WebRequest request = WebRequest.Create(work_dir + "download_bygroups.php");

                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded";
                            request.ContentLength = bytesarr.Length;

                            Stream streamwriter = request.GetRequestStream();
                            streamwriter.Write(bytesarr, 0, bytesarr.Length);
                            streamwriter.Close();

                            WebResponse response = request.GetResponse();
                            streamwriter = response.GetResponseStream();

                            StreamReader streamread = new StreamReader(streamwriter);
                            result = streamread.ReadToEnd();
                            streamread.Close();
                        }
                        catch (Exception ex)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        string[] data = result.Split('~');

                        Image[] images = new Image[4];
                        int length = data.Length;
                        for (byte j = 0; j < length - 3; j++)
                        {
                            if (!File.Exists(way + data[j]))
                            {
                                WebClient client = new WebClient();
                                Uri uri = new Uri(work_dir + "images/s1/" + data[j]);
                                client.DownloadFile(uri, way + data[j]);
                            }
                            images[j] = Image.FromFile(way + data[j]);
                        }
                        post_count++;
                        this.Invoke(new Action(() =>
                        {
                            CreateMoreFromArray(images, post_count, data[length - 3], data[length - 2], data[length - 1]);
                        }));
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Проверьте подключение к интернету");
                        break;
                    }
                }
                scroll = true;
            }
            );
            myThread.IsBackground = true;
            myThread.Start();
        }
        private void b_upload_Click(object sender, EventArgs e)
        {
            int images = GetImage(work_dir + "upload_image.php", userid);
            if (images > 0)
            {
                ReloadImages();
            }
        }
        private void img_panel_Wheel(object sender, MouseEventArgs e)
        {
            if ((img_panel.VerticalScroll.Value >= img_panel.VerticalScroll.Maximum - img_panel.ClientRectangle.Height - 99) && (scroll == true))
            {
                ScroolLoadImages(post_count);
            }
            //else if ((img_panel.VerticalScroll.Value == img_panel.VerticalScroll.Maximum - img_panel.ClientRectangle.Height + 1) && (scroll != true))
            //{
            //    System.Windows.Forms.Timer scroll_rep = new System.Windows.Forms.Timer();
            //    scroll_rep.Interval = 1000;
            //    scroll_rep.Tick += new EventHandler(scroll_rep_Tick);
            //    scroll_rep.Start();
            //}
        }
        private void scroll_rep_Tick(object sender, EventArgs e)
        {
            if (scroll == true)
            {
                ScroolLoadImages(post_count);
            }
        }
        private void img_panel_MouseEnter(object sender, EventArgs e)
        {
        }
        private void quit_Click(object sender, EventArgs e)
        {
            SwitchControls.w_reg = new w_Registration(this);
            SwitchControls.img_panel = img_panel;
            SwitchControls.b_join = b_join;
            SwitchControls.b_join.Visible = true;
            SwitchControls.b_upload = b_upload;
            SwitchControls.b_upload.Visible = false;
            SwitchControls.b_reload = b_reload;
            SwitchControls.b_reload.Visible = false;
            SwitchControls.quit.Visible = false;
            SwitchControls.b_info.Visible = false;
            SwitchControls.b_minimize.Visible = false;
            SwitchControls.close_prog.Visible = true;
            SwitchControls.b_settings.Visible = false;
            SwitchControls.l_autorname.Visible = false;
        }
        private void b_info_Click(object sender, EventArgs e)
        {
            img_panel.Hide();
            SwitchControls.b_join = b_join;
            SwitchControls.b_join.Visible = false;
            SwitchControls.b_upload = b_upload;
            SwitchControls.b_upload.Visible = false;
            SwitchControls.b_reload = b_reload;
            SwitchControls.b_reload.Visible = false;
            SwitchControls.quit.Visible = false;
            SwitchControls.b_info_cancel = b_info_cancel;
            SwitchControls.b_info_cancel.Visible = true;
            SwitchControls.b_feedback = b_feedback;
            SwitchControls.b_feedback.Visible = true;
            SwitchControls.b_report = b_report;
            SwitchControls.b_report.Visible = true;
            SwitchControls.b_minimize.Visible = false;
            SwitchControls.close_prog.Visible = false;
            SwitchControls.b_info.Visible = false;
            SwitchControls.l_autorname.Visible = false;
            b_settings.Visible = false;
            pa_label.Visible = true;
            in_way.Visible = false;
            thank.Visible = false;
        }
        private void b_info_cancel_Click(object sender, EventArgs e)
        {
            img_panel.Show();
            SwitchControls.b_join = b_join;
            SwitchControls.b_upload = b_upload;
            SwitchControls.b_upload.Visible = true;
            SwitchControls.b_reload = b_reload;
            SwitchControls.b_reload.Visible = true;
            SwitchControls.quit = quit;
            SwitchControls.quit.Visible = true;
            SwitchControls.b_info = b_info;
            SwitchControls.b_info.Visible = true;
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = false;
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = false;
            SwitchControls.b_send = b_send;
            SwitchControls.b_send.Visible = false;
            SwitchControls.b_send_2 = b_send_2;
            SwitchControls.b_send_2.Visible = false;
            SwitchControls.b_info_cancel = b_info_cancel;
            SwitchControls.b_info_cancel.Visible = false;
            SwitchControls.b_report = b_report;
            SwitchControls.b_report.Visible = false;
            SwitchControls.b_feedback = b_feedback;
            SwitchControls.b_feedback.Visible = false;
            SwitchControls.b_info.Visible = true;
            SwitchControls.b_minimize.Visible = true;
            SwitchControls.close_prog.Visible = true;
            SwitchControls.b_listbox_ok = b_listbox_ok;
            SwitchControls.b_listbox_ok.Visible = false;
            SwitchControls.label1 = label1;
            SwitchControls.label1.Visible = false;
            SwitchControls.comboBox1 = comboBox1;
            SwitchControls.comboBox1.Visible = false;
            SwitchControls.l_autorname.Visible = true;
            b_settings.Visible = true;
            pa_label.Visible = false;
            in_way.Visible = false;
            thank.Visible = false;
        }
        private void b_feedback_Click(object sender, EventArgs e)
        {
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = true;
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = true;
            SwitchControls.text_box.Clear();
            SwitchControls.b_send = b_send;
            SwitchControls.b_send.Visible = true;
            in_way.Visible = false;
            thank.Visible = false;
        }
        private void b_report_Click(object sender, EventArgs e)
        {
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = true;
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = true;
            SwitchControls.text_box.Clear();
            SwitchControls.b_send_2 = b_send_2;
            SwitchControls.b_send_2.Visible = true;
            in_way.Visible = false;
            thank.Visible = false;
        }
        private void b_send_2_Click(object sender, EventArgs e)
        {
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = false;
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = false;
            SwitchControls.b_send_2 = b_send_2;
            SwitchControls.b_send_2.Visible = false;
            in_way.Visible = true;
            try
            {
                WebRequest request = WebRequest.Create(work_dir + "report.php");
                string data = "msg=" + text_box.Text;
                byte[] bytesarr = Encoding.UTF8.GetBytes(data);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException();
            }
        }
        private void b_send_Click(object sender, EventArgs e)
        {
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = false;
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = false;
            SwitchControls.b_send = b_send;
            SwitchControls.b_send.Visible = false;
            thank.Visible = true;
            try
            {
                WebRequest request = WebRequest.Create(work_dir + "otziv.php");
                string data = "msg=" + text_box.Text;
                byte[] bytesarr = Encoding.UTF8.GetBytes(data);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                streamread.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void close_prog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void form_DClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void b_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void b_settings_Click(object sender, EventArgs e)
        {
            SwitchControls.b_join = b_join;
            SwitchControls.b_join.Visible = false;
            SwitchControls.b_upload = b_upload;
            SwitchControls.b_upload.Visible = false;
            SwitchControls.b_reload = b_reload;
            SwitchControls.b_reload.Visible = false;
            SwitchControls.quit = quit;
            SwitchControls.quit.Visible = false;
            SwitchControls.b_info = b_info;
            SwitchControls.b_info.Visible = false;
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = false;
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = false;
            SwitchControls.b_send = b_send;
            SwitchControls.b_send.Visible = false;
            SwitchControls.b_send_2 = b_send_2;
            SwitchControls.b_send_2.Visible = false;
            SwitchControls.b_info_cancel = b_info_cancel;
            SwitchControls.b_info_cancel.Visible = true;
            SwitchControls.b_report = b_report;
            SwitchControls.b_report.Visible = false;
            SwitchControls.b_feedback = b_feedback;
            SwitchControls.b_feedback.Visible = false;
            SwitchControls.b_info.Visible = false;
            SwitchControls.b_minimize.Visible = false;
            SwitchControls.close_prog.Visible = false;
            SwitchControls.l_autorname.Visible = false;
            b_info_cancel.Visible = true;
            b_settings.Visible = false;
            b_listbox_ok.Visible = true;
            comboBox1.Visible = true;
            label1.Visible = true;
            pa_label.Visible = false;
            in_way.Visible = false;
            thank.Visible = false;
            img_panel.Hide();

        }
        private void b_scrool_up_Click(object sender, EventArgs e)
        {
            img_panel.VerticalScroll.Value = 0;
        }
        private void b_listbox_ok_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                label1.Text = "Select language :";
                label_input.Text = "Input message";
                b_send.Text = "Send";
                b_send_2.Text = "Send";
                thank.Text = "Thank you for feedback";
                in_way.Text = "We'll do our best to solve the problem";
                SwitchControls.tt.SetToolTip(b_info, "Info");
                SwitchControls.tt.SetToolTip(b_settings, "Settings");
                SwitchControls.tt.SetToolTip(b_upload, "Load images");
                SwitchControls.tt.SetToolTip(b_reload, "Update");
                SwitchControls.tt.SetToolTip(b_minimize, "Minimize to tray");
                SwitchControls.tt.SetToolTip(b_feedback, "Get feedback");
                SwitchControls.tt.SetToolTip(b_report, "Get error report");
                SwitchControls.tt.SetToolTip(b_info_cancel, "Back");
                SwitchControls.tt.SetToolTip(b_cancel_info, "Back");
                SwitchControls.tt.SetToolTip(quit, "End current session");
                SwitchControls.tt.SetToolTip(close_prog, "Exit");
                SwitchControls.tt.SetToolTip(b_listbox_ok, "Apply");
                SwitchControls.tt.SetToolTip(b_join, "Join");
                SwitchControls.l_autorname.Text = SwitchControls.l_autorname.Text.Replace("Добро пожаловать", "Welcome");
                System.IO.StreamWriter write = new System.IO.StreamWriter(lang, false);
                write.WriteLine("eng");
                write.Close();
                ReloadImages();

            }
            else
            {
                label1.Text = "Выберите язык :";
                label_input.Text = "Введите сообщение";
                b_send.Text = "Отправить";
                b_send_2.Text = "Отправить";
                thank.Text = "Спасибо за отзыв :)";
                in_way.Text = " (:Мы уже в пути";
                SwitchControls.tt.SetToolTip(b_info, "Инфо");
                SwitchControls.tt.SetToolTip(b_settings, "Настройки");
                SwitchControls.tt.SetToolTip(b_upload, "Загрузить изображения");
                SwitchControls.tt.SetToolTip(b_reload, "Обновить");
                SwitchControls.tt.SetToolTip(b_minimize, "Свернуть в трей");
                SwitchControls.tt.SetToolTip(b_feedback, "Оставить отзыв");
                SwitchControls.tt.SetToolTip(b_report, "Сообщить об ошибке");
                SwitchControls.tt.SetToolTip(b_info_cancel, "Выйти из аккаунта");
                SwitchControls.tt.SetToolTip(b_cancel_info, "Назад");
                SwitchControls.tt.SetToolTip(quit, "Завершить сеанс");
                SwitchControls.tt.SetToolTip(close_prog, "Выйти из программы");
                SwitchControls.tt.SetToolTip(b_listbox_ok, "Применить");
                SwitchControls.tt.SetToolTip(b_join, "Войти");
                SwitchControls.l_autorname.Text = SwitchControls.l_autorname.Text.Replace("Welcome", "Добро пожаловать");
                System.IO.StreamWriter write = new System.IO.StreamWriter(lang, false);
                write.WriteLine("rus");
                write.Close();
                ReloadImages();
            }
        }
        private void b_cancel_settings_Click(object sender, EventArgs e)
        {
            SwitchControls.b_join = b_join;
            SwitchControls.b_join.Visible = false;
            SwitchControls.b_upload = b_upload;
            SwitchControls.b_upload.Visible = true;
            SwitchControls.b_reload = b_reload;
            SwitchControls.b_reload.Visible = true;
            SwitchControls.quit = quit;
            SwitchControls.quit.Visible = true;
            SwitchControls.b_info = b_info;
            SwitchControls.b_info.Visible = true;
            SwitchControls.label_input = label_input;
            SwitchControls.label_input.Visible = false;
            SwitchControls.text_box = text_box;
            SwitchControls.text_box.Visible = false;
            SwitchControls.b_send = b_send;
            SwitchControls.b_send.Visible = false;
            SwitchControls.b_send_2 = b_send_2;
            SwitchControls.b_send_2.Visible = false;
            SwitchControls.b_info_cancel = b_info_cancel;
            SwitchControls.b_info_cancel.Visible = false;
            SwitchControls.b_report = b_report;
            SwitchControls.b_report.Visible = false;
            SwitchControls.b_feedback = b_feedback;
            SwitchControls.b_feedback.Visible = false;
            SwitchControls.b_info.Visible = false;
            SwitchControls.b_minimize.Visible = true;
            SwitchControls.close_prog.Visible = true;
            SwitchControls.l_autorname.Visible = true;
            b_info_cancel.Visible = false;
            b_settings.Visible = true;
            b_listbox_ok.Visible = false;
            b_info.Visible = true;
            comboBox1.Visible = false;
            label1.Visible = false;
            pa_label.Visible = false;
            in_way.Visible = false;
            thank.Visible = false;
            img_panel.Show();
        }
        public void CreateMoreFromArray(Image[] pics, int post_id, string author = "Temp", string date = "Simple text", string like = "Not")
        {
            FlowLayoutPanel pnl_main = new FlowLayoutPanel();
            FlowLayoutPanel pnl_child = new FlowLayoutPanel();
            FlowLayoutPanel pnl_child_2 = new FlowLayoutPanel();
            PictureBox[] img = { new PictureBox(), new PictureBox(), new PictureBox(), new PictureBox() };
            FlowLayoutPanel to_b = new FlowLayoutPanel();
            Label t_load = new Label();
            LinkLabel t_load_link = new LinkLabel();
            Label t_date = new Label();
            Label t_date2 = new Label();
            FlowLayoutPanel group_like = new FlowLayoutPanel();
            Button btn = new Button();
            Button b_like = new Button();
            Button b_dislike = new Button();
            Label scale = new Label();
            Button b_comment = new Button();
            byte count;
            switch (pics.Length)
            {
                case 2:
                    {
                        count = 2;
                        break;
                    }
                case 3:
                    {
                        count = 3;
                        break;
                    }
                default:
                    {
                        count = 4;
                        break;
                    }
            }
            pnl_main.Anchor = AnchorStyles.Right & AnchorStyles.Left;
            pnl_main.BackColor = Color.WhiteSmoke;
            pnl_main.Name = "post_" + post_id;
            pnl_main.Padding = new Padding(10);
            int width = SwitchControls.img_panel.Size.Width;
            pnl_main.Size = new Size(width - 64, (int)Math.Round((width - 64) / 3.4));
            pnl_main.TabIndex = post_id;

            width = pnl_main.Size.Width;
            img[0].Location = new Point((int)Math.Round((width - (width / 2.36)) / 2), 13);
            img[0].BackColor = Color.Transparent;
            img[0].Name = "post_" + post_id + "_img";
            img[0].Size = new Size((int)Math.Round(width / 2.36), (int)Math.Round(width / 3.86));
            img[0].SizeMode = PictureBoxSizeMode.Zoom;
            img[0].TabIndex = 1;
            img[0].TabStop = false;
            img[0].Image = pics[0];

            t_load.AutoSize = true;
            t_load.Location = new Point(13, 10);
            t_load.Name = "post_" + post_id + "_author";
            t_load.Size = new Size(61, 13);
            t_load.TabIndex = 0;
            t_load.Font = new Font("Microsoft Sans Serif", (int)Math.Round(width / 105.99), FontStyle.Regular);
            if (File.Exists(lang) != true)
            {
                t_load.Text = "Загрузил: " + author;
            }
            else
            {
                string text = System.IO.File.ReadAllText(lang);
                if (text.Contains("rus"))
                {
                    t_load.Text = "Загрузил: " + author;
                }
                else if (text.Contains("eng"))
                {
                    t_load.Text = "Dowloaded by: " + author;
                }
            }
            t_load_link.AutoSize = true;
            t_load_link.Location = new Point(79, 10);
            t_load_link.Name = "post_" + post_id + "_user";
            t_load_link.Size = new Size(90, 13);
            t_load_link.TabIndex = 1;
            t_load_link.TabStop = true;
            t_load_link.Text = author;

            t_date.AutoSize = true;
            t_date.Location = new Point(23, 10);
            t_date.Margin = new Padding(3, 10, 3, 0);
            t_date.Name = "post_" + post_id + "_date";
            t_date.Size = new Size(45, 13);
            t_date.Font = new Font("Microsoft Sans Serif", (int)Math.Round(width / 105.99), FontStyle.Regular);
            t_date.TabIndex = 2;
            if (File.Exists(lang) != true)
            {
                t_date.Text = "Дата: " + date;
            }
            else
            {
                string text = System.IO.File.ReadAllText(lang);
                if (text.Contains("rus"))
                {
                    t_date.Text = "Дата: " + date;
                }
                else if (text.Contains("eng"))
                {
                    t_date.Text = "Date: " + date;
                }
            }

            group_like.Size = new Size(102, (int)Math.Round(width / 3.86));
            group_like.Location = new Point(700, 10);
            group_like.Name = "post_" + post_id + "_gb_like";
            group_like.TabIndex = 1;
            group_like.TabStop = true;
            group_like.Text = "";
            group_like.Visible = like_visible;



            pnl_child.Controls.Add(t_load);
            //pnl_child.Controls.Add(t_load_link);
            pnl_child.Controls.Add(t_date);
            pnl_child.BackColor = Color.Gainsboro;
            pnl_child.Location = new Point(13, 13);
            pnl_child.Name = "post_" + post_id + "_infoPanel";
            pnl_child.Padding = new Padding(10);
            pnl_child.Size = new Size((int)Math.Round(width / 4.47), (int)Math.Round(width / 10.76));
            pnl_child.TabIndex = 0;

            pnl_child_2.Location = new Point((int)Math.Round(width / 1.96), 13);
            pnl_child_2.Name = "post_" + post_id + "_customPanel";
            pnl_child_2.Size = new Size((int)Math.Round(width / 12.01), (int)Math.Round(width / 3.86));
            pnl_child_2.TabIndex = 0;

            for (int i = 1; i <= count; i++)
            {
                if (i < 3)
                {
                    img[i].Location = new Point(3, 3);
                    img[i].Name = (i == 1) ? "post_" + post_id + "_img1" : "post_" + post_id + "_img2";
                    img[i].Size = new Size((int)Math.Round(width / 12.14), (int)Math.Round(width / 17.01));
                    img[i].SizeMode = PictureBoxSizeMode.Zoom;
                    img[i].TabIndex = 0;
                    img[i].TabStop = false;
                    img[i].Image = pics[i];
                    pnl_child_2.Controls.Add(img[i]);
                }
                else
                {
                    to_b.Size = new Size((int)Math.Round(width / 2.36 + 5), (int)Math.Round(width / 3.86 + 5));
                    to_b.BorderStyle = BorderStyle.None;
                    to_b.BackColor = Color.WhiteSmoke;


                    btn.Location = new Point((int)Math.Round((width - (width / 2.36)) / 2), 13);
                    btn.Name = "post_" + post_id + "_buttonAll";
                    btn.Size = new Size((int)Math.Round(width / 2.36) - 5, (int)Math.Round(width / 3.86) - 5);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
                    btn.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                    btn.BackgroundImage = pics[0];
                    btn.TabIndex = 0;
                    btn.Text = "";
                    btn.Click += new EventHandler(btn_Click);
                    btn.MouseEnter += new EventHandler(btn_MouseEnter);
                    btn.MouseLeave += new EventHandler(btn_MouseLeave);
                    to_b.Controls.Add(btn);
                    pnl_main.Controls.Add(to_b);

                    b_like.Location = new Point(1, 1);
                    b_like.Name = "post_" + post_id + "_buttonLike";
                    b_like.Size = new Size(100, 50);
                    b_like.FlatStyle = FlatStyle.Flat;
                    b_like.FlatAppearance.BorderSize = 0;
                    b_like.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
                    b_like.BackgroundImage = Image.FromFile(@".\icons\gray_up.png");
                    b_like.BackgroundImageLayout = ImageLayout.Zoom;
                    b_like.TabIndex = 0;
                    b_like.Text = "";
                    b_like.Click += new EventHandler(like_Click);
                    b_like.MouseEnter += new EventHandler(like_MouseEnter);
                    b_like.MouseLeave += new EventHandler(like_MouseLeave);
                    group_like.Controls.Add(b_like);

                    scale.Location = new Point(1, 72);
                    scale.Name = "post_" + post_id + "_like";
                    scale.Size = new Size(group_like.Width - 1, 30);
                    scale.TextAlign = ContentAlignment.MiddleCenter;
                    scale.Font = new Font("Footlight MT", 12, FontStyle.Bold);
                    scale.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                    scale.TabIndex = 1;
                    scale.TabStop = true;
                    scale.Text = like;
                    group_like.Controls.Add(scale);

                    b_dislike.Location = new Point(1, 113);
                    b_dislike.Name = "post_" + post_id + "_buttondLike";
                    b_dislike.Size = new Size(100, 50);
                    b_dislike.FlatStyle = FlatStyle.Flat;
                    b_dislike.FlatAppearance.BorderSize = 0;
                    b_dislike.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
                    b_dislike.BackgroundImage = Image.FromFile(@".\icons\gray_down.png");
                    b_dislike.BackgroundImageLayout = ImageLayout.Zoom;
                    b_dislike.TabIndex = 0;
                    b_dislike.Text = "";
                    b_dislike.Click += new EventHandler(dislike_Click);
                    b_dislike.MouseEnter += new EventHandler(dislike_MouseEnter);
                    b_dislike.MouseLeave += new EventHandler(dislike_MouseLeave);
                    group_like.Controls.Add(b_dislike);

                    b_comment.Location = new Point(1, 113);
                    if (File.Exists(lang) != true)
                    {
                        tt.SetToolTip(b_comment, "Комментировать");
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            tt.SetToolTip(b_comment, "Комментировать");
                        }
                        else if (text.Contains("eng"))
                        {
                            tt.SetToolTip(b_comment, "Comment");
                        }
                    }
                    b_comment.Name = "post_" + post_id + "_buttondLike";
                    b_comment.Size = new Size(50, 40);
                    b_comment.FlatStyle = FlatStyle.Flat;
                    b_comment.FlatAppearance.BorderSize = 0;
                    b_comment.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
                    b_comment.BackgroundImage = Image.FromFile(@".\icons\comment_9.png");
                    b_comment.BackgroundImageLayout = ImageLayout.Zoom;
                    b_comment.TabIndex = 0;
                    b_comment.Text = "";
                    b_comment.Click += new EventHandler(comment_Click);
                    b_comment.MouseEnter += new EventHandler(comment_MouseEnter);
                    b_comment.MouseLeave += new EventHandler(comment_MouseLeave);
                    group_like.Controls.Add(b_comment);
                    break;
                }
            }
            pnl_main.Controls.Add(pnl_child);
            pnl_child.BringToFront();
            pnl_main.Controls.Add(pnl_child_2);
            pnl_main.Controls.Add(group_like);
            SwitchControls.img_panel.Controls.Add(pnl_main);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Color.WhiteSmoke;
            string[] name = ((Button)sender).Name.Split('_');
            string[] data = GetImagesByGrops(work_dir + "download_bygroups2.php", (byte)(byte.Parse(name[1]) - 1), 4);
            int lengh = data.Length;
            Form Zo = new Form();
            Zoom = Zo;
            int width = (int)Math.Round(SwitchControls.img_panel.Width / 1.16 + 60);
            int height = (int)Math.Round(SwitchControls.img_panel.Height / 1.01);
            Zo.MaximizeBox = true;
            Zo.TopMost = true;
            Zo.Size = new Size(width, height);
            Zo.StartPosition = FormStartPosition.CenterScreen;
            Zo.FormBorderStyle = FormBorderStyle.None;
            Zo.AllowTransparency = true;
            Zo.BackColor = Color.AliceBlue;
            Zo.TransparencyKey = Zo.BackColor;
            Zo.SizeChanged += new EventHandler(Zo_SizeChanged);

            FlowLayoutPanel but = new FlowLayoutPanel();
            but.Size = new Size(50, 100);
            but.BackColor = Color.Transparent;

            Button zo_close = new Button();
            zo_close.Size = new Size(40, 40);
            zo_close.FlatStyle = FlatStyle.Flat;
            zo_close.FlatAppearance.MouseOverBackColor = Color.Silver;
            zo_close.FlatAppearance.BorderSize = 0;
            zo_close.BackgroundImage = Image.FromFile(@".\icons\cross.png");
            zo_close.BackgroundImageLayout = ImageLayout.Zoom;
            zo_close.Click += new EventHandler(zo_close_Click);
            but.Controls.Add(zo_close);

            Button tb_show = new Button();
            tb_show.Size = new Size(40, 40);
            tb_show.FlatStyle = FlatStyle.Flat;
            tb_show.FlatAppearance.MouseOverBackColor = Color.Silver;
            tb_show.FlatAppearance.BorderSize = 0;
            tb_show.BackgroundImage = Image.FromFile(@".\icons\link.png");
            tb_show.BackgroundImageLayout = ImageLayout.Zoom;
            tb_show.Click += new EventHandler(tb_show_Click);
            but.Controls.Add(tb_show);

            FlowLayoutPanel pan = new FlowLayoutPanel();
            pan.Name = "pan";
            pan.Location = new Point(0, 0);
            pan.Size = new Size(Zo.Width - 20, Zo.Height - 50);
            pan.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Right & AnchorStyles.Left;
            pan.AutoScroll = true;
            pan.BackColor = Color.Transparent;
            pan.AutoScroll = true;
            for (byte j = 0; j < lengh - 3; j++)
            {
                PictureBox img = new PictureBox();
                img.Location = new Point(0, 0);
                img.Size = new Size(pan.Width - 90, pan.Height - 50);
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.TabIndex = 0;
                img.TabStop = false;
                string[] tmp = data[j].Split('я');
                //if (!File.Exists(data[j]))
                //{

                //    WebClient client = new WebClient();
                //    Uri uri = new Uri(work_dir + "images/s1/" + tmp[0]);
                //    client.DownloadFile(uri, tmp[0]);
                //}
                img.Image = Image.FromFile(way + tmp[0]);
                TextBox tbx = new TextBox();
                tbx.Size = new Size(300, 100);
                tbx.Name = "tb_" + name[1];
                tbx.Visible = false;
                tbx.Text = work_dir + "images/s1/" + tmp[1];
                tbx.Location = new Point(0, pan.Height - 25);
                pan.Controls.Add(img);
                if (j == 0) pan.Controls.Add(but);
                pan.Controls.Add(tbx);
            }
            Flow_Pan = pan;
            Zo.Controls.Add(pan);
            Zo.Show();
        }
        private void zo_close_Click(object sender, EventArgs e)
        {
            Zoom.Close();
        }
        private void tb_show_Click(object sender, EventArgs e)
        {
            try
            {
                byte i = 0;
                foreach (Control control in Flow_Pan.Controls)
                {
                    if (control is TextBox)
                    {
                        if (i == 0)
                        {
                            string data = string.Format("{0}", control.Text);
                            Clipboard.Clear();
                            Clipboard.SetText(data);
                        }
                        if (control.Visible == true)
                        {
                            control.Visible = false;
                        }
                        else
                        {
                            control.Visible = true;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                byte i = 0;
                foreach (Control control in Flow_Pan.Controls)
                {
                    if (control is TextBox)
                    {
                        if (i == 0)
                        {
                            string data = string.Format("{0}", control.Text);
                            Clipboard.Clear();
                            Clipboard.SetText(data);
                        }
                        if (control.Visible == true)
                        {
                            control.Visible = false;
                        }
                        else
                        {
                            control.Visible = true;
                        }
                        i++;
                    }
                }
            }
        }
        private void like_Click(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('_');
            string[] data_2 = GetImagesByGrops(work_dir + "download_bygroups2.php", (int.Parse(name[1]) - 1), 4);
            string[] tmp = data_2[0].Split('я');
            string img_name = tmp[0].Replace(".jpeg", "");
            string[] chk = SetLikes(userid, img_name, true);
            if (chk[0] == "0")
            {
                FlowLayoutPanel pnl_main = SwitchControls.img_panel.Controls["post_" + (int.Parse(name[1]))] as FlowLayoutPanel;
                FlowLayoutPanel gb_like = pnl_main.Controls["post_" + (int.Parse(name[1])) + "_gb_like"] as FlowLayoutPanel;
                Label scale = gb_like.Controls["post_" + (int.Parse(name[1])) + "_like"] as Label;
                scale.Text = chk[1];
            }
            else
            {

            }
        }
        private void dislike_Click(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('_');
            string[] data = GetImagesByGrops(work_dir + "download_bygroups2.php", (byte.Parse(name[1]) - 1), 4);
            string[] tmp = data[0].Split('я');
            string img_name = tmp[0].Replace(".jpeg", "");
            string[] chk = SetLikes(userid, img_name, false);
            if (chk[0] == "0")
            {
                FlowLayoutPanel pnl_main = SwitchControls.img_panel.Controls["post_" + (int.Parse(name[1]))] as FlowLayoutPanel;
                FlowLayoutPanel gb_like = pnl_main.Controls["post_" + (int.Parse(name[1])) + "_gb_like"] as FlowLayoutPanel;
                Label scale = gb_like.Controls["post_" + (int.Parse(name[1])) + "_like"] as Label;
                scale.Text = chk[1];
            }
            else
            {

            }
        }
        private void comment_Click(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('_');
            string[] data_2 = GetImagesByGrops(work_dir + "download_bygroups2.php", (int.Parse(name[1]) - 1), 4);
            string[] tmp = data_2[0].Split('я');
            string img_name = tmp[0].Replace(".jpeg", "");

            FlowLayoutPanel pnl_main = SwitchControls.img_panel.Controls["post_" + (int.Parse(name[1]))] as FlowLayoutPanel;
            int width = pnl_main.Width;
            int height = pnl_main.Height;
            pnl_main.Size = new Size(width, height * 2);

            FlowLayoutPanel comment_pnl = new FlowLayoutPanel();
            comment_pnl.Location = new Point(height + 1, 1);
            comment_pnl.BackColor = Color.White;
            comment_pnl.Name = "post_" + name[1] + "_comment_pnl";
            comment_pnl.Padding = new Padding(0);
            comment_pnl.Margin = new Padding(4);
            comment_pnl.Size = new Size(width - 30, height - 2);
            comment_pnl.TabIndex = int.Parse(name[1]);

            FlowLayoutPanel comment_field_pnl = new FlowLayoutPanel();
            comment_field_pnl.AutoScroll = true;
            comment_field_pnl.Location = new Point(0, 0);
            comment_field_pnl.BackColor = Color.WhiteSmoke;
            comment_field_pnl.Name = "post_" + name[1] + "_comment_field_pnl";
            comment_field_pnl.Padding = new Padding(0);
            comment_field_pnl.Margin = new Padding(0);
            comment_field_pnl.Size = new Size(comment_pnl.Width - 8, comment_pnl.Height - 70);
            comment_field_pnl.TabIndex = int.Parse(name[1]);

            Label comment_field = new Label();
            comment_field.AutoSize = true;
            comment_field.MaximumSize = new Size(comment_pnl.Width - 8, 999999);
            comment_field.BackColor = Color.WhiteSmoke;
            comment_field.Location = new Point(0, 0);
            comment_field.Font = new Font("Microsoft Sans Serif", (int)Math.Round(width / 99.99), FontStyle.Regular);
            comment_field.Name = "post_" + name[1] + "_comment_field";
            comment_field.Size = new Size(comment_pnl.Width - 20, comment_pnl.Height - 68);
            comment_field.TabIndex = int.Parse(name[1]);
            comment_field.TabStop = true;

            TextBox comment_input = new TextBox();
            comment_input.Name = "post_" + name[1] + "_comment_input";
            comment_input.Font = new Font("Microsoft Sans Serif", (int)Math.Round(width / 99.99), FontStyle.Regular);
            comment_input.Multiline = true;
            comment_input.Size = new Size(comment_pnl.Width - 136, 60);
            comment_input.KeyDown += new KeyEventHandler(send_Comment);

            Button comment_add = new Button();
            comment_add.Name = "post_" + name[1] + "_comment_add";
            comment_add.Size = new Size(120, 60);
            comment_add.Click += new EventHandler(comment_add_Click);
            comment_add.TextAlign = ContentAlignment.MiddleCenter;
            if (File.Exists(lang) != true)
            {
                comment_add.Text = "Отправить";
            }
            else
            {
                string text = System.IO.File.ReadAllText(lang);
                if (text.Contains("rus"))
                {
                    comment_add.Text = "Отправить";
                }
                else if (text.Contains("eng"))
                {
                    comment_add.Text = "Send";
                }
            }
            if (width / 2 > height)
            {
                comment_field_pnl.Controls.Add(comment_field);
                comment_pnl.Controls.Add(comment_field_pnl);
                comment_pnl.Controls.Add(comment_input);
                comment_pnl.Controls.Add(comment_add);
                pnl_main.Controls.Add(comment_pnl);
                comment_input.Clear();
                string[] comments = ShowComment(img_name);
                foreach (string row in comments)
                {
                    comment_field.Text += row + Environment.NewLine;
                }
                comment_field_pnl.VerticalScroll.Value = comment_field_pnl.VerticalScroll.Maximum;
            }
            else
            {
                comment_field_pnl.Controls.RemoveByKey("post_" + name[1] + "_comment_field");
                comment_field.Dispose();
                comment_pnl.Controls.RemoveByKey("post_" + name[1] + "_comment_field_pnl");
                comment_field_pnl.Dispose();
                comment_pnl.Controls.RemoveByKey("post_" + name[1] + "_comment_input");
                comment_input.Dispose();
                comment_pnl.Controls.RemoveByKey("post_" + name[1] + "_comment_add");
                comment_add.Dispose();
                pnl_main.Controls.RemoveByKey("post_" + name[1] + "_comment_pnl");
                comment_pnl.Dispose();
                pnl_main.Size = new Size(width, height / 2);
            }
        }
        private void send_Comment(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                string[] name = ((TextBox)sender).Name.Split('_');
                string[] data_2 = GetImagesByGrops(work_dir + "download_bygroups2.php", (int.Parse(name[1]) - 1), 4);
                string[] tmp = data_2[0].Split('я');
                string img_name = tmp[0].Replace(".jpeg", "");
                FlowLayoutPanel pnl_main = SwitchControls.img_panel.Controls["post_" + name[1]] as FlowLayoutPanel;
                FlowLayoutPanel comment_pnl = pnl_main.Controls["post_" + name[1] + "_comment_pnl"] as FlowLayoutPanel;
                FlowLayoutPanel comment_field_pnl = comment_pnl.Controls["post_" + name[1] + "_comment_field_pnl"] as FlowLayoutPanel;
                TextBox comment_input = comment_pnl.Controls["post_" + name[1] + "_comment_input"] as TextBox;
                Label comment_field = comment_field_pnl.Controls["post_" + name[1] + "_comment_field"] as Label;
                string autor = SwitchControls.l_autorname.Text.Replace("Добро пожаловать, ", "");
                autor = autor.Replace("Welcome, ", "");
                string com = (comment_input.Text).Replace(" ", "");
                string env = (comment_input.Text).Replace(Environment.NewLine, "");
                if (comment_input.Text != "" && com != "" && env != "")
                {
                    int chk = AddComment(img_name, autor + " : " + comment_input.Text);
                    if (chk == 0)
                    {
                        comment_field.Text = "";
                        string[] comments = ShowComment(img_name);
                        foreach (string row in comments)
                        {
                            comment_field.Text += row + Environment.NewLine;
                        }
                        comment_input.Clear();
                        comment_field_pnl.VerticalScroll.Value = comment_field_pnl.VerticalScroll.Maximum;
                    }
                }
                e.Handled = true;
            }
        }
        private void comment_add_Click(object sender, EventArgs e)
        {
            string[] name = ((Button)sender).Name.Split('_');
            string[] data_2 = GetImagesByGrops(work_dir + "download_bygroups2.php", (int.Parse(name[1]) - 1), 4);
            string[] tmp = data_2[0].Split('я');
            string img_name = tmp[0].Replace(".jpeg", "");
            FlowLayoutPanel pnl_main = SwitchControls.img_panel.Controls["post_" + name[1]] as FlowLayoutPanel;
            FlowLayoutPanel comment_pnl = pnl_main.Controls["post_" + name[1] + "_comment_pnl"] as FlowLayoutPanel;
            FlowLayoutPanel comment_field_pnl = comment_pnl.Controls["post_" + name[1] + "_comment_field_pnl"] as FlowLayoutPanel;
            TextBox comment_input = comment_pnl.Controls["post_" + name[1] + "_comment_input"] as TextBox;
            Label comment_field = comment_field_pnl.Controls["post_" + name[1] + "_comment_field"] as Label;
            string autor = SwitchControls.l_autorname.Text.Replace("Добро пожаловать, ", "");
            autor = autor.Replace("Welcome, ", "");
            string com = (comment_input.Text).Replace(" ", "");
            string env = (comment_input.Text).Replace(Environment.NewLine, "");
            if (comment_input.Text != "" && com != "" && env != "")
            {
                int chk = AddComment(img_name, autor + " : " + comment_input.Text);
                if (chk == 0)
                {
                    comment_field.Text = "";
                    string[] comments = ShowComment(img_name);
                    foreach (string row in comments)
                    {
                        comment_field.Text += row + Environment.NewLine;
                    }
                    comment_input.Clear();
                    comment_field_pnl.VerticalScroll.Value = comment_field_pnl.VerticalScroll.Maximum;
                }
            }
        }
        private void like_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Image.FromFile(@".\icons\lightgreen_up.png");
        }
        private void like_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Image.FromFile(@".\icons\gray_up.png");
        }
        private void dislike_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Image.FromFile(@".\icons\lightred_down.png");
        }
        private void dislike_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Image.FromFile(@".\icons\gray_down.png");
        }
        private void comment_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(55, 44);
        }
        private void comment_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(50, 40);
        }
        private string[] ShowComment(string image)
        {
            string result = "";
            ASCIIEncoding ascii = new ASCIIEncoding();
            string data = string.Format("image={0}", image);
            byte[] bytesarr = ascii.GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(work_dir + "comment.php");

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;

                Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                StreamReader streamread = new StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException();
            }
            string[] res = result.Split('~');
            return res;
        }
        private int AddComment(string image, string txt)
        {
            string result = "";
            UTF8Encoding ascii = new UTF8Encoding();
            string data = string.Format("image={0}&text={1}", image, txt);
            byte[] bytesarr = ascii.GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(work_dir + "comment_add.php");

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;

                Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                StreamReader streamread = new StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException();
            }

            if (result == "0")
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        private void Zo_SizeChanged(object sender, EventArgs e)
        {

        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(b.Size.Width + 5, b.Size.Height + 5);
        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(b.Size.Width - 5, b.Size.Height - 5);
        }
        public void ReloadImages()
        {
            if (scroll == true)
            {
                post_count = 0;
                img_panel.Controls.Clear();
                Thread myThread = new Thread(obj =>
                {
                    scroll = false;
                    for (byte i = 0; i < 7; i++)
                    {
                        try
                        {
                            string result = "";
                            ASCIIEncoding ascii = new ASCIIEncoding();
                            string data_2 = string.Format("id={0}&count={1}", i, 4);
                            byte[] bytesarr = ascii.GetBytes(data_2);
                            try
                            {
                                WebRequest request = WebRequest.Create(work_dir + "download_bygroups.php");

                                request.Method = "POST";
                                request.ContentType = "application/x-www-form-urlencoded";
                                request.ContentLength = bytesarr.Length;

                                Stream streamwriter = request.GetRequestStream();
                                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                                streamwriter.Close();

                                WebResponse response = request.GetResponse();
                                streamwriter = response.GetResponseStream();

                                StreamReader streamread = new StreamReader(streamwriter);
                                result = streamread.ReadToEnd();
                                streamread.Close();
                            }
                            catch (Exception ex)
                            {
                                throw new IndexOutOfRangeException();
                            }
                            string[] data = result.Split('~');

                            Image[] images = new Image[4];
                            int length = data.Length;
                            for (byte j = 0; j < length - 3; j++)
                            {
                                if (!File.Exists(way + data[j]))
                                {

                                    WebClient client = new WebClient();
                                    Uri uri = new Uri(work_dir + "images/s1/" + data[j]);
                                    client.DownloadFile(uri, way + data[j]);
                                }
                                Image image = Image.FromFile(way + data[j]);
                                images[j] = image;
                            }
                            post_count++;

                            this.Invoke(new Action(() =>
                            {
                                CreateMoreFromArray(images, post_count, data[length - 3], data[length - 2], data[length - 1]);
                            }));
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Проверьте подключение к интернету");
                            break;
                        }
                    }
                    scroll = true;
                }
                );
                myThread.IsBackground = true;
                myThread.Start();
            }
        }
        private void ScroolLoadImages(int cout)
        {
            scroll = false;
            Thread myThread = new Thread(obj =>
            {
                for (int i = cout; i < cout + 4; i++)
                {
                    try
                    {
                        string result = "";
                        ASCIIEncoding ascii = new ASCIIEncoding();
                        string data_2 = string.Format("id={0}&count={1}", i, 4);
                        byte[] bytesarr = ascii.GetBytes(data_2);
                        try
                        {
                            WebRequest request = WebRequest.Create(work_dir + "download_bygroups.php");

                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded";
                            request.ContentLength = bytesarr.Length;

                            Stream streamwriter = request.GetRequestStream();
                            streamwriter.Write(bytesarr, 0, bytesarr.Length);
                            streamwriter.Close();

                            WebResponse response = request.GetResponse();
                            streamwriter = response.GetResponseStream();

                            StreamReader streamread = new StreamReader(streamwriter);
                            result = streamread.ReadToEnd();
                            streamread.Close();
                        }
                        catch (Exception ex)
                        {
                            throw new IndexOutOfRangeException();
                        }
                        string[] data = result.Split('~');

                        Image[] images = new Image[4];
                        int length = data.Length;
                        int count = 0;
                        for (int j = 0; j < length - 3; j++)
                        {
                            if (!File.Exists(way + data[j]))
                            {

                                WebClient client = new WebClient();
                                Uri uri = new Uri(work_dir + "images/s1/" + data[j]);
                                client.DownloadFile(uri, way + data[j]);
                            }
                            Image image = Image.FromFile(way + data[j]);
                            images[j] = image;
                            count++;
                        }
                        post_count++;
                        this.Invoke(new Action(() =>
                        {
                            CreateMoreFromArray(images, post_count, data[length - 3], data[length - 2], data[length - 1]);
                        }));
                    }
                    catch (Exception err)
                    {
                        //MessageBox.Show("Проверьте подключение к интернету");
                        break;
                    }
                }
                scroll = true;
            }
            );
            myThread.IsBackground = true;
            myThread.Start();
        }
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public static string GetPost(string Url, params string[] postdata)
        {
            string result = string.Empty;
            string data = string.Empty;

            System.Text.ASCIIEncoding ascii = new ASCIIEncoding();

            if (postdata.Length % 2 != 0)
            {
                return string.Empty;
            }

            for (int i = 0; i < postdata.Length; i += 2)
            {
                data += string.Format("&{0}={1}", postdata[i], postdata[i + 1]);
            }

            data = data.Remove(0, 1);

            byte[] bytesarr = ascii.GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(Url);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;

                System.IO.Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                System.IO.StreamReader streamread = new System.IO.StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException();
            }
            return result;
        }
        public static int GetImage(string Url, int uid)
        {
            int result = 0;
            string data = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Images (*.bmp; *.jpg; *jpeg; *.gif; *.png)|*.BMP;*.JPG;*JPEG;*.GIF;*.PNG";
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string output = "";
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        Image loadedImage = Image.FromFile(file);
                        string base64Image = ImageToBase64(loadedImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                        output += (result != 0) ? "~" + base64Image : base64Image;
                        result++;
                    }
                    catch (Exception ex)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }

                using (WebClient client = new WebClient())
                {
                    byte[] response = client.UploadValues(Url, new NameValueCollection()
                            {
                                {"images", output},
                                {"uid", uid.ToString()},
                            });
                }
            }
            return result;
        }
        private string[] SetLikes(int u_id, string image, bool like)
        {
            string result = "";
            ASCIIEncoding ascii = new ASCIIEncoding();
            string data = string.Format("id={0}&image={1}&like={2}", u_id, image, like ? "1" : "0");
            byte[] bytesarr = ascii.GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(work_dir + "like.php");

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;

                Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                StreamReader streamread = new StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException();
            }

            string[] res = result.Split('~');
            if (res[0].Length < 1)
            {
                res[0] = "-1";
                return res;
            }
            else if (res[0] == "1")
            {
                res[0] = "1";
                return res;
            }
            else
            {
                res[0] = "0";
                return res;
            }
        }
        static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        string[] GetImagesByGrops(string Url, int i_id, int count = 4)
        {
            string result = "";
            ASCIIEncoding ascii = new ASCIIEncoding();
            string data = string.Format("id={0}&count={1}", i_id, count);
            byte[] bytesarr = ascii.GetBytes(data);
            try
            {
                WebRequest request = WebRequest.Create(Url);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytesarr.Length;

                Stream streamwriter = request.GetRequestStream();
                streamwriter.Write(bytesarr, 0, bytesarr.Length);
                streamwriter.Close();

                WebResponse response = request.GetResponse();
                streamwriter = response.GetResponseStream();

                StreamReader streamread = new StreamReader(streamwriter);
                result = streamread.ReadToEnd();
                streamread.Close();
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException();
            }
            return result.Split('~');
        }
        public void LogIn(int p)
        {
            userid = p;
            SwitchControls.w_reg.Close();
            SwitchControls.b_join.Visible = false;
            SwitchControls.b_upload.Visible = true;
            SwitchControls.b_reload.Visible = true;
            SwitchControls.quit.Visible = true;
            SwitchControls.b_info.Visible = true;
            SwitchControls.close_prog.Visible = false;
            SwitchControls.b_minimize.Visible = true;
            SwitchControls.b_settings.Visible = true;
            SwitchControls.l_autorname.Visible = true;
            like_visible = true;
            scroll = true;
        }
        public static void Log(string text)
        {
            File.WriteAllText("WriteText.txt", text);
        }
        private void w_Main_SizeChanged(object sender, EventArgs e)
        {
            if (SwitchControls.w_main.WindowState == FormWindowState.Minimized)
            {
                FormWin = FormWindowState.Minimized;
            }
            else if (SwitchControls.w_main.WindowState == FormWindowState.Normal)
            {
                if (FormWin == FormWindowState.Minimized)
                {

                }
                else
                {
                    ReloadImages();
                }
                FormWin = FormWindowState.Normal;
            }
            else if (SwitchControls.w_main.WindowState == FormWindowState.Maximized && FormWin == FormWindowState.Normal)
            {
                SwitchControls.img_panel.Controls.Clear();
                ReloadImages();
                FormWin = FormWindowState.Maximized;
            }

        }
        private void w_Main_ClientSizeChanged(object sender, EventArgs e)
        {
        }
        private void b_join_MouseEnter(object sender, EventArgs e)
        {
            b_join.BackColor = Color.DarkGray;
        }
        private void b_join_MouseLeave(object sender, EventArgs e)
        {
            b_join.BackColor = Color.Transparent;
        }
        private void b_upload_MouseEnter(object sender, EventArgs e)
        {
            b_upload.BackColor = Color.DarkGray;
        }
        private void b_upload_MouseLeave(object sender, EventArgs e)
        {
            b_upload.BackColor = Color.Transparent;
        }
        private void b_reload_MouseEnter(object sender, EventArgs e)
        {
            b_reload.BackColor = Color.DarkGray;
        }
        private void b_reload_MouseLeave(object sender, EventArgs e)
        {
            b_reload.BackColor = Color.Transparent;
        }
        private void b_report_MouseEnter(object sender, EventArgs e)
        {
            b_report.BackColor = Color.DarkGray;
        }
        private void b_report_MouseLeave(object sender, EventArgs e)
        {
            b_report.BackColor = Color.Transparent;
        }
        private void b_minimize_MouseEnter(object sender, EventArgs e)
        {
            b_minimize.BackColor = Color.DarkGray;
        }
        private void b_minimize_MouseLeave(object sender, EventArgs e)
        {
            b_minimize.BackColor = Color.Transparent;
        }
        private void b_feedback_MouseEnter(object sender, EventArgs e)
        {
            b_feedback.BackColor = Color.DarkGray;
        }
        private void b_feedback_MouseLeave(object sender, EventArgs e)
        {
            b_feedback.BackColor = Color.Transparent;
        }
        private void quit_MouseEnter(object sender, EventArgs e)
        {
            quit.BackColor = Color.DarkGray;
        }
        private void quit_MouseLeave(object sender, EventArgs e)
        {
            quit.BackColor = Color.Transparent;
        }
        private void b_info_cancel_MouseEnter(object sender, EventArgs e)
        {
            b_info_cancel.BackColor = Color.DarkGray;
        }
        private void b_info_cancel_MouseLeave(object sender, EventArgs e)
        {
            b_info_cancel.BackColor = Color.Transparent;
        }
        private void close_prog_MouseEnter(object sender, EventArgs e)
        {
            close_prog.BackColor = Color.DarkGray;
        }
        private void close_prog_MouseLeave(object sender, EventArgs e)
        {
            close_prog.BackColor = Color.Transparent;
        }
        private void b_settings_MouseEnter(object sender, EventArgs e)
        {
            b_settings.BackColor = Color.White;
        }
        private void b_settings_MouseLeave(object sender, EventArgs e)
        {
            b_settings.BackColor = Color.Gainsboro;
        }
        private void b_info_MouseEnter(object sender, EventArgs e)
        {
            b_info.BackColor = Color.White;
        }
        private void b_info_MouseLeave(object sender, EventArgs e)
        {
            b_info.BackColor = Color.Gainsboro;
        }
        private void img_panel_Scroll(object sender, ScrollEventArgs e)
        {
            if ((img_panel.VerticalScroll.Value >= img_panel.VerticalScroll.Maximum - img_panel.ClientRectangle.Height - 99) && (scroll == true))
            {
                ScroolLoadImages(post_count);
            }
            //else if ((img_panel.VerticalScroll.Value == img_panel.VerticalScroll.Maximum - img_panel.ClientRectangle.Height + 1) && (scroll != true))
            //{
            //    System.Windows.Forms.Timer scroll_rep = new System.Windows.Forms.Timer();
            //    scroll_rep.Interval = 1000;
            //    scroll_rep.Tick += new EventHandler(scroll_rep_Tick);
            //    scroll_rep.Start();
            //}
        }
    }
}
