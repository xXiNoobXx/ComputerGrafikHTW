using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Eingang : MonoBehaviour
{
    public GameObject PipeEntry;
    public int StoodOn;

    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject MainPlayer;
    public GameObject FadeScreen;

    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("GoDown"))
        {
            if (StoodOn == 1)
            {
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(WaitingForPipe());
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        FadeScreen.SetActive(true);
        PipeEntry.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1.5F);
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        PipeEntry.GetComponent<Animator>().enabled = false;
        SecondCam.SetActive(true);
        MainCam.SetActive(false);
        Vector3 temp = new Vector3(12, -5, 0.5F);
        MainPlayer.transform.position = temp;
        PipeEntry.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495f);
        FadeScreen.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(false);
    }
}
