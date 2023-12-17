using Godot;
using System;

namespace dawnline.core {
	public interface Character
	{
		
		byte HPTotal {get;}
		byte HPCurrent {get;}
		byte Evasion {get;}
		byte EDefense {get;}
		byte Armor {get;}

		/// <summary>
		/// Size of the character. Treat 0 as Size 1/2
		/// </summary>
		byte Size {get;}

		Guid ID {get;}
		Status[] Statuses {get;}
		Condition[] Conditions {get;}
	}

	public abstract class HaseCharacter : Character {
		public Guid ID {get;}
		public string Name {get;}
		abstract public byte Hull {get;}
		abstract public byte Agility {get;}
		abstract public byte System {get;}
		abstract public byte Engineering {get;}
		
		public byte HPTotal {get;}
		public byte HPCurrent {get;}
		public byte Evasion {get;}
		public byte EDefense {get;}
		public byte Armor {get;}
		public byte Size {get;}

		public Status[] Statuses {get;}
		public Condition[] Conditions {get;}
	}

	public class Drone : Character {

		public Guid ID {get;}
		public string Name {get;}
		public byte HPTotal {get;}
		public byte HPCurrent {get;}
		public byte Evasion {get;}
		public byte EDefense {get;}
		public byte Armor {get;}
		public byte Size {get;}

		public Status[] Statuses {get;}
		public Condition[] Conditions {get;}
	}

	public class Pilot : HaseCharacter {

		override public byte Hull {get;}
		override public byte Agility {get;}
		override public byte System {get;}
		override public byte Engineering {get;}

		public byte LicenseLevel {get;}

		public Guid[] CoreBonuses {get;}

		public Tuple<Guid, byte>[] SkillTriggers {get;}
		public Guid[] Talents {get;}
		public Tuple<Guid, int>[] Licenses {get;}

		public Guid EquipmentArmor {get;}
		public Guid[] EquipmentWeapons {get;}
		public Tuple<Guid, byte> EquipmentGear {get;}
		
	}

	public abstract class Mech : HaseCharacter {
		public byte StructureTotal {get;}
		public byte StructureCurrent {get;}

		public byte StressTotal {get;}
		public byte StressCurrent {get;}
		public byte HeatCapacityTotal {get;}
		public byte HeatCapacityCurrent {get;}

		public byte AttackBonus {get;}
		public byte TechAttackBonus {get;}

		public byte Speed {get;}
		public byte MoveRemaining {get;}

		public byte SensorRange {get;}
		public byte SaveTarget {get;}

		public byte Overshield {get;}
	}

	public class PlayerMech : Mech {
		override public byte Hull => Pilot.Hull;
		override public byte Agility => Pilot.Agility;
		override public byte System => Pilot.System;
		override public byte Engineering => Pilot.Engineering;

		public Guid Frame {get;}
		public Tuple<Guid, int>[] LicenseRequirements {get;}
		public Pilot Pilot {get;}

		public byte RepairCapacityTotal {get;}
		public byte RepairCapacityCurrent {get;}

		public byte LimitedSystemBonus {get;}

		public bool CorePoint {get;}
		public byte Overcharge {get;}

		public byte SystemPoints {get;}

		public Mount[] Mounts;
		public Guid[] MechSystems;
	}

	public class Mount {
		public enum MountType {
			Integrated,
			AuxAux,
			Main,
			Flex,
			MainAux,
			Heavy,
			Superheavy
		}
		public MountType Type;
		public Guid Modifications;
		public bool Locked;
		public Guid[] Weapons;
		public Guid[] WeaponModifications;
	}

	public class NPCMech : Mech
	{
		public byte Tier {get;}
		public byte ActivationsTotal {get;}
		public byte ActivationsCurrent {get;}
		public override byte Hull {get;}
		public override byte Agility {get;}
		public override byte System {get;}
		public override byte Engineering {get;}
		
		public Tuple<Guid, int> Features;

	}

}