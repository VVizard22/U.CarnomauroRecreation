using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RoboRyanTron.Unite2017.Events;

namespace Carnomauro.Utils
{
    public abstract class OnInputDetected : ScriptableObject
    {
        public InputAction _action;
        [SerializeField] protected GameEvent _eventToRaise;

        private void OnEnable()
        {
            _action.Enable();
            LinkActions();
        }
        private void OnDisable()
        {
            _action.Disable();
            UnlinkActions();
        }

        protected virtual void LinkActions() => _action.performed += PerformActions;
        protected virtual void UnlinkActions() => _action.performed -= PerformActions;

        public abstract void PerformActions(InputAction.CallbackContext test);
    }
}