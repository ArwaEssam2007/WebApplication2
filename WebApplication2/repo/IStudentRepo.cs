namespace WebApplication2.repo
{
    public interface IStudentRepo
    {
        Student GeStudenttById(int id);
        void UpdateStudent(StudentDTO dto);
        void AddStudent(StudentDTO dto);
        void DeleteStudent(int id);


    }
}
