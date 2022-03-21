using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIndicator : MonoBehaviour
{
    [SerializeField] int _levelIndex;
    HeroMovement _heroMovement;

    private void Start()
    {
        _heroMovement = FindObjectOfType<HeroMovement>();
    }
    public void OnLevelIndicatorClicked()
    {
        if(_heroMovement != null)
        {
            //player can only move to a level already passed or just after the current level
            if(_heroMovement.LevelProgress + 1 >= _levelIndex)
            {
                //Move to this Level
                Debug.Log("Move to this Level!");
            }
        }
    }
}
