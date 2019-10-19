using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// /// Source File: Scoreboard.cs
/// Last Modified by: Geerthan Kanthasamy
/// Stores data that are to be used in multiple scenes (data that need to be carried over between scenes)
/// </summary>
[System.Serializable]
public class Scoreboard : MonoBehaviour
{
    public int highScore;
    public int score;
    public int life;
}
