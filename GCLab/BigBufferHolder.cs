﻿using System.Runtime.Caching;

namespace GCLab;

// =====================================================
// 2) LOH + cache estático sem política de expiração
// =====================================================
static class BigBufferHolder
{

    public static byte[] Run()
    {        
        var data = new byte[200_000]; // ~200KB → LOH
        //GlobalCache.Add(data);
        MemoryCache cache = new MemoryCache(new MemoryCacheOptions());


        return data;
    }
}
