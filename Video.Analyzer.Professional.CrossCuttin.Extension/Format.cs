using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Video.Analyzer.Professional.CrossCuttin.Extension
{
    public static class Format
    {
        public static string ClearCharactersCep(string field)
        {
            return field.Replace("-", "").Replace(".", "").Replace(" ", "");
        }

        public static string ClearCharactersCnpj(string field)
        {
            return field.Replace("-", "").Replace(".", "").Replace("/", "");
        }

        public static string ClearCharactersCpf(string field)
        {
            return field.Replace("-", "").Replace(".", "");
        }

        public static string ClearCharactersTelefone(string field)
        {
            return field.Replace("-", "").Replace(".", "").Replace("(", "").Replace(")", "").Replace(" ", "");
        }

        public static string FormatCep(string cep)
        {
            return Formata(cep, "######.###");
        }

        public static string FormatCnpj(string cnpj)
        {
            return Formata(cnpj, "##.###.###/####-##");
        }

        public static string FormatCpf(string cpf)
        {
            return Formata(cpf, "###.###.###-##");
        }

        public static string FormatDate(DateTime date)
        {
            return date == DateTime.MinValue ? string.Empty : date.ToString("dd/MM/yyyy");
        }

        public static string FormatDate(DateTime? date)
        {
            return date == null ? string.Empty : (date == DateTime.MinValue ? string.Empty : ((DateTime)date).ToString("dd/MM/yyyy"));
        }

        public static string FormatDateTime(DateTime date)
        {
            return date == DateTime.MinValue ? string.Empty : date.ToString("dd/MM/yyyy HH:mm");
        }

        public static string FormatDateTime(DateTime? date)
        {
            return date == null ? string.Empty : (date == DateTime.MinValue ? string.Empty : ((DateTime)date).ToString("dd/MM/yyyy HH:mm"));
        }

        public static string FormatGender(string gender)
        {
            return gender == "M" ? "Masculino" : "Feminino";
        }

        public static string FormatValue(decimal value)
        {
            return $"{value:N}";
        }

        public static string HourFormat(DateTime date)
        {
            return date.ToString("HH:mm");
        }

        public static string HourFormat(DateTime? date)
        {
            return date?.ToString("HH:mm");
        }

        private static string Formata(string value, string mask)
        {
            var dado = new StringBuilder();
            // remove caracteres nao numericos
            foreach (var c in value)
            {
                if (char.IsNumber(c))
                    dado.Append(c);
            }

            var indMascara = mask.Length;
            var indfield = dado.Length;

            for (; indfield > 0 && indMascara > 0;)
            {
                if (mask[--indMascara] == '#')
                    indfield--;
            }

            var saida = new StringBuilder();
            for (; indMascara < mask.Length; indMascara++)
                saida.Append((mask[indMascara] == '#') ? dado[indfield++] : mask[indMascara]);

            return saida.ToString();
        }

        //validate integer
        private static bool IntegerValidator(this string input)
        {
            const string pattern = "[^0-9]";
            return Regex.IsMatch(input, pattern);
        }

        private static bool StringValidator(this string input)
        {
            var pattern = "[^a-zA-Z]";
            return Regex.IsMatch(input, pattern);
        }
    }
}