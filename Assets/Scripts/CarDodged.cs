﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[CreateAssetMenu(fileName = "Dodge", menuName = "New Dodge")]

public class CarDodged : ScriptableObject
{
    [SerializeField]
    private ScriptableIntValue totalScore;

    public void Dodge(int dodgescore)
    {
        totalScore.score += dodgescore;
    }
}