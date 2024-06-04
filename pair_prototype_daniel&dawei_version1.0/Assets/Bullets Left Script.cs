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

    void Update() {
        currentBullets = gunScript.bulletsLeft;
        UpdateBulletText();
    }
    void UpdateBulletText()
    {
        bulletText.text = "Bullets: " + currentBullets; // Update the text display
    }
}
