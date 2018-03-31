namespace Example.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Mover : MonoBehaviour
    {
        public IPositions positions;

        public float progress;
        public float speed = 1f;

        private void OnEnable()
        {
            progress = 0f;
        }

        private void Update()
        {
            if (positions == null) return;

            int posLength = positions.Length;
            int progressNum = Mathf.FloorToInt(progress);
            float progressFract = progress - progressNum;

            progressFract += Time.deltaTime * speed;

            progressNum = (progressNum + Mathf.FloorToInt(progressFract)) % posLength;
            progressFract -= Mathf.FloorToInt(progressFract);  

            progress = progressNum + progressFract;

            transform.position = Vector3.Lerp(positions[progressNum], positions[(progressNum + 1) % posLength], progressFract);
        }
    }
}