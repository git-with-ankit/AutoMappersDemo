using AutoMapper;

namespace AutoMappersDemo
{
    public class Business
    {
        private readonly IMapper _mapper;

        public Business(IMapper mapper)
        {
            _mapper = mapper;
        }
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

        public EmployeeDTO AutoMapper()
        {
            Employee emp2 = new Employee()
            {
                Name = "Emp2",
                Salary = 20000,
                Address = "London",
                Department = "IT"
            };

            EmployeeDTO emp2DTO = _mapper.Map<EmployeeDTO>(emp2);

            return emp2DTO;

        }
    }
}
