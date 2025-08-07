namespace WebApplication1.Models
{
    public class StudentBl
    {
        List<Student> students;
        public StudentBl()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "ali", ImageUrl = "image.jpg" });
            students.Add(new Student() { Id = 2, Name = "mohammed", ImageUrl = "image1.jpg" });
            students.Add(new Student() { Id = 3, Name = "nore", ImageUrl = "image2.jpg" });
            students.Add(new Student() { Id = 4, Name = "sam", ImageUrl = "image3.jpg" });

        }
        public List<Student> GetAll()
        {
            return students;
        }
        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
