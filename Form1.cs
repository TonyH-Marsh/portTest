using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace portTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fdResp.Text = "please wait ..";
            Uri uri = new Uri(fdUrl.Text);
            WebResponse resp;
            WebRequest req = WebRequest.Create(uri);

            if (fdUseCred.Checked == true)
            {
                NetworkCredential cred = new NetworkCredential(fdUser.Text, fdPw.Text);
                ICredentials icred = cred.GetCredential(uri, "basic");
                req.Credentials = icred;
            }

            // Hello world 1234
            if (fdUseProxy.Checked == true) { 
               req.Proxy = new System.Net.WebProxy(fdProxy.Text, true);
               req.Proxy.Credentials = CredentialCache.DefaultCredentials;
            }

            req.Timeout = 12000;
            
            try
            {
                resp = req.GetResponse();
                fdResp.Text = resp.Headers.ToString();
            }
            catch( Exception ex)
            {
                fdResp.Text = ex.ToString();
            }
        }

        private void fdPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
