using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sManager : MonoBehaviour
{
    public void teleportTest()
    {
        SceneManager.LoadScene(2);
    }

    public void DemoTest()
    {
        SceneManager.LoadScene(0);
    }

    public void MovementTest()
    {
        SceneManager.LoadScene(1);
    }
}
