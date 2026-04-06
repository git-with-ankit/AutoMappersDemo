using AutoMapper;

namespace AutoMappersDemo.Profiles
{
    //Profiles are classes where you describe mappings once.
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDTO>() //it auto maps all the properties whose names are same (case-insensitive) and compatible types in source and destination , but what if we want to maps different names or different type. For that we use ForMember and MapFrom
                .ReverseMap(); //Also creates mapping for EmployeeDTO to Employee


            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName))//opt is configuration for how EmployeeDTO.Name should be mapped
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City));
            //Employee.FullName → EmployeeDTO.Name and Employee.Address.City → EmployeeDTO.City and Employee.Salary → EmployeeDTO.Salary(auto)
            //if we write reversemap here , then the point till you don't write everything is forward mapping even if you dont write same name properties they get auto mapped and after .ReverseMap , whatever you write with .ForMember it is reverse mapped. If you dont write anything after ReverseMap , everything that is mapped forward is mapped in reverse
        }
    }
}
