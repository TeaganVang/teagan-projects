using System.Globalization;

namespace Occupation
{
    public class Job
    {
        public required string Title;
        public decimal Salary;
        public DateTime StartDate;

        public void JobDetails()
        {
            Console.WriteLine($"Job: {Title}, Salary: {Salary} a week, Started On: {StartDate.ToShortDateString()}");
        }
    }

    public class StateSenateCampaign
    {
        public required string Employer;
        public int EmployeeCount;
        public bool IsDemocrat;

        public void CampaignDetails()
        {
            Console.WriteLine($"Employer: {Employer}, Amount of Employees: {EmployeeCount} people, Democrat: {IsDemocrat}, Republican: False");
        }
    }
}