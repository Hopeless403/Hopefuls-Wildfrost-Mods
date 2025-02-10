// Decompiled with JetBrains decompiler
// Type: AreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
[CreateAssetMenu(menuName = "Area", fileName = "Area")]
public class AreaData : ScriptableObject
{
  public EventReference battleMusicEvent;
  public EventReference minibossMusicEvent;
  public EventReference bossMusicEvent;
  public EventReference ambienceEvent;
  public AssetReferenceGameObject battleBackgroundPrefabRef;
  public Sprite battleBaseSprite;
}
