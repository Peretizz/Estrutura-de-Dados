using System;
using System.Collections.Generic;
using Trees;

Console.WriteLine("Agora com árvores");

Tree<int> tree = new Tree<int>();

tree.Root = new TreeNode<int>
{
    Data = 100
};

// Filhos da raiz (100)
tree.Root.Children = new List<TreeNode<int>>()
{
    new TreeNode<int> { Data = 50, Parent = tree.Root },
    new TreeNode<int> { Data = 1, Parent = tree.Root },
    new TreeNode<int> { Data = 150, Parent = tree.Root }
};

// Filhos do nó 150
tree.Root.Children[2].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>
    {
        Data = 30,
        Parent = tree.Root.Children[2]
    },
    new TreeNode<int>
    {
        Data = 5,
        Parent = tree.Root.Children[2]
    },
    new TreeNode<int>
    {
        Data = 11,
        Parent = tree.Root.Children[2]
    }
};

// Filhos do nó 50
tree.Root.Children[0].Children = new List<TreeNode<int>>()
{
    new TreeNode<int>
    {
        Data = 70,
        Parent = tree.Root.Children[0]
    },
    new TreeNode<int>
    {
        Data = 61,
        Parent = tree.Root.Children[0]
    }
};

Console.WriteLine($"Raiz: {tree.Root.Data}");
Console.WriteLine($"Altura do nó 150: {tree.Root.Children[2].GetHeight()}");