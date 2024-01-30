using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine2
{
    public class EdvarsQuest
    {
        
            public Quest Details { get; set; }
            public bool IsCompleted { get; set; }
            public EdvarsQuest(Quest details)
            {
                Details = details;
                IsCompleted = false;
            }
        


    }
}
