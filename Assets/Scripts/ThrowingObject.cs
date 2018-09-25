using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingObject : MonoBehaviour {

    public enum Food{
        grape,
        cupcake,  
        chestnut
    }


    /// 投げるオブジェクト
    [SerializeField, Tooltip("投げるオブジェクトをここに割り当てる")]
    private GameObject throwingObject;

    /// スタート位置
    [SerializeField, Tooltip("発射始点をここに割り当てる")]
    private GameObject startPos;
	
    /// ターゲット位置
    [SerializeField, Tooltip("発射終点をここに割り当てる")]
    private GameObject targetPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
            throwingFood(Food.cupcake);
        }
	}

    // 食べ物を投げるメソッド
    public void throwingFood(Food food){
        switch (food)
            {
                case Food.grape:
                Debug.Log("ぶどうを投げます");
                    return;
                case Food.cupcake:
                Debug.Log("カップケーキを投げます");
                    break;
                case Food.chestnut:
                Debug.Log("栗を投げます");
                    break;
                default:
                    return;
            }
    }
}
