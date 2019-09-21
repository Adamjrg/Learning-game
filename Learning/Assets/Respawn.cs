using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	[SerializeField] private Transform player;
	[SerializeField] private Transform respawnPoint;
	public GameObject text;

	void OnTriggerEnter(Collider col){
		player.transform.position = respawnPoint.transform.position;
		text.SetActive(true);
	}


}
