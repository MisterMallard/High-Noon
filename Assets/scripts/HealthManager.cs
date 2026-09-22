using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.PackageManager;

public class HealthManager : MonoBehaviour
{
	public static HealthManager Instance;

	public int health = 100;
	public TextMeshProUGUI healthText;



	private void Awake()
	{
		Instance = this;
	}

	public void UpdateHealth(int changeAmount)
	{

		health += changeAmount;

		healthText.text = health.ToString();

		if (health <= 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
