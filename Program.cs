using System.Diagnostics;

class Program
{
    List<string> commands = new List<string>
    {
        "help",
        "cmd",
        "powershell",
        "diskmgmt",
        "scsver",
        "winver",
        "msinfo",
        "ping",
        "quit"
    };
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("StupidCSSystem Ver1\nPlease look at the first time guide before using");
        while (true)
        {
            Console.Write("> ");
            string user = Console.ReadLine().Trim().ToLower();
            switch (user)
            {
                case "help":
                    Console.WriteLine("StupidPySystem Help (++ to quit)\nReport any bugs you find!\nCommands:");
                    foreach (string command in new Program().commands)
                    {
                        Console.WriteLine($"- {command}");
                    }
                    while (true)
                    {
                        Console.Write("help> ");
                        string help = Console.ReadLine().Trim().ToLower();
                        if (help == "++")
                        {
                            break;
                        }
                        switch (help)
                        {
                            case "cmd":
                                Console.WriteLine("Command Prompt\n// Opens the Command Prompt (cmd)\n// Quits SCS");
                                break;
                            case "powershell":
                                Console.WriteLine("PowerShell\n// Opens PowerShell\n// Quits SCS");
                                break;
                            case "diskmgmt":
                                Console.WriteLine("Disk Management\n// Opens Disk Management\n// Quits SCS");
                                break;
                            case "scsver":
                                Console.WriteLine("StupidCSSystem Version\n// Displays the current version of StupidCSSystem");
                                break;
                            case "winver":
                                Console.WriteLine("Windows Version\n// Displays the current Windows version");
                                break;
                            case "msinfo":
                                Console.WriteLine("System Information\n// Displays system information");
                                break;
                            case "quit":
                                Console.WriteLine("Quits SCS");
                                return;
                            case "ping":
                                Console.WriteLine("Ping\n// Uses the built in Ping command for whatever operating system you're using");
                                break;
                            default:
                                Console.WriteLine("Command doesn't exit.");
                                break;
                        }
                    }
                    break;
                case "cmd":
                    Console.WriteLine("Opening Command Prompt...");
                    Console.Clear();
                    Process.Start(new ProcessStartInfo("cmd.exe") { UseShellExecute = false });
                    break;
                case "powershell":
                    Console.WriteLine("Opening PowerShell...");
                    Console.Clear();
                    Process.Start(new ProcessStartInfo("powershell.exe") { UseShellExecute = true });
                    break;
                case "diskmgmt":
                    Console.WriteLine("Opening Disk Management...");
                    Process.Start(new ProcessStartInfo("diskmgmt.msc") { UseShellExecute = true });
                    break;
                case "scsver":
                    Console.WriteLine("StupidCSSystem\nVersion 1 Beta\nWindows Build\nMade by @veraveemo on Discord\nVeraVeemo on GitHub\nFork of https://github.com/pepsicarrt/StupidPySystem\nOriginal by @pepsicart. on Discord and pepsicarrt on GitHub.");
                    break;
                case "winver":
                    Console.WriteLine("Windows Version\n" + Environment.OSVersion.VersionString);
                    break;
                case "msinfo":
                    Console.WriteLine("Opening System Information...");
                    Process.Start(new ProcessStartInfo("msinfo32.exe") { UseShellExecute = true });
                    break;
                case "ping":
                    Console.WriteLine("Enter the address to ping:");
                    string address = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(address))
                    {
                        Console.WriteLine("Address cannot be empty.");
                    }
                    else
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo("ping", address) { UseShellExecute = true });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error pinging {address}: {ex.Message}");
                        }
                    }
                    break;
                case "quit":
                    Console.WriteLine("Quitting StupidCSSystem...");
                    return;
                default:
                    if (string.IsNullOrEmpty(user))
                    {
                        Console.WriteLine("Please enter a command.");
                    }
                    else
                    {
                        Console.WriteLine($"Command '{user}' does not exist. Type 'help' for a list of commands.");
                    }
                    break;
            }
        }
    }
}