using UnityEngine;

namespace Shmup
{
    public class HealthItem : Item
    {
        void OnTriggerEnter(Collider other) {
            if (other.GetComponent<Player>() != null)
            {
                other.GetComponent<Player>().AddHealth((int) amount);
                Destroy(gameObject);
            }
        }
    }
}
