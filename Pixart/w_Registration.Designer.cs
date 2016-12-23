namespace Pixart
{
    partial class w_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Registration));
            this.login = new System.Windows.Forms.TextBox();
            this.Label_login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.b_Join = new System.Windows.Forms.Button();
            this.Label_or = new System.Windows.Forms.Label();
            this.b_Registration = new System.Windows.Forms.Button();
            this.password_repeat = new System.Windows.Forms.TextBox();
            this.Label_pass_rep = new System.Windows.Forms.Label();
            this.reg_cancel = new System.Windows.Forms.Button();
            this.b_join_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            this.login.MouseEnter += new System.EventHandler(this.login_MouseEnter);
            // 
            // Label_login
            // 
            resources.ApplyResources(this.Label_login, "Label_login");
            this.Label_login.BackColor = System.Drawing.Color.Transparent;
            this.Label_login.Name = "Label_login";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            // 
            // label_pass
            // 
            resources.ApplyResources(this.label_pass, "label_pass");
            this.label_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_pass.Name = "label_pass";
            // 
            // b_Join
            // 
            this.b_Join.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b_Join.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.b_Join, "b_Join");
            this.b_Join.Name = "b_Join";
            this.b_Join.UseVisualStyleBackColor = false;
            this.b_Join.Click += new System.EventHandler(this.b_Join_Click);
            // 
            // Label_or
            // 
            resources.ApplyResources(this.Label_or, "Label_or");
            this.Label_or.BackColor = System.Drawing.Color.Transparent;
            this.Label_or.Name = "Label_or";
            // 
            // b_Registration
            // 
            this.b_Registration.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b_Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.b_Registration, "b_Registration");
            this.b_Registration.Name = "b_Registration";
            this.b_Registration.UseVisualStyleBackColor = false;
            this.b_Registration.Click += new System.EventHandler(this.b_Registration_Click);
            // 
            // password_repeat
            // 
            resources.ApplyResources(this.password_repeat, "password_repeat");
            this.password_repeat.Name = "password_repeat";
            this.password_repeat.UseSystemPasswordChar = true;
            // 
            // Label_pass_rep
            // 
            resources.ApplyResources(this.Label_pass_rep, "Label_pass_rep");
            this.Label_pass_rep.BackColor = System.Drawing.Color.Transparent;
            this.Label_pass_rep.Name = "Label_pass_rep";
            // 
            // reg_cancel
            // 
            this.reg_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reg_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.reg_cancel, "reg_cancel");
            this.reg_cancel.Name = "reg_cancel";
            this.reg_cancel.UseVisualStyleBackColor = false;
            this.reg_cancel.Click += new System.EventHandler(this.reg_cancel_Click);
            // 
            // b_join_cancel
            // 
            this.b_join_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.b_join_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.b_join_cancel, "b_join_cancel");
            this.b_join_cancel.Name = "b_join_cancel";
            this.b_join_cancel.UseVisualStyleBackColor = false;
            this.b_join_cancel.Click += new System.EventHandler(this.Join_Cancel_Click);
            // 
            // w_Registration
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ControlBox = false;
            this.Controls.Add(this.b_Registration);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Label_pass_rep);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.Label_or);
            this.Controls.Add(this.Label_login);
            this.Controls.Add(this.login);
            this.Controls.Add(this.b_join_cancel);
            this.Controls.Add(this.reg_cancel);
            this.Controls.Add(this.b_Join);
            this.Controls.Add(this.password_repeat);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "w_Registration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void login_MouseEnter(object sender, System.EventArgs e)
        {
            login.Focus();
        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label Label_login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Button b_Join;
        private System.Windows.Forms.Label Label_or;
        private System.Windows.Forms.Button b_Registration;
        private System.Windows.Forms.TextBox password_repeat;
        private System.Windows.Forms.Label Label_pass_rep;
        private System.Windows.Forms.Button reg_cancel;
        private System.Windows.Forms.Button b_join_cancel;



    }
}