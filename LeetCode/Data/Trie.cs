using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Data
{
    class Trie
    {
        private class TrieNode
        {
            public TrieNode[] children = new TrieNode[26];
            public bool isWord = false;
        }

        private TrieNode root;

        public Trie()
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

            pointer.isWord = true;
        }

        //public void Delete(string word)
        //{
        //    TrieNode pointer = root;

        //    foreach (char c in word)
        //    {
        //        if (pointer.children[c - 'a'] == null)
        //        {
        //            return;
        //        }
        //        pointer = pointer.children[c - 'a'];
        //    }


        //}

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

            return pointer.isWord;
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
