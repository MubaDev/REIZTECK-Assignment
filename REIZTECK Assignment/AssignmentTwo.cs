using System;
using System.Collections.Generic;
using System.Text;

namespace REIZTECK_Assignment
{
    class AssignmentTwo
    {
        public static void taskTwo()
        {
            Branch root = newBranch("Item 1");
            (root.branches).Add(newBranch("Item 1.1"));
            (root.branches).Add(newBranch("Item 1.2"));
            (root.branches[0].branches).Add(newBranch("Item 1.1.1"));
            (root.branches[1].branches).Add(newBranch("Item 1.2.1"));
            (root.branches[1].branches).Add(newBranch("Item 1.2.2"));
            (root.branches[1].branches).Add(newBranch("Item 1.2.3"));
            (root.branches[1].branches[0].branches).Add(newBranch("Item 1.2.1.1"));
            (root.branches[1].branches[1].branches).Add(newBranch("Item 1.2.2.1"));
            (root.branches[1].branches[1].branches).Add(newBranch("Item 1.2.2.2"));
            (root.branches[1].branches[1].branches[0].branches).Add(newBranch("Item 1.2.2.1.1"));

            Console.Write("The Depth of a given structure is : " + depthCounter(root) + "\n");
        }
        public class Branch
        {
            public string Item;
            public List<Branch> branches;
        }
        public static Branch newBranch(String Item)
        {
            Branch temp = new Branch();
            temp.Item = Item;
            temp.branches = new List<Branch>();
            return temp;
        }
        static int depthCounter(Branch subBranch)
        {
            if (subBranch == null)
                return 0;

            //reset the depth for in sub branches
            int depth = 0;

            //to loop or check the leaf branches and calculate the maximum depth
            foreach (Branch item in subBranch.branches)
            {
                depth = Math.Max(depth, depthCounter(item));
            }

            return depth + 1;
        }

    }
}
