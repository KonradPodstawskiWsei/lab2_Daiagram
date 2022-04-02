using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram {
    class Task {
        public string name;
        public TaskStatus status;

        public string Name { get; set; }
        public TaskStatus Status { get; set; }

        public Task(string name, TaskStatus status) {
            this.name = name;
            this.status = status;
        }

        public override bool Equals(Object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            } else {
                Task p = (Task)obj;
                return (name == p.name) && (status == p.status);
            }
        }

        public override int GetHashCode() {
            return ((int)status << 2) ^ 2;
        }

        public override string ToString() {
            return name.ToString() + "[" + status.ToString() + "]";
        }
    }

    enum TaskStatus {
        Waiting,
        Progress,
        Done,
        Rejected
    }
}
