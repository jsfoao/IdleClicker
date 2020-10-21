using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player")]
    public float gold;
    public float goldClick;
    public float goldPerSecond;

    [Header("Press")]
    public float totalPresses;
    public float pressIncrease;
    public float pressBuyPrice;
    public float pressSellPrice;

    public Item[] items;
    private float Timer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddGold(goldClick);
        }

        Debug.Log(TotalGoldProd());
    }

    public void AddGold(float _gold)
    {
        this.gold += _gold;
    }

    public void SubtractGold(float _gold)
    {
        this.gold -= _gold;
    }

    public void BuyItem(Item _item)
    {
        if (this.gold >= _item.cost)
        {
            _item.total++;
            SubtractGold(_item.cost);
        }
        else
            Debug.Log("not enough");
    }

    public float TotalGoldProd()
    {
        float totalProdAmount = 0;
        float totalItems = 0;
        float totalGold;

        for(int i = 0; i <= items.Length; i++)
        {
            totalProdAmount += items[i].total;
            totalItems += items[i].total;
        }

        totalGold = totalProdAmount * totalItems;
        return totalGold;
    }

    private void GoldPerSecond()
    {
        Timer += Time.deltaTime;
        if (Timer >= 1f)
        {
            Timer = 0f;
            this.gold += this.TotalGoldProd();
        }
    }
}

/*
 * To 14: Create a class named PurchasableProduct. It does not inherit from MonoBehaviour. Use the [System.Serializable]-Attribute. If you now create a public PurchasableProduct[] purchasableProducts; you can configure everything in the inspector.

 * To 15: We will have to instantiate buttons depending on the configuration here. Useful methods and classes: 
     var newGameObject = Object.Instantiate(gameObject)->creates a copy of the given GameObject. You could pass a 
    reference to a prefab to this function by using a public field of type GameObject and then referencing the Prefab in the Unity Editor.

     I would create a script named PurchasableProductView to put on that gameObject. 
    So you can reference all Texts using public fields. public Text costText;public Text productName; etc.
     Var view = newGameObject.GetComponent<PurchasableProductView>()->will then give you your view.
     VerticalLayoutGroup -> It is a component from Unity that helps you layout multiple UI Elements above each other automatically. 
     You can set up the width and height of each button here.*/
