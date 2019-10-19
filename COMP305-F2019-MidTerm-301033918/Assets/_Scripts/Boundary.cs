using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Source File: Boundary.cs
/// Last Modified by: Geerthan Kanthasamy
/// This program creates an object that will hold the minimum and maximum limits a GameObject can go to 
/// on both horizontal and vertical axis
/// </summary>
namespace Util
{
    [System.Serializable]
    public class Boundary
    {
        public float Top;
        public float Right;
        public float Bottom;
        public float Left;
    }
}


