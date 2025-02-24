using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupSystem : MonoBehaviour
{
    public TMP_Text gemCountText;
    public int gemAmount;
    public void Update()
    {
        gemAmount = gameObject.transform.childCount;

        gemCountText.text = gemAmount.ToString();
    }
}
