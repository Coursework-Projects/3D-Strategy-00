using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
   [SerializeField] private int _levelProgress;

    public int LevelProgress { get => _levelProgress; }
}
