﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Dodge", menuName = "New Dodge")]
public class CarDodge : ScriptableObject
{
    [SerializeField]
    private ScriptableIntValue totalScore;
    public void Dodge(int dodgescore)
    {
        totalScore.score +=  dodgescore;
    }
}
