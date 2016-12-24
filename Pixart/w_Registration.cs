namespace Pixart
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    public delegate void OL_1();
    public delegate void SL_1(int data, string login);
    public partial class w_Registration : Form
    {
        public event OL_1 LoginEvent;
        public event SL_1 SendLoginEvent;
        public void OnLogin()
        {
            LoginEvent();
        }
        public void SendLogin(int data, string login)
        {
            SendLoginEvent(data, login);
        }
        private static string work_dir = "http://www.ru-laboratory.xyz/pixart/";
        private bool reg;
        private string lang = @"lang.txt";
        public w_Registration()
        {
            InitializeComponent();
            #region language
            if (File.Exists(lang) != true)
            {
                Label_login.Text = "Логин";
                label_pass.Text = "Пароль";
                Label_pass_rep.Text = "Пароль повторно";
                Label_or.Text = "или";
                b_Join.Text = "Войти";
                b_Registration.Text = "Регистрация";
                reg_cancel.Text = "Отмена";
                b_join_cancel.Text = "Отмена";
            }
            else
            {
                string text = System.IO.File.ReadAllText(lang);
                if (text.Contains("rus"))
                {
                    Label_login.Text = "Логин";
                    label_pass.Text = "Пароль";
                    Label_pass_rep.Text = "Пароль повторно";
                    Label_or.Text = "или";
                    b_Join.Text = "Войти";
                    b_Registration.Text = "Регистрация";
                    reg_cancel.Text = "Отмена";
                    b_join_cancel.Text = "Отмена";
                }
                else if (text.Contains("eng"))
                {
                    Label_login.Text = "Login";
                    label_pass.Text = "Password";
                    Label_pass_rep.Text = "Repeat password";
                    Label_or.Text = " or";
                    b_Join.Text = "Join";
                    b_Registration.Text = "Registration";
                    reg_cancel.Text = "Cancel";
                    b_join_cancel.Text = "Cancel";
                }
            }
            #endregion
        }
        private void b_Join_Click(object sender, EventArgs e)
        {
            #region begin
            bool errors = false; string error_text = "";
            if (login.Text.Length < 5)
            {
                errors = true;
                if (File.Exists(lang) != true)
                {
                    error_text = "Введите логин.\n";
                }
                else
                {
                    string text = System.IO.File.ReadAllText(lang);
                    if (text.Contains("rus"))
                    {
                        error_text = "Введите логин.\n";
                    }
                    else if (text.Contains("eng"))
                    {
                        error_text = "Input login.\n";
                    }
                }

            }
            if (password.Text.Length < 5)
            {
                errors = true;
                if (File.Exists(lang) != true)
                {
                    error_text = error_text + "Введите пароль.\n";
                }
                else
                {
                    string text = System.IO.File.ReadAllText(lang);
                    if (text.Contains("rus"))
                    {
                        error_text = error_text + "Введите пароль.\n";
                    }
                    else if (text.Contains("eng"))
                    {
                        error_text = error_text + "Input password.\n";
                    }
                }
            }
            if (errors)
            {
                if (File.Exists(lang) != true)
                {
                    MessageBox.Show(error_text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string text = System.IO.File.ReadAllText(lang);
                    if (text.Contains("rus"))
                    {
                        MessageBox.Show(error_text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (text.Contains("eng"))
                    {
                        MessageBox.Show(error_text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                reg = true;
                RegForms(false);
                return;
            }
            string Data = Model.GetPost(work_dir + "join.php", "Login", login.Text, "Pass", password.Text);
            if (int.Parse(Data) > 0)
            {
                #endregion
                OnLogin();
                SendLogin(int.Parse(Data), login.Text);
                Close();
                #region begin
            }
            else if (Data == "0")
            {
                if (File.Exists(lang) != true)
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string text = System.IO.File.ReadAllText(lang);
                    if (text.Contains("rus"))
                    {
                        MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (text.Contains("eng"))
                    {
                        MessageBox.Show("Invalid login or password!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                RegForms(false);
            }
            else
            {
                if (File.Exists(lang) != true)
                {
                    MessageBox.Show("На сервере ведутся технические работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string text = System.IO.File.ReadAllText(lang);
                    if (text.Contains("rus"))
                    {
                        MessageBox.Show("На сервере ведутся технические работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (text.Contains("eng"))
                    {
                        MessageBox.Show("Server technical work underway", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                RegForms(false);
            }
        }
        #endregion
        private void b_Registration_Click(object sender, EventArgs e)
        {
            reg = !reg;
            if (reg) RegForms(reg);
            else
            {
                bool errors = false; string error_text = "";
                if (login.Text.Length < 5)
                {
                    errors = true;
                    if (File.Exists(lang) != true)
                    {
                        error_text = "Длина логина не может быть меньше 5 символов\n";
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            error_text = "Длина логина не может быть меньше 5 символов\n";
                        }
                        else if (text.Contains("eng"))
                        {
                            error_text = "Login length can not be less than 5 characters\n";
                        }
                    }
                }
                if (password.Text.Length < 5)
                {
                    errors = true;
                    if (File.Exists(lang) != true)
                    {
                        error_text = error_text + "Длина пароля не может быть меньше 5 символов\n";
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            error_text = error_text + "Длина пароля не может быть меньше 5 символов\n";
                        }
                        else if (text.Contains("eng"))
                        {
                            error_text = error_text + "Password length can not be less than 5 characters\n";
                        }
                    }
                }

                if (errors)
                {
                    if (File.Exists(lang) != true)
                    {
                        MessageBox.Show(error_text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            MessageBox.Show(error_text, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (text.Contains("eng"))
                        {
                            MessageBox.Show(error_text, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    reg = true;
                    RegForms(true);
                    return;
                }

                if (password.Text != password_repeat.Text)
                {
                    if (File.Exists(lang) != true)
                    {
                        MessageBox.Show("Введённые пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            MessageBox.Show("Введённые пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (text.Contains("eng"))
                        {
                            MessageBox.Show("The entered passwords do not match", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    reg = true;
                    RegForms(true);
                    return;
                }

                string Data = Model.GetPost(work_dir + "registration.php", "login", login.Text, "pass", password.Text);
                if (Data == "0")
                {
                    if (File.Exists(lang) != true)
                    {
                        MessageBox.Show("Данный логин уже занят!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            MessageBox.Show("Данный логин уже занят!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (text.Contains("eng"))
                        {
                            MessageBox.Show("This username is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    reg = true;
                    RegForms(true);
                }
                else if (Data == "-1")
                {
                    if (File.Exists(lang) != true)
                    {
                        MessageBox.Show("На сервере ведутся временные технические работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            MessageBox.Show("На сервере ведутся временные технические работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (text.Contains("eng"))
                        {
                            MessageBox.Show("On the server, maintained temporary technical work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    reg = true;
                    RegForms(true);
                }
                else
                {
                    if (File.Exists(lang) != true)
                    {
                        MessageBox.Show("Аккаунт успешно создан!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string text = System.IO.File.ReadAllText(lang);
                        if (text.Contains("rus"))
                        {
                            MessageBox.Show("Аккаунт успешно создан!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (text.Contains("eng"))
                        {
                            MessageBox.Show("Account successfully created!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    RegForms(false);
                }
            }
        }
        private void Join_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void reg_cancel_Click(object sender, EventArgs e)
        {
            RegForms(false);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            b_join_cancel.Visible = true;
            b_Join.Visible = true;
            b_Registration.Visible = true;

        }
        private void RegForms(bool res)
        {
            reg = res;
            login.Text = "";
            password.Text = "";
            password_repeat.Text = "";
            b_Join.Visible = !res;
            if (File.Exists(lang) != true)
            {
                if (res) b_Registration.Text = "Создать";
                else b_Registration.Text = "Регистрация";
            }
            else
            {
                string text = System.IO.File.ReadAllText(lang);
                if (text.Contains("rus"))
                {
                    if (res) b_Registration.Text = "Создать";
                    else b_Registration.Text = "Регистрация";
                }
                else if (text.Contains("eng"))
                {
                    if (res) b_Registration.Text = "Create";
                    else b_Registration.Text = "Register";
                }
            }
            Label_or.Visible = !res;
            password_repeat.Visible = res;
            Label_pass_rep.Visible = res;
            reg_cancel.Visible = res;
            b_join_cancel.Visible = !res;
        }
        private void ToogleForms(bool res)
        {
            login.Text = "";
            password.Text = "";
            password_repeat.Text = "";
            login.Visible = res;
            password.Visible = res;
            label_pass.Visible = res;
            Label_login.Visible = res;
            b_Join.Visible = res;
            b_Registration.Visible = res;
            Label_or.Visible = res;
        }

    }
}
