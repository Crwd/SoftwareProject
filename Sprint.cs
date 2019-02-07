using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject {
    class Sprint {
        Board Board = new Board();
        List<Task> Tasks = new List<Task>();

        public void addTask(Task t) {
            Tasks.Add(t);
            setTodo(t);
        }

        public void removeTask(Task t) {
            t.setStatus("REMOVED");
            Tasks.Remove(t);
        }

        public void setTodo(Task t) {
            Board.Todo.Add(t);
            t.setStatus("TODO");
        }

        public void setInProgress(Task t) {
            Board.Todo.Remove(t);
            Board.InProgress.Add(t);
            t.setStatus("IN_PROGRESS");
        }

        public void setDone(Task t) {
            Board.InProgress.Remove(t);
            Board.Done.Add(t);
            t.setStatus("DONE");

            if (t.Tester != null) {
                t.Tester.testFeature(t);
            }
        }

        public int getInvestedTime() {
            int time = 0;
            foreach (Task t in Tasks) {
                time += t.getTime();
            }

            return time;
        }

        public int getFullEST() {
            int est = 0;
            foreach (Task t in Tasks) {
                est += t.getEST();
            }

            return est;
        }

        public int getRemainingEST() {
            int est = 0;
            foreach (Task t in Tasks) {
                if (!Board.Done.Contains(t)) {
                    if (t.getStatus() != "DONE") {
                        est += Math.Max(0, (t.getEST() - t.getTime()));
                    }
                }
            }

            return est;
        }
    }
}
