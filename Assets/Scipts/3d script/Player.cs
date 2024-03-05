using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] AnimationClip chestOpenAnim;
    //[SerializeField] Animation _chestOpenAnim;
    //[SerializeField] AnimatorController _animatorController;

    [SerializeField] GameObject chestLid;
    [SerializeField] float openSpeed;

    private void Start()
    {
        //_chestOpenAnim.clip = chestOpenAnim;
        //_chestOpenAnim.Stop();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {
            print("Game over");
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Chest open"))
        {
            //_chestOpenAnim.Play();
        }
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            chestLid.transform.Rotate(-120 * openSpeed * Time.deltaTime, 0, 0);
        }
    }

}
