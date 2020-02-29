using System;

namespace IAmHere.Blazor.Helpers
{
    public static class CollectionsExtensions
    {
        public static void Do(this int n, Action action)
        {
            var intAction = new Action<int>(i => action());
            n.Do(intAction);
        }

        public static void Do(this int n, Action<int> action)
        {
            for (int i = 0; i < n; i++)
            {
                action(i);
            }
        }
    }
}