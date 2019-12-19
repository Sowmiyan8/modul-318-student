using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        MailMessage m_mail = new MailMessage();
        SmtpClient m_mailserver = new SmtpClient("smtp.gmail.com");
        string result;
        public Form1(string results)
        {
            InitializeComponent();
            result = results;
        }

        private bool Input()
        {
            if (!lost.Text.Contains("@"))
            {
                MessageBox.Show("Bitte eine Emailadresse ein eingeben");
                return false;
            }
            if (!lost.Text.Contains("@"))
            {
                MessageBox.Show("Bitte Empfänger eingeben");
                return false;
            }

            if (betreff.Text == "")
            {
                MessageBox.Show("Bitte Bettref eingeben");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Input())
            {
                try
                {
                    string from = lost.Text;
                    m_mail.From = new MailAddress(from);
                    m_mail.To.Add(lost.Text);
                    m_mail.Subject = betreff.Text;

                    m_mail.IsBodyHtml = true;
                    m_mailserver.Port = 587;
                    m_mailserver.Credentials = new System.Net.NetworkCredential(from, pass.Text);
                    m_mailserver.EnableSsl = true;

                    m_mail.Body = text.Text + "\r\n" + "\r\n";

                    foreach (char connection in result)
                    {
                        m_mail.Body += connection;
                    }

                    m_mailserver.Send(m_mail);
                    MessageBox.Show("Mail versendet");
                    Close();
                }
                catch {
                    MessageBox.Show("Email kann nicht gesendet werden");
                    Close();

                }

       
            }
    
        }

    }
}
