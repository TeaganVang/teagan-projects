using People;
using Car;
using Occupation;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Garrett Ward Armstrong Magee",
            Age = 19,
            Height = 182.88
        };
        person.Responsible();

        Relation relation = new Relation
        {
            Relationship = "Partner",
            CollegeStudent = true,
            LastMeeting = new DateTime(2025, 3, 2)
        };
        relation.OurRelationship();
    
        Vehicle car = new Vehicle
        {
            CarModel = "Ford Focus",
            Year = 2010,
            IsElectric = false
        };
        car.DisplayInfo();

        Details details = new Details
        {
            Brand = "Ford",
            Price = 6000,
            IsUsed = true
        };
        details.CarDetails();

        Occupation.Job job = new Occupation.Job
        {
            Title = "Political Campaign Intern",
            Salary = 350.75m,
            StartDate = new DateTime(2023, 6, 15)
        };
        job.JobDetails();

        StateSenateCampaign statestatecampaign = new StateSenateCampaign
        {
            Employer = "Senator Jeff Pittman",
            EmployeeCount = 30,
            IsDemocrat = true
        };
        statestatecampaign.CampaignDetails();
        
    }
}

