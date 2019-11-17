using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class forStartScene : MonoBehaviour
{
    public void onClickPlayEvent()
    {
        SceneManager.LoadScene("MainScene");
    }
}
