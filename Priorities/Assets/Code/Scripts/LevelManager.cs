using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    private static LevelManager main;

    [Header("References")] 
    [SerializeField] private TextMeshProUGUI strokeUI;
    [Space(10)] 
    [SerializeField] private GameObject levelCompleteUI;
    [SerializeField] private TextMeshProUGUI levelCompletedStrokeUI;
    [Space(10)] 
    [SerializeField] private GameObject gameOverUI;

    [Header("Attributes")] 
    [SerializeField] private int maxStrokes;

    private int strokes;
    [HideInInspector] public bool outOfStrokes;
    [HideInInspector] public bool levelCompleted;

    private void Awake()
    {
        main = this;
    }

    
    
}

