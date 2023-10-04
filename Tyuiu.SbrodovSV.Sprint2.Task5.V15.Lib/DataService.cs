using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SbrodovSV.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int value)
        {
                switch (value % 7)
                {
                    case 1: return ("Понедельник");
                    case 2: return ("Вторник");
                    case 3: return ("Среда");
                    case 4: return ("Четверг");
                    case 5: return ("Пятница");
                    case 6: return ("Суббота");
                    case 0: return ("Воскресенье");
                    default: return ("Введено некорректное число (числа должны быть от 1 до 365)");
                }
        }
    }
}
