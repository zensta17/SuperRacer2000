using System;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public float playerStart;
    public float currenPosition;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        playerStart = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        currenPosition = player.position.z;
        double score = Math.Abs(playerStart - currenPosition) / 10;
        scoreText.text = Math.Floor(score).ToString();
    }
}
