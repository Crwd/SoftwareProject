using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject {
    class ProjectLeader : Employee {
        public Task createEpic(String epic, DevTeam t, int release, String title, String desc, int EstInMinutes) {
            return t.Leader.giveEpic(epic, release, title, desc, EstInMinutes);
        }
    }
}
