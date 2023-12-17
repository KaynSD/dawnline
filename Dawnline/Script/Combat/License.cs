using System;

namespace dawnline.core {
	public class LicenseLevel {
		public int Level;

		public Guid[] Frames;
		public Guid[] Systems;
		public Guid[] Weapons;
	}

	public class License {
		public Guid ID;
		public string Name;
		public Guid Manufacturer;
	}
}