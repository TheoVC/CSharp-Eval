﻿using System;
using System.Drawing;



#pragma warning disable 1591

namespace CSE.Content.ObjectConstruction {
	public struct PublicStruct_PrivateCtor {
		int i;
		float f;
		Color color;
		Random random;

		private PublicStruct_PrivateCtor(int i, float f, Color color, Random random) {
			this.i = i;
			this.f = f;
			this.color = color;
			this.random = random;
		}
	}
}