using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNichtKaputt : MonoBehaviour
{
    private float XPos;
    private float YPos;
    private float ZPos;

    private void Start()
    {
        XPos = transform.position.x;
        YPos = transform.position.y;
        ZPos = transform.position.z;
    }

    private void OnTriggerEnter(Collider col)
    {
        GetComponent<Collider>().isTrigger = false;
        if (col.gameObject.CompareTag("Player"))
        {
            StartCoroutine(MovePlatform());
        }
    }

    private IEnumerator MovePlatform()
    {
        transform.position = new Vector3(XPos, YPos + 0.2f, ZPos);
        yield return new WaitForSeconds(0.08f);

        transform.position = new Vector3(XPos, YPos, ZPos);
        yield return new WaitForSeconds(0.25f);

        GetComponent<Collider>().isTrigger = true;
    }
}
