using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monetary : MonoBehaviour
{
    [SerializeField] GameObject[] moneyList;
    public GameObject moneySpawned;
    public int moneyCount;

    public GameObject player;
    Transform playerTransform;
    Vector3 playerVector;

    private void Awake() {
        playerTransform = player.transform;
    }




    public void AddMoney() {
        playerVector = playerTransform.position;
        moneyCount++;
        Instantiate(moneySpawned, new Vector3(playerVector.x + moneyCount, 0.0525f, playerVector.z), Quaternion.identity);
    }
}
