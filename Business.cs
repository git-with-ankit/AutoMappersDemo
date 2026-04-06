namespace AutoMappersDemo
{
    public static class Business
    {
        public static EmployeeDTO TraditionalApproach()
        {
            Employee emp = new Employee() 
            { 
                Name = "Emp1",
                Salary = 20000,
                Address = "London",
                Department = "IT"
            };

            EmployeeDTO empDTO = new EmployeeDTO() 
            { 
                Name = emp.Name,
                Salary = emp.Salary,
                Address = emp.Address,
                Department = emp.Department
            };

            return empDTO;


        }
    }
}
