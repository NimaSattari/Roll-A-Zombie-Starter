using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OTE : MonoBehaviour
{
    public GameObject P;

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(enumerator());
        }
    }
    IEnumerator enumerator()
    {
        Time.timeScale = 0.25f;
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0;
        P.SetActive(true);
    }
}
