using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
	public PlayerManager playerManager;

    private void Start()
    {
		playerManager = GetComponent<PlayerManager>();
    }
    public void SaveGame()
	{
		PlayerPrefs.SetFloat("gold", playerManager.gold);
		PlayerPrefs.SetFloat("presses", playerManager.totalPresses);
		PlayerPrefs.Save();
		Debug.Log("Game data saved!");
	}

	public void LoadGame()
	{
		if (PlayerPrefs.HasKey("gold") && PlayerPrefs.HasKey("presses"))
		{
			playerManager.gold = PlayerPrefs.GetFloat("gold");
			playerManager.totalPresses = PlayerPrefs.GetFloat("presses");
			Debug.Log("Game data loaded!");
		}
		else
			Debug.LogError("There is no save data!");
	}

	public void ResetData()
	{
		PlayerPrefs.DeleteAll();
		playerManager.gold = 0f;
		playerManager.totalPresses = 0f;
		Debug.Log("Data reset complete");
	}
}