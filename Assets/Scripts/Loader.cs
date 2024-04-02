using System.Collections.Generic;
using Eflatun.SceneReference;
using MEC;
using UnityEngine.SceneManagement;

namespace Shmup {
    public static class Loader {
        static SceneReference targetScene;

        public static void Load(SceneReference scene) {
            targetScene = scene;
            SceneManager.LoadScene("Loading");
            Timing.RunCoroutine(LoadTargetScene());
        }

        static IEnumerator<float>LoadTargetScene() {
            yield return Timing.WaitForOneFrame;
            SceneManager.LoadScene(targetScene.Name);
        }
    }
}