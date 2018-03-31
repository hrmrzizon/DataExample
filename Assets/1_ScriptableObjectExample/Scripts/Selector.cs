namespace Example.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [RequireComponent(typeof(Mover))]
    public class Selector : MonoBehaviour
    {
        public bool selectAbsoluteWhenStart;

        public AbsoluteRoad absolute;
        public RelativeRoad relative;

        [ContextMenu("Absolute", false, 1000)]
        public void SetAbsoluteRoad()
        {
            GetComponent<Mover>().positions = absolute;
        }
        [ContextMenu("Relative", false, 1001)]
        public void SetRelativeRoad()
        {
            GetComponent<Mover>().positions = relative;
        }

        private void Awake()
        {
            if (selectAbsoluteWhenStart)
                SetAbsoluteRoad();
            else
                SetRelativeRoad();
        }
    }
}