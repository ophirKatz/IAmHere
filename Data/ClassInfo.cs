using System.Collections.Generic;

namespace IAmHere.Blazor.Data
{
	public class ClassInfo
	{
		public ClassInfo(int id, string classCode)
		{
			Id = id;
			ClassCode = classCode;
            Students = new List<string>();
		}
        
		public int Id { get; set; }
		public string ClassCode { get; set; }
		public List<string> Students { get; set; }
	}
}