// Decompiled with JetBrains decompiler
// Type: Bootstrap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
  [SerializeField]
  private string[] loadFirst = new string[2]
  {
    "Camera",
    "Global"
  };
  [SerializeField]
  private string[] thenLoad = new string[4]
  {
    "Input",
    "Systems",
    "Saving",
    "PauseScreen"
  };
  [SerializeField]
  private string startSceneKey = "MainMenu";
  [SerializeField]
  private string culture = "en-GB";
  [SerializeField]
  private UnityEngine.Animator progressAnimator;
  [SerializeField]
  private Image progressFill;
  [SerializeField]
  private float pauseBefore = 0.5f;
  [SerializeField]
  private float pauseAfter = 0.5f;
  [SerializeField]
  private bool unloadSceneAfter = true;
  [SerializeField]
  private float fillLerp = 0.1f;
  [SerializeField]
  private SplashScreenSequence splashScreen;
  [SerializeField]
  private float minTime;
  private float targetFill;
  private float fillAdd;
  private static bool done;
  public static int Count;
  public static readonly SortedSet<WildfrostMod> Mods = new SortedSet<WildfrostMod>();

  private void OnEnable() => ++Bootstrap.Count;

  private void OnDisable() => --Bootstrap.Count;

  private IEnumerator Start()
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
      bootstrap.ModsSetup();
      Routine.Clump clump = new Routine.Clump();
      clump.Add(bootstrap.Load());
      if ((double) bootstrap.minTime > 0.0)
        clump.Add(Sequences.Wait(bootstrap.minTime));
      yield return (object) clump.WaitForEnd();
      while (AudioSettingsSystem.Loading)
        yield return (object) null;
      if ((bool) (UnityEngine.Object) bootstrap.splashScreen)
        yield return (object) bootstrap.splashScreen.Run();
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

  private IEnumerator Load()
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

  private void Update()
  {
    if (!(bool) (UnityEngine.Object) this.progressFill)
      return;
    this.progressFill.fillAmount = Delta.Lerp(this.progressFill.fillAmount, this.targetFill, this.fillLerp, Time.deltaTime);
  }

  private IEnumerator Load(IEnumerable<string> sceneKeys)
  {
    Bootstrap bootstrap = this;
    Routine.Clump clump = new Routine.Clump();
    foreach (string sceneKey in sceneKeys)
    {
      // ISSUE: reference to a compiler-generated method
      clump.Add(SceneManager.Load(sceneKey, SceneType.Persistent, new Action<Scene>(bootstrap.\u003CLoad\u003Eb__21_0)));
    }
    yield return (object) clump.WaitForEnd();
  }

  private static bool IsModDirectory(string dir, out string[] dlls)
  {
    dlls = System.IO.Directory.GetFiles(dir, "*.dll");
    return dlls.Length != 0;
  }

  internal static void LoadModAtPath(string path)
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
        if (type.BaseType == typeof (WildfrostMod))
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

  private void ModsSetup()
  {
    foreach (System.Type allDataType in WildfrostMod.AllDataTypes)
      typeof (AddressableLoader).GetMethod("GetGroup", BindingFlags.Static | BindingFlags.Public).MakeGenericMethod(allDataType).Invoke((object) this, new object[1]
      {
        (object) allDataType.ToString()
      });
    string path = Path.Combine(Application.streamingAssetsPath, "Mods");
    if (!System.IO.Directory.Exists(path))
      System.IO.Directory.CreateDirectory(path);
    foreach (string directory in System.IO.Directory.GetDirectories(path))
      Bootstrap.LoadModAtPath(directory);
  }
}
