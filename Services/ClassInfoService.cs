using System;
using System.Collections.Generic;
using System.Linq;
using IAmHere.Blazor.Data;

namespace IAmHere.Blazor.Services
{
	public class ClassInfoService : IClassInfoService
	{
        #region Constructor

        public ClassInfoService()
        {
            Classes = new List<ClassInfo>();
        }

        #endregion

        #region Implementation of IClassInfoService

		public ClassInfo CreateNewClassSession(string classCode)
		{
            var classId = Guid.NewGuid().GetHashCode();
			var classInfo = new ClassInfo(classId, classCode);
            Classes.Add(classInfo);
            return classInfo;
		}

		public ClassInfo GetClassInfo(string classCode)
		{
			return Classes.FirstOrDefault(i => i.ClassCode == classCode);
		}

		public bool ClassExists(string classCode)
		{
			return Classes.Any(i => i.ClassCode == classCode);
		}

		#endregion

		#region Private Members

		private List<ClassInfo> Classes { get; }

        #endregion
	}
}