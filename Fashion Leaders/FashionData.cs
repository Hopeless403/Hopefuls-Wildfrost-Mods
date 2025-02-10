using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.Fashion
{
    public class CharacterDataFashion : CharacterData
    {
        public Dictionary<string, (string, string)> types = new();

        public new void SetRandomPrefab(bool locked, CharacterType type, string name, ref int index)
        {
            if (locked)
                return;
            CharacterType.PrefabGroup prefabGroup = ((IEnumerable<CharacterType.PrefabGroup>)type.prefabs).FirstOrDefault<CharacterType.PrefabGroup>((Func<CharacterType.PrefabGroup, bool>)(a => a.name == name));
            if (prefabGroup == null)
                return;
            index = prefabGroup.collection.RandomIndex();
            types[name] = (race, gender);
        }

        public new void SetRandomSprite(bool locked, CharacterType type, string name, ref int index)
        {
            if (locked)
                return;
            CharacterType.SpriteGroup spriteGroup = ((IEnumerable<CharacterType.SpriteGroup>)type.sprites).FirstOrDefault<CharacterType.SpriteGroup>((Func<CharacterType.SpriteGroup, bool>)(a => a.name == name));
            if (spriteGroup == null)
                return;
            index = spriteGroup.collection.RandomIndex();
            types[name] = (race, gender);
        }

        public new void SetRandomColorSet(bool locked, CharacterType type, string name, ref int index)
        {
            if (locked)
                return;
            CharacterType.ColorSetGroup colorSetGroup = ((IEnumerable<CharacterType.ColorSetGroup>)type.colorSets).FirstOrDefault<CharacterType.ColorSetGroup>((Func<CharacterType.ColorSetGroup, bool>)(a => a.name == name));
            if (colorSetGroup == null)
                return;
            index = colorSetGroup.collection.RandomIndex();
            types[name] = (race, gender);
        }

        public CharacterDataFashion(CharacterData data)
        {
            // get property list of the target object.
            // this is a reflection extension which simply gets properties (CanWrite = true).
            var tprops = typeof(CharacterDataFashion).GetProperties();

            tprops.Where(x => x.CanWrite == true).ToList().ForEach(prop =>
            {
                // check whether source object has the the property
                var sp = typeof(CharacterData).GetProperty(prop.Name);
                if (sp != null)
                {
                    // if yes, copy the value to the matching property
                    var value = sp.GetValue(data, null);
                    typeof(CharacterDataFashion).GetProperty(prop.Name).SetValue(this, value, null);
                }
            });
        }


    }
    [HarmonyPatch(typeof(CardScriptLeader), nameof(CardScriptLeader.Run))]
    public class PatchCSLeader
    {
        public static void Postfix(CardData target)
        {
            if (target.TryGetCustomData("CharacterData", out CharacterData characterData, null))
            {
                //target.SetCustomData("CharacterData", new CharacterDataFashion(characterData));
                Debug.LogWarning("would replace custom data");
            }
            Debug.LogWarning("done");
        }
    }
    [HarmonyPatch(typeof(CharacterAvatar), nameof(CharacterAvatar.UpdateDisplay))]
    public class PatchAvatar
    {
        public static bool Prefix(CharacterData data)
        {
            /*if (data is not CharacterDataFashion fashion)
                return true;
            Debug.LogWarning(fashion);*/
            Debug.LogWarning(data is CharacterDataFashion fashion);
            return true;
        }
    }
}

