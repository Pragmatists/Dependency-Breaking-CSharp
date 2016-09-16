using System.Collections.Generic;
using System.Threading;

namespace DependencyBreakingExamples.IntroduceStaticSetter
{
    public class Permissions
    {
        private static readonly ThreadLocal<List<string>> permissions =
            new ThreadLocal<List<string>>(() => new List<string>());


        public static bool HasPermission(string permission)
        {
            return permissions.Value.Contains(permission);
        }
    }
}