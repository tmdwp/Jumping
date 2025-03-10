using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt();
    public void OnInteract();
}

public class ItemObject : MonoBehaviour, IInteractable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        if (data.type == ItemType.Consumable)
        {
            for (int i = 0; i < data.consumables.Length; i++)
            {
                switch (data.consumables[i].type)
                {
                    case ConsumableType.Health:
                        CharacterManager.Instance.Player.condition.Heal(data.consumables[i].value);
                        break;
                    case ConsumableType.Speed:
                        CharacterManager.Instance.Player.controller.SpeedUp(data.consumables[i].value);
                        break;
                    case ConsumableType.Jump:
                        CharacterManager.Instance.Player.controller.JumpUp(data.consumables[i].value);
                        break;
                }
            }
            Destroy(gameObject);
        }
    }
}
