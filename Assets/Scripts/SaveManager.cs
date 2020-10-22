using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
	/*private PlayerManager playerManager;

    private void Start()
    {
		playerManager = GetComponent<PlayerManager>();
    }

    public void SaveGame()
	{
		//save player gold
		PlayerPrefs.SetFloat("gold", playerManager.gold);

		//save player total items
		for(int i = 0; i < playerManager.items.Length; i++)
		{
			PlayerPrefs.SetFloat(playerManager.items[i].name, playerManager.items[i].total);
		}

		PlayerPrefs.Save();
		Debug.Log("Game data saved!");
	}

	public void LoadGame()
	{
		//load player gold
		playerManager.gold = PlayerPrefs.GetFloat("gold");

		//load player total items
		for (int i = 0; i < playerManager.items.Length; i++)
		{
			PlayerPrefs.GetFloat(playerManager.items[i].name, playerManager.items[i].total);
		}

		Debug.Log("Game data loaded!");
	}

	public void ResetData()
	{
		PlayerPrefs.DeleteAll();
		playerManager.gold = 0f;

		for (int i = 0; i < playerManager.items.Length; i++)
		{
			playerManager.items[i].total = 0f;
		}
		Debug.Log("Data reset complete");
	}*/
}