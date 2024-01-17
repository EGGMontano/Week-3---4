using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    string Enemy;
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag(Enemy) > (GameObject.FindGameObjectsWithTag(Enemy).x.-84))
        {
            text = "4";
        }
    }
}
