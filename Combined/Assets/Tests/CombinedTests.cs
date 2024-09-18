using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CombinedTests
{
    [Test]
    public void CombinedTestsSimplePasses()
    {
        int[] input = { 1, 2, 1, 1, 2 };
        int[] output = CombinedFilter.combined_filter(input);
        int[] excpected = { 1, 6, 24, 120, 5040 };


    }


}
