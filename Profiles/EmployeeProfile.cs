using AutoMapper;

namespace AutoMappersDemo.Profiles
{
    //Profiles are classes where you describe mappings once.
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}
