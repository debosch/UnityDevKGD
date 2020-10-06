using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI {
    public class Preloader : MonoBehaviour {
        private void Start() {
            StartCoroutine(LoadMenuScene());
        }

        private IEnumerator LoadMenuScene() {

            var acyncOperation = SceneManager.LoadSceneAsync("Menu");
            while (!acyncOperation.isDone) {
                Debug.Log(acyncOperation.progress);
                yield return null;
            }
            
        }
    }
}

