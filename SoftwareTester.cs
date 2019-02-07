using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProject
{
    class SoftwareTester : Developer {
        public void testFeature(Task t) {
            if (isFeatureAcceptable(t)) {
                // feature acceptable and done
            } else {
                // move to backlog
                TeamLeader.UserStory story = t.getStory();
                Team.getRelease(story.release).removeTask(t);
                Team.Leader.refactorUserStory(story, "Random notice from tester");
            }
        }

        public bool isFeatureAcceptable(Task t) {
            // methods to check when feature is acceptable
            return true;
        }
    }
}
