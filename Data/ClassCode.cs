namespace IAmHere_Blazor.Data
{
    public class ClassCode
    {
        public ClassCode(int id, string code)
        {
            CodeId = id;
            Code = code;
        }

        private int CodeId { get; set; }
        public string Code { get; private set; }
    }
}