public class StudentCollection
{
    private Student[] students =
        new Student[5];

    public Student this[int index]
    {
        get
        {
            return students[index];
        }

        set
        {
            students[index] = value;
        }
    }
}