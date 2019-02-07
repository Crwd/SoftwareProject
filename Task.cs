using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject {
    class Task {
        public String Title;
        public String Description;
        public String Notice = "";
        public int EST;
        public int Time = 0;
        public SoftwareTester Tester;
        public Release Release;

        public TeamLeader.UserStory Story;

        public String Status = "CREATED";

        public Task(Release r, String title, String desc, int est, String notice = "") {
            Title = title;
            Description = desc;
            EST = est;
            Notice = notice;
            Release = r;
        }

        public void setStory(TeamLeader.UserStory story) {
            Story = story;
        }

        public TeamLeader.UserStory getStory() {
            return Story;
        }

        public void setTester(SoftwareTester t) {
            Tester = t;
        }

        public void setStatus(String s) {
            Status = s;
        }

        public String getStatus() {
            return Status;
        }

        public void setTimeNeeded(int t) {
            Time = t;
        }

        public int getTime() {
            return Time;
        }

        public int getEST() {
            return EST;
        }
    }
}
