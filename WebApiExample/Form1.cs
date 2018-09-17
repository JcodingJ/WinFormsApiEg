using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace WebApiExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string url = "http://api.nbp.pl/api/exchangerates/rates/a/" + txtCur.Text;
            var request = System.Net.WebRequest.Create(url);
            string xml="";

            request.Timeout = 1000;
            request.Method = "GET";
            request.ContentType = "application/xml";

            try
            {
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        var reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                        xml = reader.ReadToEnd();
                        txtRes.Text = xml;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xml);

            XmlNodeList elemList = xdoc.GetElementsByTagName("Mid");

            System.Globalization.CultureInfo culInfo = new System.Globalization.CultureInfo("en-GB", true);
            string res = elemList[0].InnerXml;
            lblRate.Text = res;

            decimal pln = decimal.Parse(txtVal.Text);
            decimal val = decimal.Parse(res, culInfo);
            
            decimal result = val * pln;
            
            lblRes.Text = result.ToString();
        }

    }
}
