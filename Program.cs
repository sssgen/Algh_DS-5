class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Student[] students = new Student[]
        {
            new Student("Іваненко", "Іван", 4.5, 3, "0671234567"),
            new Student("Петренко", "Петро", 4.7, 2, "0681234567"),
            new Student("Сидоренко", "Сидір", 4.2, 3, "0631234567"),
            new Student("Коваленко", "Костянтин", 5.0, 1, "0661234567"),
            new Student("Мельник", "Марія", 3.9, 3, "0951234567"),
        };

        Array.Sort(students, (x, y) => x.AverageGrade.CompareTo(y.AverageGrade)); // Для інтерполяційного пошуку потрібно

        double searchGrade = 4.5;
        var foundStudent = Search.InterpolationSearch(students, searchGrade);

        Console.WriteLine(foundStudent != null ? $"Знайдено: {foundStudent}" : "Студент не знайдений");

        BST bst = new BST();
        foreach (var student in students)
        {
            bst.AddNode(student.MobilePhone, student);
        }

        var searchPhone = "0671234567";
        var bstNode = bst.Search(searchPhone);
        Console.WriteLine(bstNode != null ? $"Знайдено: {bstNode.Student}" : "Вузол не знайдений");
    }
}
