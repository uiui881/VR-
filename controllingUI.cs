using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controllingUI : MonoBehaviour
{
    public GameObject[] UIimagesBefore;
    public GameObject[] UIimagesAfter;
    public int cnt=0;
    
    void Start()
    {
       for(int i=0; i < UIimagesBefore.Length; i++)
        {
            UIimagesBefore[i].SetActive(true);
            UIimagesAfter[i].SetActive(false);
        }
    }

    public void changeUIState(int i)
    {
        UIimagesBefore[i].SetActive(false);
        UIimagesAfter[i].SetActive(true);
    }
}


//public class controllingUI : MonoBehaviour
//{
//    public GameObject[] UIimagesBefore;
//    public GameObject[] UIimagesAfter;

//    void Start()
//    {
//        for (int i = 0; i < UIimagesBefore.Length; i++)
//        {
//            UIimagesBefore[i].SetActive(true);
//            UIimagesAfter[i].SetActive(false);
//        }
//    }

//    public void changeUIState(int i)
//    {
//        UIimagesBefore[i].SetActive(false);
//        UIimagesAfter[i].SetActive(true);
//    }
//}
