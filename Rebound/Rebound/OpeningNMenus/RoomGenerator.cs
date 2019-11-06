using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebound.OpeningNMenus
{
    public class RoomGenerator
    {
        public static string GetRoom()
        {
            string[] rooms =
            {
                
                "Stinking smoke wafts up from braziers made of skulls set around the edges of this room." +
                " The walls are in ruin with scratch marks and lines of soot that form crude pictures and what looks like some strange language." +
                "Furs and skins of unknown origin are strewn haphazardly about the floor.\n", 

                "Thick cobwebs fill the corners of the room, and wisps of webbing hang from the ceiling and waver in a wind you can barely feel. It feels strangely colder in" +
                " this room.\n",

                "This dark room hits you with the stink of wet dog and iron. There are dark shapes scattered around the room but its hard to tell what they are. " +
                "Just as you consider trying a different door, a half-hazard brazier flickers to life in the center of the room. In this new light, you can now see that the shapes on the ground are " +
                "piles of half-eaten creatures that looked vaguely canine.\n",

                "You open the door to reveal a 10-foot-by-10-foot room with a celing studded with spikes. Cracked, ancient skulls and tattered cloth are embedded " +
                "in the intimidating looking spikes like food stuck in a huge monster's teeth. Piles of debris is scattered about the room, but it's otherwise bare.\n",

                "The scent of earthy decay assaults your nose upon entering this room. Smashed bookcases and their sundered contents litter the floor everywhere you look. " +
                "Paper rots in mold-spotted heaps, and shattered wood grows strange glowing, white fungus that keeps the room illuminated.\n",

                "This room appeares mostly empty save for the hundreds of dusty tapestries hanging from the celing in neat rows. Floating back and forth along the rows is a single" +
                " washing paddle, endlessly beating the old tapestries with a muffled 'THUMP' 'THUMP' 'THUMP' in a losing battle against the dust. " +
                "If you squint, you swear you can see the vague silhouette of a person holding the paddle.\n",

                "This room is full of random objects collected into neatly sorted piles. It looks like a very organized dumpyard, and smells like it too.\n",

                "You open the door to confront a room of odd pillars shaped like human sculptures. Some hold expressions of surprise while others have their bodies curled in pain and horror." +
                " There are a few that have been knocked over, stone limbs and bits scattered along the ground. It's like some kind of macabre art showing, but the artist doesn't seem to be here. Lucky you.\n",

                "There's an almost calming sound comming from behind this door. As you step through the frame and straight into a ankle deep puddle you see why. Numerous cracks in the stone above the middle of the north wall " +
                "allows trickles of water to flow down, making it near impossible to find a dry spot to step. There also seem to be divots randomly placed in the floor where the water can pool deeper.\n",

                "A strange pyramid shape hanging upside down from the celing is the focal point of the room before you. It looks to be made of a refine amazonite in shades of light blues and browns. " +
                "You feel a strong urge to touch the smooth looking surface but as you draw closer to it, you feel slightly nauseous and light headed. Maybe it would be best to avoid the big ominous pyramid...\n",

                "You push the door open with some resistance, only noticing the wet floor when you step into the room. Long arms of ivy plants brush the top of your head as you walk in. " +
                "Thick green plants seem to cover every wall, growing upwards until it fills every space in the ceiling as well and starts to layer over top of each other. " +
                "Flowers in different shades and bright hues dotted the room, and every now and then you could see glowing blue or green mushrooms sprouting from something buried deep in layers of greenery. You're not really sure how these plants are prospering so well with no sunlight and" +
                " very little room... But oh well, you take in a deep breath and are pleasantly surprised by the soft floral aroma that greets you. This was far better than the stenches of the other rooms before it, and you intended to enjoy it while you had the " +
                "time. You barely feel the vines slowly slithering around your feet through the shallow water; not until one tries to curl its way up your leg. You to leap backwards like a startled cat and nearly lose your footing in the thick" +
                " weaving of roots and plant matter, splashing water up as you fumble. \n\nIt seems if you stay still for too long, the plants try to grow up you too; better make it quick in here. \n",

                "You open the door to what must have been a combat training room at some point. Rough fighting circles are lazily scratched into the surface of the floor." +
                " What looks like fighting dummies stand waiting for someone to attack them along the back wall, and a few punching bags hang from the ceiling in random spots. " +
                "There's something peculiar about it all though...Every dummy is stocky and each has a dilapidated chunk of leather hanging from its head that could be a mask some time ago. Realistic hair still somehow clings to the malformed, shriveled leather. " +
                "If you look closely at the punching bags as well, whatever filled the insides seemed to have tried to push it's way out at odd angles; almost tearing the strange looking leathery fabric from the inside.\n",

                "As you push open the wooden door to this room, the first thing you notice is there's actually another door etched into the stone on the far wall! " +
                "Before you get too excited, it and the table piled with debris shoved against it are warped and swollen. The table's surface is rippled into waves and one leg doesn't even touch the floor anymore." +
                " The door shows signs of someone trying to violently chop through from the other side, but at some point gave up. Looking closer, you can see why. " +
                "The ceiling on the other side of the door seems to have caved in at some point; bulging what's left of the door out with it's weight and trickling water through. " +
                "Chunks of maroon stone have fallen in through the holes in the door to join the junk pile on the table.\n",

                "As the door opens, it scrapes up frost from a floor covered in ice. The uncomfortable warmth that fills the rest of the main hall is sucked away and replaced with a chilling cold that bites at your sweaty skin. " +
                "The room before you looks like an ice cave. A tunnel trails its way through solid ice as far as you can see but before you can get too deep, you run nose first into a huge wall of frozen water that blocks your " +
                "path of its farthest reaches. Squinting through the ice, you can see warped images of skeletons floating frozen in time. All appear to be dressed in fancy party-wear. Two seemed to have been sitting and enjoying " +
                "tea together before the room was flash frozen. The rest are glued together in pairs in an eternal ball-room dancing scene. Odd. \n",

                "The door creaks open slowly and your forced to swat away cobwebs as you enter. Before you is a room about which alchemists might have dreamed of once." +
                " Three tables bend beneath a clutter of dusty bottles with long since dried liquid still staining the glass. all connected with old, cracked glass piping. " +
                "Several ancient bookshelves barely stand nearby, stuffed and overflowing with a jumble of old destroyed books, jars, bottles, bags, and boxes. A heavy scent of mildew stuffing up your nose the closer you get." +
                "It looks like some creature might have come through here at some point and shredded enough material to make a small nest at the base of the bookshelves.\n",

                "You feel a sense of foreboding upon peering into this cavernous chamber. It's mostly dark save for the faint glow of bioluminescent mushrooms sprouting from cracks in the walls. " +
                "At its center lies a low heap of debris, rubble, and bones. Atop sit several huge broken eggshells. It doesn't seem like whatever was in the eggs hatched on their own, but rather something had forced its way into them." +
                " Judging by their shattered remains, the eggs were big enough to hold a crouching man, making you wonder how large whatever ate them was.\n",

                "A horrendous, overwhelming stench wafts from the room before you as the door swings open. Small cages containing whats left of small animals and large insects line the walls. To your horror, some of the creatures were still alive; looking sickly and weak but most are clearly dead." +
                " Their rotting corpses and the unclean cages no doubt result in the \"zoo's\" foul odor. Looking closer at the cages themselves, you realize there are no doors or latches to open. Whoever entrapped these creatures didn't intend to let them back out.\n",

                "This small chamber seems to be divided into two parts. The first has several hooks on the walls from which hang dusty old robes. " +
                "An open curtain separates that space from the next, which has a huge basin set into the floor. It's nearly full with a thick oily looking liquid that bubbles every now and then." +
                "The basin sits in front of an even bigger statue of a dog-headed man. In the statue's lap is a deep vase from which the black liquid endlessly pours. " +
                "You're not sure if this room was used for bathing or sacrifices, regardless you rather not be a part of whatever takes place here.\n",

                "A strange ceiling is the focal point of the room before you. It's honeycombed with hundreds of holes about as wide as your head. " +
                "They seem to penetrate the ceiling to some height beyond a couple feet, but you can't be sure from your vantage point. The faint humming sound from inside worries you...\n",

                "A huge dented iron cage lies on its side in this room, its gate resting open on the floor. " +
                "A broken chain lies under the door, entangled with a rotted corpse that looks to be somewhat humanoid and half crushed under the weight of the cage. " +
                "Another corpse lies a short distance away from the scene, lacking a head.\n",

                "This tiny room holds a curious array of ancient machinery long since broken. Winches and levers protrude from every wall and chains with leather handle dangle from the ceiling. " +
                "On a nearby wall, you note numerous blueprints and pictograms all plastered over top of each other.\n",

                "You open the door and before you is a dragon's hoard of treasure. Coins cover every inch of the room, and jeweled objects of precious metal jut up from the money " +
                "like glittering islands in a sea of gold. It takes you a moment to remember material treasures are useless down here. If anything, this room is just a really pretty tripping hazard.\n",

                "You open the door to reveal a 10-foot-by-10-foot room with a floor studded with spikes. The bones of several creatures lie among the spikes and some insects scuttle away from the desiccated remains as you step a little closer. " +
                "No other doors are in the room, and it appears the door you opened was created to blend in with the walls. Additionally, you are amazed to see no ceiling. " +
                "You must be at the bottom of a very deep spiked pit. To your left, you do notice something had carved away at the wall enough to make a sort of 6ft overhang for it to use as a crude shelter." +
                "Whatever had done this had also taken the time to collect bits of the fallen creatures to hang up around it's little abode as decorations.\n",

                "The room is already quite crowded when you walk in. Dozens of statues in rows of three kneel in the same religious looking position, all facing the same direction. " +
                "You note as you step closer that each and every one of the statues is missing their head. Looking up at the pile of rubble they seem to be facing, you realize where they have gone. " +
                "Stacked upon one another to form a small pyramid are the dismembered heads of the statues. Most seem to hold a expression of sad acceptance, but some seem to look terrified as thick stone tears freeze in place on their smooth cheeks. " +
                "You're not sure what to make of this room.\n",

                "You blink in confusion as you enter the room; many doors fill every space of the room. " +
                "Doors of varied shapes, sizes, and designs are set in every wall and even the ceiling and floor. " +
                "Barely a hand's width lies between one door and the next. All the doors but the one you entered by are shut tight. " +
                "You spend a small amount of time trying, but no matter how many handles you jiggle every door seems to be locked.\n",

                "Burning torches in iron sconces line the walls of this room, lighting it brilliantly and nearly blinding you as you walk in. At the room's center lies a squat stone altar, " +
                "its top is splashed in recently spilled blood, but you can see the dark stains of past sacrifices underneath. " +
                "A channel in the altar funnels the blood down its side to the floor where it fills grooves in the floor that trace some kind of pattern or symbol around the altar. \n",

                " A rusted portcullis stands just beyond the door in your way. " +
                "Looking into the room, you see three other doors, similarly blocked by huge, heavy portcullises. " +
                "Four skeletons dressed in aged clothing and rusting armor sit in a theatre like balcony 10ft or so above you." +
                "Just as you're about to give up and try another door, the portcullis in front of you rattles to life and starts to lift upward, creaking and spilling dust around you as it went. " +
                "Similarly, the portcullises straight across from you also starts to rise and you can see a shadowed shape moving around excitedly behind it.\n"
            };

            Random randomRoom = new Random();
            int indexOfRoom = randomRoom.Next(rooms.Length);
            string Room = rooms[indexOfRoom];
            return Room;

        }
    }
}
