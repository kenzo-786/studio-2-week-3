using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDisappear : MonoBehaviour
{
    [SerializeField] float disappearDelay;
    [SerializeField] float disappearWaitTime;

    [SerializeField] bool isDisappear;

    [SerializeField] public GameObject obj;

    private void Start()
    {
        StartCoroutine(Disappear());
    }
    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(disappearDelay);
        obj.SetActive(false);
        yield return new WaitForSeconds(disappearWaitTime);
        obj.SetActive(true);
        StartCoroutine(Disappear());
    }

    private void Update()
    {
    }
}
