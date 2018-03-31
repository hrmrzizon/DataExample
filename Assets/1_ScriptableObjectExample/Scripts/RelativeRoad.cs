namespace Example.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class RelativeRoad : MonoBehaviour, IPositions
    {
        public Transform[] transforms;

        public Vector3 this[int index]
        {
            get { return transforms[index].localPosition; }
        }

        public int Length { get { return transforms.Length; } }
    }
}