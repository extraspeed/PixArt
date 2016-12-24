using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    class Model
    {
        public static string autor_name;
        public static string work_dir = "http://www.ru-laboratory.xyz/pixart/";
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
            catch (Exception)
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
                    catch (Exception)
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
        public static string[] SetLikes(int u_id, string image, bool like)
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
            catch (Exception)
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
        public static string[] ShowComment(string image)
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
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
            string[] res = result.Split('~');
            return res;
        }
        public static int AddComment(string image, string txt)
        {
            string result = "";
            UTF8Encoding ascii = new UTF8Encoding();
            txt = autor_name + txt;
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
            catch (Exception)
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
        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static string[] GetImagesByGrops(string Url, int i_id, int count = 4)
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
            catch (Exception)
            {
                throw new IndexOutOfRangeException();
            }
            return result.Split('~');
        }

    }
}
