using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    [SerializeField] private PlayerController _play;

    public void Play()
    {
        gameObject.SetActive(false);
        _play.isGameStarted=true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
