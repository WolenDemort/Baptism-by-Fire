using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTurn : MonoBehaviour
{
    [SerializeField]EnemyControl enemy;

    public void ChangeMove(CardController cardMove)
    {
        
        enemy.Turn();
    }



}
