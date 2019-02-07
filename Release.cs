using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject {
    class Release {
        public Sprint Sprint = new Sprint();
        List<String> Epics = new List<String>();

        public Release(int id) {

        }

        public void addTask(Task t) {
            Sprint.addTask(t);
        }

        public void removeTask(Task t) {
            Sprint.removeTask(t);
        }

        public void addEpic(String epic) {
            Epics.Add(epic);
        }

        public int getInvestedTime() {
            return Sprint.getInvestedTime();
        }

        public int getFullEST() {
            return Sprint.getFullEST();
        }

        public int getRemainingEST() {
            return Sprint.getRemainingEST();
        }

        public String getRemainingTimeFormat() {
            int seconds = getRemainingEST();
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int days = hours / 24;
            hours = hours % 24;

            return "Rlease Datum: " + days + " Tag(e), " + hours + " Stunden, " + minutes + " Minuten";
        }

        public void setTodo(Task t) {
            Sprint.setTodo(t);
        }

        public void setInProgress(Task t) {
            Sprint.setInProgress(t);
        }

        public void setDone(Task t) {
            Sprint.setDone(t);
        }
    }
}
