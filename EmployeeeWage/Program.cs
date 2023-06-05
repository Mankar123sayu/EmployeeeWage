
using System;


namespace EmployeeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EmpWage.Attendance();
            //EmployeeeWage employeeeWage = new EmployeeeWage();
            // EmpWage.TotalWage();
            // EmpWage.CalculatingPartTimeWage();
            // EmployeeDetails.CalculatingPartTimeWageWithSwitch();
            // EmployeeDetails.CalculateWagesForMonth();
            //WageTillCondition.CalculateWageTillCondition();
            // Refactor.GetWorkingHour(2);
            // MultipleCompanies.Multiple("Nokia", 10, 20, 100);

            // TotalWage google = new TotalWage("Google", 20, 5, 160);
            // TotalWage tata = new TotalWage("Tata", 10, 5, 160);

            // google.computeEmpWage();
            // Console.WriteLine(google.toString());

            // tata.computeEmpWage();
            // Console.WriteLine(tata.toString());


            Building_Array emp = new Building_Array();
            emp.addCompanyEmpWage("Audi", 20, 5, 160);
            emp.addCompanyEmpWage("Mercedes", 50, 5, 160);
            emp.computeEmpWage();
            Console.WriteLine($"Total wage for Audi company: {emp.getTotalWage("Audi")}");
            Console.WriteLine($"Total wage for Mercedes company: {emp.getTotalWage("Mercedes")}");



        }   
    }
}