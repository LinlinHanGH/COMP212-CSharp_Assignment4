using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    // class to represent one node in a list
    public class ListNode
    {
        // automatic read-only property Data
        public double Data { get; private set; }
        public string StrData { get; private set; }

        // automatic property Next
        public ListNode Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(double dataValue) : this(dataValue, null) { }

        public ListNode(string dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(double dataValue, ListNode nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }

        public ListNode(string dataValue, ListNode nextNode)
        {
            StrData = dataValue;
            Next = nextNode;
        }


    }
}
