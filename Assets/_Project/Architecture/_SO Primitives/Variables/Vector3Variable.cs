using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RoboRyanTron.Unite2017.Variables
{
    [CreateAssetMenu]
    public class Vector3Variable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public FloatReference[] Value = new FloatReference[3] {
            new FloatReference(),
            new FloatReference(),
            new FloatReference()
        };

        public Vector2 GetVector2()
        {
            return new Vector2(Value[0].Variable.Value, Value[1].Variable.Value);
        }

        public Vector3 GetVector3()
        {

            return new Vector3(Value[0].Value, Value[1].Value, Value[2].Value);
        }
    }
}