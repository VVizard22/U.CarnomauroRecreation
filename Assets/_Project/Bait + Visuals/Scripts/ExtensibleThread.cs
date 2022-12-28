using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Carnomauro.Bait
{
    public class ExtensibleThread : MonoBehaviour
    {
        [SerializeField] Transform _point;
        [SerializeField] LineRenderer _lineRenderer;
        Vector3 _pointPosition;
        float _lineLength;

        float _originalDistance;
        float _currentDistance;
        float _originalLengthValue;
        private void Awake()
        {
            _pointPosition = _point.position;
            _originalLengthValue = _lineRenderer.GetPosition(1).y;
            _originalDistance = Vector3.Distance(_pointPosition, transform.position);
        }

        // Update is called once per frame
        void Update()
        {
            _pointPosition = _point.position;
            _currentDistance = Vector3.Distance(transform.position,_pointPosition);
            Vector3 distanceVector = Vector3.zero;


            /*
             * Regla de 3 simple para obtener el valor del punto nuevo para renderizar
             * la linea
             * 
             *  Distancia Original -> Valor X en el LineRenderer
             *  Distancia nueva -> Valor Y en el LineRenderer
             */
            distanceVector.y = (_originalLengthValue * _currentDistance) / _originalDistance;
            _lineRenderer.SetPosition(1, distanceVector);
        }
    }
}