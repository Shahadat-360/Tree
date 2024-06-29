namespace InOrderTraversal
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
    public class Program
    {
        public static void InOrder(Node root, List<int> Ans)
        {
            if (root == null)return;
            InOrder(root.left,Ans);
            Ans.Add(root.data);
            InOrder(root.right,Ans);
        }
        public static void Main(string[] args)
        {
            
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            List<int> Ans = new List<int>();
            InOrder(root,Ans);
            foreach(var x in Ans)Console.WriteLine(x);
        }
    }
}
