using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordFinder
{
    public class WordFinder
    {
        private IList<string> _rows;
        private IList<string> _cols;
        private Dictionary<string, int> _repeatedWords;
        public WordFinder(IEnumerable<string> matrix)
        {
            _cols = new List<string>(matrix.Count());
            _rows = new List<string>(matrix);
            _repeatedWords = new Dictionary<string, int>();
            FillColumns();
        }

        private void FillColumns()
        {
            for(int i = 0; i< _rows.Count; i++)
            {
                var column = new StringBuilder();
                for(int j = 0; j < _rows[i].Length; j++)
                {
                    column.Append(_rows[j][i]);
                }
                _cols.Add(column.ToString());
            }
        }

        public IEnumerable<string> Find(IEnumerable<string> wordsStream)
        {
            _repeatedWords.Clear();
            Dictionary<string, int> repeatedWords = new Dictionary<string, int>();
            foreach(string wordToFind in wordsStream)
            {
                foreach(string row in _rows)
                {
                    if (row.IndexOf(wordToFind) != -1)
                    {
                        CheckRepeatedWord(wordToFind);
                    }
                }
                foreach(string col in _cols)
                {
                    int occurrences = Regex.Matches(col, $"{wordToFind}").Count;
                    if (occurrences > 0)
                    {
                        CheckRepeatedWord(wordToFind, occurrences);
                    }
                }
            }
            return _repeatedWords.OrderByDescending(x => x.Value).ThenBy( x => x.Key).ToList().Select( w => w.Key).Take(10);
        }

        private void CheckRepeatedWord(string word, int duplicates = 1)
        {
            if (_repeatedWords.ContainsKey(word))
            {
                _repeatedWords[word] = _repeatedWords[word] + duplicates;
            }
            else
            {
                _repeatedWords.Add(word, 1);
            }
        }
    }
}
