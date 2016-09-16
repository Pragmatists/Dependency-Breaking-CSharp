using System;

namespace DependencyBreakingExamples.IntroduceInstanceDelegator
{
    public class User
    {
        public DateTime DeactivatedAt { get; private set; }
        public bool Active { get; private set; }

        public User()
        {
            Active = true;
        }

        public void Deactivate()
        {
            Active = false;
            DeactivatedAt = DateTime.Now;
        }
    }
}