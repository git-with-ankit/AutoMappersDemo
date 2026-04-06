namespace AutoMappersDemo
{
    public class Employee
    {
        public string FullName { get; set; }
        public int Salary { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
    }
}