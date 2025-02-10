using Deadpan.Enums.Engine.Components.Modding;
using Gif2Textures;
using HarmonyLib;
using Newtonsoft.Json.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Dir = System.IO.Directory;

namespace WildfrostHopeMod.VFX;

[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Image))]
public class ScriptableGIFAnimated : ScriptableCardImage
{
    // we use a GIFAnimator to make it easier to list the frames and frame delays
    public GIFAnimator animatorPrefab;
    public Sprite defaultSprite;
    public bool shouldAnimate = true;

    private int loops = 1;
    private Sprite[] frames;
    private float[] delays;
    private int currentFrame = 0;
    private float currentDelay = 0;


    public Image renderer => gameObject.GetComponent<Image>();

    public override void AssignEvent()
    {
        frames = animatorPrefab.frames;
        delays = animatorPrefab.delays;
        renderer.sprite = frames[0];

        defaultSprite ??= entity.data.mainSprite;
    }
    public void Update()
    {
        if (!entity)
            return;

        if (!shouldAnimate)
        {
            renderer.sprite = defaultSprite;
            return;
        }

        currentDelay += Time.deltaTime;
        if (currentDelay > delays[currentFrame])
        {
            currentFrame = (currentFrame + 1) % frames.Length;
            currentDelay = 0;
            renderer.sprite = frames[currentFrame];
        }

        if (loops == 0)
            shouldAnimate = false;
    }

}

public class ScriptableGIFAnimatedDeploy : ScriptableCardImage
{
    public GIFAnimator animatorPrefab;
    public Sprite defaultSprite;

    private Sprite[] frames;
    private float[] delays;
    private int currentFrame = 0;
    private float currentDelay = 0;

    private bool shouldPlay = false;

    public Image renderer => gameObject.GetComponent<Image>();

    public override void AssignEvent()
    {
        frames = animatorPrefab.frames;
        delays = animatorPrefab.delays;

        // show the card's main sprite as the default if not playing the animatino
        defaultSprite = entity.data.mainSprite;
        renderer.sprite = defaultSprite;
    }

    public void CheckEnemyDeployed(Entity enemy)
    {
        // Is the "enemy" actually an enemy?
        if (enemy.owner.team != this.entity.owner.team)
            shouldPlay = false;
        else // Did the enemy deploy onto the board?
            shouldPlay = Battle.IsOnBoard(enemy) && !Battle.IsOnBoard(enemy.preContainers);
    }


    public void OnEnable()
    {
        Events.OnEntityMove += CheckEnemyDeployed;
    }
    public void OnDisable()
    {
        Events.OnEntityMove += CheckEnemyDeployed;
    }


    public void Update()
    {
        if (!entity)
            return;

        Debug.Log((entity, currentDelay, currentFrame));
        currentDelay += Time.deltaTime;
        if (currentDelay > delays[currentFrame])
        {
            currentFrame = (currentFrame + 1) % frames.Length;
            currentDelay = 0;
            renderer.sprite = frames[currentFrame];
        }
    }
}

public partial class GIFLoader
{
    public ScriptableGIFAnimated GetScriptableImage(string name)
    {
        var scriptableImage = new GameObject("ScriptableImage." + name, typeof(RectTransform), typeof(Image), typeof(ScriptableGIFAnimated));
        scriptableImage.transform.SetParent(VFXMod.parent);

        // Set the GameObject's size to the card size 
        scriptableImage.GetComponent<RectTransform>().sizeDelta = new Vector2(3.8f, 5.7f);
        // The image will try to autofill to fit the RectTransform size
        scriptableImage.GetComponent<Image>().preserveAspect = true;
        // This fixes the card being hoverable
        scriptableImage.GetComponent<Image>().raycastTarget = false;

        var image = scriptableImage.GetComponent<ScriptableGIFAnimated>();

        // these prefabs always have a GIFAnimator component
        image.animatorPrefab = TryGetPrefab(name).GetComponent<GIFAnimator>();
        return image;
    }
}
