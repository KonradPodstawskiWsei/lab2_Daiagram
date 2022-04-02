using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram {
    class Person {
        protected string name;
        protected int age;

        public string  Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public override string ToString() {
            return "Person: " + name.ToString() + "(" + age.ToString() + " y.o.)";
        }

        public override bool Equals(Object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            } else {
                Person p = (Person)obj;
                return (name == p.name) && (age == p.age);
            }
        }

        public override int GetHashCode() {
            return (age << 2) ^ 2;
        }
    }
}
