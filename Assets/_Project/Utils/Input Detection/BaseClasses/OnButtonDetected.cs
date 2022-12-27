using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Carnomauro.Utils
{
    [CreateAssetMenu]
    public class OnButtonDetected : OnInputDetected
    {
        protected override void LinkActions()
        {
            _action.performed += PerformActions;
            _action.canceled += PerformActions;
        }

        protected override void UnlinkActions()
        {
            _action.performed -= PerformActions;
            _action.canceled -= PerformActions;
        }

        public override void PerformActions(InputAction.CallbackContext test)
        {
            _eventToRaise.Raise();
        }
    }
}