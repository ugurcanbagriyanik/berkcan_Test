using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;
using Helpers;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pool;
    public Transform inventory;

    public List<MyModel> myList;

    void Start()
    {
        DoSomething();
    }

    public void DoSomething()
    {
        var childList = Helper.GetChildren(pool, "Item").ToArray();
        for (int i = 0; i < myList.Count; i++)
        {
            childList[i].transform.parent = inventory;
            childList[i].GetComponent<JumpAndSayYourName>().me = myList[i];
            childList[i].SetActive(true);
        }
    }
}