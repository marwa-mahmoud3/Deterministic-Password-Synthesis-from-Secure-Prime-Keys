using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            string key = key_txt.Text;
            string link = link_txt.Text;
            link_txt.Text = link.ToUpper();
            if(key_txt.Text.Length < 4)
                MessageBox.Show("Key Length must be Larger than 4 Character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else if(link_txt.Text.Length < 5)
                MessageBox.Show("Link Length must be Larger than 5 Character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if (link_txt.Text.Contains("www."))
                MessageBox.Show("Link must contains .www", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                long[] New_Key = ToNumber(key);
                long[] New_Link = ToNumber(link);
                long[] Formated_Key = FormateKey(New_Key);
                long[] Formated_Link = FormateLink(New_Link);
                long checkSum_key = CheckSum(Formated_Key);
                long checkSum_Link = CheckSum(Formated_Link);
                long checkSum = 0;
                string sum = "";
                sum += checkSum_key.ToString() + checkSum_Link.ToString();
                for (int i = 0; i < sum.Length; i++)
                {
                    checkSum += (int)sum[i] - 48;
                }
                long[] keyPlusLink = new long[18];
                long[] password = new long[18];
                string result = "";
                for (int i = 0, j = 0; i < 18; i++, j++)
                {
                    if (j == 6)
                        j = 0;
                    keyPlusLink[i] = (Formated_Link[i] + Formated_Key[j]) * checkSum;
                }
                for (int i = 0; i < 18; i++)
                {
                    keyPlusLink[i] = keyPlusLink[i] / 10;
                }
                for (int i = 0; i < 18; i++)
                {
                    password[i] = keyPlusLink[i] % 95 + 32;
                }

                for (int i = 0; i < password.Length; i++) 
                {
                    
                    result += (char)password[i];
                }
                password_txt.Text = result; 
            }
        }
        private long[] ToNumber(string str)
        {
            List<long> res = new List<long>();
            for (int i = 0; i < str.Length; i++) 
            {
                res.Add(str[i]);
            }
            return res.ToArray();
        }

        private long[] FormateKey(long[] arr)
        {
            List<long> res = new List<long>();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Add(arr[i]);
            }
            if (arr.Length == 4)
            {
                res.Add(arr[0] * arr[1]);
                res.Add(arr[2] * arr[3]);
            }
            else if (arr.Length == 5)
            {
                res.Add(arr[0] * arr[1]);
            }
            else if (arr.Length > 6 && arr.Length < 24)
            {
                long[] arr2 = new long[6];
                for (int i = 0; i < 6; i++)
                {
                    int h = i + 6;
                    while (h < arr.Length)
                    {
                        arr[i] *= arr[h];
                        h += 6;
                    }
                }

                for (int i = 0; i < 6; i++)
                {
                    arr2[i] = arr[i];
                }
                return arr2;
            }
            else if (arr.Length >= 24) 
            {
                long[] arr2 = new long[6];
                for (int i = 0; i < 6; i++)
                {
                    int h = i + 6;
                    while (h < arr.Length)
                    {
                        if (h < 18)
                            arr[i] *= arr[h];
                        else
                            arr[i] += arr[h];
                        h += 6;
                    }
                }

                for (int i = 0; i < 6; i++)
                {
                    arr2[i] = arr[i];
                }
                return arr2; 
            }

            return res.ToArray();
        }
        private long[] FormateLink(long[] arr)
        {
            long[] arr2 = new long[18];
            List<long> res = new List<long>();
            if (arr.Length < 18) 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    res.Add(arr[i]);
                }
                for (int i = 0; i < 18 - arr.Length; i++) 
                {
                    if (i <= 10)
                    {
                        res.Add(res[i] * res[i + 1]);
                    }
                    else
                    {
                        res.Add(res[i] + res[i + 1]);
                    }
                }
                return res.ToArray();
            }
            else if (arr.Length > 18)
            {
                for (int i = 0; i < arr.Length - 18; i++)
                {
                    arr[i] = arr[i] + arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = 48;
                }
            }
            for (int i = 0; i < 18; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }
        private long CheckSum(long[] arr)
        {
            long result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i].ToString();
                for (int j = 0; j < s.Length; j++)
                {
                    result += (int)s[j] - 48;
                }
            }
            
            return result;
        }

    }
}
