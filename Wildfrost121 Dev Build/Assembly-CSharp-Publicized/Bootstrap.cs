// Decompiled with JetBrains decompiler
// Type: Bootstrap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
public class Bootstrap : MonoBehaviour
{
  [SerializeField]
  public string[] loadFirst = new string[2]
  {
    "Camera",
    "Global"
  };
  [SerializeField]
  public string[] thenLoad = new string[4]
  {
    "Input",
    "Systems",
    "Saving",
    "PauseScreen"
  };
  [SerializeField]
  public string startSceneKey = "MainMenu";
  [SerializeField]
  public string culture = "en-GB";
  [SerializeField]
  public UnityEngine.Animator progressAnimator;
  [SerializeField]
  public Image progressFill;
  [SerializeField]
  public float pauseBefore = 0.5f;
  [SerializeField]
  public float pauseAfter = 0.5f;
  [SerializeField]
  public bool unloadSceneAfter = true;
  [SerializeField]
  public float fillLerp = 0.1f;
  [SerializeField]
  public SplashScreenSequence splashScreen;
  [SerializeField]
  public float minTime;
  public float targetFill;
  public float fillAdd;
  public static bool done;
  public static int Count;
  public static readonly SortedSet<WildfrostMod> Mods = new SortedSet<WildfrostMod>();

  public void OnEnable() => ++Bootstrap.Count;

  public void OnDisable() => --Bootstrap.Count;

  public IEnumerator Start()
  {
    Bootstrap bootstrap = this;
    if (Bootstrap.done)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) bootstrap.gameObject);
    }
    else
    {
      Bootstrap.done = true;
      Scene thisScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
      Routine.Clump clump = new Routine.Clump();
      clump.Add(bootstrap.Load());
      if ((double) bootstrap.minTime > 0.0)
        clump.Add(Sequences.Wait(bootstrap.minTime));
      yield return (object) clump.WaitForEnd();
      while (AudioSettingsSystem.Loading)
        yield return (object) null;
      if ((bool) (UnityEngine.Object) bootstrap.splashScreen)
        yield return (object) bootstrap.splashScreen.Run();
      bootstrap.ModsSetup();
      SceneManager.JobStart();
      yield return (object) Transition.To(bootstrap.startSceneKey);
      if (bootstrap.unloadSceneAfter)
      {
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(thisScene).completed += (Action<AsyncOperation>) (a => SceneManager.JobEnd());
      }
      else
      {
        UnityEngine.Object.Destroy((UnityEngine.Object) bootstrap.gameObject);
        SceneManager.JobEnd();
      }
    }
  }

  public IEnumerator Load()
  {
    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(this.culture);
    this.fillAdd = 1f / (float) (this.loadFirst.Length + this.thenLoad.Length);
    yield return (object) new WaitForSeconds(this.pauseBefore);
    if ((bool) (UnityEngine.Object) this.progressAnimator)
      this.progressAnimator.SetBool("Increasing", true);
    yield return (object) this.Load((IEnumerable<string>) this.loadFirst);
    yield return (object) this.Load((IEnumerable<string>) this.thenLoad);
    if ((bool) (UnityEngine.Object) this.progressAnimator)
    {
      this.progressAnimator.SetBool("Increasing", false);
      this.progressAnimator.SetTrigger("Ping");
    }
    yield return (object) new WaitForSeconds(this.pauseAfter);
  }

  public void Update()
  {
    if (!(bool) (UnityEngine.Object) this.progressFill)
      return;
    this.progressFill.fillAmount = Delta.Lerp(this.progressFill.fillAmount, this.targetFill, this.fillLerp, Time.deltaTime);
  }

  public IEnumerator Load(IEnumerable<string> sceneKeys)
  {
    Bootstrap bootstrap = this;
    Routine.Clump clump = new Routine.Clump();
    foreach (string sceneKey in sceneKeys)
      clump.Add(SceneManager.Load(sceneKey, SceneType.Persistent, new Action<Scene>(bootstrap.\u003CLoad\u003Eb__21_0)));
    yield return (object) clump.WaitForEnd();
  }

  public static bool IsModDirectory(string dir, out string[] dlls)
  {
    dlls = System.IO.Directory.GetFiles(dir, "*.dll");
    return dlls.Length != 0;
  }

  public static void LoadModAtPath(string path)
  {
    string[] dlls;
    if (!Bootstrap.IsModDirectory(path, out dlls))
      return;
    Assembly assembly1 = (Assembly) null;
    foreach (string assemblyFile in dlls)
    {
      Assembly assembly2 = Assembly.LoadFrom(assemblyFile);
      try
      {
        foreach (System.Type type in assembly2.GetTypes())
        {
          if (type.BaseType == typeof (WildfrostMod))
          {
            Debug.Log((object) "Found valid mod type");
            assembly1 = assembly2;
            break;
          }
        }
      }
      catch (TypeLoadException ex)
      {
      }
    }
    if (assembly1 == (Assembly) null)
    {
      Debug.LogWarning((object) ("Empty mod? " + path));
    }
    else
    {
      foreach (System.Type type in assembly1.GetTypes())
      {
        if (type.BaseType == typeof (WildfrostMod) && type != typeof (InternalMod))
        {
          WildfrostMod instance = Activator.CreateInstance(type, (object) path) as WildfrostMod;
          Bootstrap.Mods.Add(instance);
          break;
        }
      }
      Debug.LogWarning((object) ("Properly loaded mod and added instance " + assembly1?.ToString()));
    }
    Debug.LogWarning((object) ("Found mod directory " + path));
  }

  public void ModsSetup()
  {
    foreach (System.Type allDataType in WildfrostMod.AllDataTypes)
      typeof (AddressableLoader).GetMethod("GetGroup", BindingFlags.Static | BindingFlags.Public).MakeGenericMethod(allDataType).Invoke((object) this, new object[1]
      {
        (object) allDataType.ToString()
      });
    TMP_Text.OnSpriteAssetRequest += (Func<int, string, TMP_SpriteAsset>) ((hash, s) =>
    {
      foreach (WildfrostMod mod in Bootstrap.Mods)
      {
        if (s == mod.GUID)
          return mod.HasLoaded ? mod.SpriteAsset : (TMP_SpriteAsset) null;
      }
      return (TMP_SpriteAsset) null;
    });
    string path = Path.Combine(Application.streamingAssetsPath, "Mods");
    if (!System.IO.Directory.Exists(path))
      System.IO.Directory.CreateDirectory(path);
    foreach (string directory in System.IO.Directory.GetDirectories(path))
      Bootstrap.LoadModAtPath(directory);
    foreach (WildfrostMod lastMod in WildfrostMod.GetLastMods())
      lastMod?.ModLoad();
  }

  [CompilerGenerated]
  public void \u003CLoad\u003Eb__21_0(Scene a) => this.targetFill += this.fillAdd;
}
