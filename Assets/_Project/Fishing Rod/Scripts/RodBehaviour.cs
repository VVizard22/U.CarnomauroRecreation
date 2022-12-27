using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;


namespace Carnomauro.Rod
{
    public class RodBehaviour : MonoBehaviour
    {
        /*
         * This script calculates the movement amount
         * of the handgrip.
         */
        [SerializeField] FloatVariable _movementAmount;


        [Header("References for calculating the movement amount")]
        [SerializeField] Transform _reel;
        [SerializeField] Transform _handGrip;

        private Vector2 _lastPosition;

        [SerializeField] BoolVariable _shouldRodWork;

        [SerializeField] FloatVariable _movement;


        private void Update()
        {
            if (!_shouldRodWork.Value)
            {
                _movement.SetValue(0);
                return;
            }

            CalculateDirection(_handGrip.GetComponent<HandgripPositioning>().GetDirectionVector());
        }

        public void CalculateDirection(Vector2 directionVector)
        {
            Vector2 _actualPosition = _handGrip.position;


            if (_actualPosition != _lastPosition)
            {
                if (directionVector.x < 0 && directionVector.y < 0)
                {
                    //Debug.Log("Cuadrante 1");
                    if (_lastPosition.y < _actualPosition.y)
                        _movement.SetValue(-1);
                    else
                        _movement.SetValue(1);
                } else if (directionVector.x > 0 && directionVector.y < 0)
                {
                    //Debug.Log("Cuadrante 2");
                    if (_lastPosition.y > _actualPosition.y)
                        _movement.SetValue(-1);
                    else
                        _movement.SetValue(1);
                } else if (directionVector.x > 0 && directionVector.y > 0)
                {
                    //Debug.Log("Cuadrante 3");
                    if (_lastPosition.y > _actualPosition.y)
                        _movement.SetValue(-1);
                    else
                        _movement.SetValue(1);
                } else if (directionVector.x < 0 && directionVector.y > 0)
                {
                    //Debug.Log("Cuadrante 4");
                    if (_lastPosition.y < _actualPosition.y)
                        _movement.SetValue(-1);
                    else
                        _movement.SetValue(1);
                }
            } else
                _movement.SetValue(0);
            _lastPosition = _actualPosition;
        }

    }
}
