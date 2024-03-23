using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Web;

public class go_to_next_scene : MonoBehaviour
{
    public void PlayScene(string sceneName) {
        
        SceneManager.LoadSceneAsync(sceneName);
        SceneManager.UnloadSceneAsync("beginning_menu");
    }
    
}

