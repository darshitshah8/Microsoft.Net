namespace MethodOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HoulyRate { get; set; }
        public virtual decimal GetpayCheckAmount(int hoursWorked) 
        {
            return HoulyRate * hoursWorked;
        }
            
    }
}
