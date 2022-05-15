using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillInventory : MonoBehaviour
{
    GameObject Bag;
    // Start is called before the first frame update
    void Start()
    {
        this.Bag = GameObject.Find("Inventory");
        Bag.SetActive(false);
    }

    public void OpenBag()
    {
        Bag.SetActive(true);
    }
    public void CloseBag()
    {
        Bag.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
