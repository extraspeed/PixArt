using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixart
{
    public partial class w_Main : Form
    {
        public static string work_dir = "http://www.ru-laboratory.xyz/pixart/";
        public static int userid;
        public static bool scroll;
        public static bool like_visible;
        public static int post_count;
        public static string lang = @"lang.txt";
        public static string way = @".\cash\";
        static System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
        public static FormWindowState FormWin = FormWindowState.Normal;

        public w_Main()
        {
            InitializeComponent();
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

        public void CreateMoreFromArray(Image[] pics, int post_id, string author = "Temp", string date = "Simple text", string like = "Not")
        {
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

        private void b_join_Click(object sender, EventArgs e)
        {
            SwitchControls.w_reg.Show();
            SwitchControls.w_reg.Focus();
        }

        private void b_reload_Click(object sender, EventArgs e)
        {
            ReloadImages();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Size = new Size(b.Size.Width - 5, b.Size.Height - 5);
        }

        public static string GetPost(string Url, params string[] postdata)
        {
            return "";
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
        }

        private void b_report_Click(object sender, EventArgs e)
        {
        }

        private void b_send_2_Click(object sender, EventArgs e)
        {
        }

        private void b_send_Click(object sender, EventArgs e)
        {
        }


        private void close_prog_Click(object sender, EventArgs e)
        {
        }

        private void form_DClick(object sender, EventArgs e)
        {
        }

        private void b_minimize_Click(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void b_settings_Click(object sender, EventArgs e)
        {
        }

        private void b_scrool_up_Click(object sender, EventArgs e)
        {
        }

        private void b_listbox_ok_Click(object sender, EventArgs e)
        {
        }

        private void b_cancel_settings_Click(object sender, EventArgs e)
        {
        }

        private void b_upload_Click(object sender, EventArgs e)
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
        }

        private void img_panel_Wheel(object sender, MouseEventArgs e)
        {
        }
    }
}
