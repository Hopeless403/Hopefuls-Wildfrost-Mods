// Decompiled with JetBrains decompiler
// Type: StormBellManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;

public class StormBellManager : MonoBehaviour
{
  public const int TrueFinalBossPointThreshold = 10;
  public const int PointLimit = 10;
  public const int MaxPointStart = 5;
  public const int MaxPointIncrease = 1;
  [SerializeField]
  private GameObject openButton;
  [SerializeField]
  private Transform[] bellGroups;
  [SerializeField]
  private ModifierIcon bellPrefab;
  [SerializeField]
  private ModifierIconMultiple[] stormBellDisplays;
  [SerializeField]
  private GameObject stormBellUnlockDisplay;
  [SerializeField]
  private UnityEngine.Animator animator;
  [SerializeField]
  private GameObject overcranker;
  [SerializeField]
  private GameObject pointLimitDisplay;
  [SerializeField]
  private GameObject overcrankDisplay;
  [SerializeField]
  private GameObject overcrankUnlockDisplay;
  [SerializeField]
  private ColourFader backgroundFader;
  [SerializeField]
  private LocalizedString stormStrengthAddString;
  [SerializeField]
  private GameObject additionalButtons;
  [Header("Smoke")]
  [SerializeField]
  private ParticleSystem normalSmoke;
  [SerializeField]
  private ParticleSystem overcrankSmoke;
  [Header("Storm Strength Increase Popup")]
  [SerializeField]
  private GameObject stormLimitAdd;
  [SerializeField]
  private LocalizedString stormLimitAddString;
  [SerializeField]
  private LocalizedString goldFramesRemainingString;
  [SerializeField]
  private TMP_Text stormLimitAddText;
  [Header("SFX")]
  [SerializeField]
  private EventReference stormBellActivateSfx;
  [SerializeField]
  private EventReference stormBellActivate10Sfx;
  [SerializeField]
  private EventReference stormBellRandomizeSfx;
  [SerializeField]
  private EventReference stormBellClearSfx;
  private List<string> activeNames;
  private List<string> golden;
  private List<string> newGolden;
  private List<HardModeModifierData> active;
  private readonly Dictionary<ModifierIcon, HardModeModifierData> modifierIcons = new Dictionary<ModifierIcon, HardModeModifierData>();
  private bool unlocked;
  private int points;
  private int maxPoints;
  private bool overcrank;
  private string stormStrengthAddText;
  private EventInstance bellActivateSfxInstance;
  private EventInstance bellActivate10SfxInstance;
  private EventInstance bellRandomizeSfxInstance;

  private void Awake()
  {
    this.overcrank = SaveSystem.LoadProgressData<bool>("stormPointOvercrank", false);
    this.maxPoints = Mathf.Min(SaveSystem.LoadProgressData<int>("maxStormPoints", 5), 10);
    this.unlocked = SaveSystem.LoadProgressData<bool>("stormBellsUnlocked", false);
    if (!this.unlocked && SaveSystem.LoadProgressData<int>("hardModeModifiersUnlocked", 0) > 0)
    {
      this.unlocked = true;
      SaveSystem.SaveProgressData<bool>("stormBellsUnlocked", true);
    }
    if (!this.unlocked)
    {
      this.openButton.SetActive(false);
    }
    else
    {
      this.golden = SaveSystem.LoadProgressData<List<string>>("goldHardModeModifiers") ?? new List<string>();
      this.newGolden = SaveSystem.LoadProgressData<List<string>>("goldHardModeModifiersNew");
      if (!SaveSystem.LoadProgressData<bool>("stormBellsUnlockedScreenShown", false))
      {
        this.stormBellUnlockDisplay.SetActive(true);
        SaveSystem.SaveProgressData<bool>("stormBellsUnlockedScreenShown", true);
      }
      List<string> newGolden = this.newGolden;
      if (newGolden != null && newGolden.Count > 0)
      {
        int num = ((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).Count<HardModeModifierData>((Func<HardModeModifierData, bool>) (a => this.golden.Contains(a.name)));
        if (num > 0)
        {
          this.stormLimitAdd.SetActive(true);
          this.stormLimitAddText.text = this.goldFramesRemainingString.GetLocalizedString((object) num);
        }
      }
      int num1 = SaveSystem.LoadProgressData<int>("maxStormPointIncrease", 0);
      if (num1 > 0)
      {
        this.stormLimitAdd.SetActive(true);
        this.stormLimitAddText.text = this.stormLimitAddString.GetLocalizedString((object) num1);
        SaveSystem.SaveProgressData<int>("maxStormPointIncrease", 0);
      }
      this.activeNames = SaveSystem.LoadProgressData<List<string>>("activeHardModeModifiers") ?? new List<string>();
      bool flag = false;
      for (int index = this.activeNames.Count - 1; index >= 0; --index)
      {
        string bellName = this.activeNames[index];
        if (((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).All<HardModeModifierData>((Func<HardModeModifierData, bool>) (a => a.name != bellName)))
        {
          this.activeNames.RemoveAt(index);
          flag = true;
        }
      }
      if (this.active == null)
        this.active = new List<HardModeModifierData>();
      foreach (HardModeModifierData hardModeModifier in MonoBehaviourSingleton<References>.instance.hardModeModifiers)
      {
        if (this.activeNames.Contains(hardModeModifier.name))
          this.active.Add(hardModeModifier);
      }
      if (!this.overcrank)
      {
        int num2 = 0;
        for (int index = this.active.Count - 1; index >= 0; --index)
        {
          HardModeModifierData modeModifierData = this.active[index];
          if (num2 + modeModifierData.stormPoints > this.maxPoints)
          {
            this.active.RemoveAt(index);
            this.activeNames.Remove(modeModifierData.name);
            flag = true;
          }
          else
            num2 += modeModifierData.stormPoints;
        }
      }
      if (flag)
        SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiers", this.activeNames);
      this.stormStrengthAddText = this.stormStrengthAddString.GetLocalizedString();
      ModifierIcon modifierIcon1 = (ModifierIcon) null;
      for (int index = 0; index < MonoBehaviourSingleton<References>.instance.hardModeModifiers.Length; ++index)
      {
        ModifierIcon bell = this.CreateBell(MonoBehaviourSingleton<References>.instance.hardModeModifiers[index], index);
        if ((UnityEngine.Object) modifierIcon1 != (UnityEngine.Object) null && index != 5 && index != 10)
        {
          StormBellManager.ConnectBellInputLeft(bell, modifierIcon1);
          StormBellManager.ConnectBellInputRight(modifierIcon1, bell);
        }
        modifierIcon1 = bell;
      }
      this.UpdateBells();
      if (this.overcrank)
      {
        foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon2 in this.modifierIcons)
          modifierIcon2.Key.GetComponent<ModifierToggle>().canToggle = false;
      }
      if (this.overcrank)
        this.overcrankSmoke.Play();
      else if (this.points >= 10)
        this.normalSmoke.Play();
      this.additionalButtons.SetActive(!this.overcrank);
      this.pointLimitDisplay.SetActive(!this.overcrank);
      this.overcrankDisplay.SetActive(this.overcrank);
      this.overcranker.SetActive(!((IEnumerable<HardModeModifierData>) MonoBehaviourSingleton<References>.instance.hardModeModifiers).Select<HardModeModifierData, string>((Func<HardModeModifierData, string>) (a => a.name)).Except<string>((IEnumerable<string>) this.golden).Any<string>());
      if (this.overcranker.activeSelf && !SaveSystem.LoadProgressData<bool>("overcrankUnlockedScreenShown", false))
      {
        this.overcrankUnlockDisplay.SetActive(true);
        SaveSystem.SaveProgressData<bool>("overcrankUnlockedScreenShown", true);
      }
      this.SetGlobalStormBellCountParam();
    }
  }

  private void OnEnable() => this.UpdatePointsDisplays();

  public void CheckStartGoldFrameRoutine()
  {
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
    {
      if (this.golden.Contains(modifierIcon.Value.name) && (this.newGolden == null || !this.newGolden.Contains(modifierIcon.Value.name)))
        modifierIcon.Key.GetComponent<UnityEngine.Animator>()?.SetBool("Gold", true);
    }
    List<string> newGolden = this.newGolden;
    if (newGolden == null || newGolden.Count <= 0)
      return;
    string[] array = this.newGolden.ToArray();
    this.newGolden = (List<string>) null;
    SaveSystem.DeleteProgressData("goldHardModeModifiersNew");
    this.StartCoroutine(this.GoldFrameRoutine(array));
  }

  private void UpdateBells()
  {
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
    {
      ModifierToggle component = modifierIcon.Key.GetComponent<ModifierToggle>();
      if (component != null && !component.IsActive)
      {
        component.canToggle = this.maxPoints - this.points - modifierIcon.Value.stormPoints >= 0;
        component.UpdateArt();
      }
    }
  }

  private ModifierIcon CreateBell(HardModeModifierData modifier, int index)
  {
    ModifierIcon key = UnityEngine.Object.Instantiate<ModifierIcon>(this.bellPrefab, this.bellGroups[index % this.bellGroups.Length]);
    key.Set(modifier.modifierData, Vector2.left);
    key.AddText(this.stormStrengthAddText.Format((object) modifier.stormPoints));
    ModifierToggle component = key.GetComponent<ModifierToggle>();
    if (this.activeNames.Contains(modifier.name))
    {
      this.points += modifier.stormPoints;
      ModifierSystem.AddModifier(Campaign.Data, modifier.modifierData);
    }
    else if ((bool) (UnityEngine.Object) component)
      component.Toggle();
    if ((bool) (UnityEngine.Object) component)
      component.onToggle.AddListener((UnityAction) (() => this.Toggle(modifier)));
    this.modifierIcons.Add(key, modifier);
    return key;
  }

  private static void ConnectBellInputLeft(ModifierIcon from, ModifierIcon to)
  {
    UINavigationItem component1 = from.GetComponent<UINavigationItem>();
    if (component1 == null)
      return;
    UINavigationItem component2 = to.GetComponent<UINavigationItem>();
    if (component2 == null)
      return;
    component1.overrideInputs = true;
    component1.inputLeft = component2;
  }

  private static void ConnectBellInputRight(ModifierIcon from, ModifierIcon to)
  {
    UINavigationItem component1 = from.GetComponent<UINavigationItem>();
    if (component1 == null)
      return;
    UINavigationItem component2 = to.GetComponent<UINavigationItem>();
    if (component2 == null)
      return;
    component1.overrideInputs = true;
    component1.inputRight = component2;
  }

  private void Toggle(HardModeModifierData modifier)
  {
    int points = this.points;
    this.ToggleEffect(modifier);
    this.UpdatePointsDisplays();
    this.UpdateBells();
    SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiers", this.activeNames);
    this.animator.SetBool("Angry", this.points >= 10);
    this.animator.SetTrigger("Blip");
    this.SetGlobalStormBellCountParam();
    if (this.activeNames.Contains(modifier.name))
    {
      this.bellActivateSfxInstance = SfxSystem.OneShot(this.stormBellActivateSfx);
      SfxSystem.SetParam(this.bellActivateSfxInstance, "count", (float) this.activeNames.Count);
    }
    if (points < 10 && this.points >= 10)
    {
      this.backgroundFader.FadeToColour("Purple");
      this.bellActivate10SfxInstance = SfxSystem.OneShot(this.stormBellActivate10Sfx);
      this.normalSmoke.Play();
    }
    else
    {
      if (points < 10 || this.points >= 10)
        return;
      this.backgroundFader.FadeToColour("Normal");
      this.normalSmoke.Stop();
    }
  }

  private void SetGlobalStormBellCountParam() => SfxSystem.SetGlobalParam("stormbell_count", this.points >= 10 ? (float) Mathf.Max(10, this.active.Count) : (float) this.active.Count);

  private void ToggleEffect(HardModeModifierData modifier)
  {
    if (this.activeNames.Contains(modifier.name))
    {
      this.activeNames.Remove(modifier.name);
      this.active.Remove(modifier);
      this.points -= modifier.stormPoints;
      ModifierSystem.RemoveModifier(Campaign.Data, modifier.modifierData);
    }
    else
    {
      this.activeNames.Add(modifier.name);
      this.active.Add(modifier);
      this.points += modifier.stormPoints;
      ModifierSystem.AddModifier(Campaign.Data, modifier.modifierData);
    }
  }

  private void ForceEnableAllBells()
  {
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
    {
      if (!this.activeNames.Contains(modifierIcon.Value.name))
      {
        this.ToggleEffect(modifierIcon.Value);
        modifierIcon.Key.Ding();
        modifierIcon.Key.GetComponent<ModifierToggle>().SetActive(true);
      }
    }
    this.UpdatePointsDisplays();
    this.UpdateBells();
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
      modifierIcon.Key.GetComponent<ModifierToggle>().canToggle = false;
    SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiers", this.activeNames);
    this.animator.SetBool("Angry", this.points >= 10);
    this.animator.SetTrigger("Blip");
  }

  private void DisableForcedBells()
  {
    List<string> stringList = SaveSystem.LoadProgressData<List<string>>("activeHardModeModifiersBeforeOvercrank") ?? new List<string>();
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
    {
      if (!stringList.Contains(modifierIcon.Value.name))
      {
        this.ToggleEffect(modifierIcon.Value);
        modifierIcon.Key.GetComponent<ModifierToggle>().SetActive(false);
      }
    }
    this.UpdatePointsDisplays();
    this.UpdateBells();
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
      modifierIcon.Key.GetComponent<ModifierToggle>().canToggle = this.activeNames.Contains(modifierIcon.Value.name) || this.points + modifierIcon.Value.stormPoints <= this.maxPoints;
    SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiers", this.activeNames);
    this.animator.SetBool("Angry", this.points >= 10);
    this.animator.SetTrigger("Blip");
  }

  private void UpdatePointsDisplays()
  {
    foreach (ModifierIconMultiple stormBellDisplay in this.stormBellDisplays)
    {
      stormBellDisplay.Clear();
      if (this.active != null)
      {
        foreach (HardModeModifierData modeModifierData in this.active)
        {
          if ((bool) (UnityEngine.Object) modeModifierData)
            stormBellDisplay.Add(modeModifierData.modifierData);
        }
      }
    }
  }

  public static List<string> GetActiveStormBells() => SaveSystem.LoadProgressData<List<string>>("activeHardModeModifiers");

  public static int GetCurrentStormPoints(List<string> active)
  {
    int currentStormPoints = 0;
    if (active != null)
    {
      foreach (HardModeModifierData hardModeModifier in MonoBehaviourSingleton<References>.instance.hardModeModifiers)
      {
        if (active.Contains(hardModeModifier.name))
          currentStormPoints += hardModeModifier.stormPoints;
      }
    }
    return currentStormPoints;
  }

  public void UpdateAnimator()
  {
    this.animator.SetBool("Angry", this.points >= 10);
    this.animator.SetBool("Overcrank", this.overcrank);
    this.backgroundFader.FadeToColour(this.overcrank ? "Red" : (this.points >= 10 ? "Purple" : "Normal"));
    if (this.overcrank)
    {
      this.overcrankSmoke.Play();
      this.normalSmoke.Stop();
    }
    else
    {
      this.overcrankSmoke.Stop();
      if (this.points >= 10)
        this.normalSmoke.Play();
      else
        this.normalSmoke.Stop();
    }
  }

  public void ToggleOvercrank()
  {
    this.overcrank = !this.overcrank;
    this.animator.SetBool("Overcrank", this.overcrank);
    SaveSystem.SaveProgressData<bool>("stormPointOvercrank", this.overcrank);
    if (this.overcrank)
    {
      SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiersBeforeOvercrank", this.activeNames);
      this.ForceEnableAllBells();
      this.backgroundFader.FadeToColour("Red");
      SfxSystem.OneShot("event:/sfx/town/stormbell_overcrank");
      this.overcrankSmoke.Play();
      this.normalSmoke.Stop();
    }
    else
    {
      this.DisableForcedBells();
      this.backgroundFader.FadeToColour(this.points >= 10 ? "Purple" : "Normal");
      SfxSystem.OneShot("event:/sfx/town/stormbell_overcrank_deactivate");
      this.overcrankSmoke.Stop();
      if (this.points >= 10)
        this.normalSmoke.Play();
      else
        this.normalSmoke.Stop();
    }
    this.pointLimitDisplay.SetActive(!this.overcrank);
    this.overcrankDisplay.SetActive(this.overcrank);
    this.additionalButtons.SetActive(!this.overcrank);
    this.SetGlobalStormBellCountParam();
  }

  public static bool TrueFinalBossPointThresholdReached() => StormBellManager.GetCurrentStormPoints(StormBellManager.GetActiveStormBells()) >= 10;

  private IEnumerator GoldFrameRoutine(string[] modifierNames)
  {
    string[] strArray = modifierNames;
    for (int index = 0; index < strArray.Length; ++index)
    {
      string modifierName = strArray[index];
      KeyValuePair<ModifierIcon, HardModeModifierData> keyValuePair = this.modifierIcons.FirstOrDefault<KeyValuePair<ModifierIcon, HardModeModifierData>>((Func<KeyValuePair<ModifierIcon, HardModeModifierData>, bool>) (p => p.Value.name == modifierName));
      if ((bool) (UnityEngine.Object) keyValuePair.Key)
      {
        UnityEngine.Animator component = keyValuePair.Key.GetComponent<UnityEngine.Animator>();
        if (component != null)
        {
          component.SetBool("Gold", true);
          component.SetBool("BecomeGold", true);
          yield return (object) new WaitForSeconds(0.15f);
        }
      }
    }
    strArray = (string[]) null;
  }

  public void Randomize()
  {
    this.Clear();
    int num = 0;
    List<HardModeModifierData> modeModifierDataList = new List<HardModeModifierData>();
label_5:
    while (num != this.maxPoints)
    {
      modeModifierDataList.Clear();
      num = 0;
      List<HardModeModifierData> list = MonoBehaviourSingleton<References>.instance.hardModeModifiers.ToList<HardModeModifierData>();
      while (true)
      {
        HardModeModifierData random;
        do
        {
          if (num < this.maxPoints && list.Count > 0)
            random = list.TakeRandom<HardModeModifierData>();
          else
            goto label_5;
        }
        while (num + random.stormPoints > this.maxPoints);
        modeModifierDataList.Add(random);
        num += random.stormPoints;
      }
    }
    foreach (HardModeModifierData modeModifierData in modeModifierDataList)
    {
      HardModeModifierData modifier = modeModifierData;
      this.ToggleEffect(modifier);
      ModifierIcon key = this.modifierIcons.FirstOrDefault<KeyValuePair<ModifierIcon, HardModeModifierData>>((Func<KeyValuePair<ModifierIcon, HardModeModifierData>, bool>) (p => (UnityEngine.Object) p.Value == (UnityEngine.Object) modifier)).Key;
      if ((bool) (UnityEngine.Object) key)
      {
        key.Ding();
        key.GetComponent<ModifierToggle>().SetActive(true);
      }
    }
    SaveSystem.SaveProgressData<List<string>>("activeHardModeModifiers", this.activeNames);
    this.UpdatePointsDisplays();
    this.UpdateBells();
    this.UpdateAnimator();
    this.SetGlobalStormBellCountParam();
    SfxSystem.Stop(this.bellRandomizeSfxInstance);
    this.bellRandomizeSfxInstance = SfxSystem.OneShot(this.stormBellRandomizeSfx);
  }

  public void Clear()
  {
    foreach (KeyValuePair<ModifierIcon, HardModeModifierData> modifierIcon in this.modifierIcons)
    {
      if (this.activeNames.Contains(modifierIcon.Value.name))
        modifierIcon.Key.GetComponent<ModifierToggle>().Toggle();
    }
  }

  public void ClearAndPlaySfx()
  {
    if (this.active.Count <= 0)
      return;
    SfxSystem.OneShot(this.stormBellClearSfx);
    SfxSystem.Stop(this.bellRandomizeSfxInstance);
    SfxSystem.Stop(this.bellActivateSfxInstance);
    SfxSystem.Stop(this.bellActivate10SfxInstance);
    this.Clear();
  }
}
