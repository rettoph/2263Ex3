using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) write a function that accepts 2 strings s1 and s2 and returns true IFF (if and only if) 
    /// all the characters s1 are in s2 and all the characters in s2 are in s1. 
    /// Note this function may return true even if s1 is not identical to s2 or even 
    /// if they are not of the same length.
    /// </summary>
    public static class Task5
    {
        public static bool CompareStringChars(string s1, string s2)
        {
            foreach(char c in s1)
            {
                if(s2.Contains(c) == false)
                {
                    return false;
                }
            }

            foreach (char c in s2)
            {
                if (s1.Contains(c) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
