using System;
using System.Collections.Generic;
using ConsoleApp.Structure.Interfaces;

namespace ConsoleApp.Structure
{
    public class AVLTree<T> : IAvlTree<T>
    {
        #region Atributes

        public Node<T> Root { get; private set; }

        #endregion

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public AVLTree() { }

        /// <summary>
        /// Construtor da classe, já adicionando um primeiro valor como raíz.
        /// </summary>
        /// <param name="element">Valor do primeiro elemento a ser inserido na árvore</param>
        public AVLTree(ElementData<T> element)
        {
            this.Root = new Node<T>(element);
        }

        #region Método de encapsulamento (setter)

        /// <summary>
        /// Alterar o valor da propriedade Root (raíz).
        /// </summary>
        /// <param name="root">Nova referência para o nodo raíz</param>
        public void SetRoot(Node<T> root)
        {
            this.Root = root;
        }

        #endregion

        #region Métodos para Inserir, Buscar e Remover elementos

        /// <summary>
        /// Inserir elementos na árvore.
        /// </summary>
        /// <param name="element">Valor a ser inserido na árvore</param>
        public void InsertNode(ElementData<T> element)
        {
            this.Root = InsertNode(this.Root, element);
        }

        /// <summary>
        /// Inserir elementos na árvore (recursivo).
        /// </summary>
        /// <param name="node">Nodo raíz da árvore</param>
        /// <param name="element">Valor a ser inserido na árvore</param>
        /// <returns>Nova raíz da árvore com o nodo inserido</returns>
        private Node<T> InsertNode(Node<T> node, ElementData<T> element)
        {
            if(node == null)
            {
                return new Node<T>(element);
            }
            if (element.CompareTo(node.Element.Value) < 0) //element < node.Element
            {
                node.SetLeftNode(InsertNode(node.LeftNode, element));
            }
            else if (element.CompareTo(node.Element.Value) > 0) //element > node.Element
            {
                node.SetRightNode(InsertNode(node.RightNode, element));
            }
            else
            {
                return node;
            }

            return TreeBalanceAfterInsert(node, element);
        }

        /// <summary>
        /// Buscar um elemento na árvore através do seu valor.
        /// </summary>
        /// <param name="element">Valor a ser buscado na árvore</param>
        /// <returns>Nodo encontrado pela busca</returns>
        public Node<T> FindNode(ElementData<T> element)
        {
            return FindNode(this.Root, element);
        }

        /// <summary>
        /// Buscar um elemento na árvore através do seu valor.
        /// </summary>
        /// <param name="node">Nodo atual analisado pela busca</param>
        /// <param name="element">Valor a ser buscado na árvore</param>
        /// <returns>Nodo encontrado pela busca</returns>
        private Node<T> FindNode(Node<T> node, ElementData<T> element)
        {
            if (node == null || element.CompareTo(node.Element.Value) == 0)
            {
                return node;
            }
            else if (element.CompareTo(node.Element.Value) < 0)
            {
                return FindNode(node.LeftNode, element);
            }
            return FindNode(node.RightNode, element);
        }

        /// <summary>
        /// Buscar todos os elementos da árvore que satisfazem a lógica da consulta.
        /// </summary>
        /// <param name="element">Valor a ser utilizado para a consulta.</param>
        /// <returns>Lista de nodos que satisfazem a lógica da consulta.<br/>
        /// Quanto o tipo do valor é (String) busca por todos os valores da árvore <br/>
        /// de nomes que contenham o valor armazenado no ElementData.<br/>
        /// Quando o tipo do valor é (DateTime) busca por todos os valors da árvore <br/>
        /// de datas que estejam entre as datas armazenas pelo ElementData.</returns>
        public IList<Node<T>> FindNodes(ElementData<T> element)
        {
            var nodeList = new List<Node<T>>();
            return FindNodes(this.Root, element, nodeList);
        }

        /// <summary>
        /// Buscar todos os elementos da árvore que satisfazem a lógica da consulta.
        /// </summary>
        /// <param name="node">Nodo a ser analisado pela consulta.</param>
        /// <param name="element">Valor a ser utilizado para a consulta.</param>
        /// <param name="nodeList">Lista que armazena os nodos encontrados pela consulta.</param>
        /// <returns>Lista de nodos que satisfazem a lógica da consulta.</returns>
        private IList<Node<T>> FindNodes(Node<T> node, ElementData<T> element, List<Node<T>> nodeList)
        {
            if(node != null)
            {
                FindNodes(node.LeftNode, element, nodeList);
                ValidateReturn(node, element, ref nodeList);
                FindNodes(node.RightNode, element, nodeList);
            }
            return nodeList;
        }

        /// <summary>
        /// Validar necessidade de adicionar o valor atual na lista de retono da consulta.
        /// </summary>
        /// <param name="node">Nodo atual cujo valor será analiso.</param>
        /// <param name="element">Valor, filtro, de pesquisa.</param>
        /// <param name="nodeList">Lista de nodos</param>
        /// <returns>Lista de Nodos com o valor adicionado, ou não, dependendo do seu valor<br/>
        /// se enquadrar no filtro da consulta.</returns>
        private void ValidateReturn(Node<T> node, ElementData<T> element, ref List<Node<T>> nodeList)
        {
            if(node == null || element == null)
            {
                return;
            }

            var nodeValue = node.Element.Value;

            if (nodeValue is System.String) // Name
            {
                var elementValueToUpper = element.Value.ToString().ToUpper();
                var nodeValueToUpper = nodeValue.ToString().ToUpper();
                if(nodeValueToUpper.Length >= elementValueToUpper.Length)
                {
                    var substringNodeValueToUpper = nodeValueToUpper.Substring(0, elementValueToUpper.Length);
                    if (substringNodeValueToUpper.Contains(elementValueToUpper))
                    {
                        nodeList.Add(node);
                    }
                }
            }
            else if (nodeValue is System.DateTime) // DateBirth
            {
                if (node.Element.CompareTo(element.Value) >= 0 && node.Element.CompareTo(element.ExtraValue) <= 0)
                {
                    nodeList.Add(node);
                }
            }
            else // System.Int64 (long)
            {
                if (node.Element.CompareTo(element.Value) == 0)
                {
                    nodeList.Add(node);
                }
            }
        }

        /// <summary>
        /// Deletar um valor da árvore através do seu valor.
        /// </summary>
        /// <param name="element">Valor a ser deletado da árvore</param>
        public void DeleteNode(ElementData<T> element)
        {
            this.Root = DeleteNode(this.Root, element);
        }

        /// <summary>
        /// Deletar um nodo da árvore através do seu valor.
        /// </summary>
        /// <param name="node">Nodo atual analisado pelo método</param>
        /// <param name="element">Valor a ser deletado da árvore</param>
        /// <returns>Nova raíz da árvore com o nodo deletado</returns>
        private Node<T> DeleteNode(Node<T> node, ElementData<T> element)
        {
            if (node == null)
            {
                return null;
            }
            if(element.CompareTo(node.Element.Value) < 0) //element < node.Element
            {
                node.SetLeftNode(DeleteNode(node.LeftNode, element));
            }
            else if(element.CompareTo(node.Element.Value) > 0) //element > node.Element
            {
                node.SetRightNode(DeleteNode(node.RightNode, element));
            }
            else
            {
                node = DeleteNodeAccordingChildren(node);
            }

            if(node == null)
            {
                return null;
            }

            return TreeBalanceAfterDelete(node);
        }

        #endregion

        #region Métodos para auxiliar e rotacionar a árvore

        /// <summary>
        /// Efetuar rotação para a esquerda.
        /// </summary>
        /// <param name="node">Nodo base para a rotação</param>
        /// <returns>Nodo com a rotação efetuada sobre ele</returns>
        private Node<T> LeftRotate(Node<T> node)
        {
            Node<T> T1 = node.RightNode;
            Node<T> T2 = T1.LeftNode;
            T1.SetLeftNode(node);
            node.SetRightNode(T2);
            node.SetHeight(node.GetHeightOfLargestSubtree());
            T1.SetHeight(T1.GetHeightOfLargestSubtree());
            return T1;
        }

        /// <summary>
        /// Efetuar rotação para a direita.
        /// </summary>
        /// <param name="node">Nodo base para a rotação</param>
        /// <returns>Nodo com a rotação efetuada sobre ele</returns>
        private Node<T> RightRotate(Node<T> node)
        {
            Node<T> T1 = node.LeftNode;
            Node<T> T2 = T1.RightNode;
            T1.SetRightNode(node);
            node.SetLeftNode(T2);
            T1.SetHeight(T1.GetHeightOfLargestSubtree());
            node.SetHeight(node.GetHeightOfLargestSubtree());
            return T1;
        }

        /// <summary>
        /// Efetuar o balanceamento da árvore após inserção.
        /// </summary>
        /// <param name="nodeInput">Nodo base para o balanceamento</param>
        /// <param name="element">Valor que se deseja inserir na árvore</param>
        /// <returns>Árvore balanceada a partir do nodo informado</returns>
        private Node<T> TreeBalanceAfterInsert(Node<T> nodeInput, ElementData<T> element)
        {

            (Node<T> node, int balanceValue) = nodeInput.NodeBalanceAndUpdateHeight();

            if (balanceValue > 1)
            {
                if (element.CompareTo(node.LeftNode.Element.Value) < 0) //element < node.LeftNode.Element
                {
                    return RightRotate(node);
                }
                else if (element.CompareTo(node.LeftNode.Element.Value) > 0) //element > node.LeftNode.Element
                {
                    node.SetLeftNode(LeftRotate(node.LeftNode));
                    return RightRotate(node);
                }
            }
            if (balanceValue < -1)
            {
                if (element.CompareTo(node.RightNode.Element.Value) > 0) //element > node.RightNode.Element)
                {
                    return LeftRotate(node);
                }
                else if (element.CompareTo(node.RightNode.Element.Value) < 0) //element < node.RightNode.Element)
                {
                    node.SetRightNode(RightRotate(node.RightNode));
                    return LeftRotate(node);
                }
            }
            return node;
        }

        /// <summary>
        /// Efetuar o balanceamento da árvore após deleção.
        /// </summary>
        /// <param name="nodeInput">Nodo base para o balanceamento</param>
        /// <returns>Árvore balanceada a partir do nodo informado</returns>
        private Node<T> TreeBalanceAfterDelete(Node<T> nodeInput)
        {
            (Node<T> node, int balanceValue) = nodeInput.NodeBalanceAndUpdateHeight();

            if (balanceValue > 1)
            {
                if (node.LeftNode.NodeBalance() >= 0)
                {
                    return RightRotate(node);
                }
                else
                {
                    node.SetLeftNode(LeftRotate(node.LeftNode));
                    return RightRotate(node);
                }
            }
            else if (balanceValue < -1)
            {
                if (node.RightNode.NodeBalance() <= 0)
                {
                    return LeftRotate(node);
                }
                else
                {
                    node.SetRightNode(RightRotate(node.RightNode));
                    return LeftRotate(node);
                }
            }

            return node;
        }

        /// <summary>
        /// Remover o node passado por parâmetro e mover seus filhos.
        /// </summary>
        /// <param name="node">Nodo a ser deletado da árvore</param>
        /// <returns>Nodo a ser posicionado no local do deletado</returns>
        private Node<T> DeleteNodeAccordingChildren(Node<T> node)
        {
            Node<T> aux;
            if (node.LeftNode == null || node.RightNode == null)
            {
                if (node.LeftNode != null)
                {
                    aux = node.LeftNode;
                }
                else
                {
                    aux = node.RightNode;
                }

                if (aux == null)
                {
                    node = null;
                }
                else
                {
                    node = aux;
                }
            }
            else
            {
                aux = NodeWithMinimumValue(node.RightNode);
                node.SetElement(aux.Element);
                node.SetRightNode(DeleteNode(node.RightNode, aux.Element)); ;
            }

            return node;
        }

        /// <summary>
        /// Procurar o nodo com menor valor da árvore.
        /// </summary>
        /// <param name="node">Nodo raíz da consulta</param>
        /// <returns>Nodo que possui o menor valor da árvore</returns>
        private Node<T> NodeWithMinimumValue(Node<T> node)
        {
            Node<T> current = node;
            while (current.LeftNode != null)
            {
                current = current.LeftNode;
            }

            return current;
        }

        #endregion

        #region Métodos de impressão da árvore

        /// <summary>
        /// Imprimir a árvore percorrendo em pré-ordem.
        /// </summary>
        public void PreOrdem()
        {
            PreOrdem(this.Root);
        }

        /// <summary>
        /// Imprimir a árvore percorrendo em pré-ordem.
        /// </summary>
        /// <param name="node">Nodo raíz para o percurso</param>
        private void PreOrdem (Node<T> node)
        {
            if(node != null)
            {
                Console.Write(node.Element.Value + "  ");
                PreOrdem(node.LeftNode);
                PreOrdem(node.RightNode);
            }
        }

        /// <summary>
        /// Imprimir a árvore percorrendo Em-Ordem.
        /// </summary>
        public void EmOrdem()
        {
            EmOrdem(this.Root);
        }

        /// <summary>
        /// Imprimir a árvore percorrendo Em-Ordem.
        /// </summary>
        /// <param name="node">Nodo raíz para o percurso</param>
        private void EmOrdem(Node<T> node)
        {
            if(node != null)
            {
                EmOrdem(node.LeftNode);
                Console.Write(node.Element.Value + "  ");
                EmOrdem(node.RightNode);
            }   
        }

        /// <summary>
        /// Imprimir a árvore percorrendo em Pós-Ordem.
        /// </summary>
        public void PosOrdem()
        {
            PosOrdem(this.Root);
        }

        /// <summary>
        /// Imprimir a árvore percorrendo em Pós-Ordem.
        /// </summary>
        /// <param name="node">Nodo raíz para o percurso</param>
        private void PosOrdem(Node<T> node)
        {
            if(node != null)
            {
                PosOrdem(node.LeftNode);
                PosOrdem(node.RightNode);
                Console.Write(node.Element.Value + "  ");
            }
        }

        /// <summary>
        /// Método para imprimir a árvore.
        /// </summary>
        public void PrintTree()
        {
            PrintTree(this.Root, string.Empty, true);
        }

        /// <summary>
        /// Método para imprimir a árvore.
        /// </summary>
        /// <param name="currPrt">Node atual da impressão</param>
        /// <param name="indent">identação utilizada para a escrita em tela</param>
        /// <param name="rightPath">Flag que indica se o nó atual é para o lado direito da subárvore analisada</param>
        private void PrintTree(Node<T> currPrt, string indent, bool rightPath)
        {
            if (currPrt != null)
            {
                Console.Write(indent);
                if (indent.Equals(string.Empty))
                {
                    Console.Write("Raíz-");
                    indent += "   ";
                }
                else if (rightPath)
                {
                    Console.Write("D----");
                    indent += "   ";
                }
                else
                {
                    Console.Write("E----");
                    indent += "|   ";
                }
                Console.WriteLine(currPrt.Element.ValueFormated());
                PrintTree(currPrt.LeftNode, indent, false);
                PrintTree(currPrt.RightNode, indent, true);
            }
        }

        /// <summary>
        /// Método para obter a impressão da árvore.
        /// </summary>
        public string GetPrintTree()
        {
            string content = string.Empty;
            GetPrintTree(this.Root, string.Empty, true, ref content);
            return content;
        }

        /// <summary>
        /// Método para obter a impressão da árvore.
        /// </summary>
        /// <param name="currPrt">Node atual da impressão</param>
        /// <param name="indent">identação utilizada para a escrita em tela</param>
        /// <param name="rightPath">Flag que indica se o nó atual é para o lado direito da subárvore analisada</param>
        private void GetPrintTree(Node<T> currPrt, string indent, bool rightPath, ref string content)
        {
            if (currPrt != null)
            {
                content += indent;
                if (indent.Equals(string.Empty))
                {
                    content += "Raíz-";
                    indent += "\t";
                }
                else if (rightPath)
                {
                    content += "D----";
                    indent += "\t";
                }
                else
                {
                    content += "E----";
                    indent += "|\t";
                }
                content += currPrt.Element.ValueFormated() + "\r\n";
                GetPrintTree(currPrt.LeftNode, indent, false, ref content);
                GetPrintTree(currPrt.RightNode, indent, true, ref content);
            }
        }
        #endregion
    }
}