using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using ReVIOS.Oscilogram;

namespace ReVIOS.Report
{
    class CreateReport
    {
        public void DocReport(ProgressBar progressBarDL, string txtFile)
        {
            txtFile tf = new txtFile();
            //Вызов метода списка файлов - создание списка имём добавленных .txt файлов
            string[][] listOfNumbers = tf.NumbersFromTxt(txtFile);
            //Создаём приложение word
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            //Создаём объект нашего отчёта
            Document doc = app.Documents.Add(Visible: true);
            //Пустое поле Range для класса Table
            Range r = doc.Range();
            r.Text = "";
            //создаём талицу
            Table t = doc.Tables.Add(r, listOfNumbers[0].Length, listOfNumbers.Length);
            //Добавляем границы таблицы
            t.Borders.Enable = 1;

            foreach (Row row in t.Rows)
            {
                foreach (Cell cell in row.Cells)
                {
                    if (cell.RowIndex == 0)
                    {
                        cell.Range.Bold = 1;
                    }
                    else
                    {
                        cell.Range.Text = listOfNumbers[cell.ColumnIndex - 1][cell.RowIndex - 1];
                        //Долго создаёт отчёт, добавил ProgressBarDL
                        progressBarDL.Value = Convert.ToInt32(100 - (listOfNumbers[0].Length - cell.RowIndex) * 100 / listOfNumbers[0].Length);
                    }
                    //Значение ячейки по центру
                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                }
            }
            //Обнуляем ProgressBarDL
            progressBarDL.Value = 0;
            try
            {
                doc.Save();
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
