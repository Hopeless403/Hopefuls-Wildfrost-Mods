// Decompiled with JetBrains decompiler
// Type: AreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
