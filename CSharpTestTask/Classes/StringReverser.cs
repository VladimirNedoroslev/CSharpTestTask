using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestTask
{
    static class StringReverser
    {
        static public string Reverse(string s)
        {
            // Run-time complexity - O(n) - в любом случае нужно перебрать всю данную строку для того, чтобы сформировать "перевёрнутую" версию.
            // Space complexity - O(n) - резервируется место под новую строку через StringBuilder размером с данную строку.
            // n - количество символов в строке
            // Сделать алгоритм более эффективным в плане памяти не получится, так как строки в С# неизменяемы.
            // Можно сделать O(1) space complexity, но при это нужно иметь дело с массивом char и "переворот" будет in-place.

            StringBuilder stringBuilder = new StringBuilder(capacity: s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
                stringBuilder.Append(s[i]);

            return stringBuilder.ToString();
        }
    }
}
