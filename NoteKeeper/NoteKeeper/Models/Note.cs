﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NoteKeeper.Models
{
    public class Note
    {
        public String Id { get; set; }
        public String Heading { get; set; }
        public String Text { get; set; }
        public String Course { get; set; }
    }
}
