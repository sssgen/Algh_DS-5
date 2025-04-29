public class Search
{
    public static Student InterpolationSearch(Student[] students, double key)
    {
        int low = 0, high = students.Length - 1;
        while (low <= high && key >= students[low].AverageGrade && key <= students[high].AverageGrade)
        {
            if (low == high)
            {
                if (students[low].AverageGrade == key)
                    return students[low];
                break;
            }

            int pos = low + (int)((key - students[low].AverageGrade) / (students[high].AverageGrade - students[low].AverageGrade) * (high - low));

            if (students[pos].AverageGrade == key)
                return students[pos];

            if (students[pos].AverageGrade < key)
                low = pos + 1;
            else
                high = pos - 1;
        }
        return null;
    }
}
