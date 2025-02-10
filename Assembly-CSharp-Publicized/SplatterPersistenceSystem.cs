// Decompiled with JetBrains decompiler
// Type: SplatterPersistenceSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class SplatterPersistenceSystem : GameSystem
{
  [SerializeField]
  public int[] teamsToSave;
  [SerializeField]
  public Splatter basicSplatterPrefab;
  [SerializeField]
  [ReadOnly]
  public int savedCount;
  [SerializeField]
  [ReadOnly]
  public bool saveRequired;
  public Dictionary<ulong, SplatterPersistenceSystem.SplatterData[]> storedSplatters;

  public void OnEnable()
  {
    global::Events.OnEntityCreated += new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityDestroyed += new UnityAction<Entity>(this.EntityDestroyed);
    global::Events.OnCampaignSaved += new UnityAction(this.CheckSave);
    global::Events.OnCampaignLoaded += new UnityAction(this.Load);
    global::Events.OnCampaignFinal += new UnityAction(this.Clear);
  }

  public void OnDisable()
  {
    global::Events.OnEntityCreated -= new UnityAction<Entity>(this.EntityCreated);
    global::Events.OnEntityDestroyed -= new UnityAction<Entity>(this.EntityDestroyed);
    global::Events.OnCampaignSaved -= new UnityAction(this.CheckSave);
    global::Events.OnCampaignLoaded -= new UnityAction(this.Load);
    global::Events.OnCampaignFinal -= new UnityAction(this.Clear);
  }

  public void EntityCreated(Entity entity)
  {
    if (this.storedSplatters == null || !(bool) (UnityEngine.Object) entity.data || !this.storedSplatters.ContainsKey(entity.data.id) || !(bool) (UnityEngine.Object) entity.splatterSurface)
      return;
    SplatterPersistenceSystem.SplatterData[] storedSplatter = this.storedSplatters[entity.data.id];
    foreach (SplatterPersistenceSystem.SplatterData data in storedSplatter)
      entity.splatterSurface.Load(data, this.basicSplatterPrefab);
    Debug.Log((object) string.Format("Creating [{0}] splatters on [{1}]", (object) storedSplatter.Length, (object) entity));
  }

  public void EntityDestroyed(Entity entity)
  {
    if (!((UnityEngine.Object) entity.data != (UnityEngine.Object) null) || !((UnityEngine.Object) entity.owner != (UnityEngine.Object) null) || !this.teamsToSave.Contains<int>(entity.owner.team) || !entity.owner.data.inventory.deck.Contains(entity.data) && !entity.owner.data.inventory.reserve.Contains(entity.data) || !((UnityEngine.Object) entity.splatterSurface != (UnityEngine.Object) null))
      return;
    Splatter[] activeSplatters = entity.splatterSurface.GetActiveSplatters();
    if (activeSplatters == null || activeSplatters.Length <= 0)
      return;
    List<SplatterPersistenceSystem.SplatterData> list = ((IEnumerable<Splatter>) activeSplatters).Select<Splatter, SplatterPersistenceSystem.SplatterData>((Func<Splatter, SplatterPersistenceSystem.SplatterData>) (splatter => new SplatterPersistenceSystem.SplatterData(splatter))).ToList<SplatterPersistenceSystem.SplatterData>();
    if (this.storedSplatters == null)
      this.storedSplatters = new Dictionary<ulong, SplatterPersistenceSystem.SplatterData[]>();
    if (this.storedSplatters.ContainsKey(entity.data.id))
    {
      this.storedSplatters[entity.data.id] = list.ToArray();
    }
    else
    {
      this.storedSplatters.Add(entity.data.id, list.ToArray());
      ++this.savedCount;
    }
    this.saveRequired = true;
    Debug.Log((object) string.Format("Storing [{0}] splatters on data for [{1}]", (object) list.Count, (object) entity));
  }

  public void CheckSave()
  {
    if (!this.saveRequired || !Campaign.Data.GameMode.doSave)
      return;
    SaveSystem.SaveCampaignData<Dictionary<ulong, SplatterPersistenceSystem.SplatterData[]>>(Campaign.Data.GameMode, "splatter", this.storedSplatters);
    this.saveRequired = false;
  }

  public void Load()
  {
    if (SaveSystem.CampaignDataExists(Campaign.Data.GameMode, "splatter"))
    {
      this.storedSplatters = SaveSystem.LoadCampaignData<Dictionary<ulong, SplatterPersistenceSystem.SplatterData[]>>(Campaign.Data.GameMode, "splatter");
      Dictionary<ulong, SplatterPersistenceSystem.SplatterData[]> storedSplatters = this.storedSplatters;
      // ISSUE: explicit non-virtual call
      this.savedCount = storedSplatters != null ? __nonvirtual (storedSplatters.Count) : 0;
    }
    else
      this.Clear();
  }

  public void Clear()
  {
    this.storedSplatters = (Dictionary<ulong, SplatterPersistenceSystem.SplatterData[]>) null;
    this.savedCount = 0;
  }

  [Serializable]
  public class SplatterData
  {
    public Sprite sprite;
    public Color color;
    public Vector3 offset;
    public Vector3 scale;
    public float angle;

    public SplatterData()
    {
    }

    public SplatterData(Splatter splatter)
    {
      this.sprite = splatter.sprite;
      this.color = splatter.color;
      Transform transform = splatter.transform;
      this.offset = transform.localPosition;
      this.scale = transform.localScale;
      this.angle = transform.localEulerAngles.z;
    }
  }
}
