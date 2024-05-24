using System.Security.Cryptography;
namespace PasswordGen.Generator
{
    public class PasswordRandomizer
    {
        private int _passwordSize = 16;
        private int GenerateNewInstance()
        {
            int _randomInteger = RandomNumberGenerator.GetInt32('!', '~');
            return _randomInteger;
        }

        public string GeneratePassword()
        {
            char[] passwordChar = new char[_passwordSize];
            for (int i = 0; i < _passwordSize; i++)
            {
                passwordChar[i] = (char) GenerateNewInstance();
            }
            string password = new string(passwordChar);
            return password;
        }
                

            
            
           
    }
        


}
