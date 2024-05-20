using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    //eğer içeri giren karakterin tag'ı palyer ise bir sonraki sahneyi yükle 3d oyunlarda kullanılır

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    
}
