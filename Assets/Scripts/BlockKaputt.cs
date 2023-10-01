using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockKaputt : MonoBehaviour
{

    private float XPos;
    private float YPos;
    private float ZPos;
    private float Waiting = 0.02f;

    void Start()
    {
        XPos = transform.position.x;
        YPos = transform.position.y;
        ZPos = transform.position.z;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            StartCoroutine(MovePlatform());
        }
    }

    IEnumerator MovePlatform()
    {
        transform.position = new Vector3(XPos, YPos + 0.1f, ZPos);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos + 0.2f, ZPos);
        yield return new WaitForSeconds(Waiting);

        GetComponent<Collider>().isTrigger = false;

        transform.position = new Vector3(XPos, YPos + 0.3f, ZPos + 0.5f);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos + 0.4f, ZPos + 1.0f);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos - 0.1f, ZPos + 1.5f);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos - 0.6f, ZPos + 2.0f);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos - 1.6f, ZPos + 2.0f);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos - 2.6f, ZPos + 2.0f);
        yield return new WaitForSeconds(Waiting);

        transform.position = new Vector3(XPos, YPos - 4.0f, ZPos + 2.0f);
        yield return new WaitForSeconds(0.25f);

        GetComponent<Collider>().isTrigger = true;
        Destroy(gameObject);
    }
}
