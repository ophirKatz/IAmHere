using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace IAmHere.Blazor.Services
{
	public class BrowserSessionHandler : IBrowserSessionHandler
	{
		#region Constructor

		public BrowserSessionHandler(ILocalStorageService localStorage)
		{
			this.LocalStorage = localStorage;
		}

		#endregion

		#region Implementation of IBrowserSessionHandler

		public async Task<bool> IsStudentRegisteredToClass(string classCode)
		{
			var session = await LocalStorage.GetItemAsync<string>(StorageKey);
			return session != null && session.Contains(classCode);
		}

		public async Task RegisterStudentToClass(string classCode)
		{
			await LocalStorage.SetItemAsync(StorageKey, classCode);
		}

		#endregion

		#region Private Members

        private ILocalStorageService LocalStorage { get; }
		private const string StorageKey = "browser-session";

		#endregion
	}
}