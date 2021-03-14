using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KWDM_projekt
{
    class Patient
    {
        private string name;
        private int age;
        private string sex;
        private string id;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }

        public string Id { get => id; set => id = value; }

        public Patient(string name, string id)
        {
            this.name = name;
            this.id = id;

        }
    }
}
