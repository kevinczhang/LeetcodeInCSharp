using System.Collections.Generic;

namespace LeetcodeInCSharp.Medium.GraphProblems.CourseSchedule
{
    public class Solution1
    {
        public bool CanFinish(int numCourses, int[,] prerequisites)
        {
            if (prerequisites == null || prerequisites.Length == 0) return true;

            // Construct graph using dictionary
            Dictionary<int, List<int>> courseMap = new Dictionary<int, List<int>>();
            int[] courseNeedPre = new int[numCourses];
            for(int i= 0; i<prerequisites.GetLength(0); i++)
            {
                courseNeedPre[prerequisites[i, 0]]++;
                if (courseMap.ContainsKey(prerequisites[i, 1]))
                    courseMap[prerequisites[i, 1]].Add(prerequisites[i, 0]);
                else
                {
                    List<int> prereqs = new List<int>();
                    prereqs.Add(prerequisites[i, 0]);
                    courseMap.Add(prerequisites[i, 1], prereqs);
                }
            }

            // Find courses without prerequistites
            Queue<int> courseCanTake = new Queue<int>();
            for(int i=0; i<numCourses; i++)
            {
                if (courseNeedPre[i] == 0)
                    courseCanTake.Enqueue(i);
            }

            // If all courses require prerequisites return false
            if (courseCanTake.Count == 0) return false;
            // If no course requires prerequisites return false
            if (courseCanTake.Count == numCourses) return true;

            // Use DFS to detect cycle
            HashSet<int> visited = new HashSet<int>();
            while(courseCanTake.Count > 0)
            {
                int curCourse = courseCanTake.Dequeue();                
                if (courseMap.ContainsKey(curCourse))
                {
                    foreach (int nb in courseMap[curCourse])
                    {
                        if (visited.Contains(nb) && courseMap.ContainsKey(nb)) return false;
                        courseNeedPre[nb]--;
                        if (courseNeedPre[nb] == 0)
                            courseCanTake.Enqueue(nb);
                    }
                }
                visited.Add(curCourse);
            }
            return visited.Count == numCourses;
        }
    }
}
