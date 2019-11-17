using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using HTC.UnityPlugin.Vive;

public class movingObject : MonoBehaviour, IPointerClickHandler
{
  
    public Animation anim;
    public void OnPointerClick(PointerEventData eventData)
    {
        anim.Play();
    }

 







    //public Transform movingObjectTr;
    //public void OnPointerClick(PointerEventData eventData)
    //{
    //    Debug.Log("I Clicked!!");
    //    movingObjectTr = this.gameObject.GetComponent<Transform>();
    //    movingObjectTr.transform.position += new Vector3(0f, 2f, 0f);
    //    Debug.Log("I Moved!!");
    //    StartCoroutine(DelayForThreeSC());

    //}

    //public IEnumerator DelayForThreeSC()
    //{
    //    yield return new WaitForSeconds(1.0f);
    //    movingObjectTr.transform.position -= new Vector3(0f, 2f, 0f);
    //}



    //public void Start()
    //{
    //    originalTr = this.gameObject.GetComponent<Transform>();
    //    originalLocation = originalTr.position;
    //}

    //public void goBackToPlace()
    //{
    //    StartCoroutine(DelayForThreeSC());
    //}


    //public IEnumerator DelayForThreeSC()
    //{
    //    yield return new WaitForSeconds(1.5f);
    //    this.gameObject.transform.position = originalLocation;

    //}
}
