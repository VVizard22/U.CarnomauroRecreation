using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace Carnomauro.Utils
{
    public class RotateTowards : MonoBehaviour
    {
        public bool UseReference = true;
        public Transform TransformReference;
        public Vector3Variable Variable;

        public Vector3 Value
        {
            get { return UseReference ? 
                    TransformReference.position : Variable.GetVector3(); }
        }

        private void Update()
        {
            UpdateRotation();
        }

        void UpdateRotation()
        {
            Vector3 target = Value;
            target.z = 0f;

            target.x -= transform.position.x;
            target.y -= transform.position.y;

            float angle = Mathf.Atan2(target.y,target.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));
        }
    }
}