using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {1, 2, 3, 4, 5};

		// 5回処理を繰り返す
		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}

		// 5回処理を繰り返す
		for (int i = 4; i >=  0; i--) {
			Debug.Log (points [i]);

		}
	}

	// Update is called once per frame
	void Update () {

	}
}