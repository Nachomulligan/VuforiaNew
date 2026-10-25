using UnityEngine;

public class TargetUnlock : MonoBehaviour
{
    [SerializeField] private string cardName;
    [SerializeField] CollectionManager collectionManager;

    private bool unlocked;

    public void Unlock()
    {
        if (unlocked)
        {
            return;
        }
        unlocked = true;
        collectionManager.UnlockCard(cardName);
    }
}
