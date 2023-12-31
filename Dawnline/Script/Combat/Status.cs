namespace dawnline.core {
	public abstract class Condition {
	}

	public abstract class Status {
	}

	#region Statuses

	public class Engaged : Status {
		// If a character moves adjacent to a hostile character, they both gain the ENGAGED status for as long as 
		// they remain adjacent to one another. Ranged attacks made by an ENGAGED character gain 1 (-). 
		// Additi­onally, characters that become ENGAGED by targets of equal or greater SIZE during the course of a 
		// movement stop moving immedi­ately and lose any unused movement.
	}

	public class Hidden : Status {
		// HIDDEN characters can’t be targeted by hostile attacks or actions, don’t cause engagement, and enemies 
		// only know their approximate location. Attacking, forcing saves, taking reactions, using BOOST, 
		// and losing cover all remove HIDDEN after they resolve. Characters can find HIDDEN characters with SEARCH.
	}

	public class Invisible : Status {
		// All attacks against INVISIBLE characters, regardless of type, have a 50 percent chance to miss 
		// outright, before an attack roll is made. Roll a dice or flip a coin to determine if the attack misses.
		// Additionally, INVISIBLE characters can always HIDE, even without cover.
	}

	public class Prone : Status {
		// Attacks against PRONE targets receive +1 accuracy.
		// Additionally, PRONE characters are SLOWED and count as moving in difficult terrain. Characters can 
		// remove PRONE by standing up instead of taking their standard move, unless they’re IMMOBILIZED. 
		// Standing up doesn’t count as movement, so doesn’t trigger OVERWATCH or other effects.
	}

	public class DangerZone : Status {
		// Characters are in the DANGER ZONE when half or more of their heat is filled in. 
		// They’re smoking hot, which enables some attacks, talents, and effects.
	}

	public class Exposed : Status {
		// Characters become EXPOSED when they’re dealing with runaway heat buildup – their armor is weakened by 
		// overheating, their vents are open, and their weapons are spinning down, providing plenty of weak points. 
		// All kinetic, explosive, or energy damage taken by EXPOSED characters is doubled, before applying any reductions. 
		// A mech can clear EXPOSED by taking the STABILIZE action.
	}

	public class Shutdown : Status {
		// MECH ONLY
		// When a mech is SHUT DOWN:
		// • all heat is cleared and the EXPOSED status is removed;
		// • any cascading NHPs are stabilised and no longer cascading
		// • any statuses and conditions affecting the mech caused by tech actions, such as LOCK ON, immediately end.
		// SHUT DOWN mechs have IMMUNITY to all tech actions and attacks, including any from allied characters.
		// While SHUT DOWN, mechs are STUNNED indefinitely. Nothing can prevent this condition, and it remains 
		// until the mech ceases to be SHUT DOWN.
	}

	public class DownAndOut : Status {
		// PILOT ONLY
		// Pilots that are DOWN AND OUT are unconscious and STUNNED – if they take any more damage, they die. 
		// They'll regain consciousness and half of their HP when they rest.
	}

	public class Intangible : Status {
		// INTANGIBLE characters can move through obstructions such as characters or terrain but not end their turns 
		// in them. They, their actions, and any effects they own or control can only affect other Intangible characters 
		// and objects. Tangible characters can move through INTANGIBLE characters and objects but not end their turns 
		// inside their spaces and can’t affect them in any way.
		
		// INTANGIBLE characters cannot capture points or count for zones (for sitreps) and don’t count as 
		// adjacent to tangible characters.
		// Effects that are already active on a character when they become INTANGIBLE, such as statuses, remain active, 
		// but effects that require an ongoing interaction between two characters or objects (like traps or force fields) end. 
		// If a mech becomes INTANGIBLE, its pilot remains INTANGIBLE for the same duration.
	}

	#endregion
	#region Conditions

	public class Immobilized : Condition {
		// IMMOBILIZED characters cannot make any voluntary movements, although involuntary movements are unaffected.
	}

	public class Impaired : Condition {
		// IMPAIRED characters receive +1 difficulty on all attacks, saves, and skill checks.
	}

	public class Jammed : Condition {
		// JAMMED characters can’t: 
		// • use comms to talk to other characters, 
		// • make attacks, other than IMPROVISED ATTACK, GRAPPLE, and RAM;
		// • take reactions, or take or benefit from tech actions.
	}

	public class LockOn : Condition {
		// Hostile characters can choose to consume a character’s LOCK ON condition in exchange for +1 accuracy on their 
		// next attack against that character. LOCK ON is also required to use some talents and systems.
	}

	public class Shredded : Condition {
		// SHREDDED characters don’t benefit from ARMOR or RESISTANCE.
	}

	public class Slowed : Condition {
		// The only movement SLOWED characters can make is their standard move, on their own turn – they can’t BOOST or make any 
		// special moves granted by talents, systems, or weapons.
	}

	public class Stunned : Condition {
		// STUNNED mechs cannot OVERCHARGE, move, or take any actions – including free actions and reactions. 
		// Pilots can still MOUNT, DISMOUNT, or EJECT from STUNNED mechs, and can take actions normally.
		// STUNNED mechs have a maximum of 5 EVASION, and automatically fail all HULL and AGILITY checks and saves.
	}

	#endregion


}