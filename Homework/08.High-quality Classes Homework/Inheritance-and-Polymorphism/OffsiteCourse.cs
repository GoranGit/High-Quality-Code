namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class OffsiteCourse : Course
    {

        private string town;
       
        public OffsiteCourse(string name):this(name,null,null)
        {
        }

        public OffsiteCourse(string courseName, string teacherName):this(courseName,teacherName,null)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students):base(courseName,teacherName,students)
        {
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(town))
                {
                    throw new ArgumentNullException("Town property can't be null or empty!");
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("OffsiteCourse { Name = ");
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
