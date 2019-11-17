using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class forTimer : MonoBehaviour
{
    public Text timeText;
    private float time;
    void Awake()
    {
        time = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }

        timeText.text = Mathf.Ceil(time).ToString();

        if (time < 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
