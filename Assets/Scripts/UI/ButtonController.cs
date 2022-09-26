using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string name;
    public void PassScene()
    {
        SceneManager.LoadScene("Game1");
    }
}
