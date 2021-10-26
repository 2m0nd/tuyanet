﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.clusterrr.TuyaNet
{
    public class TuyaResponse
    {
        public TuyaCommand Command { get; }
        public int ReturnCode { get; }
        public string JSON { get; }

        internal TuyaResponse(TuyaCommand command, int returnCode, string json)
        {
            Command = command;
            ReturnCode = returnCode;
            JSON = json;
        }

        public override string ToString() => $"{Command}: {JSON} (return code = {ReturnCode})";
    }
}
