using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMakingMaterials : MonoBehaviour
{
    public GameObject[] randomLocation;
    public GameObject[] things;
   // public GameObject[] UIimagesBefore;
   // public GameObject[] UIimagesAfter;
    int numForLocation;
    int numForThings;
    
    void Start()
    {
        bool[] arrayForLocation= new bool[randomLocation.Length];
        bool[] arrayForThings = new bool[things.Length];
      

        for(int i=0; i < things.Length; i++)
        {
            while (true)
            {
                numForLocation = Random.Range(0, randomLocation.Length);
                numForThings = Random.Range(0, things.Length);

                if (arrayForLocation[numForLocation] == false && arrayForThings[numForThings]==false)
                {
                    break;
                }
            }
            Instantiate(things[numForThings], randomLocation[numForLocation].transform.position, Quaternion.identity);

            arrayForLocation[numForLocation] = true;
            arrayForThings[numForThings] = true;
        }
        
    }

}
