using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    bool flag;
    Vector3 scaleChangeUp, scaleChangeDown;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        scaleChangeUp = new Vector3(1f, 1f, 1f);
        scaleChangeDown = new Vector3(-1f, -1f, -1f);
    }

    // Update is called once per frame
    void Update()
    {
        //since all axis are expanding at the same rate, ill only compare one of them to the target scale
        if (transform.localScale.x > 4f || transform.localScale.x < 1f)
            flag = !flag;

        if (flag)
            transform.localScale += scaleChangeUp * Time.deltaTime;
        else if(!flag)
            transform.localScale += scaleChangeDown * Time.deltaTime;
    }
}
