using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc208
    {
        private const int ALPHABET_SIZE = 26;
        private class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
            public bool isWordOrNot = false;
        }

        private TrieNode root;

        public lc208()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode pointer = root;

            foreach (char c in word)
            {
                if (pointer.children[c - 'a'] == null)
                {
                    pointer.children[c - 'a'] = new TrieNode();
                }
                pointer = pointer.children[c - 'a'];
            }

            pointer.isWordOrNot = true;
        }

        public bool Search(string word)
        {
            TrieNode pointer = root;

            foreach (char c in word)
            {
                if (pointer.children[c - 'a'] == null)
                {
                    return false;
                }
                pointer = pointer.children[c - 'a'];
            }

            return pointer.isWordOrNot;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode pointer = root;

            foreach (char c in prefix)
            {
                if (pointer.children[c - 'a'] == null)
                {
                    return false;
                }
                pointer = pointer.children[c - 'a'];
            }

            return true;
        }
    }
}
