using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_02
{
    public class Course:IMessage
    {
        public Course() { }
        public Course(int id) { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string AuthorUrl { get; set; }
        public void M1()
        {
            //...
        }

        public bool SendMessage()
        {
            //...

            return false;
        }
    }
}
