using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RoboRyanTron.Unite2017.Variables;


namespace Carnomauro.Bait
{
    public class BaitBehaviour : MonoBehaviour
    {
        [SerializeField] FloatReference _directionValue;
        [SerializeField] FloatReference _speedValue;
        Transform _transform;

        private void Awake()
        {
            _transform = transform;
        }

        private void FixedUpdate()
        {
            if (_directionValue.Value == 0)
                return;

            Vector3 position = _transform.position;

            float yPosition = position.y;

            yPosition += _directionValue * _speedValue.Value * Time.deltaTime; ;

            position.y = yPosition;
            _transform.position = position;
        }
    }
}