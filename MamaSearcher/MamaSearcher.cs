using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public class MamaSearcher : IMamaSearcher
    {
        private Dictionary<string,Action<int, string>> _mapActionToPreform { get; set; }

        public MamaSearcher()
        {
            _mapActionToPreform = new Dictionary<string, Action<int, string>>();    
        }
        public void PerformSearch(string content)
        {
            foreach (var action in _mapActionToPreform)
            {
                string pattern = action.Key;
                if (content.Contains(pattern)) 
                {
                    int index = content.IndexOf(pattern[0]);
                    action.Value(index,pattern);
                }
            }
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            if (!_mapActionToPreform.ContainsKey(pattern))
            {
                _mapActionToPreform.Add(pattern, actionToPerform);
            }
            else 
            {
                _mapActionToPreform[pattern] += actionToPerform;
            }
        }
    }
}
