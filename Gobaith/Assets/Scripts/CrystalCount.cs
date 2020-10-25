using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCount : MonoBehaviour
{
    public static int crystalAmount;
    private Text crystalCounter;

    // Start is called before the first frame update
    void Start()
    {
        crystalCounter = GetComponent<Text>();
        crystalAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        crystalCounter.text = "Crystals: " + crystalAmount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Crystal"))
        {
            CrystalCount.crystalAmount += 1;
            Destroy(collision.gameObject);
        }
    }
}
