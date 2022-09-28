using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyProp : MonoBehaviour
{
    Monetary money;
    public GameObject monetisingManager;

    private void Awake() {
        money = monetisingManager.GetComponent<Monetary>();
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "MoneyPlaceholder") {
            //print(other.gameObject.name);
            money.AddMoney();
            Destroy(gameObject);
        }
    }
}
