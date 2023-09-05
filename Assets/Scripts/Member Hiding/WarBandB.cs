using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandB : MonoBehaviour
{
    private void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemyB();
        Humanoid orc = new OrcB();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
