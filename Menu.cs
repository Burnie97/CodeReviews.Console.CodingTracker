using Spectre.Console;
namespace coding_tracker
{
    public static class Menu
    {
        public static void DisplayMenu()
        {
            SetWindowSize();

            var fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", "starwars.flf");
            var font = FigletFont.Load(fontPath);

            FigletMessage("Habit Tracker");


            var table = new Table();
            table.Centered();
            table.Width(80);
            table.Border = TableBorder.AsciiDoubleHead;
            table.AddColumn(new TableColumn("[italic blue]Option[/]").Centered());
            table.AddColumn(new TableColumn("[italic blue]Description[/]").LeftAligned());

            table.AddRow("[red]0[/]", "[red]- Close App[/]");
            table.AddRow("1", "- View all sessions");
            table.AddRow("2", "- View specific session");
            table.AddRow("3", "- Insert new session");
            table.AddRow("4", "- Delete session");
            table.AddRow("5", "- Update session");

            AnsiConsole.Write(table);
        }

        private static void SetWindowSize()
        {
            int minWidth = 90;
            if (Console.WindowWidth < minWidth)
                Console.WindowWidth = minWidth;
        }

        public static void FigletMessage(string message)
        {
            var fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", "starwars.flf");
            var font = FigletFont.Load(fontPath);

            AnsiConsole.Write(
                new FigletText(font, message)
                    .Centered()
                    .Color(Color.Blue));

        }
    }
}