
using System.Data;
using System.Xml.Linq;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new
        PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new 
        PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(job1.Id, job2.Id - 1 );
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name );
            Assert.AreEqual("ACME", job3.EmployerName.Value );
            Assert.AreEqual("Desert", job3.EmployerLocation.Value );
            Assert.AreEqual("Quality control", job3.JobType.Value );
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value );
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse( job1.Equals( job2 ) );
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string layout =
                "\n" +
                "\n";

            string correctLayout = job3.ToString();

            Assert.AreEqual( layout, correctLayout );
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string correctLayout =
            $"\n" +
                    $"ID: {job3.Id}\n" +
                    $"Name: {job3.Name}\n" +
                    $"Employer: {job3.EmployerName.Value}\n" +
            $"Location: {job3.EmployerLocation.Value}\n" +
                    $"Position Type: {job3.JobType.Value}\n" +
                    $"Core Competency: {job3.JobCoreCompetency.Value}\n" +
                    $"\n";

            string layoutToTest = job3.ToString();

            Assert.AreEqual( layoutToTest, correctLayout );
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.AreEqual("Data not available", job1.ToString());
        }

    }
}

