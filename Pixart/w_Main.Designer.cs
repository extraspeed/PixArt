namespace Pixart
{
    partial class w_Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Main));
            this.img_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.quit = new System.Windows.Forms.Button();
            this.b_info = new System.Windows.Forms.Button();
            this.text_box = new System.Windows.Forms.TextBox();
            this.label_input = new System.Windows.Forms.Label();
            this.b_send = new System.Windows.Forms.Button();
            this.b_report = new System.Windows.Forms.Button();
            this.b_feedback = new System.Windows.Forms.Button();
            this.b_cancel_info = new System.Windows.Forms.Button();
            this.pa_label = new System.Windows.Forms.Label();
            this.thank = new System.Windows.Forms.Label();
            this.in_way = new System.Windows.Forms.Label();
            this.close_prog = new System.Windows.Forms.Button();
            this.b_minimize = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.b_settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.b_listbox_ok = new System.Windows.Forms.Button();
            this.b_info_cancel = new System.Windows.Forms.Button();
            this.b_reload = new System.Windows.Forms.Button();
            this.b_join = new System.Windows.Forms.Button();
            this.b_upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_send_2 = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.l_autorname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_panel
            // 
            this.img_panel.AllowDrop = true;
            resources.ApplyResources(this.img_panel, "img_panel");
            this.img_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.img_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.img_panel.ForeColor = System.Drawing.Color.Black;
            this.img_panel.Name = "img_panel";
            this.img_panel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.img_panel_Scroll);
            this.img_panel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.form_DClick);
            this.img_panel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.img_panel_Wheel);
            // 
            // quit
            // 
            resources.ApplyResources(this.quit, "quit");
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.Name = "quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            this.quit.MouseEnter += new System.EventHandler(this.quit_MouseEnter);
            this.quit.MouseLeave += new System.EventHandler(this.quit_MouseLeave);
            // 
            // b_info
            // 
            resources.ApplyResources(this.b_info, "b_info");
            this.b_info.BackColor = System.Drawing.Color.Gainsboro;
            this.b_info.FlatAppearance.BorderSize = 0;
            this.b_info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.b_info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.b_info.Name = "b_info";
            this.b_info.UseVisualStyleBackColor = false;
            this.b_info.Click += new System.EventHandler(this.b_info_Click);
            this.b_info.MouseEnter += new System.EventHandler(this.b_info_MouseEnter);
            this.b_info.MouseLeave += new System.EventHandler(this.b_info_MouseLeave);
            // 
            // text_box
            // 
            resources.ApplyResources(this.text_box, "text_box");
            this.text_box.Name = "text_box";
            // 
            // label_input
            // 
            resources.ApplyResources(this.label_input, "label_input");
            this.label_input.BackColor = System.Drawing.Color.Gainsboro;
            this.label_input.Name = "label_input";
            // 
            // b_send
            // 
            this.b_send.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.b_send, "b_send");
            this.b_send.Name = "b_send";
            this.b_send.UseVisualStyleBackColor = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // b_report
            // 
            this.b_report.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b_report, "b_report");
            this.b_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_report.FlatAppearance.BorderSize = 0;
            this.b_report.Name = "b_report";
            this.b_report.UseVisualStyleBackColor = false;
            this.b_report.Click += new System.EventHandler(this.b_report_Click);
            this.b_report.MouseEnter += new System.EventHandler(this.b_report_MouseEnter);
            this.b_report.MouseLeave += new System.EventHandler(this.b_report_MouseLeave);
            // 
            // b_feedback
            // 
            this.b_feedback.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b_feedback, "b_feedback");
            this.b_feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_feedback.FlatAppearance.BorderSize = 0;
            this.b_feedback.Name = "b_feedback";
            this.b_feedback.UseVisualStyleBackColor = false;
            this.b_feedback.Click += new System.EventHandler(this.b_feedback_Click);
            this.b_feedback.MouseEnter += new System.EventHandler(this.b_feedback_MouseEnter);
            this.b_feedback.MouseLeave += new System.EventHandler(this.b_feedback_MouseLeave);
            // 
            // b_cancel_info
            // 
            resources.ApplyResources(this.b_cancel_info, "b_cancel_info");
            this.b_cancel_info.BackColor = System.Drawing.Color.Transparent;
            this.b_cancel_info.FlatAppearance.BorderSize = 0;
            this.b_cancel_info.Name = "b_cancel_info";
            this.b_cancel_info.TabStop = false;
            this.b_cancel_info.UseVisualStyleBackColor = false;
            this.b_cancel_info.Click += new System.EventHandler(this.b_info_cancel_Click);
            // 
            // pa_label
            // 
            resources.ApplyResources(this.pa_label, "pa_label");
            this.pa_label.BackColor = System.Drawing.Color.Transparent;
            this.pa_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pa_label.Name = "pa_label";
            // 
            // thank
            // 
            resources.ApplyResources(this.thank, "thank");
            this.thank.BackColor = System.Drawing.Color.Gainsboro;
            this.thank.Name = "thank";
            // 
            // in_way
            // 
            resources.ApplyResources(this.in_way, "in_way");
            this.in_way.BackColor = System.Drawing.Color.Gainsboro;
            this.in_way.Name = "in_way";
            // 
            // close_prog
            // 
            resources.ApplyResources(this.close_prog, "close_prog");
            this.close_prog.BackColor = System.Drawing.Color.Transparent;
            this.close_prog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_prog.FlatAppearance.BorderSize = 0;
            this.close_prog.Name = "close_prog";
            this.close_prog.UseVisualStyleBackColor = false;
            this.close_prog.Click += new System.EventHandler(this.close_prog_Click);
            this.close_prog.MouseEnter += new System.EventHandler(this.close_prog_MouseEnter);
            this.close_prog.MouseLeave += new System.EventHandler(this.close_prog_MouseLeave);
            // 
            // b_minimize
            // 
            this.b_minimize.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b_minimize, "b_minimize");
            this.b_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_minimize.FlatAppearance.BorderSize = 0;
            this.b_minimize.Name = "b_minimize";
            this.b_minimize.UseVisualStyleBackColor = false;
            this.b_minimize.Click += new System.EventHandler(this.b_minimize_Click);
            this.b_minimize.MouseEnter += new System.EventHandler(this.b_minimize_MouseEnter);
            this.b_minimize.MouseLeave += new System.EventHandler(this.b_minimize_MouseLeave);
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // b_settings
            // 
            resources.ApplyResources(this.b_settings, "b_settings");
            this.b_settings.BackColor = System.Drawing.Color.Gainsboro;
            this.b_settings.FlatAppearance.BorderSize = 0;
            this.b_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.b_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.b_settings.Name = "b_settings";
            this.b_settings.UseVisualStyleBackColor = false;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            this.b_settings.MouseEnter += new System.EventHandler(this.b_settings_MouseEnter);
            this.b_settings.MouseLeave += new System.EventHandler(this.b_settings_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Name = "label1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
                resources.GetString("comboBox1.Items"),
                resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // b_listbox_ok
            // 
            this.b_listbox_ok.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.b_listbox_ok, "b_listbox_ok");
            this.b_listbox_ok.FlatAppearance.BorderSize = 0;
            this.b_listbox_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.b_listbox_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.b_listbox_ok.Name = "b_listbox_ok";
            this.b_listbox_ok.UseVisualStyleBackColor = false;
            this.b_listbox_ok.Click += new System.EventHandler(this.b_listbox_ok_Click);
            // 
            // b_info_cancel
            // 
            resources.ApplyResources(this.b_info_cancel, "b_info_cancel");
            this.b_info_cancel.BackColor = System.Drawing.Color.Transparent;
            this.b_info_cancel.FlatAppearance.BorderSize = 0;
            this.b_info_cancel.Name = "b_info_cancel";
            this.b_info_cancel.TabStop = false;
            this.b_info_cancel.UseVisualStyleBackColor = false;
            this.b_info_cancel.Click += new System.EventHandler(this.b_info_cancel_Click);
            this.b_info_cancel.MouseEnter += new System.EventHandler(this.b_info_cancel_MouseEnter);
            this.b_info_cancel.MouseLeave += new System.EventHandler(this.b_info_cancel_MouseLeave);
            // 
            // b_reload
            // 
            this.b_reload.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b_reload, "b_reload");
            this.b_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_reload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_reload.FlatAppearance.BorderSize = 0;
            this.b_reload.Name = "b_reload";
            this.b_reload.UseMnemonic = false;
            this.b_reload.UseVisualStyleBackColor = false;
            this.b_reload.Click += new System.EventHandler(this.b_reload_Click);
            this.b_reload.MouseEnter += new System.EventHandler(this.b_reload_MouseEnter);
            this.b_reload.MouseLeave += new System.EventHandler(this.b_reload_MouseLeave);
            // 
            // b_join
            // 
            this.b_join.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b_join, "b_join");
            this.b_join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_join.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_join.FlatAppearance.BorderSize = 0;
            this.b_join.Name = "b_join";
            this.b_join.UseMnemonic = false;
            this.b_join.UseVisualStyleBackColor = false;
            this.b_join.Click += new System.EventHandler(this.b_join_Click);
            this.b_join.MouseEnter += new System.EventHandler(this.b_join_MouseEnter);
            this.b_join.MouseLeave += new System.EventHandler(this.b_join_MouseLeave);
            // 
            // b_upload
            // 
            this.b_upload.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.b_upload, "b_upload");
            this.b_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_upload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_upload.FlatAppearance.BorderSize = 0;
            this.b_upload.Name = "b_upload";
            this.b_upload.UseMnemonic = false;
            this.b_upload.UseVisualStyleBackColor = false;
            this.b_upload.Click += new System.EventHandler(this.b_upload_Click);
            this.b_upload.MouseEnter += new System.EventHandler(this.b_upload_MouseEnter);
            this.b_upload.MouseLeave += new System.EventHandler(this.b_upload_MouseLeave);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // b_send_2
            // 
            this.b_send_2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.b_send_2, "b_send_2");
            this.b_send_2.Name = "b_send_2";
            this.b_send_2.UseVisualStyleBackColor = true;
            this.b_send_2.Click += new System.EventHandler(this.b_send_2_Click);
            // 
            // l_autorname
            // 
            resources.ApplyResources(this.l_autorname, "l_autorname");
            this.l_autorname.BackColor = System.Drawing.Color.Gainsboro;
            this.l_autorname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_autorname.Name = "l_autorname";
            // 
            // w_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.img_panel);
            this.Controls.Add(this.b_info);
            this.Controls.Add(this.b_settings);
            this.Controls.Add(this.l_autorname);
            this.Controls.Add(this.b_listbox_ok);
            this.Controls.Add(this.b_send_2);
            this.Controls.Add(this.b_send);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.in_way);
            this.Controls.Add(this.thank);
            this.Controls.Add(this.pa_label);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.b_info_cancel);
            this.Controls.Add(this.close_prog);
            this.Controls.Add(this.b_cancel_info);
            this.Controls.Add(this.b_upload);
            this.Controls.Add(this.b_join);
            this.Controls.Add(this.text_box);
            this.Controls.Add(this.b_reload);
            this.Controls.Add(this.b_minimize);
            this.Controls.Add(this.b_feedback);
            this.Controls.Add(this.b_report);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "w_Main";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.w_Main_Load);
            this.Shown += new System.EventHandler(this.w_Main_Valide);
            this.SizeChanged += new System.EventHandler(this.w_Main_SizeChanged);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.form_DClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel img_panel;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button b_info;
        private System.Windows.Forms.TextBox text_box;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Button b_send;
        private System.Windows.Forms.Button b_report;
        private System.Windows.Forms.Button b_feedback;
        private System.Windows.Forms.Button b_cancel_info;
        private System.Windows.Forms.Label pa_label;
        private System.Windows.Forms.Label thank;
        private System.Windows.Forms.Label in_way;
        private System.Windows.Forms.Button close_prog;
        private System.Windows.Forms.Button b_minimize;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button b_listbox_ok;
        private System.Windows.Forms.Button b_info_cancel;
        private System.Windows.Forms.Button b_reload;
        private System.Windows.Forms.Button b_join;
        private System.Windows.Forms.Button b_upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_send_2;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Label l_autorname;
    }
}

