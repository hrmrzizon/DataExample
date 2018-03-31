namespace Example.Serializatoin.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [ExecuteInEditMode]
    public class TestBehaviour : MonoBehaviour
    {
        public float data;

        [SerializeField]
        public Vector4 data2;

        [HideInInspector]
        public Color data3;

        [SerializeField]
        [HideInInspector]
        public AnimationCurve data4;

        [NonSerialized]
        public int data5;

        public GameObject data6;
        public GameObject data7;

        [HideInInspector]
        private Color data8;

        private void OnEnable()
        {
            if (data7 != null)
            {
                if (Application.isPlaying)
                    Destroy(data7);
                else
                {
                    DestroyImmediate(data7);
                }
            }

            if (data6 != null)
                data7 = (GameObject)Instantiate(data6);
        }

        private void OnDisable()
        {
            if (data7 != null)
            {
                if (Application.isPlaying)
                    Destroy(data7);
                else
                    DestroyImmediate(data7);                    
            }
        }
    }
}
