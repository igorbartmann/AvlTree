using System;
using ConsoleApp.Structure.Interfaces;

namespace ConsoleApp.Structure
{
    public class Node<T> : INode<T>
    {
        #region Atributes
        public const int INIT_HEIGHT = 1;
        public ElementData<T> Element { get; private set; }
        public int Height { get; private set; }
        public Node<T> LeftNode { get; private set; }
        public Node<T> RightNode { get; private set; }
        #endregion

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        /// <param name="element">Valor do nodo</param>
        public Node(ElementData<T> element)
        {
            this.Element = element;
            this.Height = INIT_HEIGHT;
        }

        #region Métodos de encapsulamento (setters)

        /// <summary>
        /// Método para alterar o valor do elemento do nodo.
        /// </summary>
        /// <param name="element">Novo elemento do nodo</param>
        public void SetElement(ElementData<T> element)
        {
            this.Element = element;
        }

        /// <summary>
        /// Método para alterar a altura do nodo.
        /// </summary>
        /// <param name="height">Nova altura do nodo</param>
        public void SetHeight(int height)
        {
            this.Height = height;
        }

        /// <summary>
        /// Método para alterar a subárvore esquerda do nodo.
        /// </summary>
        /// <param name="leftNode">Referência da nova subárvore esquerda do nodo</param>
        public void SetLeftNode(Node<T> leftNode)
        {
            this.LeftNode = leftNode;
        }

        /// <summary>
        /// Método para alterar a subárvore direitda do nodo.
        /// </summary>
        /// <param name="rightNode">Referência da nova subárvore direita do nodo</param>
        public void SetRightNode(Node<T> rightNode)
        {
            this.RightNode = rightNode;
        }

        #endregion

        #region Métodos para cálculos do nodo

        /// <summary>
        /// Calcular o fator de balanceamento do nodo.
        /// </summary>
        /// <returns>Valor do balanceamento do nodo</returns>
        public int NodeBalance()
        {
            if (this == null)
            {
                return 0;
            }

            return (this.LeftNode?.Height ?? 0) - (this.RightNode?.Height ?? 0);
        }

        /// <summary>
        /// Calcular o fator do balanceamento e atualizar a altura do nodo.
        /// </summary>
        /// <returns>Nodo com a altura atualizada e o valor do seu fator de balanceamento</returns>
        public (Node<T>, int) NodeBalanceAndUpdateHeight()
        {
            if (this == null)
            {
                return (null, 0);
            }

            int balanceValue = this.NodeBalance();
            this.SetHeight(this.GetHeightOfLargestSubtree());
            return (this, balanceValue);
        }

        /// <summary>
        /// Obtém a altura da maior subárvore do nodo.
        /// </summary>
        /// <returns>Altura da maior subárvore do nodo</returns>
        public int GetHeightOfLargestSubtree()
        {
            return Math.Max(this.LeftNode?.Height ?? 0, this.RightNode?.Height ?? 0) + INIT_HEIGHT;
        }

        #endregion

        /// <summary>
        /// Método para imprimir o nodo de forma simples.
        /// </summary>
        public void PrintNode()
        {
            Console.WriteLine($"Elemento: [{this.Element}].\n" +
                $"Altura: {this.Height}.\n" +
                $"Nodo à esquerda: [{this.LeftNode?.Element.PrintElementDataValue() ?? "não possui subárvore à esquerda"}].\n" +
                $"Nodo à direita: [{this.RightNode?.Element.PrintElementDataValue() ?? "não possui subárvore à direita"}].\n");
        }
    }
}