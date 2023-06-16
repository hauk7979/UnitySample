using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	// 플레이어.
	private GameObject	_player = null;

	public Vector3		offset;

	// Use this for initialization
	void Start () {

		// 플레이어의 인스턴스를 준비한다.
		_player = GameObject.FindGameObjectWithTag("Player");

		offset = transform.position - _player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		// 플레이어와 함께 이동
		transform.position = new Vector3(_player.transform.position.x + offset.x, transform.position.y, transform.position.z);

	}
}
