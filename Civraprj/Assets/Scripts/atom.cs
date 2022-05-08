using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atom : MonoBehaviour
{


    public GameObject display;
    string helper;
    public GameObject[] electron;
    public int electronNum=0;
    // Update is called once per frame
    void Update()
    {
        
        
    }
    //
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Electron"))
        {
            Destroy(other.gameObject);
            if (electronNum < 30)
            {
                electronNum++;
                electron[electronNum-1].GetComponent<MeshRenderer>().enabled=true;
                if (electronNum <= 2)
                {
                    helper = (string)("1s" + electronNum);
                }else if(electronNum <= 4)
                {
                    helper = (string)("1s2 2s" + (electronNum - 2));
                }else if(electronNum <= 10)
                {
                    helper = (string)("1s2 2s2 2p" + (electronNum - 4));
                }else if(electronNum <= 12)
                {
                    helper = (string)("1s2 2s2 2p6 3s" + (electronNum - 10));
                }else if (electronNum <= 18)
                {
                    helper = (string)("1s2 2s2 2p6 3s2 3p" + (electronNum - 12));
                }else if (electronNum <= 20)
                {
                    helper = (string)("1s2 2s2 2p6 3s2 3p6 4s" + (electronNum - 18));
                }else if (electronNum <= 30)
                {
                    helper = (string)("1s2 2s2 2p6 3s2 3p6 4s2 3d" + (electronNum - 20));
                }
                display.GetComponent<TextMesh>().text = helper;

            }
            
        }
    }

}
