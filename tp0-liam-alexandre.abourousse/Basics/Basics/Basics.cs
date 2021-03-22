using System;

namespace Basics
{
    public class Basics
    {
        public static void HappyBirthday()
        {
            Console.Out.WriteLine("Happy birthday Harry!");
        }

        public static void HappyBirthdayAdvanced(string name)
        {
            Console.Out.WriteLine("Happy birthday " + name + "!");
        }

        public static uint SentLetters(uint owls)
        {
            if (owls == 0)
                return 0;
            return owls + SentLetters(owls - 1);
        }

        public static string SortingHat(uint n)
        {
            switch (n % 4)
            {
                case 0:
                    return "Gryffindor";
                case 1:
                    return "Hufflepuff";
                case 2:
                    return "Ravenclaw";
                default:
                    return "Slytherin";
            }
        }

        public static void QuidditchWinner(string house1, uint score1, string house2, uint score2)
        {
            if (score1 > score2)
                Console.Out.WriteLine(house1 + " wins by " + (score1 - score2) + " points!");
            else if (score1 < score2)
                Console.Out.WriteLine(house2 + " wins by " + (score2 - score1) + " points!");
            else
                Console.Out.WriteLine("It's a tie!");
        }

        public static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        public static bool IsAlpha(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        public static char ToUpper(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return (char)('A' + c - 'a');
            }

            return c;
        }

        static bool IsLower(char c)
        {
            return c >= 'a' && c <= 'z';
        }

        static bool IsUpper(char c)
        {
            return c >= 'A' && c <= 'Z';
        }

        public static char RotAlphaRight(char c, uint rot)
        {
            rot = rot % 26;

            if (IsLower(c))
            {
                if (c + rot > 'z')
                    return (char)('a' + rot - ('z' - c) - 1);
                return (char)(c + rot);
            }
            if (IsUpper(c))
            {
                if (c + rot > 'Z')
                    return (char)('A' + rot - ('Z' - c) - 1);
                return (char)(c + rot);
            }
            
            return c;
        }
    }
}