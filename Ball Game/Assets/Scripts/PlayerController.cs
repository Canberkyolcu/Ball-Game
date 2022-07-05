using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 35.0f;
    public bool isGameStarted=false;



    void Update()
    {
        if (isGameStarted == true)
        {
            float ver = Input.GetAxis("Mouse X") * Time.deltaTime * _speed;
            float hor = Input.GetAxis("Mouse Y") * Time.deltaTime * _speed;
              
            transform.eulerAngles += new Vector3(hor, 0, ver);
        }

    }
}
