using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace RST_Invest
{
    internal class Validator
    {
        private HashSet<string> _numenclature;
        private const string regMask = "[A-Z\\d]{24}";
        private Regex regex = new Regex(regMask);

        public Validator(string filePath)
        {
            var json = File.ReadAllText(filePath);
            _numenclature = new HashSet<string>();
            try
            {
                dynamic jsonObject = JsonConvert.DeserializeObject(json);
                var arr = jsonObject["Numenclature"].ToObject<string[]>();
                
                foreach(var str in arr)
                {
                    _numenclature.Add(str);
                }
            }
            catch (Exception ex) 
            {
                Console.Error.WriteLine($"Deserialization error. {ex.Message}");
            }
        }
        public bool Validate(string input)
        {
            if (regex.IsMatch(input.ToUpper()))
            {
                return _numenclature.Contains(input);
            }
            return false;
                    
        }
    }
}
