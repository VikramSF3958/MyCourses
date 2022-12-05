
namespace _11_LinqQueries
{
    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string Gender { get; set; }

        public List<Student> AllStudentsLists()
        {
            List<Student> lStudentList = new List<Student>();

            Student student3 = new Student()
            {
                StudentID = 103,
                StudentName = "Krithi",
                Gender = "Female",
            };
            lStudentList.Add(student3);

            Student student1 = new Student()
            {
                StudentID = 100,
                StudentName = "Vikram",
                Gender = "Male",
            };
            lStudentList.Add(student1);

            Student student2 = new Student()
            {
                StudentID = 101,
                StudentName = "Jeeva",
                Gender = "Male",
            };
            lStudentList.Add(student2);

            return lStudentList;
        }
    }
}