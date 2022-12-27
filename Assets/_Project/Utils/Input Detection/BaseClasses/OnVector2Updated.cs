using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RoboRyanTron.Unite2017.Variables;

namespace Carnomauro.Utils
{
    [CreateAssetMenu]
    public class OnVector2Updated : OnInputDetected
    {
        [SerializeField] FloatReference x;
        [SerializeField] FloatReference y;


        public override void PerformActions(InputAction.CallbackContext test)
        {
            Vector2 current = test.ReadValue<Vector2>();
            x.Variable.Value = current.x;
            y.Variable.Value = current.y;
        }

    }


}