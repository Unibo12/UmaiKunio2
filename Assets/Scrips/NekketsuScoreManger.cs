using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NekketsuScoreManger : MonoBehaviour
{
    NekketsuAction NAct; //NekketsuActionが入る変数

    public GameObject score_object = null; // Textオブジェクト

    public int score_num = 0; // スコア変数

    private TextMeshProUGUI score_text;

    public NekketsuScoreManger(NekketsuAction nekketsuAction)
    {
        NAct = nekketsuAction;
    }

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        score_text = score_object.GetComponent<TextMeshProUGUI>();

        // テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;

        score_num += 1; // とりあえず1加算し続けてみる
    }
}
