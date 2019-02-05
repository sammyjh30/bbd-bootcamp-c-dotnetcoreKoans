using System;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
    public class PathToEnlightenment : Path
    {
        public PathToEnlightenment()
        {
            Types = new Type[] {
				typeof(AboutAsserts),
				typeof(AboutNull),
				typeof(AboutArrays),
				typeof(AboutArrayAssignment),
				typeof(AboutStrings),
				typeof(AboutControlStatements),
                typeof(AboutGenericContainers),
				typeof(AboutFloats),
                typeof(AboutMethods),
				typeof(AboutClassesAndStructs),
				typeof(AboutProperties),
				typeof(AboutInheritance),
				typeof(AboutBitwiseAndShiftOperator),
                typeof(AboutDelegates),
                typeof(AboutLambdas)
                };
        } 
    }
}