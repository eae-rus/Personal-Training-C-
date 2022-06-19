using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime;

namespace Spektr_Analis_sravn_medods
{
    // Этот класс содержит код Excel Interop нам нужно.
    // Его основное целью является упрощение работы с Excel, чтобы не заморачиваться во внешнем коде,
    // а только вызывать нужные операции, которые всё сами сделают. Я прекрасно понимаю, что это может замедлить программу.
    class ExcelReaderInterop
    {
        // Сохранение объект Application, чтобы можно было использовать в дальнейших функциях/методах.
        Application _excelApp;
        // Инициализируется новый читатель Excel. И интегрируется с объектом интерфейса Excel.
        public ExcelReaderInterop()
        {
            _excelApp = new Application();
        }

        // Метод, который открывает книги Excel и считывает данные из них в двумерный массив из "объектов"
        // Работает без нареканий
        public object[,] ExcelReadTableOneShets(string thisFileName, int numSheet)
        {
            try
            {
                // открытие
                //
                // Этот беспорядок кода открывает книгу Excel. Я не знаю, что все
                // эти аргументы делают, но они могут быть изменены, чтобы влиять на поведение.
                Workbook workBook = _excelApp.Workbooks.Open(thisFileName,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);

                // обращение к внутреннему методу чтения
                object[,] valueTable = ExcelScanIntenalOneShet(workBook, numSheet);
                // закрытие книги
                _excelApp.Quit();
                // возврат полученных значений, используется доп. переменная, чтобы можно было закрыть книгу
                return valueTable;
            }
            catch
            {
                //
                // Обработка исключений.
                // В случае ошибки возвращает "null"
                //
                return null;
            }
        }



        // Метод, который открывает пользователю  книгу Excel по указанному адресу, чтобы он мог заносить туда данные
        // Работает без нареканий
        public void ExcelOpenVisable(string thisFileName)
        {
            try
            {
                // открытие
                //
                // Этот беспорядок кода открывает книгу Excel. Я не знаю, что все
                // эти аргументы делают, но они могут быть изменены, чтобы влиять на поведение.
                Workbook workBook = _excelApp.Workbooks.Open(thisFileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
                // Собственно делаем видимым
                _excelApp.Visible = true;
            }
            catch
            {
                //
                // Обработка исключений.
                //
            }

        }


        // Метод, который читает лист1 (ОДИН ЛИСТ), внутренний метод
        // Сканирование выбранной книги Excel и сохранение информацию об ячейках этой книги в качестве объекта [,] массив. 
        // Работает без нареканий
        private object[,] ExcelScanIntenalOneShet(Workbook workBookIn, int numSheet)
        {
            // Листы индексируются начиная с 1.
            Worksheet sheet = (Worksheet)workBookIn.Sheets[numSheet];
            // получение значений
            Range excelRange = sheet.UsedRange;
            // Не могу прокомментировать именно это решение, так как не особо в нём разбираюсь, могу лишь сказать,
            // что оно работает и работает достаточно быстро по сравнению с другими, поэтому и был оставлен именно он.
            object[,] valueArray = (object[,])excelRange.get_Value(
                XlRangeValueDataType.xlRangeValueDefault);
            
            return valueArray;
        }


        // Метод, который записывает книги Excel # 
        // Работает!
        private Sheets sheets;
        private Worksheet worksheet;
        private Range cells;
        public void ExcelWriterTableOneShets(string thisFileName, int numSheet, string cels0, Double [,] mas) // для mas (Строка,Столбец)
        {
            try
            {
                // Этот беспорядок кода открывает книгу Excel. Я не знаю, что все
                // эти аргументы делать, но они могут быть изменены, чтобы влиять на поведение.

                _excelApp = new Application();
                Workbook workbook = _excelApp.Workbooks.Open(thisFileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

                sheets = workbook.Worksheets;
                //Получаем ссылку на лист "numSheet"
                worksheet = (Worksheet)sheets.get_Item(numSheet);

                // Еще один способ определения выбранных ячеек - использование метода get_Offset(x,y) объекта Range, 
                // возвращающего объект Range, отстоящий от заданной ячейки на заданное количество строк и столбцов, 
                // считая от левого верхнего угла. Это позволяет работать с ячейками, позиция которых заданы относительно 
                // выбранной ячейки или группы ячеек.

                cells = worksheet.get_Range(cels0, cels0);
                int a = mas.GetLength(0); // количество строк
                int b = mas.GetLength(1); // количество столбцов

                for (int i = 0; i < a; i++) 
                {
                    cells = cells.get_Offset(i, 0); //смещение относительно базовой на iстрок
                    for (int j = 0; j < b; j++) 
                    {
                        cells.Value2 = mas[i, j];
                        cells = cells.get_Offset(0, 1); //смещение относительно заданой выше на j столбцов
                    }
                    cells = worksheet.get_Range(cels0, cels0);
                }

                // сохранение книги
                workbook.Save();
                _excelApp.Quit();

            }
            catch
            {
                //
                // Обработка исключений.
                //
            }
        }

        // Метод, который записывает книги Excel (перегруженный вывод, тут всего одно число входное) 
        // Работает!
        public void ExcelWriterTableOneShets(string thisFileName, int numSheet, string cels0, Double mas) // для mas (Строка,Столбец)
        {
            try
            {
                // Этот беспорядок кода открывает книгу Excel. Я не знаю, что все
                // эти аргументы делать, но они могут быть изменены, чтобы влиять на поведение.

                _excelApp = new Application();
                Workbook workbook = _excelApp.Workbooks.Open(thisFileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);

                sheets = workbook.Worksheets;
                //Получаем ссылку на лист "numSheet"
                worksheet = (Worksheet)sheets.get_Item(numSheet);

                // Еще один способ определения выбранных ячеек - использование метода get_Offset(x,y) объекта Range, 
                // возвращающего объект Range, отстоящий от заданной ячейки на заданное количество строк и столбцов, 
                // считая от левого верхнего угла. Это позволяет работать с ячейками, позиция которых заданы относительно 
                // выбранной ячейки или группы ячеек.

                cells = worksheet.get_Range(cels0, cels0);
                cells.Value2 = mas;
                
                // сохранение книги
                workbook.Save();
                _excelApp.Quit();

            }
            catch
            {
                //
                // Обработка исключений.
                //
            }
        }


    }
}
