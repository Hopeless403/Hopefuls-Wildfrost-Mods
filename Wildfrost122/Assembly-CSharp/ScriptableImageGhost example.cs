```cs
// Ensures that the GameObject (prefab) this is attached to will have an Image component
// If it doesn't already have one, an Image will be added
[RequireComponent(typeof(Image))]
public class ScriptableImageGhost : ScriptableCardImage
{
    public Image image => GetComponent<Image>();

    // if you want, you can have multiple sprites depending on the situation
    //public Sprite[] sprites; // similar to Storm Globe

    // for this example we want to show single alternate sprite in a nice situation
    public Sprite altSprite; // set on demand

    // gets called when the card is created (eg Leaders having one consistent avatar)
    public override void AssignEvent()
    {
        // we use the CardData's main sprite for a backup here
        // otherwise it won't have any sprite
        image.sprite = this.entity.data.mainSprite;
    }
    public override void UpdateEvent()
    {
        Debug.LogWarning("Update event triggered");
        var num = Mathf.Max(0, this.entity.hp.current);
        var den = Mathf.Max(1, this.entity.hp.max);
        Debug.LogWarning($"Health is at {num}/{den}");

        // set the card's opacity to the percentage of its health remaining
        (this.entity.display as Card).canvasGroup.alpha = Mathf.Clamp((float)num / (float)den, 0, 1);

        // change the sprite depending on what's happening now
        if (this.entity.hp.current == 69 && altSprite != null)
            image.sprite = altSprite;
        else
            image.sprite = this.entity.data.mainSprite;
    }
}

//...
.SubscribeToAfterAllBuildEvent(card =>
{
    // Create a new GameObject that will host the ScriptableImage
    var ghostObject = new GameObject("Ghost", typeof(RectTransform), typeof(Image), typeof(ScriptableImageGhost));

    // HideAndDontSave so it doesn't get touched during gameplay, OR
    ghostObject.hideFlags = HideFlags.HideAndDontSave;
    // ensure the GameObject is kept in memory this session
    GameObject.DontDestroyOnLoad(ghostObject);

    // Set the GameObject's size to the card size 
    ghostObject.GetComponent<RectTransform>().sizeDelta = new Vector2(3.8f, 5.7f);

    // The image will try to autofill to fit the RectTransform size
    ghostObject.GetComponent<Image>().preserveAspect = true;
    // This fixes the card being hoverable
    ghostObject.GetComponent<Image>().raycastTarget = false;

    var image = ghostObject.GetComponent<ScriptableImageGhost>();

    // altSprite was a custom property we defined that will be used in the UpdateEvent
    image.altSprite = ImagePath("Luca_Profile01.png").ToSprite();

    // Note that we have to use the ScriptableImage component of a valid GameObject
    card.scriptableImagePrefab = image;

    Debug.LogError("WHERE IS GHOST?");
    Debug.LogError(ghostObject.scene.name);
    Debug.LogError(card.scriptableImagePrefab);
}