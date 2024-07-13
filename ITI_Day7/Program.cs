namespace ITI_Day7
{

    class Student
    {

        int id;
        string name;
        int age;

        static Student()
        {
            Console.WriteLine("Hello This is first Student");
        }
        public Student(int id , string name , int age)
        {
            this.id = id;   
            this.name = name;   
            this.age = age; 

        }
        //public void setData(int id, string name="Student", int age=15)
        //{
        //    this.id = id;
        //    this.name = name;   
        //    this.age = age;

        //}
        public void getData()
        {
            Console.WriteLine($"{name}  -  {id}  -  {age}");
        }
        public string is_over_age()
        {
            if(age>24)
                return "graduated";

            return "not graduated";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(5454,"sami",20);
            Student s2 = new Student(54654,"abdo",26);

          

            s1.getData();
            s2.getData();

            Console.WriteLine(s1.is_over_age());
            Console.WriteLine(s2.is_over_age());
        }
    }
}