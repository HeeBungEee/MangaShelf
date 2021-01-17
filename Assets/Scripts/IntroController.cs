using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroController : MonoBehaviour
{
    public void Event_EndOfIntro()
    {
        SceneManager.LoadScene("Scene_Main");
    }
}
