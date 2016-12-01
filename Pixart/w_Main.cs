using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public w_Main()
        {
            InitializeComponent();
        }

        private void w_Main_Load(object sender, EventArgs e)
        {
        }

        private void w_Main_Valide(object sender, EventArgs e)
        {
        }

        private void w_Main_SizeChanged(object sender, EventArgs e)
        {
        }

        private void b_join_Click(object sender, EventArgs e)
        {
        }

        private void b_reload_Click(object sender, EventArgs e)
        {
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
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
        }

        private void quit_Click(object sender, EventArgs e)
        {
        }

        private void b_info_Click(object sender, EventArgs e)
        {
        }

        private void b_info_cancel_Click(object sender, EventArgs e)
        {
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
