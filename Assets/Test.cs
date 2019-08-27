using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//課題　配列を宣言して出力しましょう。
//Lesson4で作成したプロジェクトScriptTestに追記しましょう。
//
//下記の条件を満たしてください
//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
//for文を使い、配列の各要素の値を順番に表示してください
//for文を使い、配列の各要素の値を逆順に表示してください





public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] array = new int[5];

		// 配列の各要素に値を代入する
		array [0] = 30;
		array [1] = 20;
		array [2] = 50;
		array [3] = 10;
		array [4] = 80;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}



//		for (int i = 4; i == 0; i--) {
//			Debug.Log (array [i]);
//		}
	}

	// Update is called once per frame
	void Update () {

	}
}





//public class midboss {
//	private int hp = 100;
//	private int power = 50;
//
//	public void Attack() {
//		Debug.Log (this.power + "のダメージを与えた");
//
//	}
//
//	public void Defence(int damage){
//		Debug.Log (damage + "のダメージを受けた");
//		this.hp -= damage;
//
//	}
//
//}
//
//public class Test : MonoBehaviour {
//
//	void Start () {
//		midboss lastboss = new midboss ();
//
//		lastboss.Attack();
//
//		lastboss.Defence (3);
//	}
//
//	void Update () {
//	}
//}
//


//
//public class Boss {
//	private int hp = 100;
//	private int power = 25;
//
//	public void Attack() {
//		Debug.Log (this.power + "のダメージを与えた");
//
//	}
//
//	public void Defence(int damage){
//		Debug.Log (damage + "のダメージを受けた");
//		this.hp -= damage;
//
//	}
//
//}
//
//public class Test : MonoBehaviour {
//	 
//	void Start () {
//		Boss lastboss = new Boss ();
//
//		lastboss.Attack();
//
//		lastboss.Defence (3);
//	}
//
//	void Update () {
//	}
//}
//

