using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private int Deep = 0;
        public void CreateGraph(int deep, int childrens)
        {
            Deep = deep;
            Node startNode = SetNode(0,childrens, 0);
        }

        public Node SetNode(int deep,int childrens, int index)
        {
            Node node = new Node(deep, index);
            if (deep < Deep)
            {
                for (int i = 0; i < childrens; i++)
                {
                    node.childrens.Add(SetNode(deep+ 1,childrens, i));
                }
            }

            return node;
        }
    }

    public class Node
    {
        public int Deep = 0;
        public List<Node> childrens;
        public int Number;

        public Node(int deep, int index)
        {
            Deep = deep;
            childrens = new List<Node>();
            Console.WriteLine($"deep {deep} index {index}");
            Number = new System.Random().Next(0, 10);
        }
    }
}
