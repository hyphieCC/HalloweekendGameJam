using UnityEngine;
using TMPro;
using Managers;
using Systems;

public class FloorDisplayUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI floorText;
    private PlayerSystem player;

    void Start()
    {
        if (floorText == null)
            floorText = GetComponent<TextMeshProUGUI>();

        player = FindFirstObjectByType<PlayerSystem>();
    }

    void Update()
    {
        if (player != null && player.inventory != null)
            floorText.text = $"Floor {player.inventory.currentFloor}";
    }
}