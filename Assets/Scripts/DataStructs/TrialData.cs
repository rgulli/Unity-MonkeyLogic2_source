﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Misc;

public class TrialData
{
    public int Trial_Number;
    public Vector3 Start_Position;
    public Vector3 Start_Rotation; 

    public GameObject Fix_Object;
    public Vector3 Fix_Position_World;
    public Vector3 Fix_Position_Screen;
    public float Fix_Size;
    public float Fix_Window; 

    public GameObject[] Cue_Objects;
    
    public Material Cue_Material;

    public bool MultipleTargets;

    public MultipleRewardMultiplier MultipleRewardsScale;

    public GameObject[] Target_Objects;

    public Material[] Target_Materials;

    public Vector3[] Target_Positions;

    public GameObject[] Distractor_Objects;

    public Material[] Distractor_Materials;
    
    public Vector3[] Distractor_Positions;

    public string Outcome;

    public double Unity_Local_Time;

    public Vector3[] Additional_Positions;

    public float[] Additional_Floats;

    public GameObject[] Additional_GameObjects;

    public Material[] Additional_Materials;

    public string GetData(double curr_time)
    {
        // we will save instance IDs and use the map generated in the 
        // ExperimentController.GenerateIDMap() function
        Unity_Local_Time = curr_time;
        return JsonUtility.ToJson(this);
    }

}
