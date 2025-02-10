using Il2CppSystem.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin;
static class WikiData
{
    


    public static string cards = """
    --Pets
    cards["Booshu"] = {
    	Name="Booshu",
    	Types={Pet=true, Companion=true},
    	Health=4,
    	Attack=3,
    	Counter=5,
    	Desc="Restore '''3''' {{Stat|Health}} to all allies",
    	Challenge="Recall '''3''' Companions",
    	ChallengeOrder=1,
    }

    cards["Binku"]= {
    	Name="Binku",
    	Types={Pet=true, Companion=true},
    	Health=3,
    	Attack=2,
    	Counter=4,
    	Desc="Apply '''3''' {{Stat|Ink}}",
    	Challenge="Hit the Enemy Wave Bell '''5''' times",
    	ChallengeOrder=5
    }
    cards["Lil Gazi"] = {
    	Name="Lil' Gazi",
    	Types={Pet=true, Companion=true},
    	Health=3,
    	Attack=4,
    	Counter=4,
    	Desc="While active, add '''+1''' {{Stat|Attack}} to all allies",
    	Challenge="Achieve a '''6x''' kill combo",
    	ChallengeOrder=6,
    }
    cards["Loki"] = {
    	Name="Loki",
    	Types={Pet=true, Companion=true},
    	Health=5,
    	Attack=3,
    	Counter=3,
    	Desc="Apply '''1''' {{Stat|Demonize}}<br>{{Keyword|Aimless}}",
    	Challenge="Kill '''3''' {{Stat|Demonize|Demonized}} enemies",
    	ChallengeOrder=2,
    }
    cards["Sneezle"] = {
    	Name="Sneezle",
    	Types={Pet=true, Companion=true},
    	Health=6,
    	Attack=2,
    	Counter=3,
    	Desc="{{Keyword|Draw}} '''1''' when hit",
    	Challenge="Buy '''5''' discounted [[Items]]",
    	ChallengeOrder=3,
    }
    cards["Snoof"] = {
    	Name="Snoof",
    	Types={Pet=true, Companion=true},
    	Health=3,
    	Attack=3,
    	Counter=3,
    	Desc="Apply '''1''' {{Stat|Snow}}",
    	Challenge="''Unlocked by default.''",
    	ChallengeOrder=0,
    }
    cards["Spike"] = {
    	Name="Spike",
    	Types={Pet=true, Companion=true},
    	Health=7,
    	Other="2 {{Stat|Teeth}}",
    	Desc="{{Keyword|Hogheaded}}",
    	Challenge="Kill '''10''' enemies with {{Stat|Teeth}}",
    	ChallengeOrder=4,
    }

    --Frozen Travellers
    cards["Alloy"] = {
    	Name="Alloy",
    	Types={Companion=true, HotSpring=true, NonPetCompanion=true},
    	Health=12,
    	Attack=6,
    	Counter=5,
    	Other="1 {{Stat|Bom}}",
    	Desc="Apply '''1''' {{Stat|Scrap}} to a random ally",
    	Tribes={"Clunkmasters"},
    	Challenge="Add 10 {{Keyword|Scrap}} to Clunkers",
    	ChallengeOrder=5,
    }

    cards["The Baker"] = {
    	Name="The Baker",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=9,
    	Counter=4,
    	Desc="Add '''1''' {{Card|Skull Muffin}} to your hand<br>{{Keyword|Spark}}",
    	Tribes={"Shademancers"},
    }

    cards["Berry Sis"] = {
    	Name="Berry Sis",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=2,
    	Counter=3,
    	Desc="When hit, add lost {{Stat|Health}} to a random ally",
    	Tribes={"Shademancers"},
    }
    cards["Big Berry"] = {
    	Name="Big Berry",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=10,
    	Attack=5,
    	Counter=4,
    	Desc="On kill, restore '''2''' {{Stat|Health}} to self and allies in the row",
    	Tribes={"All"},
    }
    cards["Biji"] = {
    	Name="Biji",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=0,
    	Counter=4,
    	Desc="Apply '''3''' {{Stat|Bom}}<br>Increase by 1 when hit",
    	Tribes={"Clunkmasters"},
    }
    cards["Blunky"] = {
    	Name="Blunky",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=1,
    	Attack=1,
    	Counter=2,
    	Desc="When deployed, gain '''1''' {{Stat|Block}}",
    	Tribes={"All"},
    }
    cards["Bombom"] = {
    	Name="Bombom",
    	Types={Companion=true, HotSpring=true, NonPetCompanion=true},
    	Health=16,
    	Attack=7,
    	Counter=4,
    	Desc="Deal '''5''' damage to self and allies in the row<br>{{Keyword|Barrage}}",
    	Tribes={"All"},
    	Challenge="Use {{Keyword|Smackback}} to kill 20 enemies",
    	ChallengeOrder=3,
    }
    cards["Bonnie"] = {
    	Name="Bonnie",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=4,
    	Counter=4,
    	Desc="Restore '''2''' {{Stat|Health}} and {{Keyword|Cleanse}} all allies",
    	Tribes={"All"},
    }
    cards["Chikichi"] = {
    	Name="Chikichi",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=2,
    	Attack=2,
    	Counter=3,
    	Desc="When {{Keyword|Sacrificed}}, summon [[Chikani]]",
    	Tribes={"Shademancers"},
    }
    cards["Chompom"] = {
    	Name="Chompom",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=3,
    	Attack=1,
    	Counter=3,
    	Other="2 {{Stat|Shell}}",
    	Desc="Deal additional damage equal to {{Stat|Shell}}",
    	Tribes={"Snowdwellers"},
    }
    cards["Devicro"] = {
    	Name="Devicro",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=7,
    	Attack=2,
    	Counter=4,
    	Desc="When an ally is {{Keyword|Sacrificed}}, gain their {{Stat|Attack}}",
    	Tribes={"Shademancers"},
    }
    cards["Dimona"] = {
    	Name="Dimona",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=6,
    	Attack=2,
    	Counter=3,
    	Desc="When an enemy is hit with an [[Item]], apply '''1''' {{Stat|Demonize}} to them",
    	Tribes={"All"},
    }
    cards["Egg"] = {
    	Name="Egg",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Desc="When destroyed, summon [[Dregg]]",
    	Tribes={"Shademancers"},
    }
    cards["Firefist"] = {
    	Name="Firefist",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=12,
    	Attack=2,
    	Counter=5,
    	Desc="When {{Stat|Health}} lost, gain equal {{Stat|Spice}}",
    	Tribes={"Snowdwellers"},
    }
    cards["Fizzle"] = {
    	Name="Fizzle",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=5,
    	Attack=0,
    	Counter=4,
    	Other="x3 {{Stat|Frenzy}}",
    	Desc="Apply '''1''' {{Stat|Bom}}",
    	Tribes={"Clunkmasters"},
    }
    cards["Folby"] = {
    	Name="Folby",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=12,
    	Attack=3,
    	Counter=4,
    	Desc="{{Keyword|Trash}} '''1''' when hit",
    	Tribes={"Clunkmasters"},
    }
    cards["Foxee"] = {
    	Name="Foxee",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=4,
    	Attack=1,
    	Counter=3,
    	Other="x3 {{Stat|Frenzy}}",
    	Tribes={"All"},
    }

    cards["Fulbert"] = {
    	Name="Fulbert",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 4,
    	Attack= 1,
    	Counter= 3,
    	Desc="When {{Stat|Spice|Spiced}} or {{Stat|Shell|Shelled}}, apply equal {{Stat|Shroom}} to a random enemy",
    	Tribes={"Snowdwellers"},
    }

    cards["Fungun"] = {
    	Name="Fungun",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=10,
    	Attack=0,
    	Counter=5,
    	Desc="Apply '''2''' {{Stat|Shroom}}<br>Increase by 1 when hit",
    	Tribes={"Snowdwellers"},
    }

    cards["Gojiber"] = {
    	Name="Gojiber",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 7,
    	Attack= 0,
    	Other="{{Stat|Reaction}}",
    	Desc="Deal additional damage equal to {{Stat|Health}}<br>{{Keyword|Smackback}}",
    	Tribes={"All"},
    }

    cards["Groff"] = {
    	Name="Groff",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=6,
    	Attack=5,
    	Other="{{Stat|Reaction}}, x2 {{Stat|Frenzy}}",
    	Desc="<span style=\"color:brown\">Trigger when an ally is {{Keyword|Sacrificed}}</span>",
    	Tribes={"Shademancers"},
    }
    cards["Hazeblazer"] = {
    	Name="Hazeblazer",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=10,
    	Attack=0,
    	Counter=5,
    	Desc="Apply '''1''' {{Stat|Haze}}<br>Deal '''3''' damage to self",
    	Tribes={"Clunkmasters"},
    }
    cards["Jumbo"] = {
    	Name="Jumbo",
    	Types={Companion=true, HotSpring=true, NonPetCompanion=true},
    	Health=13,
    	Attack=1,
    	Counter=3,
    	Desc="Also hits ally behind<br>{{Keyword|Barrage}}",
    	Tribes={"All"},
    	Challenge="Deal 10 damage to your own team",
    	ChallengeOrder=1,
    }
    cards["Kernel"] = {
    	Name="Kernel",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=3,
    	Counter=4,
    	Desc="When hit, apply '''2''' {{Stat|Shell}} to ally behind",
    	Tribes={"Snowdwellers"},
    }

    cards["Knuckles"] = {
    	Name="Knuckles",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 8,
    	Attack= 4,
    	Other="{{Stat|Reaction}}",
    	Desc="<span style=\"color:brown\">Trigger when hit</span>",
    	Tribes={"Clunkmasters"},
    }

    cards["Kreggo"] = {
    	Name="Kreggo",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=7,
    	Attack=2,
    	Counter=5,
    	Desc="When a card is destroyed, gain '''+1''' {{Stat|Attack}}",
    	Tribes={"Clunkmasters"},
    }
    cards["Lil Berry"] = {
    	Name="Lil' Berry",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=2,
    	Counter=4,
    	Desc="When healed, gain '''+2''' {{Stat|Attack}}",
    	Tribes={"Snowdwellers"},
    }

    cards["Lupa"] = {
    	Name="Lupa",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 4,
    	Attack= 1,
    	Counter= 5,
    	Desc="When hit, boost the effects of a random ally and enemy by '''1'''",
    	Tribes={"All"},
    }

    cards["Mama Tinkerson"] = {
    	Name="Mama Tinkerson",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 5,
    	Attack= 3,
    	Counter= 4,
    	Desc="While active, add '''x2''' {{Stat|Frenzy}} to all [[Clunkers|Clunker]] allies",
    	Tribes={"Clunkmasters"},
    }

    cards["Mini Mika"] = {
    	Name="Mini Mika",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=2,
    	Counter=5,
    	Desc="When hit with [[Junk]], gain '''x1''' {{Stat|Frenzy}}",
    	Tribes={"Clunkmasters"},
    }
    cards["Monch"] = {
    	Name="Monch",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=6,
    	Attack=2,
    	Counter=4,
    	Desc="Before attacking, eat allies in the row, absorbing their {{Stat|Attack}} and {{Stat|Health}}",
    	Tribes={"Shademancers"},
    }
    cards["Naked Gnome"] = {
    	Name="Naked Gnome",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=1,
    	Attack=1,
    	Counter=2,
    	Tribes={"All"},
    	Gold="Doesn't drop gold"
    }

    cards["Needle"] = {
    	Name="Needle",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 7,
    	Attack= 3,
    	Counter= 4,
    	Desc="Destroy all {{Card|Junk}} in hand and {{Keyword|Draw}} '''1''' for each",
    	Tribes={"Clunkmasters"},
    }

    cards["Nom & Stompy"] = {
    	Name="Nom & Stompy",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=10,
    	Attack=10,
    	Counter=10,
    	Desc="When a card is destroyed, count down {{Stat|Counter}} by '''1'''",
    	Tribes={"Clunkmasters"},
    }

    cards["Nova"] = {
    	Name="Nova",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 3,
    	Attack= 3,
    	Counter= 12,
    	Other= "{{Stat|Reaction}}, 1 {{Stat|Block}}",
    	Desc="Hits all enemies<br><span style=\"color:brown\">Trigger when self or ally loses {{Stat|Block}}</span>",
    	Tribes={"All"},
    }

    cards["Pimento"] = {
    	Name="Pimento",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 7,
    	Attack= 2,
    	Counter= 5,
    	Desc="Retains {{Stat|Spice}}",
    	Tribes={"Snowdwellers"},
    }


    cards["Pootie"] = {
    	Name="Pootie",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=1,
    	Attack=1,
    	Counter=3,
    	Desc="When destroyed, add '''x1''' {{Stat|Frenzy}} to a random ally",
    	Tribes={"Snowdwellers"},
    }
    cards["Pyra"] = {
    	Name="Pyra",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=6,
    	Counter=4,
    	Desc="Apply '''4''' {{Stat|Spice}} to ally behind",
    	Tribes={"Snowdwellers"},
    }

    cards["Roibos"] = {
    	Name="Roibos",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 7,
    	Attack= 2,
    	Counter= 4,
    	Desc="When hit, add '''+1''' {{Stat|Attack}} to ally with the lowest {{Stat|Attack}}",
    	Tribes={"All"},
    }


    cards["Scaven"] = {
    	Name="Scaven",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=5,
    	Counter=3,
    	Desc="{{Keyword|Trash}} '''1'''",
    	Tribes={"Clunkmasters"},
    }
    cards["Shelly"] = {
    	Name="Shelly",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=4,
    	Attack=1,
    	Counter=3,
    	Desc="When an enemy is killed, apply '''3''' {{Stat|Shell}} to the attacker",
    	Tribes={"Snowdwellers"},
    }
    cards["Shen"] = {
    	Name="Shen",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=6,
    	Attack=0,
    	Counter=4,
    	Desc="Apply '''2''' {{Stat|Overburn}}<br>Increase by 1 when hit",
    	Tribes={"Shademancers"},
    }
    cards["Snobble"] = {
    	Name="Snobble",
    	Types={Companion=true, HotSpring=true, NonPetCompanion=true},
    	Health=5,
    	Attack=2,
    	Counter=4,
    	Desc="Apply {{Stat|Snow}} equal to damage dealt",
    	Tribes={"All"},
    	Challenge="Equip 10 [[Charms]]",
    	ChallengeOrder=0,
    }
    cards["Snoffel"] = {
    	Name="Snoffel",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=4,
    	Counter=4,
    	Desc="Apply '''1''' {{Stat|Snow}} to all enemies",
    	Tribes={"All"},
    }
    cards["Splinter"] = {
    	Name="Splinter",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=4,
    	Attack=4,
    	Counter=4,
    	Desc="When deployed, copy the effects of a random enemy in the row",
    	Tribes={"Shademancers"},
    }

    cards["Spoof"] = {
    	Name="Spoof",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 2,
    	Counter= 5,
    	Desc="Summon a {{Keyword|Bootleg}} copy of a random enemy",
    	Tribes={"Shademancers"},
    }

    cards["Taiga"] = {
    	Name="Taiga",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Counter=4,
    	Other="2 {{Stat|Teeth}}",
    	Desc="Gain '''2''' {{Stat|Teeth}}",
    	Tribes={"Shademancers"},
    }
    cards["Tinkerson Jr"] = {
    	Name="Tinkerson Jr.",
    	Link="Tinkerson Jr",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=3,
    	Counter=3,
    	Desc="While active, add {{Stat|Attack}} to all [[Junk]] in your hand",
    	Tribes={"Clunkmasters"},
    }
    cards["Tiny Tyko"] = {
    	Name="Tiny Tyko",
    	Types={Companion=true, HotSpring=true, NonPetCompanion=true},
    	Health=2,
    	Attack=1,
    	Counter=4,
    	Other="x2 {{Stat|Frenzy}}",
    	Desc="When hit, gain '''x1''' {{Stat|Frenzy}}",
    	Tribes={"Snowdwellers"},
    	Challenge="Achieve a 4x kill combo",
    	ChallengeOrder=2,
    }

    cards["Toaster"] = {
    	Name="Toaster",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 9,
    	Attack= 3,
    	Counter= 3,
    	Other="x2 {{Stat|Frenzy}}",
    	Desc="While active, add {{Keyword|Consume}} to [[Items]] in your hand",
    	Tribes={"Clunkmasters"},
    }


    cards["Tusk"] = {
    	Name="Tusk",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=5,
    	Attack=2,
    	Counter=5,
    	Desc="While active, add '''3''' {{Stat|Teeth}} to all allies",
    	Tribes={"Shademancers"},
    }
    cards["Van Jun"] = {
    	Name="Van Jun",
    	Types={Companion=true, HotSpring=true, NonPetCompanion=true},
    	Health=4,
    	Counter=4,
    	Desc="Add '''+2''' {{Stat|Attack}} and '''+2''' {{Stat|Health}} to all {{Keyword|Summoned}} allies",
    	Tribes={"Shademancers"},
    	Challenge="Summon 50 Allies",
    	ChallengeOrder=4,
    }
    cards["Vesta"] = {
    	Name="Vesta",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=8,
    	Attack=0,
    	Counter=4,
    	Desc="Double the target's {{Stat|Overburn}}<br>{{Keyword|Barrage}}",
    	Tribes={"Shademancers"},
    }
    cards["Wallop"] = {
    	Name="Wallop",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=9,
    	Attack=4,
    	Counter=4,
    	Desc="Deal '''8''' additional damage to {{Stat|Snow}}'d targets",
    	Tribes={"Snowdwellers"},
    }
    cards["Wort"] = {
    	Name="Wort",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=6,
    	Attack=0,
    	Counter=3,
    	Other="x2 {{Stat|Frenzy}}",
    	Desc="Apply '''2''' {{Stat|Shroom}}<br>{{Keyword|Aimless}}",
    	Tribes={"Snowdwellers"},
    }
    cards["Yuki"] = {
    	Name="Yuki",
    	Types={Companion=true, NonPetCompanion=true},
    	Health=1,
    	Attack=1,
    	Counter=4,
    	Desc="Whenever anything is {{Stat|Snow}}'d, gain equal {{Stat|Attack}}",
    	Tribes={"Snowdwellers"},
    }

    cards["Zula"] = {
    	Name="Zula",
    	Types={Companion=true, NonPetCompanion=true},
    	Health= 7,
    	Attack= 0,
    	Other="{{Stat|Reaction}}",
    	Desc="Apply '''2''' {{Stat|Overburn}}<br><span style=\"color:brown\">Trigger when an enemy is killed</span>",
    	Tribes={"Shademancers"},
    }


    --Clunkers
    cards["Bitebox"] = {
    	Name="Bitebox",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When hit, deal equal damage to the attacker",
    	Tribes={"All"},
    }
    cards["Bling Bank"] = {
    	Name="Bling Bank",
    	Types={Clunker=true},
    	Scrap=1,
    	Other="{{Stat|Reaction}}",
    	Desc="Gain '''4''' {{Bling}}<br><span style=\"color:brown\">Trigger when an enemy is killed</span>",
    	Tribes={"All"},
    }
    cards["Blundertank"] = {
    	Name="Blundertank",
    	Types={Clunker=true},
    	Scrap=2,
    	Attack=5,
    	Other="{{Stat|Reaction}}",
    	Desc="<span style=\"color:brown\">Trigger when [[Junk]] is destroyed</span>",
    	Tribes={"Clunkmasters"},
    }
    cards["Bombarder"] = {
    	Name="Bombarder",
    	Types={Clunker=true},
    	Scrap=1,
    	Attack=0,
    	Other="{{Stat|Reaction}}",
    	Desc="<span style=\"color:brown\">Trigger against anything that is hit with {{Stat|Bom}}</span>",
    	Tribes={"Clunkmasters"},
    }
    cards["Fungo Blaster"] = {
    	Name="Fungo Blaster",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When a {{Stat|Shroom}}'d enemy dies, apply their {{Stat|Shroom}} to a random enemy",
    	Tribes={"Snowdwellers"},
    }
    cards["Gachapomper"] = {
    	Name="Gachapomper",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="While active, add {{Keyword|Barrage}} to allies in the row",
    	Tribes={"Clunkmasters"},
    }
    cards["Haze Balloon"] = {
    	Name="Haze Balloon",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When destroyed, apply '''1''' {{Stat|Haze}} to the attacker and double their {{Stat|Attack}}",
    	Tribes={"Clunkmasters"},
    }
    cards["Heartforge"] = {
    	Name="Heartforge",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When an ally is healed, apply double {{Stat|Spice}}",
    	Tribes={"Snowdwellers"},
    }
    cards["Heartmist Station"] = {
    	Name="Heartmist Station",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When an ally is hit, restore their {{Stat|Health}} by '''1'''",
    	Tribes={"All"},
    }
    cards["ICGM"] = {
    	Name="I.C.G.M",
    	Link="I.C.G.M.",
    	Types={Clunker=true},
    	Scrap=3,
    	Attack=10,
    	Counter=13,
    	Desc="Before triggering, gain {{Stat|Frenzy}} equal to {{Stat|Scrap}}<br>Destroy self",
    	Tribes={"Clunkmasters"},
    }
    cards["Junkhead"] = {
    	Name="Junkhead",
    	Types={Clunker=true},
    	Scrap=3,
    	Desc="{{Keyword|Trash}} '''1''' when hit",
    	Tribes={"Clunkmasters"},
    }
    cards["Kobonker"] = {
    	Name="Kobonker",
    	Types={Clunker=true, InventorsHut=true},
    	Scrap=1,
    	Attack=3,
    	Other="{{Stat|Reaction}}",
    	Desc="<span style=\"color:brown\">Trigger against anything that is hit with {{Stat|Snow}}</span>",
    	Tribes={"Snowdwellers"},
    	Challenge="Add 3 [[Clunkers]] to your deck",
    	ChallengeOrder=1,
    }
    cards["Krono"] = {
    	Name="Krono",
    	Types={Clunker=true, InventorsHut=true},
    	Scrap=1,
    	Desc="While active, add '''x1''' {{Stat|Frenzy}} to allies without {{Crown}}",
    	Tribes={"All"},
    	Challenge="Buy 10 {{Crown}}",
    	ChallengeOrder=5,
    }
    cards["Mega Mimik"] = {
    	Name="Mega Mimik",
    	Types={InventorsHut=true, Clunker=true, EnemyClunker=true},
    	Scrap=3,
    	Attack=5,
    	Other="{{Stat|Reaction}}",
    	Desc="<div style=\"color:brown;\">Trigger when an ally in the row attacks</div>Lose '''1''' {{Stat|Scrap}}",
    	Tribes={"All"},
    	Challenge="Apply 60 {{Stat|Shell}}",
    	ChallengeOrder=4,
    }
    cards["Mimik"] = {
    	Name="Mimik",
    	Types={Clunker=true, EnemyClunker=true},
    	Scrap=1,
    	Attack=2,
    	Other="{{Stat|Reaction}}",
    	Desc="<span style=\"color:brown\">Trigger when an ally in the row attacks</span>",
    	Tribes={"All"},
    }
    cards["Mobile Campfire"] = {
    	Name="Mobile Campfire",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="While active, add '''+3''' {{Stat|Attack}} to allies in the row",
    	Tribes={"Snowdwellers"},
    }
    cards["Moko Totem"] = {
    	Name="Moko Totem",
    	Types={Clunker=true},
    	Scrap=2,
    	Attack=0,
    	Other="{{Stat|Reaction}}, x5 {{Stat|Frenzy}}",
    	Desc="<span style=\"color:brown\"> Trigger when {{Stat|Spice}} reaches</span> '''10'''<br> Destroy self",
    	Tribes={"Snowdwellers"},
    }
    cards["Pepper Flag"] = {
    	Name="Pepper Flag",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="While active, all allies retain {{Stat|Spice}}",
    	Tribes={"Snowdwellers"},
    }
    cards["Plinker"] = {
    	Name="Plinker",
    	Types={Clunker=true, EnemyClunker=true},
    	Scrap=5,
    	Attack=2,
    	Counter=1,
    	Desc="Lose '''1''' {{Stat|Scrap}}",
    	Tribes={"Clunkmasters"},
    }
    cards["Portable Workbench"] = {
    	Name="Portable Workbench",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="While active, all {{Keyword|Recycle}} effects require '''1''' less [[Junk]]",
    	Tribes={"Clunkmasters"},
    }
    cards["Shroominator"] = {
    	Name="Shroominator",
    	Types={Clunker=true},
    	Scrap=4,
    	Desc="Whenever anything is {{Stat|Shroom}}'d, double the amount and lose '''1''' {{Stat|Scrap}}",
    	Tribes={"Snowdwellers"},
    }
    cards["Shroomine"] = {
    	Name="Shroomine",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When hit, apply '''4''' {{Stat|Shroom}} to the attacker",
    	Tribes={"Snowdwellers"},
    }
    cards["Spice Sparklers"] = {
    	Name="Spice Sparklers",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="While active, add '''+3''' {{Stat|Attack}} to [[Items]] in your hand",
    	Tribes={"Snowdwellers"},
    }
    cards["Sunglass Chime"] = {
    	Name="Sunglass Chime",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="When destroyed, trigger all allies",
    	Tribes={"Clunkmasters"},
    }
    cards["Tootordion"] = {
    	Name="Tootordion",
    	Types={Clunker=true},
    	Scrap=3,
    	Counter=3,
    	Desc="Trigger a random ally<br>Lose '''1''' {{Stat|Scrap}}",
    	Tribes={"Clunkmasters"},
    }
    cards["Totem of the Goat"] = {
    	Name="Totem of the Goat",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="Before an enemy attacks, apply '''1''' {{Stat|Demonize}} to them",
    	Tribes={"All"},
    }
    cards["Woodhead"] = {
    	Name="Woodhead",
    	Types={Clunker=true},
    	Scrap=1,
    	Desc="<span style=\"color:gray\">''Does nothing, but will take a hit for you :)''</span>",
    	Tribes={"Snowdwellers"},
    }

    cards["Zoomlin Nest"] = {
    	Name="Zoomlin Nest",
    	Types={Clunker=true},
    	Scrap= 1,
    	Desc="While active, allies gain {{Keyword|Zoomlin}} when drawn",
    	Tribes={"All"},
    }


    --Items
    cards["Azul Battle Axe"] = {
    	Name="Azul Battle Axe",
    	Types={Item=true, ShopItem=true},
    	Attack=3,
    	Desc="Apply {{Stat|Overburn}} equal to damage dealt",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Azul Candle"] = {
    	Name="Azul Candle",
    	Types={Item=true, ShopItem=true},
    	Attack=1,
    	Desc="Double the target's {{Stat|Overburn}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Azul Skull"] = {
    	Name="Azul Skull",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Kill an ally<br>Apply '''4''' {{Stat|Overburn}} to front enemy",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["B.I.N.K"] = {
    	Name="B.I.N.K",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''2''' {{Stat|Ink}}<br>Hits all enemies",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Beepop Mask"] = {
    	Name="Beepop Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Beepop]]",
    	Tribes={"Shademancers"},
    	Price=60,
    }
    cards["Berry Basket"] = {
    	Name="Berry Basket",
    	Types={Item=true, ShopItem=true},
    	Desc="Restore '''2''' {{Stat|Health}} and {{Keyword|Cleanse}} all allies",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Berry Bell"] = {
    	Name="Berry Bell",
    	Types={Item=true},
    	Desc="Increase {{Stat|Health}} by '''1'''<br>{{Keyword|Barrage}}",
    	Tribes={"Shademancers"},
    	Price=25,
    }
    cards["Berry Blade"] = {
    	Name="Berry Blade",
    	Types={Item=true, ShopItem=true},
    	Attack=4,
    	Desc="Restore {{Stat|Health}} to front ally equal to damage dealt",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Blank Mask"] = {
    	Name="Blank Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon a copy of an ally<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=65,
    }
    cards["Blaze Bom"] = {
    	Name="Blaze Bom",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Add '''x1''' {{Stat|Frenzy}}<br>Apply '''4''' {{Stat|Bom}}",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Blaze Tea"] = {
    	Name="Blaze Tea",
    	Types={Item=true, ShopItem=true},
    	Desc="Add '''x1''' {{Stat|Frenzy}}<br>Increase {{Stat|Counter}} by '''1'''<br>{{Keyword|Consume}}",
    	Tribes={"All"},
    	Price=62,
    }
    cards["Blizzard Bottle"] = {
    	Name="Blizzard Bottle",
    	Types={Item=true},
    	Attack=0,
    	Desc="Apply '''3''' {{Stat|Snow}}",
    	Tribes={"All"},
    	Price=30,
    }
    cards["Bom Barrel"] = {
    	Name="Bom Barrel",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''4''' {{Stat|Bom}}<br>{{Keyword|Barrage}}<br>{{Keyword|Trash}} '''4'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }

    cards["Bonescraper"] = {
    	Name="Bonescraper",
    	Types={Item=true, ShopItem=true},
    	Attack= 5,
    	Desc="Killing an enemy counts as {{Keyword|Sacrifice|Sacrificing}} an ally",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Broken Vase"] = {
    	Name="Broken Vase",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="<span style=\"color:gray\">''Maybe it can be fixed...''</span>",
    	Tribes={"All"},
    	Price=15,
    }
    cards["Clockwork Bom"] = {
    	Name="Clockwork Bom",
    	Types={Item=true, ShopItem=true},
    	Attack=2,
    	Desc="Apply '''3''' {{Stat|Bom}}<br>{{Keyword|Critical}}",
    	Tribes={"Clunkmasters"},
    	Price=45,
    }
    cards["Demonheart"] = {
    	Name="Demonheart",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''1''' {{Stat|Demonize}}<br>Restore '''9''' {{Stat|Health}}",
    	Tribes={"All"},
    	Price=40,
    }
    cards["Dragon Pepper"] = {
    	Name="Dragon Pepper",
    	Types={Item=true, ShopItem=true},
    	Desc="Apply '''7''' {{Stat|Spice}}<br>{{Keyword|Consume}}",
    	Tribes={"Snowdwellers"},
    	Price=55,
    }
    cards["Fallow Mask"] = {
    	Name="Fallow Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Fallow]]",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Flamewater"] = {
    	Name="Flamewater",
    	Types={Item=true},
    	Desc="Increase {{Stat|Attack}} by '''1'''",
    	Tribes={"Snowdwellers"},
    	Price=25,
    }
    cards["Flask of Ink"] = {
    	Name="Flask of Ink",
    	Types={Item=true},
    	Attack=0,
    	Desc="Apply '''4''' {{Stat|Ink}}",
    	Tribes={"Clunkmasters"},
    	Price=25,
    }
    cards["Foggy Brew"] = {
    	Name="Foggy Brew",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''1''' {{Stat|Haze}}<br>{{Keyword|Aimless}}<br>{{Keyword|Consume}}",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Forging Stove"] = {
    	Name="Forging Stove",
    	Types={Item=true, ShopItem=true},
    	Desc="Destroy a card in your hand<br>Add its {{Stat|Attack}} to a random ally",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Frenzy Wrench"] = {
    	Name="Frenzy Wrench",
    	Types={Item=true, ShopItem=true},
    	Desc="Add '''x1''' {{Stat|Frenzy}} to a card in your hand<br>{{Keyword|Recycle}} '''2'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Frost Bell"] = {
    	Name="Frost Bell",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''2''' {{Stat|Frost}}<br>{{Keyword|Barrage}}",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Frostbite Shard"] = {
    	Name="Frostbite Shard",
    	Types={Item=true, ShopItem=true},
    	Desc="Reduce the target's effects by '''1'''<br>{{Keyword|Consume}}",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Frostbloom"] = {
    	Name="Frostbloom",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''3''' {{Stat|Frost}}",
    	Tribes={"All"},
    	Price=45,
    }
    cards["Gearhammer"] = {
    	Name="Gearhammer",
    	Types={Item=true},
    	Attack=2,
    	Desc="Gain '''+1''' {{Stat|Attack}}",
    	Tribes={"Clunkmasters"},
    	Price=10,
    }
    cards["Gigi's Cookie Box"] = {
    	Name="Gigi's Cookie Box",
    	Types={Item=true, ShopItem=true},
    	Desc="Add '''1''' {{Stat|Scrap}} to all allies<br>{{Keyword|Consume}}",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Gigi's Gizmo"] = {
    	Name="Gigi's Gizmo",
    	Types={Item=true, ShopItem=true},
    	Desc="Add '''1''' {{Stat|Scrap}}<br>{{Keyword|Recycle}} '''1'''<br>{{Keyword|Draw}} '''2'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Grabber"] = {
    	Name="Grabber",
    	Types={InventorsHut=true, Item=true, ShopItem=true},
    	Attack=1,
    	Desc="{{Keyword|Noomlin}}<br>{{Keyword|Yank}}",
    	Tribes={"All"},
    	Price=40,
    	Challenge="Kill 20 enemies with [[Items]]",
    	ChallengeOrder=2,
    }
    cards["Gunk Fruit"] = {
    	Name="Gunk Fruit",
    	Types={Item=true},
    	Attack=1,
    	Desc="{{Keyword|Consume}}",
    	Tribes={"All"},
    	Price=0,
    }
    cards["Haze Keg"] = {
    	Name="Haze Keg",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''1''' {{Stat|Haze}}<br>{{Keyword|Recycle}} '''2'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Hongo's Hammer"] = {
    	Name="Hongo's Hammer",
    	Types={Item=true, ShopItem=true},
    	Attack=1,
    	Desc="Apply '''3''' {{Stat|Shroom}}",
    	Tribes={"Snowdwellers"},
    	Price=40,
    }
    cards["Ice Dice"] = {
    	Name="Ice Dice",
    	Types={Item=true, ShopItem=true},
    	Desc="Apply '''1''' {{Stat|Block}} to a random ally<br>Apply '''1''' {{Stat|Block}} to a random enemy",
    	Tribes={"All"},
    	Price=40,
    }
    cards["JunJun Mask"] = {
    	Name="Junjun Mask",
    	Link="JunJun Mask",
    	Types={Item=true},
    	Desc="Summon [[JunJun|Junjun]]",
    	Tribes={"Shademancers"},
    	Price=30,
    }
    cards["Junk"] = {
    	Name="Junk",
    	Types={Item=true},
    	Attack=0,
    	Desc="<span style=\"color:gray\">''Does absolutely nothing...''</span>",
    	Tribes={"All"},
    	Price=0,
    }
    cards["Leech Mask"] = {
    	Name="Leech Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Leech]] on the enemy side<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Lumin Goop"] = {
    	Name="Lumin Goop",
    	Types={Item=true, ShopItem=true},
    	Desc="<span style=\"color:gray\">''Could be used to fix something...''</span>",
    	Tribes={"All"},
    	Price=15,
    }
    cards["Lumin Lantern"] = {
    	Name="Lumin Lantern",
    	Types={Item=true, ShopItem=true},
    	Desc="Boost a random ally's effects by '''1'''<br>Boost a random enemy's effects by '''2'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Magma Booster"] = {
    	Name="Magma Booster",
    	Types={Item=true, ShopItem=true},
    	Desc="Increase {{Stat|Attack}} by '''3'''<br>Add {{Keyword|Aimless}} to the target",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Mini Muncher"] = {
    	Name="Mini Muncher",
    	Types={Item=true, ShopItem=true},
    	Desc="Destroy a card in your hand<br>{{Keyword|Noomlin}}",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Molten Dip"] = {
    	Name="Molten Dip",
    	Types={Item=true, ShopItem=true},
    	Desc="Increase {{Stat|Attack}} by '''2'''<br>{{Keyword|Barrage}}<br>{{Keyword|Consume}}",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Noomlin Biscuit"] = {
    	Name="Noomlin Biscuit",
    	Types={Item=true, ShopItem=true},
    	Desc="Add {{Keyword|Noomlin}} to a card in your hand<br>{{Keyword|Consume}}",
    	Tribes={"All"},
    	Price=55,
    }
    cards["Nutshell Cake"] = {
    	Name="Nutshell Cake",
    	Types={Item=true, ShopItem=true},
    	Desc="Apply '''9''' {{Stat|Shell}}<br>Reduce {{Stat|Health}} by '''2'''<br>{{Keyword|Consume}}",
    	Tribes={"Snowdwellers"},
    	Price=50,
    }
    cards["Peppereaper"] = {
    	Name="Peppereaper",
    	Types={Item=true, ShopItem=true},
    	Attack=1,
    	Desc="Apply '''4''' {{Stat|Spice}}",
    	Tribes={"Snowdwellers"},
    	Price=45,
    }
    cards["Peppering"] = {
    	Name="Peppering",
    	Types={Item=true, ShopItem=true},
    	Desc="Apply '''2''' {{Stat|Spice}} to all allies",
    	Tribes={"Snowdwellers"},
    	Price=40,
    }
    cards["Pinkberry Juice"] = {
    	Name="Pinkberry Juice",
    	Types={Item=true, ShopItem=true},
    	Desc="Increase {{Stat|Health}} by '''4'''",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Pom Mask"] = {
    	Name="Pom Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Pom]] on the enemy side<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Pombomb"] = {
    	Name="Pombomb",
    	Types={Item=true, ShopItem=true},
    	Attack=5,
    	Desc="Hits all undamaged enemies",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Proto-Stomper"] = {
    	Name="Proto-Stomper",
    	Types={Item=true, ShopItem=true},
    	Attack=8,
    	Desc="{{Keyword|Trash}} '''2'''",
    	Tribes={"Clunkmasters"},
    	Price=55,
    }
    cards["Scrap Pile"] = {
    	Name="Scrap Pile",
    	Types={InventorsHut=true, Item=true, ShopItem=true},
    	Desc="Add '''1''' {{Stat|Scrap}}",
    	Tribes={"Snowdwellers"},
    	Price=40,
    	Challenge="Block 10 hits with [[Clunkers]]",
    	ChallengeOrder=3,
    }
    cards["Scrappy Sword"] = {
    	Name="Scrappy Sword",
    	Types={Item=true},
    	Attack=2,
    	Desc="<span style=\"color:gray\">''A traditional trusty weapon''</span>",
    	Tribes={"Snowdwellers"},
    	Price=10,
    }
    cards["Shade Clay"] = {
    	Name="Shade Clay",
    	Types={Item=true, ShopItem=true},
    	Desc="Make a copy of an '''Item''' in your hand<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Shade Wisp"] = {
    	Name="Shade Wisp",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon a copy of an enemy on your side with '''1''' {{Stat|Health}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Sheepopper Mask"] = {
    	Name="Sheepopper Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Sheepopper]] on the enemy side<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Shell Shield"] = {
    	Name="Shell Shield",
    	Types={Item=true, ShopItem=true},
    	Desc="Apply '''4''' {{Stat|Shell}}",
    	Tribes={"Snowdwellers"},
    	Price=40,
    }
    cards["Shellbo"] = {
    	Name="Shellbo",
    	Types={Item=true, ShopItem=true},
    	Attack=2,
    	Desc="Apply '''5''' {{Stat|Shell}}<br>{{Keyword|Barrage}}",
    	Tribes={"Snowdwellers"},
    	Price=50,
    }
    cards["Skullmist Tea"] = {
    	Name="Skullmist Tea",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Kill an ally<br>Add their {{Stat|Attack}} to all allies<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }

    cards["Skull Muffin"] = {
    	Name="Skull Muffin",
    	Types={Item=true, ShopItem=true},
    	Attack= 0,
    	Desc="Kill an ally<br>{{Keyword|Zoomlin}}<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }


    cards["Slapcrackers"] = {
    	Name="Slapcrackers",
    	Types={InventorsHut=true, Item=true, ShopItem=true},
    	Attack=1,
    	Other="x4 {{Stat|Frenzy}}",
    	Desc="{{Keyword|Aimless}}",
    	Tribes={"All"},
    	Price=50,
    	Challenge="Achieve a 3x kill combo",
    	ChallengeOrder=0,
    }
    cards["Snow Stick"] = {
    	Name="Snow Stick",
    	Types={Item=true},
    	Attack=1,
    	Desc="Apply '''2''' {{Stat|Snow}}",
    	Tribes={"Snowdwellers"},
    	Price=30,
    }
    cards["Snowcake"] = {
    	Name="Snowcake",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''10''' {{Stat|Snow}}<br>{{Keyword|Consume}}",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Snowzooka"] = {
    	Name="Snowzooka",
    	Types={Item=true},
    	Attack=0,
    	Desc="Apply '''2''' {{Stat|Snow}}<br>{{Keyword|Critical}}",
    	Tribes={"Clunkmasters"},
    	Price=30,
    }

    cards["Snuffer Mask"] = {
    	Name="Snuffer Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Snuffer]]<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }


    cards["Soulbound Skulls"] = {
    	Name="Soulbound Skulls",
    	Types={Item=true, ShopItem=true},
    	Desc="Add {{Keyword|Soulbound}} to an ally<br>Add {{Keyword|Soulbound}} to a random enemy",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Spice Stones"] = {
    	Name="Spice Stones",
    	Types={Item=true, ShopItem=true},
    	Desc="Apply '''1''' {{Stat|Spice}}<br>Double the target's {{Stat|Spice}}",
    	Tribes={"Snowdwellers"},
    	Price=50,
    }
    cards["Spore Pack"] = {
    	Name="Spore Pack",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''2''' {{Stat|Shroom}}<br>{{Keyword|Barrage}}",
    	Tribes={"Snowdwellers"},
    	Price=50,
    }
    cards["Storm Globe"] = {
    	Name="Storm Globe",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''4''' {{Stat|Snow}}<br>Reduce by 1 when played",
    	Tribes={"All"},
    	Price=40,
    }
    cards["Stormbear Spirit"] = {
    	Name="Stormbear Spirit",
    	Types={Item=true, ShopItem=true},
    	Attack=8,
    	Desc="Target must be {{Stat|Snow}}'d",
    	Tribes={"Snowdwellers"},
    	Price=45,
    }
    cards["Sun Rod"] = {
    	Name="Sun Rod",
    	Types={Item=true},
    	Desc="Count down {{Stat|Counter}} by '''2'''",
    	Tribes={"Snowdwellers"},
    	Price=50,
    }
    cards["Sunburst Tootoo"] = {
    	Name="Sunburst Tootoo",
    	Types={Item=true},
    	Attack=1,
    	Desc="Count down {{Stat|Counter}} by '''2'''",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Suncream"] = {
    	Name="Suncream",
    	Types={Item=true, ShopItem=true},
    	Desc="Reduce {{Stat|Counter}} by '''1'''<br>{{Keyword|Recycle}} '''1'''<br>{{Keyword|Consume}}",
    	Tribes={"Clunkmasters"},
    	Price=60,
    }
    cards["Sunlight Drum"] = {
    	Name="Sunlight Drum",
    	Types={Item=true, ShopItem=true},
    	Desc="Count down {{Stat|Counter}} by '''1'''<br>{{Keyword|Barrage}}",
    	Tribes={"All"},
    	Price=50,
    }
    cards["Sunsong Box"] = {
    	Name="Sunsong Box",
    	Types={Item=true},
    	Desc="Increase {{Stat|Attack}} by '''1'''<br>Count down {{Stat|Counter}} by '''1'''<br>{{Keyword|Recycle}} '''1'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Supersnower"] = {
    	Name="Supersnower",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Apply '''3''' {{Stat|Snow}}<br>{{Keyword|Barrage}}<br>{{Keyword|Recycle}} '''2'''",
    	Tribes={"Clunkmasters"},
    	Price=50,
    }
    cards["Tar Blade"] = {
    	Name="Tar Blade",
    	Types={Item=true},
    	Attack=0,
    	Desc="Deal additional damage equal to [[Tar Blade]]s in hand",
    	Tribes={"Shademancers"},
    	Price=10,
    }
    cards["The Lumin Vase"] = {
    	Name="The Lumin Vase",
    	Types={Item=true},
    	Desc="Apply '''1''' {{Stat|Lumin}}",
    	Tribes={"All"},
    	Price=500,
    }
    cards["Tiger Skull"] = {
    	Name="Tiger Skull",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Kill an ally<br>Apply '''3''' {{Stat|Teeth}} to allies in the row",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Tigris Mask"] = {
    	Name="Tigris Mask",
    	Types={Item=true, ShopItem=true},
    	Desc="Summon [[Tigris]]<br>{{Keyword|Consume}}",
    	Tribes={"Shademancers"},
    	Price=50,
    }
    cards["Yeti Skull"] = {
    	Name="Yeti Skull",
    	Types={Item=true, ShopItem=true},
    	Attack=0,
    	Desc="Kill an ally<br>Apply '''3''' {{Stat|Snow}} to enemies in the row",
    	Tribes={"Shademancers"},
    	Price=50,
    }

    cards["Zoomlin Wafers"] = {
    	Name="Zoomlin Wafers",
    	Types={Item=true, ShopItem=true},
    	Desc="Add {{Keyword|Zoomlin}} to all cards in your hand<br>{{Keyword|Consume}}",
    	Tribes={"All"},
    	Price=55,
    }


    --Shades
    cards["Beepop"] = {
    	Name="Beepop",
    	Types={Shade=true},
    	Health=1,
    	Desc="When destroyed, apply '''4''' {{Stat|Overburn}} to the attacker",
    	SummonCon="Using [[Beepop Mask]]",
    }
    cards["Chikagoru"] = {
    	Name="Chikagoru",
    	Types={Shade=true},
    	Health=10,
    	Attack=10,
    	Counter=3,
    	SummonCon="{{Keyword|Sacrifice|Sacrificing}} [[Chikashi]]",
    }
    cards["Chikani"] = {
    	Name="Chikani",
    	Types={Shade=true},
    	Health=4,
    	Attack=4,
    	Counter=3,
    	Desc="When {{Keyword|Sacrifice|Sacrificed}}, summon [[Chikasan]]",
    	SummonCon="{{Keyword|Sacrifice|Sacrificing}} [[Chikichi]]",
    }
    cards["Chikasan"] = {
    	Name="Chikasan",
    	Types={Shade=true},
    	Health=6,
    	Attack=6,
    	Counter=3,
    	Desc="When {{Keyword|Sacrifice|Sacrificed}}, summon [[Chikashi]]",
    	SummonCon="{{Keyword|Sacrifice|Sacrificing}} [[Chikani]]",
    }
    cards["Chikashi"] = {
    	Name="Chikashi",
    	Types={Shade=true},
    	Health=8,
    	Attack=8,
    	Counter=3,
    	Desc="When {{Keyword|Sacrifice|Sacrificed}}, summon [[Chikagoru]]",
    	SummonCon="{{Keyword|Sacrifice|Sacrificing}} [[Chikasan]]",
    }
    cards["Dregg"] = {
    	Name="Dregg",
    	Types={Shade=true},
    	Health=4,
    	Attack=5,
    	Counter=5,
    	Other="x3 {{Stat|Frenzy}}",
    	SummonCon="[[Egg]] is destroyed",
    }
    cards["Fallow"] = {
    	Name="Fallow",
    	Types={Shade=true},
    	Health=6,
    	Attack=2,
    	Counter=4,
    	Desc="{{Keyword|Barrage}}",
    	SummonCon="Using [[Fallow Mask]]",
    }
    cards["JunJun"] = {
    	Name="Junjun",
    	Link="JunJun",
    	Types={Shade=true},
    	Health=3,
    	Attack=2,
    	Counter=3,
    	Desc="{{Keyword|Aimless}}",
    	SummonCon="Using [[JunJun Mask|Junjun Mask]]",
    }
    cards["Leech"] = {
    	Name="Leech",
    	Types={Shade=true},
    	Health=5,
    	Attack=2,
    	Counter=3,
    	Desc="Take '''3''' {{Stat|Health}} from all allies",
    	SummonCon="Using [[Leech Mask]]",
    }
    cards["Pom"] = {
    	Name="Pom",
    	Types={Shade=true},
    	Health=7,
    	Desc="While active, add {{Keyword|Barrage}} to all enemies",
    	SummonCon="Using [[Pom Mask]]",
    }
    cards["Sheepopper"] = {
    	Name="Sheepopper",
    	Types={Shade=true},
    	Health=4,
    	Desc="When destroyed, deal '''8''' damage to all allies",
    	SummonCon="Using [[Sheepopper Mask]]",
    }
    cards["Snuffer"] = {
    	Name="Snuffer",
    	Types={Shade=true},
    	Health= 4,
    	Desc="When {{Keyword|Sacrifice|Sacrificed}}, add '''+1''' {{Stat|Attack}} to all allies and resummon",
    	SummonCon="Using [[Snuffer Mask]] or by {{Keyword|Sacrifice|Sacrificing}} Snuffer",
    }
    cards["Tigris"] = {
    	Name="Tigris",
    	Types={Shade=true},
    	Health=5,
    	Other="2 {{Stat|Teeth}}",
    	Desc="Gain '''1''' {{Stat|Teeth}} when hit, or an ally is hit",
    	SummonCon="Using [[Tigris Mask]]",
    }

    --Enemies
    cards["Baby Snowbo"] = {
    	Name="Baby Snowbo",
    	Types={Enemy=true},
    	Health=1,
    	Attack=1,
    	Counter=2,
    	Gold=2
    }
    cards["Beeberry"] = {
    	Name="Beeberry",
    	Types={Enemy=true},
    	Health= 2,
    	Attack= 1,
    	Counter= 3,
    	Desc="When destroyed, add '''+1''' {{Stat|Health}} to all allies",
    	Gold=2
    }
    cards["Berry Witch"] = {
    	Name="Berry Witch",
    	Types={Enemy=true},
    	Health=6,
    	Attack=2,
    	Counter=4,
    	Desc="Restore '''2''' {{Stat|Health}} to all allies",
    	Gold=5
    }
    cards["Bigfoot"] = {
    	Name="Bigfoot",
    	Types={Enemy=true},
    	Health=12,
    	Attack=5,
    	Counter=4,
    	Desc="{{Keyword|Barrage}}",
    	Gold=5
    }
    cards["Blaze Beetles"] = {
    	Name="Blaze Beetles",
    	Types={Enemy=true},
    	Health= 11,
    	Attack= 1,
    	Counter= 3,
    	Desc="When a card is destroyed, gain '''x1''' {{Stat|Frenzy}}<br>{{Keyword|Barrage}}",
    	Gold=7
    }
    cards["Bulbhead"] = {
    	Name="Bulbhead",
    	Types={Enemy=true},
    	Health=8,
    	Attack=0,
    	Counter=5,
    	Desc="Apply '''2''' {{Stat|Shroom}}<br>{{Keyword|Barrage}}",
    	Gold=6
    }
    cards["Burster"] = {
    	Name="Burster",
    	Types={Enemy=true},
    	Health=10,
    	Attack=1,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Apply '''1''' {{Stat|Haze}}",
    	Gold=7
    }
    cards["Chungoon"] = {
    	Name="Chungoon",
    	Types={Enemy=true},
    	Health=6,
    	Attack=1,
    	Counter=3,
    	Desc="When hit, gain '''+1''' {{Stat|Attack}}",
    	Gold=5
    }
    cards["Conker"] = {
    	Name="Conker",
    	Types={Enemy=true},
    	Health=2,
    	Attack=2,
    	Counter=5,
    	Other="10 {{stat|Shell}}",
    	Desc="Deal additional damage equal to {{Stat|Shell}}",
    	Gold=7
    }
    cards["Dungrok"] = {
    	Name="Dungrok",
    	Types={Enemy=true},
    	Health= 14,
    	Attack= 4,
    	Counter= 3,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Destroy the rightmost card in your hand",
    	Gold=7
    }
    cards["Earth Berry"] = {
    	Name="Earth Berry",
    	Types={Enemy=true},
    	Health=6,
    	Attack=0,
    	Counter=3,
    	Desc="Deal additional damage equal to {{Stat|Health}}",
    	Gold=5
    }
    cards["Frostinger"] = {
    	Name="Frostinger",
    	Types={Enemy=true},
    	Health=8,
    	Attack=1,
    	Counter=3,
    	Desc="Apply '''1''' {{Stat|Frost}}",
    	Gold=6
    }
    cards["Gobbler"] = {
    	Name="Gobbler",
    	Types={Enemy=true},
    	Health=7,
    	Attack=1,
    	Counter=3,
    	Desc="When an ally is killed, gain their {{Stat|Attack}}",
    	Gold=2
    }
    cards["Gobling"] = {
    	Name="Gobling",
    	Types={Enemy=true},
    	Health=6,
    	Counter=4,
    	Desc="Escape from the battle<br>Drop '''4''' {{Bling}} when hit",
    	Gold="Doesn't drop gold"
    }
    cards["Gogong"] = {
    	Name="Gogong",
    	Types={Enemy=true},
    	Health=5,
    	Attack=2,
    	Other="{{Stat|Reaction}}",
    	Desc="{{Keyword|Smackback}}",
    	Gold=5
    }
    cards["Gok"] = {
    	Name="Gok",
    	Types={Enemy=true},
    	Health=18,
    	Attack=5,
    	Counter=5,
    	Desc="When hit, apply '''1''' {{Stat|Demonize}} to the attacker",
    	Gold=2
    }
    cards["Grink"] = {
    	Name="Grink",
    	Types={Enemy=true},
    	Health=8,
    	Attack=1,
    	Counter=2,
    	Desc="Apply '''2''' {{Stat|Frost}}",
    	Gold=2
    }
    cards["Grizzle"] = {
    	Name="Grizzle",
    	Types={Enemy=true},
    	Health=16,
    	Attack=4,
    	Counter=5,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Apply '''3''' {{Stat|Snow}}",
    	Gold=7
    }
    cards["Grog"] = {
    	Name="Grog",
    	Types={Enemy=true},
    	Health=12,
    	Attack=6,
    	Counter=8,
    	Desc="When hit, count down {{Stat|Counter}} by '''1'''",
    	Gold=3
    }
    cards["Gromble"] = {
    	Name="Gromble",
    	Types={Enemy=true},
    	Health=12,
    	Attack=2,
    	Counter=2,
    	Gold=3
    }
    cards["Grouchy"] = {
    	Name="Grouchy",
    	Types={Enemy=true},
    	Health=5,
    	Attack=2,
    	Counter=4,
    	Desc="While damaged, {{Stat|Attack}} is increased by '''2'''",
    	Gold=3
    }
    cards["Grumps"] = {
    	Name="Grumps",
    	Types={Enemy=true},
    	Health=9,
    	Attack=10,
    	Counter=8,
    	Desc="When hit, reduce the attacker's {{Stat|Attack}} by '''1'''",
    	Gold=6
    }
    cards["Gunk Gobbler"] = {
    	Name="Gunk Gobbler",
    	Types={Enemy=true},
    	Health= 7,
    	Attack= 0,
    	Counter= 3,
    	Desc="When a card is destroyed, gain '''+2''' {{Stat|Attack}}",
    	Gold=7
    }
    cards["Gunkback"] = {
    	Name="Gunkback",
    	Types={Enemy=true},
    	Health= 10,
    	Attack= 4,
    	Counter= 4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="When hit, add [[Gunk Fruit]] to your hand",
    	Gold=7
    }
    cards["Hog"] = {
    	Name="Hog",
    	Types={Enemy=true},
    	Health=1,
    	Attack=1,
    	Counter=2,
    	Desc="{{Keyword|Wild}}",
    	Gold=2
    }
    cards["Jab Joat"] = {
    	Name="Jab Joat",
    	Types={Enemy=true},
    	Health=10,
    	Attack=1,
    	Counter=3,
    	Other="x2 {{stat|Frenzy}}",
    	Gold=2
    }
    cards["Krab"] = {
    	Name="Krab",
    	Types={Enemy=true},
    	Health=5,
    	Attack=8,
    	Counter=5,
    	Other="3 {{Stat|Block}}",
    	Gold=7
    }
    cards["Kraken"] = {
    	Name="Kraken",
    	Types={Enemy=true},
    	Health= 20,
    	Attack= 3,
    	Counter= 4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Hits all enemies",
    	Gold=6
    }
    cards["Krawler"] = {
    	Name="Krawler",
    	Types={Enemy=true},
    	Health=10,
    	Attack=4,
    	Counter=3,
    	Desc="When hit, apply '''2''' {{Stat|Block}} to a random ally",
    	Gold=7
    }
    cards["Lump"] = {
    	Name="Lump",
    	Types={Enemy=true},
    	Health= 2,
    	Attack= 1,
    	Counter= 3,
    	Desc="While active, add '''+1''' {{Stat|Attack}} to all allies",
    	Gold=2
    }
    cards["Makoko"] = {
    	Name="Makoko",
    	Types={Enemy=true},
    	Health=8,
    	Attack=0,
    	Counter=1,
    	Desc="Gain '''+1''' {{Stat|Attack}}",
    	Gold=2
    }
    cards["Marrow"] = {
    	Name="Marrow",
    	Types={Enemy=true},
    	Health=14,
    	Attack=2,
    	Counter=4,
    	Desc="While active, add '''2''' {{Stat|Teeth}} to all allies",
    	Gold=5
    }
    cards["Minimoko"] = {
    	Name="Minimoko",
    	Types={Enemy=true},
    	Health=6,
    	Attack=1,
    	Counter=2,
    	Desc="Gain '''+1''' {{Stat|Attack}}",
    	Gold=2
    }
    cards["Naked Gnome (Enemy)"] = {
    	Name="Naked Gnome",
    	Image="Naked Gnome",
    	Link="Naked Gnome",
    	Types={Enemy=true},
    	Health=1,
    	Desc="<span style=\"color:grey\"> ''Does absolutely nothing...'' </span>",
    	Gold="Doesn't drop gold"
    }
    cards["Octako"] = {
    	Name="Octako",
    	Types={Enemy=true},
    	Health= 10,
    	Attack= 2,
    	Counter= 3,
    	Desc="Apply '''2''' {{Stat|Ink}}<br>{{Keyword|Barrage}}",
    	Gold=4
    }
    cards["Ooba Bear"] = {
    	Name="Ooba Bear",
    	Types={Enemy=true},
    	Health=6,
    	Attack=4,
    	Counter=3,
    	Desc="When hit, apply '''2''' {{Stat|Snow}} to the attacker",
    	Gold=5
    }
    cards["Paw Paw"] = {
    	Name="Paw Paw",
    	Types={Enemy=true},
    	Health=10,
    	Attack=1,
    	Counter=3,
    	Desc="When hit, gain '''2''' {{Stat|Teeth}}",
    	Gold=5
    }
    cards["Pecan"] = {
    	Name="Pecan",
    	Types={Enemy=true},
    	Health=2,
    	Attack=4,
    	Counter=4,
    	Other="6 {{stat|Shell}}",
    	Desc="Gain '''2''' {{Stat|Shell}}",
    	Gold=7
    }
    cards["Pengoon"] = {
    	Name="Pengoon",
    	Types={Enemy=true},
    	Health=2,
    	Attack=1,
    	Counter=2,
    	Gold=2
    }
    cards["Pepper Witch"] = {
    	Name="Pepper Witch",
    	Types={Enemy=true},
    	Health=8,
    	Attack=1,
    	Counter=3,
    	Desc="When hit, apply '''2''' {{Stat|Spice}} to allies in the row",
    	Gold=2
    }
    cards["Plum"] = {
    	Name="Plum",
    	Types={Enemy=true},
    	Health=15,
    	Attack=2,
    	Counter=3,
    	Desc="Restore '''4''' {{Stat|Health}} to all allies",
    	Gold=7
    }
    cards["Popshroom"] = {
    	Name="Popshroom",
    	Types={Enemy=true},
    	Health=6,
    	Attack=0,
    	Counter=4,
    	Desc="Apply '''4''' {{Stat|Shroom}}<br>Destroy self",
    	Gold=7
    }
    cards["Porkypine"] = {
    	Name="Porkypine",
    	Types={Enemy=true},
    	Health=6,
    	Attack=2,
    	Counter=4,
    	Desc="{{Keyword|Barrage}}",
    	Gold=6
    }
    cards["Prickle"] = {
    	Name="Prickle",
    	Types={Enemy=true},
    	Health=5,
    	Counter=3,
    	Other="2 {{Stat|Teeth}}",
    	Desc="Gain '''2''' {{Stat|Teeth}}",
    	Gold=6
    }
    cards["Puffball"] = {
    	Name="Puffball",
    	Types={Enemy=true},
    	Health=2,
    	Attack=0,
    	Other="{{Stat|Reaction}}",
    	Desc="Apply '''2''' {{Stat|Shroom}}<br><div style=\"color:brown;\">Trigger against the target when an ally attacks</div>",
    	Gold=5
    }
    cards["Pygmy"] = {
    	Name="Pygmy",
    	Types={Enemy=true},
    	Health=5,
    	Attack=0,
    	Counter=2,
    	Desc="Apply '''1''' {{Stat|Demonize}}<br>{{Keyword|Barrage}}",
    	Gold=2
    }
    cards["Rockhog"] = {
    	Name="Rockhog",
    	Types={Enemy=true},
    	Health=7,
    	Attack=4,
    	Counter=6,
    	Desc="While active, add '''x1''' {{Stat|Frenzy}} to all allies",
    	Gold=7
    }
    cards["Shell Witch"] = {
    	Name="Shell Witch",
    	Types={Enemy=true},
    	Health=6,
    	Attack=2,
    	Counter=3,
    	Desc="Apply '''2''' {{Stat|Shell}} to all allies",
    	Gold=5
    }
    cards["Shroom Gobbler"] = {
    	Name="Shroom Gobbler",
    	Types={Enemy=true},
    	Health=12,
    	Attack=2,
    	Counter=5,
    	Desc="Whenever anything takes damage from {{Stat|Shroom}}, gain '''+1''' {{Stat|Attack}}",
    	Gold=6
    }
    cards["Shrootles"] = {
    	Name="Shrootles",
    	Types={Enemy=true},
    	Health=8,
    	Attack=0,
    	Counter=3,
    	Other="x3 {{Stat|Frenzy}}",
    	Desc="Apply '''1''' {{Stat|Shroom}}<br>{{Keyword|Aimless}}",
    	Gold=6
    }
    cards["Smog"] = {
    	Name="Smog",
    	Types={Enemy=true},
    	Health=10,
    	Attack=5,
    	Counter=6,
    	Desc="While active, add {{Keyword|Aimless}} to all enemies",
    	Gold=5
    }
    cards["Snow Gobbler"] = {
    	Name="Snow Gobbler",
    	Types={Enemy=true},
    	Health=8,
    	Attack=1,
    	Counter=5,
    	Desc="Whenever anything is {{Stat|Snow}}'d, gain '''+2''' {{Stat|Attack}}",
    	Gold=6
    }
    cards["Snowbirb"] = {
    	Name="Snowbirb",
    	Types={Enemy=true},
    	Health=4,
    	Attack=1,
    	Counter=3,
    	Desc="Apply '''4''' {{Stat|Snow}}<br>{{Keyword|Longshot}}",
    	Gold=5
    }
    cards["Snowbo"] = {
    	Name="Snowbo",
    	Types={Enemy=true},
    	Health=4,
    	Attack=1,
    	Counter=2,
    	Desc="{{Keyword|Aimless}}",
    	Gold=4
    }
    cards["Spuncher"] = {
    	Name="Spuncher",
    	Types={Enemy=true},
    	Health=15,
    	Attack=3,
    	Counter=3,
    	Gold=2
    }
    cards["Tentickle"] = {
    	Name="Tentickle",
    	Types={Enemy=true},
    	Health=7,
    	Attack=4,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="When hit, apply '''3''' {{Stat|Ink}} to the attacker",
    	Gold=7
    }
    cards["Waddlegoons"] = {
    	Name="Waddlegoons",
    	Types={Enemy=true},
    	Health=9,
    	Attack=1,
    	Counter=3,
    	Other="x3 {{Stat|Frenzy}}",
    	Gold=7
    }
    cards["Warthog"] = {
    	Name="Warthog",
    	Types={Enemy=true},
    	Health=18,
    	Attack=5,
    	Counter=5,
    	Other="{{Stat|Reaction}}",
    	Desc="{{Keyword|Wild}}<br>{{Keyword|Smackback}}",
    	Gold=7
    }
    cards["Wild Snoolf"] = {
    	Name="Wild Snoolf",
    	Types={Enemy=true},
    	Health=4,
    	Attack=1,
    	Counter=3,
    	Desc="Apply '''2''' {{Stat|Snow}}",
    	Gold=5
    }
    cards["Willow"] = {
    	Name="Willow",
    	Types={Enemy=true},
    	Health=16,
    	Attack=0,
    	Counter=5,
    	Desc="Apply '''5''' {{Stat|Overburn}}",
    	Gold=7
    }
    cards["Winter Worm"] = {
    	Name="Winter Worm",
    	Types={Enemy=true},
    	Health=10,
    	Attack=8,
    	Counter=6,
    	Desc="When hit, reduce {{Stat|Attack}} by '''1'''",
    	Gold=7
    }
    cards["Woolly Drek"] = {
    	Name="Woolly Drek",
    	Types={Enemy=true},
    	Health=28,
    	Attack=3,
    	Counter=5,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Eat and {{Keyword|Absorb}} a random ally",
    	Gold=7
    }

    --Enemy Clunkers
    cards["Bombarder (Enemy)"] = {
    	Name="Bombarder",
    	Types={EnemyClunker=true},
    	Scrap=3,
    	Attack=0,
    	Counter=4,
    	Desc="Apply '''2''' {{Stat|Bom}}<br>Hits all enemies",
    }
    cards["Ice Forge"] = {
    	Name="Ice Forge",
    	Types={EnemyClunker=true},
    	Scrap=2,
    	Desc="While active, add '''+2''' {{Stat|Attack}} to all allies and '''-2''' {{Stat|Attack}} to all enemies",
    }
    cards["Ice Lantern"] = {
    	Name="Ice Lantern",
    	Types={EnemyClunker=true},
    	Scrap=1,
    	Desc="While active, add '''+2''' {{Stat|Attack}} to all allies",
    }
    cards["Moko Head"] = {
    	Name="Moko Head",
    	Types={EnemyClunker=true},
    	Scrap=1,
    	Desc="When destroyed, apply '''5''' {{Stat|Spice}} to all allies",
    }
    cards["Octobom"] = {
    	Name="Octobom",
    	Types={EnemyClunker=true},
    	Scrap= 1,
    	Desc="When destroyed, apply '''4''' {{Stat|Ink}} to all enemies and allies",
    }
    cards["Spike Wall"] = {
    	Name="Spike Wall",
    	Types={EnemyClunker=true},
    	Scrap=3,
    	Attack=3,
    	Other="{{Stat|Reaction}}",
    	Desc="{{Keyword|Frontline}}<br>{{Keyword|Smackback}}",
    }

    --Minibosses
    cards["Big Peng"] = {
    	Name="Big Peng",
    	Types={Miniboss=true},
    	Health=10,
    	Attack=1,
    	Counter=4,
    	Desc="Gain '''+1''' {{Stat|Attack}} when an ally is killed",
    }
    cards["Bigloo"] = {
    	Name="Bigloo",
    	Types={Miniboss=true},
    	Health=30,
    	Attack=5,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Apply '''2''' {{Stat|Snow}}<br>{{Keyword|Barrage}}",
    }
    cards["Bogberry"] = {
    	Name="Bogberry",
    	Types={Miniboss=true},
    	Health= 8,
    	Attack= 1,
    	Counter= 4,
    	Desc="When healed, gain '''+2''' {{Stat|Attack}}",
    }
    cards["Bolgo"] = {
    	Name="Bolgo",
    	Types={Miniboss=true},
    	Health=20,
    	Attack=5,
    	Counter=3,
    	Other="10 {{Stat|Shell}}",
    	Desc="When hit, gain '''+1''' {{Stat|Attack}}",
    }
    cards["Bumbo"] = {
    	Name="Bumbo",
    	Types={Miniboss=true},
    	Health=15,
    	Attack=3,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Apply '''2''' {{Stat|Snow}}<br>{{Keyword|Barrage}}",
    }
    cards["King Moko"] = {
    	Name="King Moko",
    	Types={Miniboss=true},
    	Health=80,
    	Attack=10,
    	Counter=7,
    	Other="x5 {{Stat|Frenzy}}<br>{{Stat|Resist Snow}}",
    	Desc="When hit, apply '''3''' {{Stat|Spice}} to everyone in the battle",
    }
    cards["Lumako"] = {
    	Name="Lumako",
    	Types={Miniboss=true},
    	Health= 30,
    	Attack= 3,
    	Counter= 3,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Boost the effects of all enemies and allies by '''1'''",
    }
    cards["Maw Jaw"] = {
    	Name="Maw Jaw",
    	Types={Miniboss=true},
    	Health=30,
    	Attack=5,
    	Counter=4,
    	Other="{{Stat|Reaction}}",
    	Desc="<div style=\"color:brown;\">Trigger when hit</div>",
    }
    cards["Muttonhead"] = {
    	Name="Muttonhead",
    	Types={Miniboss=true},
    	Health=30,
    	Attack=4,
    	Counter=3,
    	Desc="When {{Stat|Snow}}'d, apply '''1''' {{Stat|Demonize}} to all enemies",
    }
    cards["Nimbus"] = {
    	Name="Nimbus",
    	Types={Miniboss=true},
    	Health= 10,
    	Attack= 2,
    	Counter= 5,
    	Desc="{{Keyword|Barrage}}",
    }
    cards["Numskull"] = {
    	Name="Numskull",
    	Types={Miniboss=true},
    	Health=30,
    	Attack=6,
    	Counter=4,
    	Other="8 {{Stat|Block}}<br>{{Stat|Resist Snow}}",
    	Desc="While active, add {{Keyword|Hogheaded}} to all enemies",
    }
    cards["Queen Globerry"] = {
    	Name="Queen Globerry",
    	Types={Miniboss=true},
    	Health=15,
    	Attack=0,
    	Counter=5,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Deal additional damage equal to {{Stat|Health}}",
    }
    cards["Razor"] = {
    	Name="Razor",
    	Types={Miniboss=true},
    	Health=50,
    	Attack=3,
    	Counter=3,
    	Other="{{Stat|Resist Snow}}",
    	Desc="{{Keyword|Wild}}",
    }
    cards["The Ringer"] = {
    	Name="The Ringer",
    	Types={Miniboss=true},
    	Health=15,
    	Attack=5,
    	Counter=5,
    	Other="{{Stat|Resist Snow}}",
    	Desc="When hit, apply '''2''' {{Stat|Frost}} to a random enemy",
    }
    cards["The Snow Knight"] = {
    	Name="The Snow Knight",
    	Types={Miniboss=true},
    	Health=10,
    	Attack=1,
    	Counter=2,
    	Desc="Whenever anything is {{Stat|Snow}}'d, gain '''+1''' {{Stat|Attack}}",
    }
    cards["Veiled Lady"] = {
    	Name="Veiled Lady",
    	Types={Miniboss=true},
    	Health=12,
    	Attack=0,
    	Counter=3,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Apply '''3''' {{Stat|Shroom}}",
    }
    cards["Weevil"] = {
    	Name="Weevil",
    	Types={Miniboss=true},
    	Health= 50,
    	Attack= 4,
    	Counter= 4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Before attacking, destroy all [[Items]] in hand and gain '''+1''' {{Stat|Attack}} for each",
    }


    --Bosses
    cards["Bam"] = {
    	Name="Bam",
    	Types={Boss=true},
    	Health=16,
    	Attack=6,
    	Counter=6,
    	Other="{{Stat|Resist Snow}}",
    	Desc="{{Keyword|Wild}}",
    }
    cards["Bamboozle"] = {
    	Name="Bamboozle",
    	Types={Boss=true},
    	Health=18,
    	Attack=3,
    	Counter=5,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Hits all enemies",
    }
    cards["Boozle"] = {
    	Name="Boozle",
    	Types={Boss=true},
    	Health=14,
    	Attack=2,
    	Counter=2,
    	Desc="Apply '''1''' {{Stat|Snow}}<br>{{Keyword|Wild}}",
    }
    cards["Frost Bomber"] = {
    	Name="Frost Bomber",
    	Types={Boss=true},
    	Health=60,
    	Attack=5,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="{{Keyword|Barrage}}",
    }
    cards["Frost Crusher"] = {
    	Name="Frost Crusher",
    	Types={Boss=true},
    	Health=90,
    	Attack=2,
    	Counter=2,
    	Desc="Gain '''+2''' {{Stat|Attack}}",
    }
    cards["Frost Guardian"] = {
    	Name="Frost Guardian",
    	Types={Boss=true},
    	Health=60,
    	Attack=0,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="When {{Stat|Health}} lost, add equal {{Stat|Attack}} to self and allies",
    }
    cards["Frost Guardian (Phase 2)"] = {
    	Name="Frost Guardian",
    	Link="Frost Guardian",
    	Health=999,
    	Attack=2,
    	Counter=2,
    	Other="{{Stat|Resist Snow}}",
    	Desc="When an ally is killed, lose half {{Stat|Health}} and gain '''+2''' {{Stat|Attack}}",
    }
    cards["Frost Jailer"] = {
    	Name="Frost Jailer",
    	Types={Boss=true},
    	Health=90,
    	Attack=5,
    	Counter=5,
    	Desc="While active, add {{Keyword|Unmovable}} to all enemies",
    }
    cards["Frost Junker"] = {
    	Name="Frost Junker",
    	Types={Boss=true},
    	Health=30,
    	Attack=1,
    	Counter=2,
    	Desc="When a card is destroyed, gain '''+1''' {{Stat|Attack}}",
    }
    cards["Frost Lancer"] = {
    	Name="Frost Lancer",
    	Types={Boss=true},
    	Health=60,
    	Attack=7,
    	Counter=6,
    	Other="{{Stat|Resist Snow}}",
    	Desc="{{Keyword|Aimless}}",
    }
    cards["Frost Muncher"] = {
    	Name="Frost Muncher",
    	Types={Boss=true},
    	Health=30,
    	Attack=4,
    	Counter=6,
    	Desc="Destroy the rightmost card in your hand",
    }
    cards["Infernoko"] = {
    	Name="Infernoko",
    	Types={Boss=true},
    	Health=16,
    	Attack=1,
    	Counter=4,
    	Other="{{Stat|Resist Snow}}",
    	Desc="When an ally is killed, gain their {{Stat|Attack}}",
    }
    cards["Infernoko (Phase 2)"] = {
    	Name="Infernoko",
    	Link="Infernoko",
    	Health=30,
    	Attack=2,
    	Counter=2,
    	Other="{{Stat|Resist Snow}}",
    	Desc="Gain '''+1''' {{Stat|Attack}}",
    }
    cards["Krunker"] = {
    	Name="Krunker",
    	Types={Boss=true},
    	Scrap=8,
    	Attack=8,
    	Counter=3,
    	Desc="{{Keyword|Backline}}<br>{{Keyword|Bombard}}",
    }
    cards["Krunker (Phase 2)"] = {
    	Name="Krunker",
    	Link="Krunker",
    	Health=50,
    	Attack=3,
    	Counter=2,
    	Other="{{Stat|Resist Snow}}",
    	Desc="{{Keyword|Backline}}<br>{{Keyword|Bombard}}",
    }
    cards["Truffle"] = {
    	Name="Truffle",
    	Types={Boss=true},
    	Health=110,
    	Attack=4,
    	Counter=4,
    	Desc="{{Keyword|Split}} when '''10''' {{Stat|Health}} lost",
    }
    """;
}