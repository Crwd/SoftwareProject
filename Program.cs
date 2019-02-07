using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject {
    class Program {
        static void Main(string[] args) {
            DevTeam Team = new DevTeam();
            Team.add(new Developer());
            Team.add(new Developer());
            Team.add(new Developer());
            Team.add(new SoftwareTester());

            TeamLeader Leader = new TeamLeader();
            ProjectLeader PLeader = new ProjectLeader();

            Team.setLeader(Leader);

            Team.createRoadmap(3);

            Task t1 = PLeader.createEpic("Website", Team, 1, "Homepage Erstellung", "CMS, Design, Backend", 25000);
            Task t2 = PLeader.createEpic("Forum", Team, 1, "Communityforum", "Userboard, Topics, Profiles", 100000);
            Task t3 = PLeader.createEpic("Logo", Team, 1, "Logo Design", "Design", 10000);
            Task t4 = PLeader.createEpic("Backup", Team, 1, "New Backup", "Data, Saving, Backup", 30000);

            Release R = Team.getRelease(1);

            System.Console.WriteLine(R.getRemainingTimeFormat());

            Team.onTaskDone(t1, 2000, true);
            System.Console.WriteLine(R.getRemainingTimeFormat());

            Team.onTaskDone(t2, 120000, true);
            System.Console.WriteLine(R.getRemainingTimeFormat());

            Team.onTaskDone(t3, 8000, true);
            System.Console.WriteLine(R.getRemainingTimeFormat());

            Team.onTaskDone(t4, 30600, true);
            System.Console.WriteLine(R.getRemainingTimeFormat());
        }
    }
}
