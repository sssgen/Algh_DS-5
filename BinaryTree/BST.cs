public class BST
{
    public class Node
    {
        public string MobilePhone { get; set; }
        public Student Student { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string mobilePhone, Student student)
        {
            MobilePhone = mobilePhone;
            Student = student;
        }
    }

    public Node Root { get; set; }

    public void AddNode(string mobilePhone, Student student)
    {
        Root = AddNodeRecursive(Root, mobilePhone, student);
    }

    private Node AddNodeRecursive(Node root, string mobilePhone, Student student)
    {
        if (root == null)
        {
            return new Node(mobilePhone, student);
        }

        if (string.Compare(mobilePhone, root.MobilePhone) < 0)
        {
            root.Left = AddNodeRecursive(root.Left, mobilePhone, student);
        }
        else if (string.Compare(mobilePhone, root.MobilePhone) > 0)
        {
            root.Right = AddNodeRecursive(root.Right, mobilePhone, student);
        }

        return root;
    }

    public Node Search(string mobilePhone)
    {
        return SearchRecursive(Root, mobilePhone);
    }

    private Node SearchRecursive(Node root, string mobilePhone)
    {
        if (root == null || root.MobilePhone == mobilePhone)
            return root;

        if (string.Compare(mobilePhone, root.MobilePhone) < 0)
            return SearchRecursive(root.Left, mobilePhone);

        return SearchRecursive(root.Right, mobilePhone);
    }

    public Node RotateLeft(Node root)
    {
        Node newRoot = root.Right;
        root.Right = newRoot.Left;
        newRoot.Left = root;
        return newRoot;
    }

    public Node RotateRight(Node root)
    {
        Node newRoot = root.Left;
        root.Left = newRoot.Right;
        newRoot.Right = root;
        return newRoot;
    }
}
