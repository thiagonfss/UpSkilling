using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Extensions;

public static class StringExtension
{
    public static string ToTittleCase(this string text)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(text.Trim());
    }

    public static string ToCpfNormalized(this string text, bool pontuacao = true) 
    {
        text = text.Trim();
        string newText = String.Join("", text.Where(Char.IsDigit)).PadRight(11, '0');
        if (pontuacao)
            return newText.Insert(3, ".").Insert(7, ".").Insert(11, "-").Substring(0, 14); // xxx.xxx.xxx-xx;
        return newText.Substring(0, 11); // xxxxxxxxxxx
    }

    public static string ToNumberPhoneNormalized(this string text)
    {
        text = text.Trim();
        string newText = new string(text.Where(c => char.IsDigit(c)).ToArray()).PadRight(11, '0');
        text = $"{newText.Substring(0, 2)} {newText.Substring(2, 1)} {newText.Substring(3, 4)}-{newText.Substring(7)}";
        return text.Substring(0, 14); // xx x xxxx-xxxx
    }
}