using System;
using System.Collections.Generic;
using System.Text;

namespace CalcConsole
{
    public class Names
    {
        public string NickName { get; set; }
        public string GetFullName(string firstName, string lastName) {
            return $"Sr {firstName} {lastName}";
        }
    }
}
