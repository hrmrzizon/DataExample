namespace Example.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu]
    public class AbsoluteRoad : ScriptableObject, IPositions
    {
        public Vector3[] absolutePositions;

        public Vector3 this[int index]
        {
            get { return absolutePositions[index]; }
        }
        public int Length
        {
            get { return absolutePositions.Length; }
        }
    }
}
