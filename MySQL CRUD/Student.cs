namespace MySQL_CRUD
{
    internal class Student
    {
        public string Name { get; set; }

        public string Reg { get; set; }

        public string Class { get; set; }

        public string Section { get; set; }

        public Student(string name, string reg, string @classs, string section)
        {
            Name = name;
            Reg = reg;
            Class = @classs;
            Section = section;
        }
    }
}
