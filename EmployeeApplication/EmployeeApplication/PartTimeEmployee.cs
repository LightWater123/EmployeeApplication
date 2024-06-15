namespace EmployeeInterface
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Department { get; set; }
        string JobTitle { get; set; }
        double Salary { get; }
        void ComputeSalary(int hoursWorked, double ratePerHour);
    }

    public class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_title; 
        private double basic_salary;

        public PartTimeEmployee(string Fname, string Lname, string dept, string job)
        {
            this.first_name = Fname;
            this.last_name = Lname;
            this.department = dept;
            this.job_title = job; 
            this.basic_salary = 0.0;
        }

        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle 
        {
            get { return job_title; } 
            set { job_title = value; } 
        }

        public double Salary
        {
            get { return basic_salary; }
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return basic_salary;
        }
    }
}
