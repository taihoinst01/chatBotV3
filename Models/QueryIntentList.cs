﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chatBotV3.Models
{
    [Serializable]
    public class QueryIntentList
    {
        public string luisId;
        public string luisIntent;
        public int dlgId;
    }
}
