﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram {
    class Teacher : Person {
        public Teacher(string name, int age): base(name, age) {
            
        }

        public override string ToString() {
            return "Teacher: " + name.ToString() + "(" + age.ToString() + " y.o.)";
        }

    }
}