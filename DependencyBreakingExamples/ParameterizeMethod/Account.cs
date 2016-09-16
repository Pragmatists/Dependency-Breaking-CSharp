using System;

namespace DependencyBreakingExamples.ParameterizeMethod
{
    public class Account
    {
        public void Deactivate()
        {

            IsActive = false;
            DeactivatedAt = DateTime.Now;

            // ...
        }

        public DateTime DeactivatedAt { get; private set; }

        public bool IsActive { get; private set; } = true;
    }
}
