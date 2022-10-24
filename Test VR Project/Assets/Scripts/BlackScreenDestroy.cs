using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreenDestroy : MonoBehaviour
{
    public GameObject blackScreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForBlack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForBlack()
    {
        yield return new WaitForSeconds(1);
        blackScreen.SetActive(false); //After 1 second of animation blackscreen turns off
    }
}
