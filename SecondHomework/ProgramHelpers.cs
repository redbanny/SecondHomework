using System.Collections;
using System.Collections.Generic;

namespace SecondHomework
{
    internal static class ProgramHelpers
    {
        private static List<int> lisik = new List<int>();
        private static ArrayList arrayList = new ArrayList();
        private static LinkedList<int> linkList = new LinkedList<int>();

        public static List<int> Lisik { get => lisik; set => lisik = value; }
        public static ArrayList ArrayList { get => arrayList; set => arrayList = value; }
        public static LinkedList<int> LinkList { get => linkList; set => linkList = value; }
    }
}