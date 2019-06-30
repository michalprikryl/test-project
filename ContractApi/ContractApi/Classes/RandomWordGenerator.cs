using System;

namespace ContractApi.Classes
{
    public static class RandomWordGenerator
    {
        private static readonly string _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static string GetRandomWord(int wordLength)
        {
            Random random = new Random();
            char[] word = new char[wordLength];
            for (int i = 0; i < wordLength; i++)
            {
                word[i] = _characters[random.Next(0, _characters.Length)];
            }

            return new string(word);
        }
    }
}
