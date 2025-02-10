using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WildfrostHopeMod.Fashion;

public class FashionLeaderSequence : UISequence
{
    public Entity unit = CardManager.Get(AddressableLoader.GetCardDataClone("Leader_Tutorial1"), null, null, false, true).entity;
    public Transform cardHolder;
    public Transform unitPreParent;
    public Vector3 unitPrePosition;
    public Vector3 unitPreRotation;
    public Vector3 unitPreScale;

    //public GameObject backButton = HelpPanelSystem.instance.backButton.InstantiateKeepName();

    public static FashionLeaderSequence instance;
    public static RenameCompanionSequence renameSeq;
    public static GameObject fashionButton => AddFashionButton.fashionButton;
    //public void Start() => StartCoroutine(Instantiation());
    public IEnumerator Instantiation()
    {
        Debug.LogWarning("Starting inst");
        if (!instance)
        {
            Debug.LogWarning("Waiting...");
            yield return new WaitUntil(() => Resources.FindObjectsOfTypeAll<RenameCompanionSequence>().Any());
            renameSeq = Instantiate(Resources.FindObjectsOfTypeAll<RenameCompanionSequence>().First(), FashionMod.behaviour.transform);
            fashionButton.transform.Find("Animator/Button").GetComponent<Button>()?.onClick.AddListener(() => CoroutineManager.Start(instance.Run()));

            instance = this;
        }
    }
    public override IEnumerator Run()
    {
        yield return new WaitForEndOfFrame();
        Resources.FindObjectsOfTypeAll<InspectNewUnitSequence>().FirstOrDefault()?.transform.Find("Rename Button").GetComponentInChildren<Button>().onClick.Invoke();
    }
}