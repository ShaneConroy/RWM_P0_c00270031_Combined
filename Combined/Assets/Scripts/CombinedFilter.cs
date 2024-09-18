using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter : MonoBehaviour
{
    public static int[] combined_filter(int[] input)
    {
        int[] var = RunningTotal.running_total(input);

        int[] var2 = Fact.fact(var);

        return var2;

    }
}
