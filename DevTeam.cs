using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject {
    class DevTeam {
        List<Developer> Members = new List<Developer>();
        Release[] Roadmap = new Release[100];

        public TeamLeader Leader;

        int currentRelease = 0;

        public DevTeam() {

        }

        public DevTeam(List<Developer> t, TeamLeader l) {
            Members = t;
            setLeader(l);
        }

        public DevTeam(List<Developer> t) {
            Members = t;
        }

        public void setLeader(TeamLeader l) {
            Leader = l;
            l.Team = this;
        }

        public void add(Developer e) {
            Members.Add(e);
            e.Team = this;
        }

        public void remove(Developer e) {
            Members.Remove(e);
            e.Team = null;
        }

        public void addEpic(String e, int release) {
            Roadmap[release].addEpic(e);
        }

        public Release getRelease(int releaseId) {
            return Roadmap[releaseId];
        }

        public void createRoadmap(int releases) {
            for (int i = 0; i < releases; i++) {
                Roadmap[i] = new Release(i);
            }
        }

        public Release createRelease(int id) {
            Roadmap[id] = new Release(id);
            return Roadmap[id];
        }

        public Task createTask(TeamLeader.UserStory s) {
            // Schätzung des Aufwands etc.
            // Nicht sicher ob das hier nur Pseudo Code sein sollte oder echte Berechnungen ?
            Release r = getRelease(s.release);

            int newEST = 0;
            Task t = new Task(r, s.title, s.description, s.est, s.notice);
            t.setStory(s);

            // if priority high enough take into current sprint
            Roadmap[s.release].addTask(t);
            // if-end

           // if (Math.Abs(newEST - s.est) <= 5) {
                return t; // Estimated time correct; create task
            //} else {
                //return null; // Estimated time incorrect; cancel task
            //}
        }

        public void onTaskDone(Task t, int time, bool done = false) {
            if (t != null) {
                t.setTimeNeeded(time);
                
                if (done) {
                    t.Release.setDone(t);
                }
            }
        }

        public SoftwareTester getTester() {
            foreach (Employee e in Members) {
                if ((e as SoftwareTester) != null) {
                    return (SoftwareTester) e;
                }
            }

            return null;
        }
    }
}
