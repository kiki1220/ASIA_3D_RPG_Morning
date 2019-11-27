
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("動畫參數名稱")]
    public string parrun = "跑步開關";
    public string parjump = "跳耀開關";
    public string paratk = "攻擊開關";
    public string pardamage = "受傷";
    public string pardead = "死亡";

    [Header("道具")]
    public int countneed = 10;
    public int countcurrent;

    [Header("數值")]
    public bool isdead;
    public float hp = 100;

    //遊戲開始
    private void Start()
    {
        
    }

    //更新(約一秒更新60次)
    private void Update()
    {
        
    }

    
}


