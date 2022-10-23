using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //go to the next scene in queue (build settings)
    }

    public void SceneBack()
    {
        Debug.Log("He's alive!");
        SceneManager.LoadScene(0); //go to the last scene in queue (build settings)
    }
}
