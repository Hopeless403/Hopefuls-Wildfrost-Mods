using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WildfrostHopeMod.Effects.ContextEntity;

namespace WildfrostHopeMod.Effects
{// Restricted to a single entity
    public enum ContextEntity
    {
        //Basically any should work actually
        None,
        AllyBehind,
        AllyInFrontOf,
        BackAlly,
        FrontAlly,
        FrontEnemy,
        RightCardInHand,
        Self,
        Anything,

        Allies,
        Enemies,

        AnyItem,
        AnyClunker,
        AnySummoned,
        AnyFriendly,
        AnyEnemy,
        AnyMiniboss, // As in the cardType field, so including Leader and Boss/BossSmall
        CrownCard,

        CharmCard,

        EnemyShroomed, // Enemy (Shroomed)
                       // ALSO: Card (Status)
        WildUnit,
        SoulboundUnit,

        CardInFrontOf, // if no AllyInFrontOf, then FrontEnemy
        AllyInColumn,
        RedrawBell, // Hit, 

    }
    public static class ContextEntityExt
    {
        public static bool IsAlly(this ContextEntity entity)
        {
            return new List<ContextEntity>
            {
                AllyBehind,
                AllyInFrontOf,
                BackAlly,
                FrontAlly 
            }
            .Contains(entity);
        }
    }
}
