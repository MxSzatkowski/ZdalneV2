﻿using ExecFile;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Wrapper;
using System;

namespace Test
{
    public class Exec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wynik wrapera z dll import");

            var tets = new ExecWrapper();
            tets.UseWrapperMethod();
            Console.WriteLine("");
        }
    }
}