using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NewYearPresent.Sweets;

namespace NewYearPresent.CandyContainer
{
    public class CandyBox : CandyContainerBase
    {
        public CandyBox(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}