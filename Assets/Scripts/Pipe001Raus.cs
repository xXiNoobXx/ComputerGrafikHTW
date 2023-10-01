using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001Raus : MonoBehaviour
{
    public GameObject FadeScreen;
    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject PipeEntry;
    public GameObject MainPlayer;


    IEnumerator OnTriggerEnter(Collider col)
    {
        FadeScreen.SetActive(true);
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        MainCam.SetActive(true);
        SecondCam.SetActive(false);
        Vector3 temp = new Vector3(27.4F, 2, 0.5F);
        MainPlayer.transform.position = temp;
        PipeEntry.GetComponent<Animator>().enabled = true;
        FadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(1);
        PipeEntry.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(false);
    }
}
