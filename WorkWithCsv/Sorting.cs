using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithCsv
{
    class Sorting
    {
        public string[,] SortingFiles()
        {
            // Получение путей и названий txt и wav файлов
            string PathToDatafiles = Directory.GetCurrentDirectory().ToString() + "\\DataFiles";
            string[] getTxtFiles = Directory.GetFiles(PathToDatafiles, "*.txt");
            string[] getWavFiles = Directory.GetFiles(PathToDatafiles, "*.wav");


            // Списки для:
            // - Ключей поиска
            // - Отсортированных wav и txt файлов
            // - Списка дат
            List<string> keys = new List<string>();
            List<string> wavSortedList = new List<string>();
            List<string> txtSortedList = new List<string>();
            List<string> recievedDates = new List<string>();
            string[,] sortedArray = new string[getTxtFiles.Length, 6];

            // Получение ключей
            foreach (string t in getTxtFiles)
            {
                Char _extensionDelimiter = '.';
                Char _mainDelimiter = '_';
                string[] fileName = t.Split(_extensionDelimiter).First().Split(_mainDelimiter);
                string key = fileName[1] + "_" + fileName[2];
                keys.Add(key);
            }

            // Поиск wav файлов по ключам
            foreach (string k in keys)
            {
                foreach (string wav in getWavFiles)
                {
                    if (wav.Contains(k)) wavSortedList.Add(wav);
                }
            }

            // Получение txt файлов по ключам
            foreach (string k in keys)
            {
                foreach (string txt in getTxtFiles)
                {
                    if (txt.Contains(k)) txtSortedList.Add(txt);
                }
            }

            // Получение дат
            foreach (string s in getTxtFiles) recievedDates.Add(GetDate(s));

            // Организация двумерного массива для базы данных
            for (int i = 0; i < keys.Count; i++)
            {
                sortedArray[i, 0] = recievedDates[i];
                sortedArray[i, 1] = txtSortedList[i];
                sortedArray[i, 2] = wavSortedList[i];
                sortedArray[i, 3] = null;
                sortedArray[i, 4] = null;
                sortedArray[i, 5] = null;
            }

            return sortedArray;
        }

        // Метод получения даты в формате "10.02.24 01:01:01"
        private string GetDate(string e)
        {
            string _fullFileName = e;
            Char _extensionDelimiter = '.';
            Char _mainDelimiter = '_';
            string fileName = _fullFileName.Split(_extensionDelimiter).First();
            string rawTime = fileName.Split(_mainDelimiter)[1];
            string rawDate = fileName.Split(_mainDelimiter)[2];

            List<string> _splitTime = new List<string>();
            List<string> _splitDate = new List<string>();
            int i = 0;
            int _step = 2;
            while (i < rawTime.Length)
            {
                _splitTime.Add(rawTime.Substring(i, _step));
                i = i + _step;
            }
            int j = 0;
            while (j < rawDate.Length)
            {
                _splitDate.Add(rawDate.Substring(j, _step));
                j = j + _step;
            }
            string output = String.Join(".", _splitTime) + " " + String.Join(":", _splitDate);

            return output;
        }
    }
}
