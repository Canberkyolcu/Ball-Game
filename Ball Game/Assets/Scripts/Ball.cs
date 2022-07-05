using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private float _dieSpeed = 0.5f;
    [SerializeField] private GameObject panel, panel2;





    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "delik")
        {
            Destroy(GetComponent<Rigidbody>());
            transform.position = other.gameObject.transform.position;
            InvokeRepeating("die", 0.0f, 0.02f);
            StartCoroutine(wait(3f));
        }

        if (other.tag == "win")
        {
            Destroy(GetComponent<Rigidbody>());
            transform.position = other.gameObject.transform.position;
            InvokeRepeating("die", 0.0f, 0.02f);
            StartCoroutine(wait1(3f));
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "zemin")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }

    private void die()
    {
        transform.localScale = new Vector3(_dieSpeed, _dieSpeed, _dieSpeed);
    }

    IEnumerator wait(float seconds)
    {
        //Destroy(gameObject);
        //Time.timeScale = 0f;
        panel2.SetActive(true);
        yield return new WaitForSeconds(seconds);
        panel2.SetActive(false);
        SceneManager.LoadScene(0);
    }

    IEnumerator wait1(float seconds)
    {
        //Destroy(gameObject);
        //Time.timeScale = 0f;
        panel.SetActive(true);
        yield return new WaitForSeconds(seconds);
        panel.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
