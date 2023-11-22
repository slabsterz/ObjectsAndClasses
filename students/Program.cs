namespace students
{
    internal class Program
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Town { get; set; }

            public Student(
                string setFirstName, 
                string setLastName, 
                int setAge,
                string setTown) 
            { 
                FirstName = setFirstName;
                LastName = setLastName;
                Age = setAge;
                Town = setTown;
            }

        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string firstName = input[0];

                if (firstName == "end")
                {
                    break;
                }

                string lastName = input[1]; 
                int age = int.Parse(input[2]);
                string town = input[3];

                Student student = new Student(firstName, lastName, age, town);

                students.Add(student);

            }

            string targetCity = Console.ReadLine();

            List<Student> filteredStudentList = students.Where(x => x.Town == targetCity).ToList();

            foreach (Student student in filteredStudentList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}