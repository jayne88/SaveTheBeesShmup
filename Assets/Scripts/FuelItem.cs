using UnityEngine;

namespace Shmup
{
    public class FuelItem : Item {
        void OnTriggerEnter(Collider other) {
            if (other.GetComponent<Player>() != null)
            {
                other.GetComponent<Player>().AddFuel(amount);
                Destroy(gameObject);
            }
        }
    }
}
