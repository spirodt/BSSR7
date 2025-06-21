using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BssBase.Functions.Helpers
{
    public static class FiskalnaExtensions
    {
        public static string SrediTekstZaFiskalna(this string text)
        {
            string retval = "";
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'А':
                        retval += 'A';
                        break;

                    case 'Б':
                        retval += 'B';
                        break;

                    case 'В':
                        retval += 'V';
                        break;

                    case 'Г':
                        retval += 'G';
                        break;

                    case 'Д':
                        retval += 'D';
                        break;

                    case 'Ѓ':
                        retval += 'G';
                        break;

                    case 'Е':
                        retval += 'E';
                        break;

                    case 'Ж':
                        retval += 'Z';
                        break;

                    case 'З':
                        retval += 'Z';
                        break;

                    case 'Ѕ':
                        retval += 'Y';
                        break;

                    case 'И':
                        retval += 'I';
                        break;

                    case 'Ј':
                        retval += 'J';
                        break;

                    case 'К':
                        retval += 'K';
                        break;

                    case 'Л':
                        retval += 'L';
                        break;

                    case 'Љ':
                        retval += 'Q';
                        break;

                    case 'М':
                        retval += 'M';
                        break;

                    case 'Н':
                        retval += 'N';
                        break;

                    case 'Њ':
                        retval += 'W';
                        break;

                    case 'О':
                        retval += 'O';
                        break;

                    case 'П':
                        retval += 'P';
                        break;

                    case 'Р':
                        retval += 'R';
                        break;

                    case 'С':
                        retval += 'S';
                        break;

                    case 'Т':
                        retval += 'T';
                        break;

                    case 'Ќ':
                        retval += 'K';
                        break;

                    case 'У':
                        retval += 'U';
                        break;

                    case 'Ф':
                        retval += 'F';
                        break;

                    case 'Х':
                        retval += 'H';
                        break;

                    case 'Ц':
                        retval += 'C';
                        break;

                    case 'Ч':
                        retval += 'C';
                        break;

                    case 'Џ':
                        retval += 'X';
                        break;

                    case 'Ш':
                        retval += 'S';
                        break;

                    case 'а':
                        retval += 'a';
                        break;

                    case 'б':
                        retval += 'b';
                        break;

                    case 'в':
                        retval += 'v';
                        break;

                    case 'г':
                        retval += 'g';
                        break;

                    case 'д':
                        retval += 'd';
                        break;

                    case 'ѓ':
                        retval += 'g';
                        break;

                    case 'е':
                        retval += 'e';
                        break;

                    case 'ж':
                        retval += 'z';
                        break;

                    case 'з':
                        retval += 'z';
                        break;

                    case 'ѕ':
                        retval += 'y';
                        break;

                    case 'и':
                        retval += 'i';
                        break;

                    case 'ј':
                        retval += 'j';
                        break;

                    case 'к':
                        retval += 'k';
                        break;

                    case 'л':
                        retval += 'l';
                        break;

                    case 'љ':
                        retval += 'q';
                        break;

                    case 'м':
                        retval += 'm';
                        break;

                    case 'н':
                        retval += 'n';
                        break;

                    case 'њ':
                        retval += 'w';
                        break;

                    case 'о':
                        retval += 'o';
                        break;

                    case 'п':
                        retval += 'p';
                        break;

                    case 'р':
                        retval += 'r';
                        break;

                    case 'с':
                        retval += 's';
                        break;

                    case 'т':
                        retval += 't';
                        break;

                    case 'ќ':
                        retval += 'c';
                        break;

                    case 'у':
                        retval += 'u';
                        break;

                    case 'ф':
                        retval += 'f';
                        break;

                    case 'х':
                        retval += 'h';
                        break;

                    case 'ц':
                        retval += 'c';
                        break;

                    case 'ч':
                        retval += 'c';
                        break;

                    case 'џ':
                        retval += 'x';
                        break;

                    case 'ш':
                        retval += 's';
                        break;

                    default:
                        retval += text[i];
                        break;
                }
            }
            return retval;
        }

        public static string ConvertDateTimeToSynergyDate(DateTime value, bool dash = true)
        {
            string DD = value.Day.ToString("D2"), MM = value.Month.ToString("D2"), YY = (value.Year - 2000).ToString("D2");
            return DD + ((dash == true) ? "-" : "") + MM + ((dash == true) ? "-" : "") + YY;
        }
    }
}
