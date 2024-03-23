using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonUi : MonoBehaviour
{
    private string newGameLevel = "Prototype";
    // Start is called before the first frame update
    public void NewGameButton() {
        SceneManager.LoadScene(newGameLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
