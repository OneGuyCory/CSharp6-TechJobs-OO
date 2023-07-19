using System;
namespace TechJobsOOAutoGraded6
{
	public class Location : JobField
	{
        public Location(string value) : base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }
    }
}

