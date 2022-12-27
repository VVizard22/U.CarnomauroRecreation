using UnityEngine;

namespace Carnomauro.Utils
{
    public class OnMouseEnterCollider : RaiseOnSomething
    {

        private void OnMouseEnter() => _eventToRaise?.Raise();

        private void OnMouseExit() => _eventToRaise?.Raise();
    }
}
