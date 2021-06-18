using System;

namespace ConsoleApp.Object
{
    public class Person
    {
        #region Atributes

        public const int TOT_PROPERTIES = 5;
        public const int TOT_DIGITS_CPF = 11;
        public const int TOT_DIGITS_RG = 10; // Padrão do Rio Grande do Sul.

        public long Cpf { get; private set; }
        public long Rg { get; private set; }
        public string Name { get; private set; }
        public DateTime DateBirthday { get; private set; }
        public string CityBirth { get; private set; }

        #endregion

        /// <summary>
        /// Construtor padrão da classe.
        /// </summary>
        public Person() { }

        /// <summary>
        /// Construtor da classe recebendo valores das propriedades do objeto no formato de string.
        /// </summary>
        /// <param name="cpf">CPF da pessoa</param>
        /// <param name="rg">RG da pessoa</param>
        /// <param name="name">Nome da pessoa</param>
        /// <param name="dateBirthday">Data de nascimento da pessoa</param>
        /// <param name="cityBirth">Cidade de nascimento da pessoa</param>
        public Person(string cpf, string rg, string name, string dateBirthday, string cityBirth)
        {
            this.Cpf = FormatCpfToLong(cpf);
            this.Rg = FormatRgToLong(rg);
            this.Name = name;
            this.DateBirthday = FormatStringToDateTime(dateBirthday);
            this.CityBirth = cityBirth;
        }

        /// <summary>
        /// Construtor da classe recebendo os valores das propriedades do objeto.
        /// </summary>
        /// <param name="cpf">CPF da pessoa</param>
        /// <param name="rg">RG da pessoa</param>
        /// <param name="name">Nome da pessoa</param>
        /// <param name="dateBirthday">Data de nascimento da pessoa</param>
        /// <param name="cityBirth">Cidade de nascimento da pessoa</param>
        public Person(long cpf, long rg, string name, DateTime dateBirthday, string cityBirth)
        {
            this.Cpf = cpf;
            this.Rg = rg;
            this.Name = name;
            this.DateBirthday = dateBirthday;
            this.CityBirth = cityBirth;
        }

        #region Métodos de encapsulamento (setters)

        /// <summary>
        /// Alterar o CPF da pessoa.
        /// </summary>
        /// <param name="cpf">CPF da pessoa</param>
        public void SetCpf(long cpf)
        {
            this.Cpf = cpf;
        }

        /// <summary>
        /// Alterar o Registro Geral da pessoa.
        /// </summary>
        /// <param name="rg">RG da pessoa</param>
        public void SetRg(long rg)
        {
            this.Rg = rg;
        }

        /// <summary>
        /// Alterar o nome da pessoa.
        /// </summary>
        /// <param name="name">Nome da pessoa</param>
        public void SetName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Alterar a data de nascimento da pessoa.
        /// </summary>
        /// <param name="dateBirthday">Data de nascimento da pessoa</param>
        public void SetDateBirthday(DateTime dateBirthday)
        {
            this.DateBirthday = dateBirthday;
        }

        /// <summary>
        /// Alterar a cidade de nascimento da pessoa.
        /// </summary>
        /// <param name="cityBirth">Cidade de nascimento da pessoa</param>
        public void SetCityBirth(string cityBirth)
        {
            this.CityBirth = cityBirth;
        }

        #endregion

        #region Métodos auxiliares de formatação

        /// <summary>
        /// Formatar o CPF do tipo string para o tipo long.
        /// </summary>
        /// <param name="cpf">CPF no tipo string</param>
        /// <returns>CPF no tipo long</returns>
        public static long FormatCpfToLong(string cpf)
        {
            try
            {
                if(cpf.Trim().Length != TOT_DIGITS_CPF)
                {
                    throw new FormatException();
                }

                return Convert.ToInt64(cpf);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        /// <summary>
        /// Formatar o CPF do tipo long para o tipo string.
        /// </summary>
        /// <param name="cpf">CPF no tipo long</param>
        /// <returns>CPF no tipo string</returns>
        public static string FormatCpfToString(long cpf)
        {
            string cpfFormatado = cpf.ToString();
            int qtdZerosFaltantes = TOT_DIGITS_CPF - cpfFormatado.Length;
            while(qtdZerosFaltantes > 0)
            {
                cpfFormatado = "0" + cpfFormatado;
                qtdZerosFaltantes--;
            }

            return cpfFormatado;
        }

        /// <summary>
        /// Formatar o RG do tipo string para o tipo long.
        /// </summary>
        /// <param name="rg">RG no tipo string</param>
        /// <returns>RG no tipo long</returns>
        public static long FormatRgToLong(string rg)
        {
            try
            {
                if(rg.Trim().Length != TOT_DIGITS_RG)
                {
                    throw new FormatException();
                }

                return Convert.ToInt64(rg);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        /// <summary>
        /// Formatar o RG do tipo inteiro para o tipo string.
        /// </summary>
        /// <param name="rg">RG no tipo long</param>
        /// <returns>RG no tipo string</returns>
        public static string FormatRgToString(long rg)
        {
            string rgFormatado = rg.ToString();
            int qtdZerosFaltantes = TOT_DIGITS_RG - rgFormatado.Length;
            while (qtdZerosFaltantes > 0)
            {
                rgFormatado = "0" + rgFormatado;
                qtdZerosFaltantes--;
            }

            return rgFormatado;
        }

        /// <summary>
        /// Formatar data do formato string para DateTime.
        /// </summary>
        /// <param name="data">Data no formato string</param>
        /// <returns>Data no formato DateTime</returns>
        public static DateTime FormatStringToDateTime(string data)
        {
            try
            {
                string[] dataSeparada = data.Split('/');
                return  new DateTime(Convert.ToInt32(dataSeparada[2].Trim()),
                    Convert.ToInt32(dataSeparada[1].Trim()),
                    Convert.ToInt32(dataSeparada[0].Trim()));
            }
            catch(Exception)
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Formatar data do formata DateTime para string.
        /// </summary>
        /// <param name="data">Data no formato DateTime</param>
        /// <returns>Data no formato string</returns>
        public static string FormatDateTimeToString(DateTime data)
        {
           return ($"{data.Day}/{data.Month}/{data.Year}");
        }

        #endregion

        /// <summary>
        /// Imprimir os dados da pessoa.
        /// </summary>
        /// <returns>string formatada com os dados da pessoa</returns>
        public override string ToString()
        {
            return ($"NOME: {this.Name}.\r\n" +
                $"DATA DE NASCIMENTO: {FormatDateTimeToString(this.DateBirthday)}.\r\n" +
                $"CPF: {FormatCpfToString(this.Cpf)}.\r\n" +
                $"RG: {FormatRgToString(this.Rg)}.\r\n" +
                $"CIDADE DE NASCIMENTO: {this.CityBirth}.\r\n");
        }
    }
}