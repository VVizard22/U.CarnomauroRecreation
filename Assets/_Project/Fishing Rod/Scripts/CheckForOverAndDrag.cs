using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace Carnomauro.Rod
{
    public class CheckForOverAndDrag : MonoBehaviour
    {
        [SerializeField] BoolVariable _shouldWork;

        bool _isDragging;
        bool _mouseOver;
        bool _hasToReset = false;

        public void OnMouseEnterUpdate()
        {
            _mouseOver = !_mouseOver;

            if (!_mouseOver && _isDragging)
            {
                _hasToReset = true;
                _mouseOver = true;
            }

            CheckDefinitive();
        }

        public void OnMouseStartDragging()
        {
            _isDragging = !_isDragging;

            if (!_isDragging && _hasToReset)
            {
                _hasToReset = false;
                _mouseOver = false;
            }
            CheckDefinitive();
        }

        public void CheckDefinitive() =>
            _shouldWork.SetValue(_mouseOver && _isDragging);
    }
}