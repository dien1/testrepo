using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class InfoClick : MonoBehaviour
{

    public GameObject obj;

    void Start()
    {
        obj = GameObject.Find("Canvas_2D").transform.Find(transform.parent.parent.name).gameObject;

        GetComponent<Button>().onClick.AddListener(delegate
        {
            obj.SetActive(true);
        });
    }


}
