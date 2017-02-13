using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithCsv
{
    class CopyAndFillingDB
    {
        // Путь до корня программы
        public static string ProgPath = Directory.GetCurrentDirectory();
        // Имя папки с файлами
        public static string NewFolderName = "DataFiles";
        // Имя csv файла - базы данных, и путь до него.
        public static string FileName = "data.csv";
        public static string PathToDatabase = ProgPath + "\\" + FileName;

        //Путь для копирования файлов
        public static string PathForCopy = Path.Combine(ProgPath, NewFolderName);

        public void CopyFiles()
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Создание папки для файлов, если ещё не существует
                if (!Directory.Exists(PathForCopy)) Directory.CreateDirectory(PathForCopy);
            }
            // Определение переменных, получение массива имен файлов
            string[] sourseFiles = openFileDialog1.FileNames;
            string destinationFile, fileName;
            foreach (string s in sourseFiles)
            {
                // Получаем имя файла,
                // Создаем путь для перемещения
                // Копируем
                fileName = s.Split('\\').Last();
                destinationFile = Path.Combine(PathForCopy, fileName);
                File.Copy(s, destinationFile, true);
            }
        }


        private void FillingDatabase(string[,] arrayForDatabase)
        {

            // Считываем информацию из файла

            // Откываем поток в файл
            using (var sw = new StreamWriter(PathToDatabase))
            {
                //Подключаем библиотеку записи в csv
                var writer = new CsvWriter(sw);
                writer.Configuration.Delimiter = ",";
                writer.WriteHeader(typeof(Fields));
                for (int i = 0; i < arrayForDatabase.GetLength(0); i++)
                {
                    writer.WriteField(arrayForDatabase[i, 0]);
                    writer.WriteField(arrayForDatabase[i, 1]);
                    writer.WriteField(arrayForDatabase[i, 2]);
                    writer.WriteField(arrayForDatabase[i, 3]);
                    writer.WriteField(arrayForDatabase[i, 4]);
                    writer.WriteField(arrayForDatabase[i, 5]);
                    writer.NextRecord();
                }
            }
        }

        public void Filling()
        {
            Sorting sort = new Sorting();
            string[,] array = sort.SortingFiles();

            FillingDatabase(array);
        }
        
        public void AddingAndFilling()
        {
            CopyFiles();
            Sorting sort = new Sorting();
            string[,] array = sort.SortingFiles();
            
            FillingDatabase(array);
        }


    }
}
