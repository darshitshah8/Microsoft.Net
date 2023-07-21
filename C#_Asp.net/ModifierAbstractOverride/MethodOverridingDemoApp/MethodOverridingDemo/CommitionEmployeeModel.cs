namespace MethodOverridingDemo
{
    public class CommitionEmployeeModel : EmployeeModel 
    {
        public decimal CommitionAmmount { get; set; }

        public override decimal GetpayCheckAmount(int hoursWorked)
        {
            decimal initialPay =base.GetpayCheckAmount(hoursWorked);
            return initialPay + CommitionAmmount;
        }
    }
}
