using System.Collections;
using RoboRyanTron.Unite2017.Events;
using UnityEngine;

namespace Carnomauro.Utils
{
    public abstract class RaiseOnSomething : MonoBehaviour
    {
        [SerializeField]protected GameEvent _eventToRaise;
    }
}