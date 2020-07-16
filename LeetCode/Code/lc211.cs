using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc211
    {
        private class TrieNode
        {
            public TrieNode[] children = new TrieNode[26];
            public bool isWord = false;
            char c;

            public TrieNode() { }
            public TrieNode(char c)
            {
                this.c = c;
            }
        }

        private TrieNode root;
        private int[] nouse;
        /** Initialize your data structure here. */
        public lc211()
        {
            nouse = new int[8 * 1000 * 1000 * 100];
            root = new TrieNode();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return;

            TrieNode pointer = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (pointer.children[word[i] - 'a'] == null)
                    pointer.children[word[i] - 'a'] = new TrieNode(word[i]);
                pointer = pointer.children[word[i] - 'a'];
            }

            pointer.isWord = true;
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return helper(0, word, root);
        }

        private bool helper(int index, string word, TrieNode pointer)
        {
            if (index == word.Length)
                return pointer.isWord;

            char curC = word[index];

            if (curC != '.')
            {
                if (pointer.children[curC - 'a'] != null)
                {
                    return helper(index + 1, word, pointer.children[curC - 'a']);
                }
                else
                {
                    return false;
                }
            }

            if (curC == '.')
            {
                for (int i = 0; i < pointer.children.Length; i++)
                {
                    if (pointer.children[i] != null && helper(index + 1, word, pointer.children[i]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
