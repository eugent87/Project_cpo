using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Interface.Main_page
{
    static class Validation_class
    {
        public static bool IsValidDate_match_with_mask(string input)
        { 
            string pattern = @"^\d{2}.\d{2}.\d{4}$";
            if (Regex.IsMatch(input, pattern))
            {
                DateTime tempDate;
                return DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out tempDate);
            }
            MessageBox.Show("Введите дату в формате dd.MM.yyyy", "Неверный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public static bool IsValidDate_match_good_date(string input)
        {
            // Проверяем, что длина входной строки правильная
            if (input.Length < 10)
            {
                MessageBox.Show("Неверный формат даты. Ожидается dd.MM.yyyy", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DateTime now = DateTime.Now;
            int currentYear = now.Year;
            int currentMonth = now.Month;
            int currentDay = now.Day;

            int Day = int.Parse(input.Substring(0, 2));
            int Month = int.Parse(input.Substring(3, 2));
            int Year = int.Parse(input.Substring(6, 4));

            // Проверка на допустимый год
            if (Year > currentYear || Year < 1920)
            {
                MessageBox.Show("Введите настоящий год", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка на допустимый месяц
            if (Month > 12 || Month < 1)
            {
                MessageBox.Show("Введите настоящий месяц", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка на допустимый день
            if (Day < 1 || Day > DateTime.DaysInMonth(Year, Month))
            {
                MessageBox.Show($"В этом месяце {DateTime.DaysInMonth(Year, Month)} дней.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка на будущее
            if ((Year == currentYear && Month > currentMonth) ||
                (Year == currentYear && Month == currentMonth && Day > currentDay))
            {
                MessageBox.Show("Вы в будущем:)", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
