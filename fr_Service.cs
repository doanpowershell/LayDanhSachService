using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;



namespace WindowsFormsApplication1
{
    public partial class form_Service : Form
    {
        string text;
        public form_Service()
        {
            InitializeComponent();
        }

        private void Show_Service_Load(object sender, EventArgs e)
        {
            ////comboBox1.Items.Add("Dinh Van Quoc");
            //// tao mot doi tuong powershell
            //PowerShell.Create().AddScript("gwmi win32_service | select Name").AddCommand("Out-String").Invoke<string>();
            //foreach (string str in PowerShell.Create().AddScript("gwmi win32_service | select Name").AddCommand("Out-String").Invoke<string>())
            //{             
            //   // MessageBox.Show(str);
            //   comboBox1.Items.Add(str);
            //}
            //// them lenh thuc thi
            ////ps.AddCommand("Out-String");

           // ps.AddScript("Get-Service");
            // goi lenh
            //ps.Invoke<string>();
            //comboBox1.Items.Add(ps);

            PowerShell ps = PowerShell.Create();
            ps.AddScript("gwmi win32_service | select name");
            Collection<PSObject> p = ps.Invoke();
            string cb = string.Empty;
            foreach (PSObject str in p)
            {
                cb = "\n" + str.Members["Name"].Value.ToString();
                comboBox1.Items.Add(cb);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = null;
            text = (string)comboBox1.SelectedItem;
            MessageBox.Show(text);
        }
    }
}
