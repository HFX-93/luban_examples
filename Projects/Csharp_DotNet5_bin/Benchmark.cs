﻿using Bright.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;




class CacheLoader
{
    public string Dir { get; }


    private readonly Dictionary<string, byte[]> cache = new();

    public CacheLoader(string dir)
    {
        Dir = dir;
    }

    public ByteBuf LoadOrFromCache(string name)
    {
        if (!cache.TryGetValue(name, out byte[] result))
        {
            result = File.ReadAllBytes($"{Dir}/{name}.bin");
            cache.Add(name, result);
        }
        return new ByteBuf(result);
    }
}

internal class Benchmark
{
    public static void Run(string dir)
    {
        var loader = new CacheLoader(dir);

        var tables = new List<cfg.Tables>();
        for (int k = 0; k < 10; k++)
        {
            var w = new Stopwatch();
            w.Start();
            for (int i = 0; i < 100; i++)
            {
                tables.Add(new cfg.Tables(loader.LoadOrFromCache));
            }
            w.Stop();
            Console.WriteLine("== cost {0} ms", w.ElapsedMilliseconds);
        }
    }

}

