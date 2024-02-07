using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{

    public Test2 target;
    public float posX = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.doMove == true) {
            transform.Translate(posX, 0f, 0f);
        }
    }
}
