﻿using System;

namespace AlumniApp
{
	class SupervisorBuilder : UserBuilder
	{
		public override void BuildCareer()
		{
			//just for students
		}
		public override void BuildSubjectID()
		{
			//just for teachers and students
		}
		public override void BuildGrades()
		{
			//just students
		}
		public override void Download()
		{
			//just for students
		}

		public override void NoAccess()
        {
			Form1.noaccess.Visible = true;

		}
	}
}