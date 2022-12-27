using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Carnomauro.Utils
{
    public class OnMouseEnterUI : RaiseOnSomething, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData) => _eventToRaise?.Raise();
        public void OnPointerExit(PointerEventData eventData) => _eventToRaise?.Raise();
    }
}