using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Shmup
{
    public class BossStage : MonoBehaviour
    {
        public List<Enemy> enemySystems;
        public bool IsBossInvulnerable = true;

        void Start() {
            foreach (var system in enemySystems) {
                //system.gameObject.SetActive(false);
            }
        }
        public void InitializeStage() {

            foreach (var system in enemySystems) {
                if (system.gameObject != null)
                {
                    system.gameObject.SetActive(true);
                }
            }            
        }
        public bool IsStageComplete() {
            return enemySystems.All(system => system == null || !(system.GetHealthNormalized() > 0));
        }

    }
}
