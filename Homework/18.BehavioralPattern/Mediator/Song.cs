using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    public class Song : IFile
    {
        private float size;

        private string name;

        public Song(float size, string name)
        {
            this.Size = size;
            this.Name = name;
        }

        public float Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                this.size = value;
            }
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }
    }
}