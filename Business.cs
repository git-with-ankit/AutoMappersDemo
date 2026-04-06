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
            var emp = new Employee
            {
                FullName = "Employee 1",
                Salary = 20000,
                Address = new Address
                {
                    City = "Delhi"
                }
            };

            EmployeeDTO empDTO = new EmployeeDTO() 
            { 
                Name = emp.FullName,
                Salary = emp.Salary,
                City = emp.Address.City
            };

            return empDTO;


        }

        public EmployeeDTO AutoMapper()
        {
            var emp2 = new Employee
            {
                FullName = "Employee2",
                Salary = 20000,
                Address = new Address
                {
                    City = "Delhi"
                }
            };

            EmployeeDTO emp2DTO = _mapper.Map<EmployeeDTO>(emp2);

            return emp2DTO;

        }
    }
}
