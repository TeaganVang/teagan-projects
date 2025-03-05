namespace People
{
    public class Person
    {
        public required string Name;
        public int Age;
        public double Height;

        public void Responsible()
        {
            Console.WriteLine($"{Name}, {Age} years old, {Height} meters(6'2 ft), is responsible for crashing and killing a deer.");
        }
    }

    
    public class Relation
    {
        public required string Relationship;
        public bool CollegeStudent;
        public DateTime LastMeeting;

        public void OurRelationship()
        {
            Console.WriteLine($"Garrett Ward Armstrong Magee is my {Relationship}. It is {CollegeStudent} that he is a freshman at KU. The last time we met was {LastMeeting.ToShortDateString()}");
        }
    }
}