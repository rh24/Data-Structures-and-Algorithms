using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="root">Node to set Root property</param>
        public BinaryTree(Node root)
        {
            Root = root;
        }

        // Depth-first traversals
        /// <summary>
        /// Pre-order: Root, Left, Right
        /// Instantiate a new list when running the method, and pass into method as a parameter
        /// </summary>
        /// <param name="node">Starting node</param>
        /// <param name="nodes">Generic list of nodes for updating list recursively</param>
        /// <returns></returns>
        public List<Node> PreOrder(Node node, List<Node> nodes)
        {
            if (node == null) return nodes;
            nodes.Add(node);
            PreOrder(node.LeftChild, nodes);
            PreOrder(node.RightChild, nodes);

            return nodes;
        }

        /// <summary>
        /// In order: Left, Root, Right
        /// </summary>
        /// <param name="node">Starting node</param>
        /// <param name="nodes">Generic list of nodes for updating list recursively</param>
        public List<Node> InOrder(Node node, List<Node> nodes)
        {
            if (node == null) return nodes;
            InOrder(node.LeftChild, nodes);
            nodes.Add(node);
            InOrder(node.RightChild, nodes);

            return nodes;
        }

        /// <summary>
        /// Post-order: Left, Right, Root
        /// </summary>
        /// <param name="node">Starting node</param>
        /// <param name="nodes">Generic list of nodes for updating list recursively</param>
        public List<Node> PostOrder(Node node, List<Node> nodes)
        {
            if (node == null) return nodes;
            InOrder(node.LeftChild, nodes);
            InOrder(node.RightChild, nodes);
            nodes.Add(node);

            return nodes;
        }
    }
}
