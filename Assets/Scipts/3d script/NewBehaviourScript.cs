using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
        yield return new WaitForSeconds(1);
        gameObject.SetActive(true); 
        StartCoroutine(Disappear());
    }

    private void Update()
    {
        StartCoroutine(Disappear());
    }
}
