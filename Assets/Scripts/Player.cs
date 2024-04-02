using UnityEngine;

namespace Shmup
{
    public class Player : Plane {
        [SerializeField] float maxFuel;
        [SerializeField] float fuelConsumptionRate;
        float fuel;

        public float GetFuelNormalized() => 1 - (fuel/maxFuel);
        void Update() {
            fuel -= fuelConsumptionRate * Time.deltaTime;
        }
        protected override void Die()
        {
            //Implement
        }
    }
}
