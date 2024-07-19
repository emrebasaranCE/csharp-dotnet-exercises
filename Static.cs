using System;

namespace Static_namespace
{
    class Test2
    {
        public static void not_main()
        {
            Student std_1 = new Student("Student 1", "HotBOii", 3289, 1);
            Student std_2 = new Student("Student 2", "YEssir", 48739, 1);

            std_1.print_info_of_student();

            Student.get_current_student_count();
        }
    }
    class Student
    {
        private static int student_count;
        private string name;
        private string last_name;
        private int no;
        private int grade;


        public static int Student_count { get => student_count; set => student_count = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public int No { get => no; set => no = value; }
        public int Grade { 
            get => grade;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Grade should be at least 1 !");
                    grade = 1;
                }
                else
                    grade = value; 
            }
        }

        public Student()
        {
            student_count = 0;
        }

        public Student(string name, string last_name, int no, int year_of_study)
        {
            this.Name = name;
            this.Last_name = last_name;
            this.No = no;
            this.Grade = year_of_study;
            student_count++;
        }

        public void print_info_of_student()
        {
            Console.WriteLine($"Student Name:       {Name}");
            Console.WriteLine($"Student Last_name:  {Last_name}");
            Console.WriteLine($"Student No:         {No}");
            Console.WriteLine($"Student Grade:      {Grade}");
        }        

        public static void get_current_student_count()
        {
            Console.WriteLine($"Total Student Count:      {Student_count}");
        }
        public void increase_grade()
        {
            Grade = Grade + 1;
        }
        public void decrease_grade()
        {
            Grade = Grade - 1;
        }
    }
}