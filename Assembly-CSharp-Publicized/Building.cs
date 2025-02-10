// Decompiled with JetBrains decompiler
// Type: Building
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Building : MonoBehaviour
{
  public BuildingType type;
  public bool canSelect = true;
  [SerializeField]
  public UnityEventGameObject onSelect;
  [SerializeField]
  public GameObject toBuild;
  [SerializeField]
  public GameObject underConstruction;
  [SerializeField]
  public GameObject fullyBuilt;
  [SerializeField]
  public Building.Icon[] icons;
  [SerializeField]
  public UnityEvent onDataUpdated;
  public bool buildStarted;
  public bool built;
  public List<string> unlocks;
  public List<string> uncheckedUnlocks;
  public GameObject currentActiveIcon;

  public List<string> checkedUnlocks
  {
    get
    {
      if (this.unlocks == null)
        return (List<string>) null;
      return this.uncheckedUnlocks == null ? this.unlocks : this.unlocks.Except<string>((IEnumerable<string>) this.uncheckedUnlocks).ToList<string>();
    }
  }

  public bool HasUncheckedUnlocks
  {
    get
    {
      List<string> uncheckedUnlocks = this.uncheckedUnlocks;
      return uncheckedUnlocks != null && uncheckedUnlocks.Count > 0;
    }
  }

  public void CheckIfUnlocked()
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    this.buildStarted = (UnityEngine.Object) this.type.started == (UnityEngine.Object) null || MetaprogressionSystem.IsUnlocked(this.type.started, unlockedList);
    this.built = (UnityEngine.Object) this.type.finished == (UnityEngine.Object) null || MetaprogressionSystem.IsUnlocked(this.type.finished, unlockedList);
    if (!this.built && !this.buildStarted)
    {
      this.gameObject.SetActive(false);
    }
    else
    {
      this.gameObject.SetActive(true);
      this.RunUpdateEvent();
    }
  }

  public void RunUpdateEvent()
  {
    this.onDataUpdated?.Invoke();
    if (this.built && this.type.unlocks != null && this.type.unlocks.Length != 0)
    {
      List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
      this.unlocks = ((IEnumerable<UnlockData>) this.type.unlocks).Select<UnlockData, string>((Func<UnlockData, string>) (a => a.name)).Intersect<string>((IEnumerable<string>) unlockedList).ToList<string>();
      if (this.unlocks.Count > 0 && !this.type.unlockedCheckedKey.IsNullOrWhitespace())
      {
        List<string> second = SaveSystem.LoadProgressData<List<string>>(this.type.unlockedCheckedKey);
        this.uncheckedUnlocks = second == null ? new List<string>((IEnumerable<string>) this.unlocks) : this.unlocks.Except<string>((IEnumerable<string>) second).ToList<string>();
        Debug.Log((object) string.Format("[{0}] has unchecked {1} unlocks [{2}]", (object) this.name, (object) this.uncheckedUnlocks.Count, (object) string.Join(", ", (IEnumerable<string>) this.uncheckedUnlocks)));
      }
    }
    this.UpdateSprite();
    this.SetSuitableIcon();
  }

  public bool Select()
  {
    try
    {
      if (this.canSelect)
      {
        if (this.onSelect != null)
        {
          this.onSelect.Invoke(this.onSelect.GetPersistentTarget(0) as GameObject);
          return true;
        }
      }
    }
    catch (ArgumentOutOfRangeException ex)
    {
      return false;
    }
    return false;
  }

  public void UpdateSprite()
  {
    if ((bool) (UnityEngine.Object) this.toBuild)
      this.toBuild.gameObject.SetActive(!this.buildStarted && !this.built);
    if ((bool) (UnityEngine.Object) this.underConstruction)
      this.underConstruction.gameObject.SetActive(this.buildStarted && !this.built);
    if (!(bool) (UnityEngine.Object) this.fullyBuilt)
      return;
    this.fullyBuilt.gameObject.SetActive(this.built);
  }

  public void SetSuitableIcon()
  {
    string name = "";
    foreach (BuildingIconSetter component in this.GetComponents<BuildingIconSetter>())
      name = component.Get(this);
    this.SetIcon(name);
  }

  public void SetIcon(string name)
  {
    if ((bool) (UnityEngine.Object) this.currentActiveIcon)
      this.currentActiveIcon.SetActive(false);
    if (name.IsNullOrWhitespace())
      return;
    Building.Icon icon = ((IEnumerable<Building.Icon>) this.icons).FirstOrDefault<Building.Icon>((Func<Building.Icon, bool>) (a => a.name == name));
    if (icon == null)
      return;
    this.currentActiveIcon = icon.obj;
    this.currentActiveIcon.SetActive(true);
  }

  public void Bloop()
  {
    this.transform.localScale = new Vector3(1.5f, 0.6666667f, 1f);
    LeanTween.cancel(this.gameObject);
    LeanTween.scale(this.gameObject, Vector3.one, 1.5f).setEase(LeanTweenType.easeOutElastic);
  }

  public void CreateDisplay(GameObject prefab) => UnityEngine.Object.FindObjectOfType<BuildingDisplay>(true)?.Create(prefab, this);

  [Serializable]
  public class Icon
  {
    public string name;
    public GameObject obj;
  }
}
