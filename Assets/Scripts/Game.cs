using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Game : MonoBehaviour
{
    void Start()
    {
        // Player
        Player myPlayer = new Player();
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
*/

public class Game
{
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();
        int x = Enemy.enemyCount;
    }
}