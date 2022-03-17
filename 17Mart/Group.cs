using System;
using System.Collections.Generic;
using System.Text;

namespace _17Mart
{
    internal class Group
    {
        private string _groupno;
        private int _studentLimit;
        public string GroupNo
        {
            get { return this._groupno; }
            set 
            {
                if (CheckCondition(value))
                {
                    this._groupno = value;
                }
            }
        }
        public int StudentLimit
        {
            get { return this._studentLimit; }
            set 
            {
                if (value >= 0)
                {
                    this._studentLimit = value;
                }
            }
        }
        public bool CheckCondition(string text)
        {
            if(!string.IsNullOrWhiteSpace(text) && text.Length==5 && char.IsUpper(text[0]) && char.IsUpper(text[1]) && char.IsDigit(text[2]) && char.IsDigit(text[3]) && char.IsDigit(text[4]))
            {
                return true;
            }
            return false;
        }
    }
    
}
