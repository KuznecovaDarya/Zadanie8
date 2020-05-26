using System;
using static System.Convert;
using static System.Console;
using studentlib;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введи сегодняшнюю дату: ");
            WriteLine("День: ");
            int day = ToInt32(ReadLine());
            WriteLine("Месяц: ");
            int month = ToInt32(ReadLine());
            WriteLine("Год: ");
            int year = ToInt32(ReadLine());

            Proect a = new Proect();
            int n = 1;
            while (n > 0)
            {
                WriteLine("1 - Показать Информацию о студентах.\n2 - Добавить студента.\n3 - Удалить студента.\n4 - Изменить студента.\n5 - Поиск студентов.\n6 - Выход.");
                n = ToInt32(ReadLine());
                if (n == 1)
                {
                    WriteLine("1 - Вся информация о студентах.\n2 - Список студентов с инициалами.\n3 - Список студентов старше 18.\n4 - Список студентов младше 18.");
                    int m = ToInt32(ReadLine());
                    if (m == 1)
                    {
                        a.show();
                    }
                    else if (m == 2)
                    {
                        a.inic();
                    }
                    else if (m == 3)
                    {
                        a.Vozvr(m, day, month, year);
                    }
                    else if (m == 4)
                    {
                        a.Vozvr(m, day, month, year);
                    }
                    WriteLine("Введи следующее действие: ");
                }
                else if (n == 2)
                {
                    WriteLine("ID: "); string id = ReadLine();
                    WriteLine("ФИО: "); string fio = ReadLine();
                    WriteLine("Группа: "); string group = ReadLine();
                    WriteLine("Дата рождения: "); string data = ReadLine();

                    a.add(id, fio, group, data);
                    WriteLine("Введи следующее действие: ");
                }
                else if (n == 4)
                {
                    WriteLine("Введи ID и измененные данные: ");
                    WriteLine("ID: "); string id = ReadLine();
                    WriteLine("ФИО: "); string fio = ReadLine();
                    WriteLine("Группа: "); string group = ReadLine();
                    WriteLine("Дата: "); string data = ReadLine();
                    a.izmenie(id, fio, group, data);
                    WriteLine("Введи следующее действие: ");
                }
                else if (n == 3)
                {
                    WriteLine("Введи ID: ");
                    string id = ReadLine();
                    a.del(id);
                    WriteLine("Введи следующее действие: ");
                }
                else if (n == 5)
                {
                    WriteLine("1 - поиск по ID.\n2 - поиск по фамилии\n");
                    int m = ToInt32(ReadLine());
                    if (m == 1)
                    {
                        WriteLine("Введи ID: ");
                        string id = ReadLine();
                        a.viv(id);
                    }
                    else if (m == 2)
                    {
                        WriteLine("Введи фамилию: ");
                        string famil = ReadLine();
                        a.famp(famil);
                    }
                    WriteLine("Введи следующее действие: ");
                }
                else if (n == 6)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
