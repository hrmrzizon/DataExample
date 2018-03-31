namespace Example.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public interface IPositions
    {
        Vector3 this[int index] { get; }
        int Length { get; }
    }
}