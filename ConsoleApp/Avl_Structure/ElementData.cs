using System;
using ConsoleApp.Object;

namespace ConsoleApp.Structure
{
    public class ElementData<T> : IComparable<T>
    {
        #region Atributes

        public T Value { get; set; }

        /// <summary>
        /// Utilizado apenas para armazenar a data máxima para a consulta de data.
        /// </summary>
        public T ExtraValue { get; set; }

        public Person PersonReference { get; set; }

        #endregion

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="value">Valor do elemento</param>
        /// <param name="personReference">Referência do objeto de pessoa referenciada</param>
        public ElementData(T value, Person personReference = null)
        {
            this.Value = value;
            this.PersonReference = personReference;
        }

        public ElementData(T value, T extraValue)
        {
            this.Value = value;
            this.ExtraValue = extraValue;
        }

        /// <summary>
        /// Imprimir o dado valor do elemento.
        /// </summary>
        /// <returns></returns>
        public string PrintElementDataValue()
        {
            return $"Value: {this.Value}.\n";
        }

        /// <summary>
        /// Método para formatar o valor do ElementData.
        /// </summary>
        /// <returns>Retorna o valor atual formatado para o tipo correto de visualização.</returns>
        public string ValueFormated()
        {
            if(this.Value is System.String) // Nome
            {
                return this.Value.ToString();
            }
            else if(this.Value is System.DateTime) // DateBirth
            {
                return Person.FormatDateTimeToString(Convert.ToDateTime(this.Value));
            }
            else // CPF
            {
                return Person.FormatCpfToString(Convert.ToInt64(this.Value));
            }
        }        

        /// <summary>
        /// Método para realizar comparações dos objetos desta classe genérica.
        /// </summary>
        /// <param name="other">Parâmetro a ser comparado com o atual</param>
        /// <returns>Retorna 0 se ambos valores são iguals.<br/>
        /// Retorna < 0 se o valor atual precedo o informado por parâmetro.<br/>
        /// Retorna > 0 se o valor atual procede o informado por parametro.</returns>
        public int CompareTo(T other)
        {
            if(other == null)
            {
                return -1;
            }

            if(this.Value is System.String)
            {
                return this.Value.ToString().ToUpper().CompareTo(other.ToString().ToUpper());
            }
            else if(this.Value is System.DateTime)
            {
                return Convert.ToDateTime(this.Value).CompareTo(Convert.ToDateTime(other));
            }
            else // System.Int64 (long)
            {
                return Convert.ToInt64(this.Value).CompareTo(Convert.ToInt64(other));
            }
        }

        /// <summary>
        /// Método ToString para imprimir as informações do ElementData.
        /// </summary>
        /// <returns>Informações no formato string</returns>
        public override string ToString()
        {
            return $"Value: {this.Value}.\n" +
                $"IndexObjectInList:\n\t[{this.PersonReference.ToString()}\n\t]\n";
        }
    }
}