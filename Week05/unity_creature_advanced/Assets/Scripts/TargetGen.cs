using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGen : MonoBehaviour
{

    public Target prefab;
    public int numTargets = 10;

    [HideInInspector] public List<Target> targets;

    void Awake()
    {
        targets = new List<Target>();

        for (int i=0; i<numTargets; i++) {
            Target target = Instantiate(prefab, transform.position, transform.rotation);
            target.transform.parent = transform;
            targets.Add(target);
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
