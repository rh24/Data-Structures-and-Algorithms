using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        // Depth-first traversals

        /// <summary>
        /// Pre-order: Root, Right, Left
        /// Instantiate a new list when running the method, and pass into method as a parameter
        /// </summary>
        /// <param name="root">Starting root node</param>
        /// <param name="nodes">Generic list of nodes for updating list recursively</param>
        /// <returns></returns>
        public List<Node> PreOrder(Node root, List<Node> nodes)
        {
            nodes.Add(root);
            if (root.LeftChild != null) PreOrder(root.LeftChild, nodes);
            if (root.RightChild != null) PreOrder(root.RightChild, nodes);

            return nodes;
        }

        /// <summary>
        /// In order: Left, Root, Right
        /// </summary>
        /// <param name="root">Starting root node</param>
        /// <param name="nodes">Generic list of nodes for updating list recursively</param>
        /// <param name="nodes">Generic list of nodes for updating list recursively</param>
        public List<Node> InOrder(Node root, List<Node> nodes)
        {
            if (root.LeftChild != null) InOrder(root.LeftChild, nodes);
            nodes.Add(root);
            if (root.RightChild != null) InOrder(root.RightChild, nodes);

            return nodes;
        }

        // Post-order: Left, Right, Root
        public List<Node> PostOrder(Node root, List<Node> nodes)
        {
            if (root.LeftChild != null) InOrder(root.LeftChild, nodes);
            if (root.RightChild != null) InOrder(root.RightChild, nodes);
            nodes.Add(root);

            return nodes;
        }
    }
}
