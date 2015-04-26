namespace EmloyeeInformation
{
    class Employee
    {
        public string id;
        public string name;
        public double salary;

        public  string GetEmployeeName()
        {
            return name;
        }

        public double GetEmployeeSalary()
        {
            return salary;
        }
    }
}
