using Bogus;

namespace W02.Models
{
    public static class SchoolDB
    {

        public static List<Student> Students = new List<Student>();
       
        public static void InitializeDb(int number)
        {

            if (Students.Count == 0)
            {
                for (int i = 0; i < number; i++)
                {
                    var student = new Faker<Student>()
                        .RuleFor(s => s.Id, f => i +1)
                        .RuleFor(s => s.Name, f => f.Name.FullName())
                        .RuleFor(s => s.Email, f => f.Internet.Email())
                        .RuleFor(s => s.Age, f => f.Random.Int(18, 38));

                    Students.Add(student);
                }
            }
        
        }


    }
}
