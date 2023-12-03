using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent(out Ball ball))
            Restart();
    }
    
    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
