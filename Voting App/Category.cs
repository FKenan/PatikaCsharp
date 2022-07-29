using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    internal class Category
    {
        private static int idCounter=0;

        private int voteCount = 0;
        public int VoteCount { get => voteCount; }

        private int id;
        public int Id { get => id; set => id = value; }

        private string categoryName;
        public string CategoryName { get => categoryName; set => categoryName = value; }      

        private static List<Category> categories = new List<Category>();
        internal static List<Category> Categories { get => categories;}
        

        public Category(string categoryName)
        {
            idCounter++;
            this.categoryName = categoryName;
            id = idCounter;
            categories.Add(this);
        }

        public void AddVote()
        {
            voteCount++;
        }
    }
}
