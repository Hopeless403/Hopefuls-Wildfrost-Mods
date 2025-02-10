using System;
using UnityEngine;
using UnityEngine.Localization;
using WildFrostModHope;
using WildfrostModMiya;

namespace WildfrostModHope;

public static class ClassAdder
{
    public static event Action<int> OnAskForAddingClasses;

    public static ClassData ModifyFields<T>(
        this T t, 
        Func<T, T> modifyFields) where T : ClassData
    {
        t = modifyFields(t);
        return t;
    }

    public static T SetText<T>(this T t, string text) where T : ClassData
    {
        t.textKey = LocalizationHelper.FromId(LocalizationHelper.CreateLocalizedString(((Object)(object)t).name + ".Text", text));
        return t;
    }

    public static T RegisterClassInApi<T>(this T t) where T : ClassData
    {
        WildFrostTribeAdder.ClassDataAdditions.Add((ClassData)t);
        return t;
    }

    public static T CreateClassData<T>(string modName, string cardName) where T : ClassData
    {
        T instance = ScriptableObject.CreateInstance<T>();
        instance.textKey = new LocalizedString();
        ((Object)(object)instance).name = cardName.StartsWith(modName) ? cardName : modName + "." + cardName;
        if (modName == "")
            ((Object)(object)instance).name = cardName;
        return instance;
    }

    internal static void LaunchEvent()
    {
        Action<int> addingClasses = ClassAdder.OnAskForAddingClasses;
        if (addingClasses == null)
            return;
        addingClasses(0);
    }
}
