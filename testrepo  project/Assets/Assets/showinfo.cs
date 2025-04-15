using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class showinfo : MonoBehaviour
{
    void Start()
    {
        transform.Find("¹Ø±Õ").GetComponent<Button>().onClick.AddListener(delegate
         {
             gameObject.SetActive(false);
         });
    }

    private void OnEnable()
    {
        foreach (Transform tr in transform.parent)
        {
            if(tr!=transform)
            tr.gameObject.SetActive(false);
        }

        transform.DOKill();
        transform.localScale = Vector3.zero;
       

        transform.DOScale(Vector3.one,1).SetEase(Ease.OutBack);
    }
}
