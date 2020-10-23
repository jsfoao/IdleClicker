using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public PlayerManager playerManager;
    private ItemView itemView;
    public Text ItemText;

    public Button buyButton;
    [SerializeField] Color buttonColorEnable;
    [SerializeField] Color buttonColorDisable;

    public GameObject floatTextPrefab;
    public Transform floatTextSpawn;
    [SerializeField] float destroyTime;
    private GameObject floatTextPrefabInstance;

    private void Start()
    {
        itemView = GetComponent<ItemView>();
    }

    private void Update()
    {
        //setting item text
        ItemText.text = itemView.item.name + " (" + itemView.item.total.ToString() + ")";

        if (itemView.item.reset) 
        {
            ShowFloatText(floatTextPrefab, floatTextSpawn);
        }

        //buy button
        //setting button text
        SetButtonText(buyButton, "Buy (" + itemView.item.cost.ToString() + ")");

        // setting button text color
        if (itemView.item.cost < playerManager.gold)
        {
            SetButtonColor(buyButton, buttonColorDisable);
        }
        else
        {
            SetButtonColor(buyButton, buttonColorEnable);
        }
    }

    private void SetButtonText(Button _button, string _newText)
    {
        Text buttonText = _button.GetComponentInChildren<Text>();
        buttonText.text = _newText;
    }

    private void SetButtonColor(Button _button, Color _newcolor)
    {
        Text text = _button.GetComponentInChildren<Text>();
        text.color = _newcolor;
    }

    public void ShowFloatText(GameObject _textPrefab, Transform _spawnPos)
    {
        floatTextPrefabInstance = Instantiate(_textPrefab, _spawnPos);
        floatTextPrefabInstance.GetComponent<Text>().text = "+" + itemView.item.totalGold.ToString();
        Destroy(floatTextPrefabInstance, destroyTime);
    }
}
