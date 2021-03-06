using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SQLManager;
using UnityEngine;
using UnityEngine.UI;

namespace ViewManager
{
    public class PlayerButtonManager : MonoBehaviour
    {
        public void createPlayerButton(GameObject itemPrefab,int itemNumber,GameObject baseObject)
        {
            for (int i = 0; i < itemNumber; i++)
            {
                GameObject item =(GameObject)Instantiate(itemPrefab,baseObject.transform.position,Quaternion.identity);
                item.transform.parent = baseObject.transform;
                item.name = i.ToString();
            }
        }
    }
}
