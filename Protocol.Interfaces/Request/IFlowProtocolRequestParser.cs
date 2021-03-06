﻿namespace FlowProtocol.Interfaces.Request
{
    using System.Collections.Concurrent;

    public interface IFlowProtocolRequestParser
    {
        ConcurrentDictionary<string, string> ParseRequest(string request);
    }
}