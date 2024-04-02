using UnityEngine;

namespace Shmup
{
    public abstract class Plane : MonoBehaviour {
        [SerializeField] int maxHealth;
        int health;

        protected virtual void Awake() => health = maxHealth;

        public void SetMaxHealth(int amount) => maxHealth = amount;
        public void TakeDamage(int amount) {
            if (health <= 0) {
                Die();
            }
        }

        public float GetHealthNormalized() => 1 - (health / maxHealth);
        protected abstract void Die();
    }
}
