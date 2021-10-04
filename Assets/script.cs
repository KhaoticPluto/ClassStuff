using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public LayerMask mask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit Hit;
            Debug.DrawRay(Vector3.zero, transform.forward * 50, Color.green);
            if (Physics.Raycast(Vector3.zero, transform.forward, out Hit, 50, mask))
            {
                Debug.Log(Hit.transform.name);
            }
        }
    }
}
