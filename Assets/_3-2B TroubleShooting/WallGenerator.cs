using UnityEngine;

/// <summary>
/// 一定間隔で壁を生成するコンポーネント
/// 適当なオブジェクトにアタッチして使う。
/// 一定間隔で、設定した Wall Prefabs からランダムにプレハブを選び、生成する
/// </summary>
public class WallGenerator : MonoBehaviour
{
    /// <summary>壁として生成するプレハブ</summary>
    [SerializeField] GameObject[] m_wallPrefabs = null;
    /// <summary>壁を生成する間隔（秒）</summary>
    [SerializeField] float m_wallGenerateInterval = 2f;
    float t = 0;

    void Start()
    {
        GenerateWall();
    }

    void Update()
    {
        t += Time.deltaTime;
        if(t>=m_wallGenerateInterval)
        {
            t = 0;
            
            GenerateWall();
        }
    }

    /// <summary>
    /// プレハブにセットした「壁」プレハブのうち、ランダムに一つを生成する
    /// </summary>
    void GenerateWall()
    {
        int rnd = Random.Range(0, 3);
        GameObject go = Instantiate(m_wallPrefabs[rnd]);  // プレハブからオブジェクトを生成して、変数 go に入れる
    }
}
