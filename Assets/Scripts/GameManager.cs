using UnityEngine;

namespace Shmup
{
    public class GameManager : MonoBehaviour {
        public static GameManager Instance {get; private set;}
        //public Player Player => player; 
        Player player;
        int score;

        public bool IsGameOver() => player.GetHealthNormalized() <= 0 || player.GetFuelNormalized() <= 0;
        void Awake() {
            if (Instance == null) {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else {
                Destroy(gameObject);
            }

            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }

        public void AddScore(int amount) => score += amount;
        public int GetScore() => score; 
    }
}
