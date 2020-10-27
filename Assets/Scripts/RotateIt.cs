using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIt : MonoBehaviour
{
    Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(30f, 60f, 90f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
