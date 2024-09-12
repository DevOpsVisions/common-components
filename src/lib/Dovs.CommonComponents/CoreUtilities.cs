namespace Dovs.CommonComponents
{
    public class CoreUtilities
    {
        public static string GetWelcomeMessage(string appName)
        {
            // ASCII art logo and welcome message
            string welcomeMessage = @"
  ____              ___             __     ___     _                 
 |  _ \  _____   __/ _ \ _ __  ___  \ \   / (_)___(_) ___  _ __  ___ 
 | | | |/ _ \ \ / / | | | '_ \/ __|  \ \ / /| / __| |/ _ \| '_ \/ __|
 | |_| |  __/\ V /| |_| | |_) \__ \   \ V / | \__ \ | (_) | | | \__ \
 |____/ \___| \_/  \___/| .__/|___/    \_/  |_|___/_|\___/|_| |_|___/
                        |_|                                          
";
            return welcomeMessage + "\nWelcome to " + appName + " by DevOps Visions!\n";
        }

    }
}
