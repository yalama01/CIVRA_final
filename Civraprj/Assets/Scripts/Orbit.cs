using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Orbit : MonoBehaviour
{
    public float magnitude;
    public float xSpread;
    public float zSpread;
    public float yOffset;
    public GameObject Atom;
    public float offset;
    

    public float rotSpeed;
    public bool clockwise;

    public float timer = 0;
    private void Start()
    {
        timer += offset;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*rotSpeed;
        Rotate();
        
    }
    void Rotate()
    {
        if (clockwise){
            float x = -Mathf.Cos(timer)*xSpread*magnitude;
            float z = Mathf.Sin(timer)*zSpread*magnitude;
            Vector3 pos = new Vector3(x,yOffset,z);
            transform.localPosition = pos;
        }
        else{
            float x = Mathf.Cos(timer) * xSpread * magnitude;
            float z = Mathf.Sin(timer) * zSpread * magnitude;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.localPosition = pos;

        }
    }

}
