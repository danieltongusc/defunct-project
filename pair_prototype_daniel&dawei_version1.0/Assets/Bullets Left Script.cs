using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletManager : MonoBehaviour
{
    public int maxBullets;
    private int currentBullets; 
    public TextMeshProUGUI bulletText;
    private Gun gunScript;


    void Start()
    {
        GameObject gun = GameObject.Find("Gun");
        gunScript = gun.GetComponent<Gun>();
        currentBullets = maxBullets; // Initialize bullets
        UpdateBulletText(); // Update UI text on start
    }

    public void FireBullet()
    {
        if (currentBullets > 0)
        {
            currentBullets--; // Decrease bullet count
            UpdateBulletText(); // Update the UI text
            // Add your firing logic here
        }
        else
        {
            Debug.Log("Out of bullets!");
        }
    }

    void UpdateBulletText()
    {
        bulletText.text = "Bullets: " + currentBullets; // Update the text display
    }

    // Method to reload bullets
    public void ReloadBullets()
    {
        currentBullets = maxBullets;
        UpdateBulletText();
    }

    void Update() {
        currentBullets = gunScript.bulletsLeft;
        UpdateBulletText();
    }
}
