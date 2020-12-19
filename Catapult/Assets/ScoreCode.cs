using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    [SerializeField] Text Score;
    [SerializeField] Transform MC;
    void Update()
    {
        Score.text=(MC.position.x+10.91).ToString("0");
        //Later, to be filled for damage to MC
    }
}
