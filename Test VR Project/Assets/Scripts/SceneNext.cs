using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    public GameObject blackScreen;
    //public Animator blackAnimator;

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
        blackScreen.SetActive(true);
        StartCoroutine(WaitForBlack());
    }

    public void SceneBack()
    {
       blackScreen.SetActive(true);
       StartCoroutine(SecondSceneToBlack());
    }

    IEnumerator WaitForBlack()
    {
        yield return new WaitForSeconds(1); //wait one second after screen started to fade to black
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //go to the next scene in queue (build settings)
    }

    IEnumerator SecondSceneToBlack()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0); //go to the last scene in queue (build settings)

    }
}
