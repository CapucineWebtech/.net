using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    private static readonly Dictionary<char, int> RomanMap = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
        {'A', 5000},
        {'B', 10000},
        {'E', 50000},
        {'F', 100000},
        {'G', 500000},
        {'H', 1000000}
    };

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Entrez un chiffre romain (I, V, X, L, C, D, M, A, B, E, F, G, H):"); 
            Console.WriteLine("A = 5000\nB = 10000\nE = 50000\nF = 100000\nG = 500000\nH = 1000000\n");
            string input = Console.ReadLine().ToUpper();

            if (IsValidRomanNumeral(input))
            {
                int result = ConvertRomanToInteger(input);
                Console.WriteLine($"La valeur de {input} est {result}.");
            }
            else
            {
                Console.WriteLine("Entrez un chiffre romain valide.");
            }
        }
    }

    public static int RomanToInt(string s)
    {
        if (!IsValidRomanNumeral(s))
        {
            throw new ArgumentException("Invalid Roman numeral");
        }

        return ConvertRomanToInteger(s);
    }

    private static bool IsValidRomanNumeral(string s)
    {
        // Supprimer les espaces
        if (s.Contains(" "))
        {
            s = s.Replace(" ", "");
        }

        // Vérifier si la chaîne est vide
        if (string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Erreur : Chaîne vide.");
            return false;
        }

        // Vérifier si la chaîne contient des caractères non romains
        if (!Regex.IsMatch(s, "^[IVXLCDMAEBFGH]*$"))
        {
            Console.WriteLine("Erreur : Caractères non romains.");
            return false;
        }

        // Pas plus de trois répétitions I, X, C, M, B, F et H
        if (Regex.IsMatch(s, "I{4,}|X{4,}|C{4,}|M{4,}|B{4,}|F{4,}|H{4,}"))
        {
            Console.WriteLine("Erreur : Plus de trois répétitions de I, X, C, M, B, F ou H.");
            return false;
        }

        // Pas de répétitions pour V, L, D, A, E ou G
        if (Regex.IsMatch(s, "V{2,}|L{2,}|D{2,}|A{2,}|E{2,}|G{2,}"))
        {
            Console.WriteLine("Erreur : Répétitions de V, L, D, A, B, E, F, G ou H.");
            return false;
        }

        

        // Pas plus de 1 symbole si suivit par un symbloe de valeur supérieure
        if (Regex.IsMatch(s, "I(?=[VXLCDMABEFHG])|V(?=[XLCDMABEFHG])|X(?=[LCDMABEFHG])|L(?=[CDMABEFHG])|C(?=[DMABEFHG])|D(?=[MABEFHG])|M(?=[ABEFHG])|A(?=[BEFHG])|B(?=[EFHG])|E(?=[FHG])|F(?=[HG])|H(?=[G])"))
        {
            Console.WriteLine("Erreur : Soustractions incorrectes.");
            return false;
        }

        // Vérifier les soustractions incorrectes
        if (Regex.IsMatch(s, "IL|IC|ID|IM|VX|VL|VC|VD|VM|XD|XM|LC|LD|LM|DM|IVI|IXI|XLX|XCX|CDC|CMC|LXL|LCL|DLD|DCD|DMD"))
        {
            Console.WriteLine("Erreur : Soustractions incorrectes.");
            return false; 
        }

        return true;
    }

    private static int ConvertRomanToInteger(string s)
    {
        int result = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = RomanMap[s[i]];

            if (value < prevValue)
            {
                result -= value;
            }
            else
            {
                result += value;
            }

            prevValue = value;
        }

        return result;
    }
}
