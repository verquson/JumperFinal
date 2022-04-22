using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maali : MonoBehaviour
{

    public AudioClip GoalClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag ==("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            AudioSource.PlayClipAtPoint(GoalClip, transform.position);
        }
    }


}
