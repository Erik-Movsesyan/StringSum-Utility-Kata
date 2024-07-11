namespace StringSum_Utility_Kata
{
    public class StringSum
    {
        public string Sum(string num1, string num2)
        {
            if (!ValidateArg(num1) || !ValidateArg(num2))
                return "0";

            var parsedNum1 = int.Parse(num1);
            var parsedNum2 = int.Parse(num2);

            return (parsedNum1 + parsedNum2).ToString();
        }

        private static bool ValidateArg(string arg)
        {
            if(arg == null)
                return false;

            var containsDots = arg.Contains('.');
            var conversionSucceed = int.TryParse(arg, out int result);

            return !containsDots && conversionSucceed && result > 0;
        }
    }
}
