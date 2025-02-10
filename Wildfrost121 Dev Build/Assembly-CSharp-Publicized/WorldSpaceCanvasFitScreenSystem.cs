// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasFitScreenSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class WorldSpaceCanvasFitScreenSystem : GameSystem
{
  public static WorldSpaceCanvasFitScreenSystem instance;
  public static bool exists;
  [Header("Screen Size")]
  [ReadOnly]
  public int screenWidth;
  [ReadOnly]
  public int screenHeight;
  [ReadOnly]
  public float aspectRatio;
  [Header("UI Size")]
  [ReadOnly]
  public Rect safeArea;
  public const float fixedHeight = 11.547f;
  public const float maxWidth = 26.943f;
  public const float minWidth = 17.32051f;
  public const float minAspect = 1.5f;
  public const float maxAspect = 2.33333325f;
  [CompilerGenerated]
  public Camera \u003Ccam\u003Ek__BackingField;
  public static readonly List<WorldSpaceCanvasUpdater> canvases = new List<WorldSpaceCanvasUpdater>();
  public static readonly Vector3 camPosition = new Vector3(0.0f, 0.0f, -10f);
  public ScreenOrientation lastOrientation;
  public Rect lastSafeArea;

  public Camera cam
  {
    get => this.\u003Ccam\u003Ek__BackingField;
    set => this.\u003Ccam\u003Ek__BackingField = value;
  }

  public static float AspectRatio
  {
    get
    {
      return !WorldSpaceCanvasFitScreenSystem.exists ? 1.77777779f : Mathf.Min(2.33333325f, WorldSpaceCanvasFitScreenSystem.instance.aspectRatio);
    }
  }

  public void OnEnable()
  {
    WorldSpaceCanvasFitScreenSystem.instance = this;
    WorldSpaceCanvasFitScreenSystem.exists = true;
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.UpdateSize();
  }

  public void OnDisable() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  public void SceneChanged(Scene scene) => this.UpdateSize();

  public void Update()
  {
    if (!(bool) (Object) this.cam)
    {
      this.cam = Camera.main;
      if (!(bool) (Object) this.cam)
        return;
      this.UpdateSize();
    }
    else
    {
      if (this.cam.scaledPixelWidth == this.screenWidth && this.cam.scaledPixelHeight == this.screenHeight)
        return;
      this.UpdateSize();
    }
  }

  [Button(null, EButtonEnableMode.Always)]
  public void UpdateSize()
  {
    this.lastOrientation = Screen.orientation;
    this.lastSafeArea = Screen.safeArea;
    Debug.Log((object) string.Format("[{0}] UPDATING ~World Space~ CANVAS SIZE", (object) this));
    if (!(bool) (Object) this.cam)
      this.cam = Camera.main;
    this.screenWidth = this.cam.scaledPixelWidth;
    this.screenHeight = this.cam.scaledPixelHeight;
    this.aspectRatio = this.cam.aspect;
    Debug.Log((object) string.Format("New Size: ({0}, {1}) Aspect: {2}", (object) this.screenWidth, (object) this.screenHeight, (object) this.aspectRatio));
    int screenWidth = this.screenWidth;
    Rect safeArea1;
    if ((double) this.aspectRatio > 2.3333332538604736)
    {
      screenWidth = Mathf.RoundToInt((float) this.screenHeight * 2.33333325f);
      Debug.Log((object) string.Format("OVER MAX ASPECT RATIO. Actual Size: ({0}, {1}) Aspect: {2}", (object) screenWidth, (object) this.screenHeight, (object) (float) ((double) screenWidth / (double) this.screenHeight)));
      ref Rect local = ref safeArea1;
      double x = (double) Screen.safeArea.x;
      double y = (double) Screen.safeArea.y;
      Rect safeArea2 = Screen.safeArea;
      double width = (double) safeArea2.width;
      safeArea2 = Screen.safeArea;
      double height = (double) safeArea2.height;
      local = new Rect((float) x, (float) y, (float) width, (float) height);
      if ((double) safeArea1.width / (double) safeArea1.height > 2.3333332538604736)
      {
        float num1 = safeArea1.height * 2.33333325f;
        float num2 = safeArea1.width - num1;
        safeArea1.x = Mathf.Max(0.0f, safeArea1.x - num2);
        safeArea1.width = num1;
      }
    }
    else
      safeArea1 = Screen.safeArea;
    this.safeArea = new Rect()
    {
      x = safeArea1.x / (float) screenWidth,
      y = safeArea1.y / (float) this.screenHeight,
      width = safeArea1.width / (float) screenWidth,
      height = safeArea1.height / (float) this.screenHeight
    };
    Debug.Log((object) string.Format("UI Safe Area: {0}", (object) safeArea1));
    foreach (WorldSpaceCanvasUpdater canvase in WorldSpaceCanvasFitScreenSystem.canvases)
      canvase.UpdateSize();
  }

  public static void Register(WorldSpaceCanvasUpdater canvas)
  {
    WorldSpaceCanvasFitScreenSystem.canvases.Add(canvas);
  }

  public static void Unregister(WorldSpaceCanvasUpdater canvas)
  {
    WorldSpaceCanvasFitScreenSystem.canvases.Remove(canvas);
  }
}
