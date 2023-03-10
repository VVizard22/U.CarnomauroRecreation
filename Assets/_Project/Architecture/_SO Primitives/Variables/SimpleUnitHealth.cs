// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;
using RoboRyanTron.Unite2017.Events;

namespace RoboRyanTron.Unite2017.Variables
{
    public class SimpleUnitHealth : MonoBehaviour
    {
        public FloatVariable HP;

        public bool ResetHP;

        public FloatReference StartingHP;
        public GameEvent PlayerDamageEvent;

        private void Start()
        {
            if (ResetHP)
                HP.SetValue(StartingHP);
        }

        private void OnTriggerEnter(Collider other)
        {
            DamageDealer damage = other.gameObject.GetComponent<DamageDealer>();
            if (damage != null)
            {
                HP.ApplyChange(-damage.DamageAmount);
                PlayerDamageEvent.Raise();
            }
        }
    }
}