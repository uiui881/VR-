using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using HTC.UnityPlugin.Vive;

public class findingObject : MonoBehaviour, IPointerClickHandler
{
    public int id;
    public controllingUI cui;
    public void Start()
    {
        cui = GameObject.Find("controllingUI").GetComponent<controllingUI>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Click!!!!!");
        cui.UIimagesBefore[id].SetActive(false);
        cui.UIimagesAfter[id].SetActive(true);
        cui.cnt++;
        if (cui.cnt == 5)
        {
            SceneManager.LoadScene("SuccessScene");
        }
        Destroy(this.gameObject);    
    }
}
