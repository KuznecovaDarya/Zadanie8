using System;
using static System.Convert;
using static System.Console;
using System.Collections.Generic;

namespace studentlib
{
    public class Proect
    {
        public class student
        {
            public string id;
            public string fio;
            public string group;
            public string data;
        }
        public List<student> list = new List<student>();
        public void add(string id, string fio, string group, string data)
        {
            list.Add(new student() { id = id, fio = fio, group = group, data = data });
        }
        public void del(string id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id) list.RemoveAt(i);
            }

        }
        public void izmenie(string id, string fio, string group, string data)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    list[i].fio = fio;
                    list[i].group = group;
                    list[i].data = data;
                }
            }
        }
        public void viv(string id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    Console.WriteLine(list[i].id + " " + list[i].fio + " " + list[i].group + " " + list[i].data);
                }
            }

        }
        public void years(string id, int day1, int month1, int year1)
        {
            int t1;
            int t2;
            int vozr;
            string day = "";
            string month = "";
            string year = "";
            string dat = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id == id)
                {
                    dat = list[i].data + "";
                }
            }
            t1 = dat.IndexOf(".");
            t2 = dat.LastIndexOf(".");
            for (int i = 0; i < t1; i++)
            {
                day = day + dat[i];
            }
            for (int i = t1 + 1; i < t2; i++)
            {
                month = month + dat[i];
            }
            for (int i = t2 + 1; i < dat.Length; i++)
            {
                year = year + dat[i];
            }
            Console.WriteLine("Дата рождения" + day + "." + month + "." + year);
            vozr = year1 - ToInt32(year);
            if (ToInt32(month) > month1) vozr = vozr - 1;
            else if (ToInt32(month) == month1)
                if (ToInt32(day) < day1) vozr = vozr - 1;
            Console.WriteLine("\nВозраст = " + vozr);
        }
        public void show()
        {
            foreach (var i in list)
            {
                Console.WriteLine(i.id + " " + i.fio + " " + i.group + " " + i.data);
            }

        }
        public void inic()
        {
            string prom = "";
            for (int i = 0; i < list.Count; i++)
            {
                string rez = "";
                prom = list[i].fio;
                string[] words = prom.Split(' ');
                rez = rez + words[0] + " " + words[1][0] + "." + words[2][0] + ".";
                Console.WriteLine(rez);
            }
        }
        public void famp(string fam)
        {
            string prom = "";
            for (int i = 0; i < list.Count; i++)
            {
                prom = list[i].fio;
                string[] words = prom.Split(' ');
                if (fam == words[0])
                {
                    Console.WriteLine(list[i].id + " " + list[i].fio + " " + list[i].group + " " + list[i].data);
                }
            }
        }
        public void Vozvr(int param, int day1, int month1, int year1)
        {
            for (int g = 0; g < list.Count; g++)
            {
                int t1;
                int t2;
                int vozr;
                string day = "";
                string month = "";
                string year = "";
                string dat;
                string id;

                id = list[g].id;
                dat = list[g].data + "";

                t1 = dat.IndexOf(".");
                t2 = dat.LastIndexOf(".");
                for (int i = 0; i < t1; i++)
                {
                    day = day + dat[i];
                }
                for (int i = t1 + 1; i < t2; i++)
                {
                    month = month + dat[i];
                }
                for (int i = t2 + 1; i < dat.Length; i++)
                {
                    year = year + dat[i];
                }
                vozr = year1 - ToInt32(year);
                if (ToInt32(month) > month1) vozr = vozr - 1;
                else if (ToInt32(month) == month1)
                    if (ToInt32(day) < day1) vozr = vozr - 1;
                if (param == 4) if (vozr < 18) Console.WriteLine(list[g].fio + " ");
                if (param == 3) if (vozr > 18) Console.WriteLine(list[g].fio + " ");
            }
        }
    }
}
