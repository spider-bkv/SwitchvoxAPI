﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchvoxAPI
{
    public partial class CallLogs
    {
        private readonly SwitchvoxRequest request;

        internal CallLogs(SwitchvoxRequest request)
        {
            this.request = request;
        }
    }
}