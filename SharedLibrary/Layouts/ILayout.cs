using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SharedLibrary
{
    public interface ILayout
    {
        public byte[] Parse(Match match);
    }
}
