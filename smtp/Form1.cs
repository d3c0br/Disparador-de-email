using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices;

namespace smtp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        IList<string> ListaEmails = new List<string>();
        int count;
		
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtAssunto.Text == "" || txtMensagem.Text == "" || txtEmailFrom.Text == "" || txtSenha.Text == "" || txtPorta.Text == "" || txtSmtp.Text == "" || txtIntervalo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                
                if (btnIniciar.ForeColor == Color.Lime)
                {

                    btnIniciar.ForeColor = Color.Red;
                    btnIniciar.Text = "Parar";

                    timer1.Interval = Convert.ToInt32(txtIntervalo.Text);
                    timer1.Start();

                    ObterEmails();
                }
                else if (btnIniciar.ForeColor == Color.Red)
                {
                    btnIniciar.ForeColor = Color.Lime;
                    btnIniciar.Text = "Iniciar";
                    timer1.Stop();
                    progressBar1.Value = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = Convert.ToInt32(txtIntervalo.Text) * 10;

            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            else
            {

                try
                {
                    if(count == 0) 
                    { 
                        timer1.Stop();
                        btnIniciar.ForeColor = Color.Lime;
                        btnIniciar.Text = "Iniciar";
                        progressBar1.Value = 0;

                        MessageBox.Show("O envio terminou!");
                        //this.Close();

                    }
                    else
                    {
                        MailMessage mail = new MailMessage();

                        mail.From = new MailAddress(txtEmailFrom.Text); 
                        mail.To.Add(ListaEmails[count]);
                        mail.Subject = txtAssunto.Text;
                        mail.Body = txtMensagem.Text;
                        mail.IsBodyHtml = true;

                        if (listBox1.Items.Count != 0)
                        {
                            
                            foreach (var listBoxItem in listBox1.Items)
                            {
                                
                                mail.Attachments.Add(new Attachment(listBoxItem.ToString()));

                            }
                        }
                        


                        using (var smtp = new SmtpClient(txtSmtp.Text))
                        {
                            smtp.EnableSsl = true; 
                            smtp.Port = Convert.ToInt32(txtPorta.Text);       
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; 
                            smtp.UseDefaultCredentials = false; 

                            smtp.Credentials = new NetworkCredential(txtEmailFrom.Text, txtSenha.Text);

                            smtp.Send(mail);

                            lbLogs.Items.Add("Enviado: " + ListaEmails[count]);

                            
                            lbLogs.SetSelected(lbLogs.Items.Count - 1, true);

                            count--;
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    lbLogs.Items.Add("Aguarde...");
                    count--;
                }

                progressBar1.Value = 0;
            }


        }

        private void ObterEmails()
        {
            try
            {
                ListaEmails.Clear();

                string data = File.ReadAllText(btnListaDestinatarios.Text, Encoding.UTF8);

                string linha;

                StringReader texto = new StringReader(data.ToString());
                while ((linha = texto.ReadLine()) != null)
                {
                    ListaEmails.Add(linha);
                }

                count = ListaEmails.Count;
            }
            catch
            {
                btnIniciar.ForeColor = Color.Lime;
                btnIniciar.Text = "Iniciar";
                MessageBox.Show("Adicione uma lista de emails válida!");
                timer1.Stop();
                progressBar1.Value = 0;
            }
           


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnListaDestinatarios_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Selecione a lista de emails";
            file.Filter = "Text Files(*.txt)|*.txt";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                btnListaDestinatarios.Text = file.FileName;
            }
        }

        private void brnAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Selecione um arquivo para anexar ao email";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(file.FileName);
            }
        }

    }
}
