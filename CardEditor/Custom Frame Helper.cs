using Deadpan.Enums.Engine.Components.Modding;
using System.Collections.Generic;
using UnityEngine;

public static class CustomFrameHelper
{
    // TODO: Use on CardDataBuilders
    public static CardDataBuilder WithCustomFrame(this CardDataBuilder builder, Sprite frame)
    {
        newFrames[builder._data.name] = frame;
        return builder;
    }

    // TODO: Call in Load()
    public static void Enable()
    {
        Events.OnEntityCreated += OnEntityCreated;
        Events.OnCardPooled += OnCardPooled;
    }

    // TODO: Call in Unload()
    public static void Disable()
    {
        Events.OnEntityCreated -= OnEntityCreated;
        Events.OnCardPooled -= OnCardPooled;
    }
    public static readonly Dictionary<string, Sprite> newFrames = new Dictionary<string, Sprite>();
    private static readonly Dictionary<Card, Sprite> oldSprites = new Dictionary<Card, Sprite>();

    // Hooks to Events.OnEntityCreated
    private static void OnEntityCreated(Entity entity)
    {
        if (entity?.data?.name == null)
            return;

        if (entity.display is Card card && newFrames.TryGetValue(entity.data.name, out var newFrame))
        {
            oldSprites[card] = card.frameImage.sprite;
            card.frameImage.sprite = newFrame;
        }
    }

    // Hooks to Events.OnCardPooled
    private static void OnCardPooled(Card card)
    {
        if (card?.frameImage?.sprite == null)
            return;

        if (newFrames.TryGetValue(card.entity.data.name, out var newFrame) && oldSprites.ContainsKey(card))
        {
            card.frameImage.sprite = oldSprites[card];
            oldSprites.Remove(card);
        }
    }
}