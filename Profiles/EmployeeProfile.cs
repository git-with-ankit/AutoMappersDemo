using AutoMapper;

namespace AutoMappersDemo.Profiles
{
    //Profiles are classes where you describe mappings once.
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDTO>(); //it auto maps all the properties whose names are same (case-insensitive) and compatible types in source and destination , but what if we want to maps different names or different type. For that we use ForMember and MapFrom

            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))//opt is configuration for how EmployeeDTO.Name should be mapped
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City));//mployee.FullName → EmployeeDTO.Name and Employee.Address.City → EmployeeDTO.City and Employee.Salary → EmployeeDTO.Salary(auto)
        }
    }
}
