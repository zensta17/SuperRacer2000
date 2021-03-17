using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public double coins;
    public double score;

    public PlayerData(double coins, double score)
    {
        this.coins = coins;
        this.score = score;
    }
}
