using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Password_Generator
{
    public class RandomPasswordGeneratorService
    {
        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERS = "123456789";

        public string GeneratePassword(bool useLowerCase, bool useUpperCase, bool useNumbers, int passwordLength)
        {
            char[] password = new char[passwordLength];
            string charSet = "";
            Random random = new Random();

            if (useLowerCase) { charSet += LOWER_CASE; }
            if (useUpperCase) { charSet += UPPER_CAES; }
            if (useNumbers) { charSet += NUMBERS; }

            if (!useLowerCase && !useUpperCase && !useNumbers)
            {
                return "Cannot Generate Password";
            }

            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = charSet[random.Next(charSet.Length - 1)];
            }

            return String.Join(null, password);
        }        
    }
}
