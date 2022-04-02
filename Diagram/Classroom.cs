using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram {
    class Classroom {
        public string name;
        public Person[] persons;

        public string Name { get; set; }

        public Classroom(string name, Person[] persons) {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString() {
            string buff = "Classroom: " + name + "\n \n";

            for (int i = 0; i < persons.Count(); i++) {
                buff += persons[i] + "\n \n";
            }

            return buff;
        }
    }
}
