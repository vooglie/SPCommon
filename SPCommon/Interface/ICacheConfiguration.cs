﻿namespace SPCommon.Interface
{
    public interface ICacheConfiguration
    {
        string Key { get; set; }
        object Query { get; set; }
        int SingleItemId { get; set; }
        object Context { get; set; } // This is usually the SPWeb object
        string ListName { get; set; }
    }
}
