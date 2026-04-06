namespace AutoMappersDemo
{
    public class EmployeeDTO
    {
        public string Name { get; set; }     // different name
        public int Salary { get; set; }
        public string City { get; set; }     // flattened
    }
}