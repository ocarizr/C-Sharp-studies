using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourTest
{
    class Task1
    {
        public string solution(string S)
        {
            var i = 0;
            var j = S.Length - 1;

            var s = new StringBuilder(S);

            for (; i <= j; ++i, --j)
            {
                if (s[i] != s[j] && (s[i] != '?' && s[j] != '?')) return "NO";

                if (s[i] != '?' && s[j] != '?') continue;
                else if (s[i] != '?' && s[j] == '?') s[j] = s[i];
                else if (s[i] == '?' && s[j] != '?') s[i] = s[j];
                else
                {
                    s[i] = s[j] = 'a';
                }
            }

            return s.ToString();
        }
    }
}
