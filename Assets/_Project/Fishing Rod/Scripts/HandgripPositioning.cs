using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;

namespace Carnomauro.Rod
{
    public class HandgripPositioning : MonoBehaviour
    {
        [SerializeField] BoolVariable _shouldWork;
        [SerializeField] Vector3Variable _mousePosition;
        [SerializeField] Transform _reelTransform;

        Vector2 _directionVector;
        Vector2 _centerPosition;
        Vector3 _lastPosition;
        float _distanceToCenter;

        private void Awake()
        {
            _centerPosition = _reelTransform.localPosition;

            _lastPosition = transform.localPosition;
            _distanceToCenter = Vector2.Distance(_centerPosition,_lastPosition);
        }

        private void Update()
        {
            if (!_shouldWork.Value)
                return;
            Vector3 _realMousePos = _mousePosition.GetVector3();
            Vector2 _worldMousePos = Camera.main.ScreenToWorldPoint(_realMousePos);

            _directionVector = _centerPosition - _worldMousePos;
            _directionVector.Normalize();

            transform.localPosition = _centerPosition - _directionVector * _distanceToCenter;

        }

        public Vector2 GetDirectionVector() => _directionVector;
    }
}