using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static readonly Dictionary<string, int> PointDictionary = new Dictionary<string, int>()
    {
        { "SmallStarTag", 10 },
        {"LargeStarTag", 30 },
        { "SmallCloudTag", 40 },
        { "LargeCloudTag", 70 }
    };

    //スコアを表示するテキスト
    private GameObject scoreText;

    // 角度
    private static int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のスコアオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = 0.ToString();

    }

    // Update is called once per frame
    void Update()
    {
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //スコア更新
        score += PointDictionary[this.tag];
        this.scoreText.GetComponent<Text>().text = score.ToString();
    }

}
