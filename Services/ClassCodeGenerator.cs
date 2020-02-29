using System;
using System.Text;
using IAmHere.Blazor.Helpers;
using IAmHere.Blazor.Services;
using IAmHere_Blazor.Data;

namespace IAmHere_Blazor.Services
{
    public class ClassCodeGenerator : IClassCodeGenerator
    {
        #region Constructor

        public ClassCodeGenerator(ICodeConfiguration codeConfiguration)
        {
			CodeConfiguration = codeConfiguration;
		}

        #endregion

        #region Implementation of IClassCodeGenerator

        public ClassCode GenerateClassCode()
        {
            var uniqueId = Guid.NewGuid().GetHashCode();
            return new ClassCode(uniqueId, GenerateRandomCode());
        }

        #endregion

        #region Private Methods

        private string GenerateRandomCode()
        {
            var randomCode = string.Empty;
            if (CodeConfiguration.NumbersOnly)
            {
                randomCode = RandomNumber(CodeConfiguration.Length).ToString(); 
            }
            else
            {
                randomCode = RandomString(CodeConfiguration.Length);
            }

            return randomCode;
        }

        private int RandomNumber(int length)
        {
            var min = (int) Math.Pow(10, (length - 1));
            var max = (int) Math.Pow(10, length);
            return Random.Next(min, max);
        }

        private string RandomString(int length)
        {
            var result = new StringBuilder(length);
            length.Do(() => result.Append(AlphaNumeric[Random.Next(AlphaNumeric.Length)]));
            return result.ToString();
        }

        #endregion

        #region Private Members
        
        private Random Random { get; } = new Random();
		private ICodeConfiguration CodeConfiguration { get; }
        private string AlphaNumeric { get; } = "0123456789abcdefghijklmnopqrstuvwxyz";

        #endregion
	}
}