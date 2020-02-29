namespace IAmHere.Blazor.Services
{
	public class CodeConfiguration : ICodeConfiguration
	{
		public int Length { get; set; }

		public bool NumbersOnly { get; set; }
	}

	public interface ICodeConfiguration
    {
        int Length { get; }
        bool NumbersOnly { get; }
    }
}