namespace HospitalService.Shared.EmailServices
{
    public static class RendomStringGenerators
    {
        public static string RandomCode(int length)
        {
            var rendom = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rendom.Next(s.Length)]).ToArray());
        }
    }
}
