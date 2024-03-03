using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnMechanics : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.y < -7f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
