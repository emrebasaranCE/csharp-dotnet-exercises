using System;

namespace Constructor_namespace
{
    class Test2
    {
        public static void not_main()
        {
            Student std_1 = new Student("Student 1", "HotBOii", 3289);
            Student std_2 = new Student();
            std_2.Name = "Student 2";
            std_2.Last_name = "YEssir";
            std_2.No = 48739;

            std_1.print_info_of_student();
            std_2.print_info_of_student();

            Student std_3 = new Student("Student 3", "Yur mum");

            std_3.print_info_of_student();
        }
    }
    class Student
    {
        public string Name;
        public string Last_name;
        public int No;

        public Student(string name, string last_name, int no)
        {
            this.Name = name;
            this.Last_name = last_name;
            this.No = no;
        }

        public Student(string name, string last_name)
        {
            this.Name = name;
            this.Last_name = last_name;
        }

        public Student(){}

        public void print_info_of_student()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Last_name: {Last_name}");
            Console.WriteLine($"No: {No}");
        }


    }
}