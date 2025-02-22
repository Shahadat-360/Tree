﻿using TreeTraversal;

List<int> Ans = new List<int>();
void PreOrder(Node root)
{
    if (root == null)return;
    Ans.Add(root.data);
    PreOrder(root.left);
    PreOrder(root.right);
}

Node root = new Node(1);
root.left = new Node(2);
root.right = new Node(3);
root.left.left = new Node(4);
root.left.right = new Node(5);
PreOrder(root);
foreach(var x in Ans)Console.WriteLine(x);