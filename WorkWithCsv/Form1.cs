using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReVIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CopyAndFillingDB cafDB = new CopyAndFillingDB();
            cafDB.AddingAndFilling();
            dataGridView.Refresh();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fieldsBindingSource.DataSource = new List<Fields>();

            string path = Directory.GetCurrentDirectory();
            string[] getFile = Directory.GetFiles(path, "data.csv");


            if (getFile.Length == 0){
                CopyAndFillingDB cafDB = new CopyAndFillingDB();
                cafDB.Filling();
                var sr = new StreamReader(new FileStream("data.csv", FileMode.Open));
                var csv = new CsvReader(sr);
                fieldsBindingSource.DataSource = csv.GetRecords<Fields>();
                dataGridView.Refresh();
                sr.Close();
            }
            else
            {
                var sr = new StreamReader(new FileStream("data.csv", FileMode.Open));
                var csv = new CsvReader(sr);

                fieldsBindingSource.DataSource = csv.GetRecords<Fields>();
                dataGridView.Refresh();
                sr.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("data.csv"))
            {
                var test = fieldsBindingSource.List;
                var writer = new CsvWriter(sw);
                writer.WriteHeader(typeof(Fields));
                
                foreach (Fields f in test)
                {
                    writer.WriteRecord(f);
                }
            }
        }

        private void fieldsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
