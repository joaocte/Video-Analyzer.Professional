using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Video.Analyzer.Professional.Domain.Exceptions;

namespace Video.Analyzer.Professional.CrossCuttin.Extension
{
    public static class Cripto
    {
        public static void AreEqual(string a, string b, string errorMessage)
        {
            if (a != b)
                throw new CustomException(errorMessage);
        }

        public static string ByteArrayToString(this byte[] inputArray)
        {
            var output = new StringBuilder("");

            for (var i = 1; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }

            return output.ToString();
        }

        public static string CreateSalt(this string salt, int size)
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return buff.ByteArrayToString();
        }

        public static void ForNegative(int number, string propName)
        {
            if (number < 0)
                throw new CustomException(propName + " não pode ser negativo!");
        }

        /// <summary>
        /// Este método verifica se uma string é vazio ou nullo
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void ForNullOrEmpty(string value, string errorMessage)
        {
            if (String.IsNullOrEmpty(value))
                throw new CustomException(errorMessage);
        }

        public static void ForNullOrEmptyDefaultMessage(string value, string propName)
        {
            if (String.IsNullOrEmpty(value))
                throw new CustomException(propName + " é obrigatório!");
        }

        public static void ForValidId(string propName, Guid id)
        {
            ForValidId(id, propName + " id inválido!");
        }

        public static void ForValidId(Guid id, string errorMessage)
        {
            if (id == Guid.Empty)
                throw new CustomException(errorMessage);
        }

        public static void ForValidId(string propName, int id)
        {
            ForValidId(id, propName + " id inválido!");
        }

        public static void ForValidId(int id, string errorMessage)
        {
            if (!(id > 0))
                throw new CustomException(errorMessage);
        }

        public static string GenerateSaltedHash(this string pwd, string salt)
        {
            HashAlgorithm algorithm = new SHA512CryptoServiceProvider();

            salt = salt.ToCharArray().Reverse().ToString();

            var saltBytes = Encoding.ASCII.GetBytes(salt);
            var senha = Encoding.ASCII.GetBytes(pwd);

            var plainTextWithSaltBytes = new byte[senha.Length + saltBytes.Length];

            for (var i = 0; i < senha.Length / 2; i++)
            {
                plainTextWithSaltBytes[i] = senha[i];
            }

            for (var i = senha.Length / 2; i <= saltBytes.Length + 1; i++)
            {
                plainTextWithSaltBytes[i] = saltBytes[i - 2];
            }

            for (var i = saltBytes.Length + senha.Length / 2; i < plainTextWithSaltBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = senha[i - saltBytes.Length];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes).ByteArrayToString();
        }

        public static void StringLength(string propName, string stringValue, int maximum)
        {
            StringLength(stringValue, maximum, propName + " não pode ter mais que " + maximum + " caracteres");
        }

        public static void StringLength(string stringValue, int maximum, string message)
        {
            var length = stringValue.Length;
            if (length > maximum)
            {
                throw new CustomException(message);
            }
        }

        public static void StringLength(string propName, string stringValue, int minimum, int maximum)
        {
            StringLength(stringValue, minimum, maximum, propName + " deve ter de " + minimum + " à " + maximum + " caracteres!");
        }

        public static void StringLength(string stringValue, int minimum, int maximum, string message)
        {
            if (String.IsNullOrEmpty(stringValue))
                stringValue = String.Empty;

            var length = stringValue.Length;
            if (length < minimum || length > maximum)
            {
                throw new CustomException(message);
            }
        }
    }
}