using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject
{
    class TeamLeader : Employee {
        public DevTeam Team;

        internal struct UserStory {
            public string title;
            public string description;
            public int est;
            public int time; // time in seconds
            public Task task;
            public String notice;
            public int release;
        }

        List<UserStory> BackLog = new List<UserStory>();

        public TeamLeader() {
         
        }

        public Task giveEpic(String epic, int release, String title, String desc, int EstInMinutes) {
            Team.addEpic(epic, release);
            return createUserStory(title, desc, EstInMinutes, release);
        }

        public Task createUserStory(String title, String desc, int est, int release, String notice = "") {
            UserStory s = new UserStory();
            s.title = title;
            s.description = desc;
            s.est = est;
            s.time = 0;
            s.notice = notice;
            s.release = release;
            BackLog.Add(s);
            return Team.createTask(s);
        }

        public void refactorUserStory(UserStory s, String notice = "") {
            BackLog.Remove(s);
            s.notice = notice;
            BackLog.Add(s);
            Team.createTask(s);
        }
    }
}
