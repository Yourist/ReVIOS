using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReVIOS.Oscilogram
{
    class txtFile
    {
        public string[][] NumbersFromTxt(string txtPath)
        {
            string targetPath = Directory.GetCurrentDirectory() + "\\DataFiles";
            string[] filesPath;
            string[] lines; //массив всех строк txt файла
            //массив, заполняющийся построчно. Можно добавить ещё данных. имеет 5 столбцов
            string[][] listOfMax = { new string[] { "" }, new string[] { "" }, new string[] { "" }, new string[] { "" }, new string[] { "" } };
            string[] splitedLine; //разбитая строка txt файла
            int k = 0;

            if (Directory.Exists(targetPath)) //Проверка, существует ли эта папка
            {
                filesPath = Directory.GetFiles(targetPath, "*.txt");
                if (filesPath != null)
                {
                    // Эту переменную будем добывать другим способом, через 2ой клик по DadaBase
                    txtPath = filesPath[0];
                    //Построчно получаем все строки из txt в string[]
                    lines = File.ReadAllLines(txtPath);
                    //находим строки, начинающиеся с int переменных
                    for (int i = 0; i < lines.Length - 20; i++)
                    {
                        string line = lines[0];
                        char needChar = line[1];
                        //Каждую строку дробим на массив с разделителем " "
                        splitedLine = lines[i].Split('\t');
                        //Проверяем, равен ли 0ой элемент массива разбитой строки - целому числу
                        try
                        {
                            Convert.ToInt32(splitedLine[0]);
                            // 5 - это кол-во столбцов в отчёте, кол-во величин, которые нам необходимы из txt
                            for (int n = 0; n < 5; n++)
                            {
                                //Увеличиваем массив начиная со 2го шага, т.е. когда k>0
                                if (k > 0)
                                {
                                    //Изменение величины массива, что бы добавить в него новый элемент
                                    Array.Resize(ref listOfMax[n], listOfMax[n].Length + 1);
                                }
                                listOfMax[n][k] = splitedLine[n + 1];
                                //Где:
                                //splitedLine[1] - начало импульса, мс
                                //splitedLine[2] - конец импульса, мс
                                //splitedLine[3] - Амплитуда, кв
                                //splitedLine[4] - Энергетическая характеристика (интеграл по амплитудам)
                                //splitedLine[5] - Количество осцилляций
                            }
                            //Наращиваем массив
                            k++;
                        }
                        catch (FormatException)
                        {
                            //MessageBox.Show(e.ToString());
                        }
                    }
                    return listOfMax; // Если всё удачно вернёт сформированный массив массивов
                }
                else
                {
                    MessageBox.Show("Добавьте *.txt файл с прибора");
                    return listOfMax;
                }
            }
            else
            {
                MessageBox.Show("Добавьте *.txt файлы в проект");
                return listOfMax;
            }
        }

        public void ShowMax(DataGridView dataGridOfMax, string txtFile)
        {
            
            //Вызов метода списка файлов - создание списка имён добавленных .txt файлов
            string[][] listOfNumbers = NumbersFromTxt(txtFile);
            //Проверка, был ли добавлен .txt файл
            if (listOfNumbers != null)
            {
                //Задаём кол-во строк и столбцов в DaraGridView
                dataGridOfMax.RowCount = listOfNumbers[0].GetLength(0);
                dataGridOfMax.ColumnCount = 2;
                //Задаём названия заголовков
                dataGridOfMax.TopLeftHeaderCell.Value = "№";
                dataGridOfMax.Columns[0].HeaderText = "Начало импульса [мс]";
                dataGridOfMax.Columns[1].HeaderText = "Амплитуда";

                for (int i = 0; i < listOfNumbers[0].GetLength(0); i++)
                {
                    // Нас интересует время и амплитуда, поэтому берём только [0] и [2]
                    int m = 0;
                    for (int j = 0; j < dataGridOfMax.ColumnCount; j++)
                    {
                        dataGridOfMax.Rows[i].Cells[j].Value = listOfNumbers[m][i];
                        dataGridOfMax.Rows[i].HeaderCell.Value = i + 1;
                        m = +2;
                    }
                }
            }
        }
    }
}
