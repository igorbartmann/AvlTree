using System;

namespace ConsoleApp.Structure.Interfaces
{
    public interface IAvlTree<T>
    {
        /// <summary>
        /// Alterar o valor da propriedade Root (raíz).
        /// </summary>
        /// <param name="root">Nova referência para o nodo raíz</param>
        void SetRoot(Node<T> root);

        /// <summary>
        /// Inserir elementos na árvore.
        /// </summary>
        /// <param name="element">Valor a ser inserido na árvore</param>
        void InsertNode(ElementData<T> element);

        /// <summary>
        /// Buscar um elemento na árvore através do seu valor.
        /// </summary>
        /// <param name="element">Valor a ser buscado na árvore</param>
        /// <returns>Nodo encontrado pela busca</returns>
        Node<T> FindNode(ElementData<T> element);

        /// <summary>
        /// Buscar todos os elementos da árvore que satisfazem a lógica da consulta.
        /// </summary>
        /// <param name="element">Valor a ser utilizado para a consulta.</param>
        /// <returns>Lista de nodos que satisfazem a lógica da consulta.<br/>
        /// Quanto o tipo do valor é (String) busca por todos os valores da árvore <br/>
        /// de nomes que contenham o valor armazenado no ElementData.<br/>
        /// Quando o tipo do valor é (DateTime) busca por todos os valors da árvore <br/>
        /// de datas que estejam entre as datas armazenas pelo ElementData.</returns>
        System.Collections.Generic.IList<Node<T>> FindNodes(ElementData<T> element);

        /// <summary>
        /// Deletar um elemento da árvore através do seu valor.
        /// </summary>
        /// <param name="element">Valor a ser deletado da árvore</param>
        void DeleteNode(ElementData<T> element);

        /// <summary>
        /// Imprimir a árvore percorrendo em pré-ordem.
        /// </summary>
        void PreOrdem();

        /// <summary>
        /// Imprimir a árvore percorrendo Em-Ordem.
        /// </summary>
        void EmOrdem();

        /// <summary>
        /// Imprimir a árvore percorrendo em Pós-Ordem.
        /// </summary>
        void PosOrdem();

        /// <summary>
        /// Método para imprimir a árvore.
        /// </summary>
        void PrintTree();

        /// <summary>
        /// Método para obter a impressão da árvore.
        /// </summary>
        string GetPrintTree();
    }
}