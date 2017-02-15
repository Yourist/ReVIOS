using CsvHelper;
using ReVIOS.Oscilogram;
using ReVIOS.Report;
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

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {

            string txt = FilePath().Item2;
            string wav = FilePath().Item1;
            customWaveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(wav);
            customWaveViewer1.FitToScreen();
            customWaveViewer2.WaveStream = new NAudio.Wave.WaveFileReader(wav);
            customWaveViewer2.FitToScreen();

            txtFile tf = new txtFile();
            tf.ShowMax(dataGridOfMax, txt);

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            string txt = FilePath().Item2;
            CreateReport crr = new CreateReport(); 
            crr.DocReport(progressBarDL, txt);
        }


        public Tuple<string, string, string, string> FilePath()
        {
            //получаем индекс строки
            var _chosenRow = dataGridView.CurrentCell.RowIndex;

            var sr = new StreamReader(new FileStream("data.csv", FileMode.Open));
            var csv = new CsvReader(sr);
            csv.Read();
            string wav = csv.GetRecord<Fields>().wavFile;
            string txt = csv.GetRecord<Fields>().txtFile;
            string photo = csv.GetRecord<Fields>().Photo;
            string fullName = csv.GetRecord<Fields>().FullName;
            sr.Close();
            return Tuple.Create(wav, txt, photo, fullName);
        }
    }
}
