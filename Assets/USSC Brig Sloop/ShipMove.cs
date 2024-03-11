using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShipMove : MonoBehaviour

{
    public float Xvalue, Yvalue, Zvalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Xvalue, Yvalue, Zvalue) * Time.deltaTime);
    }
}
