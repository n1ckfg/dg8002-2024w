using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    public float posX = 0.01f;
    public bool doMove = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            doMove = !doMove;
        }

        if (doMove == true) {
            transform.Translate(posX, 0f, 0f);
        }

    }
}
