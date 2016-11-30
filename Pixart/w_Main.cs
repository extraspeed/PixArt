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
        public w_Main()
        {
            InitializeComponent();
        }

        public static string GetPost(string Url, params string[] postdata)
        {
            return "";
        }

        public void LogIn(int p)
        {
        }

        public void ReloadImages()
        {
        }
    }
}
