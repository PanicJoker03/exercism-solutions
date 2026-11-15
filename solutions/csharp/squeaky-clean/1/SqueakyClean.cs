using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool upperNext = false;

        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                sb.Append('_');
            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            else if (c == '-')
            {
                upperNext = true;
            }
            else if (char.IsLetter(c))
            {
                if (c >= 'α' && c <= 'ω')
                {
                    // Greek lowercase letters are omitted
                    // (a pending kebab-case capitalisation is not consumed)
                    continue;
                }

                sb.Append(upperNext ? char.ToUpper(c) : c);
                upperNext = false;
            }
            // anything else is omitted
        }

        return sb.ToString();
    }
}