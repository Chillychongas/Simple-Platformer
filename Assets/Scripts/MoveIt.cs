using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour
{
    bool flag;
    Vector3 pointOne, pointTwo;

    // Start is called before the first frame update
    public void Start()
    {
        flag = true;
        pointOne = new Vector3(3f, 1f, 0f);
        pointTwo = new Vector3(-3f, 1f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        //pointOne and pointTwo are sorta like waypoints to use distance comparisons
        if (Vector3.Distance(transform.position, pointOne) < .01f || Vector3.Distance(transform.position, pointTwo) < .01f)
            flag = !flag;
        
        if (flag)
            transform.Translate(Vector3.right * Time.deltaTime);
        else if (!flag)
            transform.Translate(Vector3.left * Time.deltaTime);
    }
}
