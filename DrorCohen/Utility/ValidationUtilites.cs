﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DrorCohen.Utility
{
    public static class ValidationUtilites
    {
        public static bool isHour(string s)
        {
            if (s.Length != 5)
                return false;
            if (s[2] != ':')
                return false;
            for(int i = 0; i < 5; i++)
            {
                if (i == 2)
                    continue;
                if (s[i] < '0' || s[i] > '9')
                    return false;
            }
            int x = int.Parse(s[0] + "" + s[1]);
            if (x < 0 || x > 23)
                return false;
            x = int.Parse(s[3] + "" + s[4]);
            if (x < 0 || x > 59)
                return false;
            return true;
        }
        public static bool isDay(string s)
        {
            return s.Equals("Sun") ||
                s.Equals("Mon") ||
                s.Equals("Tue") ||
                s.Equals("Wed") ||
                s.Equals("Thu") ||
                s.Equals("Fri") ||
                s.Equals("Sat");
        }
        public static bool isNumber(string s)
        {
            foreach (char c in s)
                if (c < '0' || c > '9')
                    return false;
            return true;
        }
        public static bool IsLegalHour(string hour)
        {
            if (hour.Length != 5)
                return false;
            if (hour[2] != ':')
                return false;
            int x;
            string s = hour[0] + "" + hour[1];
            x = int.Parse(s);
            if (x < 0 || x > 23)
                return false;
            s = hour[3] + "" + hour[4];
            x = int.Parse(s);
            if (x < 0 || x > 59)
                return false;
            return true;
        }
        public static bool LegalId(string s)
        {
            /*if (s.Length == 0)
                return false;*/
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                char c = s[i]; ;
                int k = ((i % 2) + 1) * (c - '0');
                if (k > 9)
                    k -= 9;
                sum += k;

            }
            return sum % 10 == 0;
        }

        public static bool CheckIdNumber(String s)
        {
            return s.Length == 9;
        }

        public static bool PhoneNumber(string num)
        {
            string pattern = @"\b0[2-4 7-9]-[2-9]\d{6}";
            Regex r = new Regex(pattern);
            return r.IsMatch(num);
        }
        public static bool LegalName(string name)
        {
            string pattern = @"\b[א-ת- ]+";
            Regex r = new Regex(pattern);
            return r.IsMatch(name);
        }
        public static int GetAge(DateTime d)
        {
            DateTime t = DateTime.Today;
            int age = t.Year - d.Year;
            if (t < d.AddYears(age)) age--;
            return age;
        }

        public static bool GreaterThanZero(int num)
        {
            return num > 0;
        }

        public static bool IsHebrewLetter(char c)
        {
            string otiyot = "'אבגדהוזחטיכלמנסעפצקרשתךםןףץ";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsEnglishLetter(char c)
        {
            string otiyot = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'";
            if (otiyot.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsDigits(char c)
        {
            string digits = "0123456789";
            if (digits.IndexOf(c) == -1)
                return false;
            return true;
        }

        public static bool IsLegalItemName(string word)
        {
            foreach (char c in word)
                if (IsDigits(c) == false && IsHebrewLetter(c) == false && c != '-' && c != ' ' && IsEnglishLetter(c) == false)
                    return false;
            return true;
        }

        public static bool IsLegalName(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && (c != '-'||c!= ' '))
                    return false;
            return true;
        }
        public static bool IsLegalAddress(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && !(c<='9'&&c>='0') && (c != '-' && c != ' '))
                    return false;
            return true;
        }

        public static bool IsLegalCity(string word)
        {
            foreach (char c in word)
                if (IsHebrewLetter(c) == false && IsEnglishLetter(c) == false && c != '-' && c != ' ')
                    return false;
            return true;
        }

        public static bool IsLegalId(string id)
        {
            string word = id;
            if (word.Length != 9)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalDigit(string dig)
        {
            string digit = dig;
            foreach (char c in digit)
                if (digit.IndexOf(c) == -1)
                    return false;
            return true;
        }
        public static bool IsLegalZipcode(string zip)
        {
            string zipcode = zip;
            if (zipcode.Length != 5)
                return false;
            foreach (char c in zipcode)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalCNumberVisa(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 16)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalCNumberAmericanexpress(string cnum)
        {
            string creditnumber = cnum;
            if (creditnumber.Length != 15)
                return false;
            foreach (char c in creditnumber)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalThreeDig(string tdig)
        {
            string threedig = tdig;
            if (threedig.Length != 3)
                return false;
            foreach (char c in threedig)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }
        public static bool IsLegalItemId(string id)
        {
            string word = id;
            if (word.Length != 5)
                return false;
            foreach (char c in word)
                if (IsDigits(c) == false)
                    return false;
            return true;
        }

        public static bool IsLegalSex(string sex)
        {
            return(sex=="Male"||sex=="Female");
        }
        public static bool IsLegalJob(string job)
        {
            return (job == "Doctor" || job == "Nurse" || job == "Other");
        }

        internal static bool IsPhoneNumber(string text)
        {
            if (text.Length != 10)
                return false;
            foreach (char c in text)
                if (!(c >= '0' && c <= '9'))
                    return false;
            return true;
        }
    }
}
