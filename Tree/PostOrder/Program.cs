namespace PostOrder
{
    public class Node
    {
        public int data { get; set; }
        public Node? left { get; set; }
        public Node? right { get; set; }
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    internal class Program
    {
        public static void PostOrder(Node root,List<int> Ans)
        {
            if (root == null)return;
            PostOrder(root.left, Ans);
            PostOrder(root.right, Ans);
            Ans.Add(root.data);
        }
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            List<int> Result = new List<int>();
            PostOrder(root,Result);
            foreach (var x in Result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
