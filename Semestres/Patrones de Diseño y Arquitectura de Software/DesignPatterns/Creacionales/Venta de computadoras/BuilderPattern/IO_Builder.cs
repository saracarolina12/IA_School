using System;

namespace BuilderPattern
{
	abstract class IO_Builder
	{
		public abstract void setAsOutput();
		public abstract void setAsInput();
		public abstract void setInfo();
		public abstract void setConector();
		public abstract void setPort();
		public abstract void setAsCart();
		public abstract void setAsToner();

		public abstract void setAsLaser();
		public abstract void setAsIny();
		public abstract IO IO_GetResult(); //returns finished product
	}
}
