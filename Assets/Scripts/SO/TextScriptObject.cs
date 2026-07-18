using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class TextScriptObject : ScriptableObject 
{
    public string name;
    public int level;

    public int[] levelDate;
    public int[] levelDate2 = { 10 };

    public int[,] mapDate;
}
