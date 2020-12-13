using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    [SerializeField] Text m_MyText;
    [SerializeField] Transform MC;
    void Update()
    {
        m_MyText.text=(MC.position.x+10.91).ToString("0");
    }
}
