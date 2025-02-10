// Decompiled with JetBrains decompiler
// Type: AreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.AddressableAssets;

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
