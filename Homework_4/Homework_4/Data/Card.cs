using System;

namespace Homework_4.Data
{
    public class Card
    {
        private string Name;
        private long SynCode;
        private long ProjectId;

        public Card(string name, long synCode, long projectId)
        {
            Name = name;
            SynCode = synCode;
            ProjectId = projectId;
        }

        public Card()
        {
            
        }

        public string SetNewName()
        {
            Console.WriteLine("Name your card:");
            Name = Convert.ToString(Console.ReadLine());
            return Name;
        }

        public long SetNewProjectId()
        {
            Console.WriteLine("Set ProjectId for new card");
            ProjectId = Convert.ToInt64(Console.ReadKey());
            return ProjectId;
        }
    }
}