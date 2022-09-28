using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoneyFollower : MonoBehaviour
{
    public GameObject player;
    [SerializeField] float playerDelta;
    public GameObject parentMoney;
    public GameObject monetary;

    private void Start() {
        player = GameObject.FindWithTag("Player");
        monetary = GameObject.FindWithTag("Monetary");
        //calculate delta with player
        playerDelta = transform.position.x - player.transform.position.x;
        parentMoney = GameObject.FindWithTag("SpawnedMoney");
        transform.SetParent(parentMoney.transform);
        gameObject.name = "money " + monetary.GetComponent<Monetary>().moneyCount.ToString();
        print(gameObject.name);
    }


    private void Update() {
        transform.position = new Vector3(player.transform.position.x + playerDelta, transform.position.y, Mathf.Lerp(transform.position.z, player.transform.position.z, playerDelta * 0.1f));
    }
}
