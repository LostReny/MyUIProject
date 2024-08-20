namespace MyUtilities
{
    using System.Collections.Generic;
    using UnityEngine;
    using Random = UnityEngine.Random;

    public static class MyUtils
    {
        public static T GetRandom<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}