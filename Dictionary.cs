using System;
using System.Collections.Generic;

namespace Dict
{
    public class Codex
    {
        Dictionary<string, string> codex = new();

        public Codex()
        {
            codex = new Dictionary<string, string>();
            codex.Add("one", "uno");
            codex.Add("two", "dos");
            codex.Add("three", "tres");

            foreach (var (key, value) in codex)
            {
                Console.WriteLine($"{key}: {value}");
            }
        }
    }
}