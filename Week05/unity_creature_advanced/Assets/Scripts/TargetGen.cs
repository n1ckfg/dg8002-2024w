using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGen : MonoBehaviour
{

    public Target prefab;
    public int numTargets = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<numTargets; i++) {
            Instantiate(prefab, transform.position, transform.rotation);
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
