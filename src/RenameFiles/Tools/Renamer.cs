using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
  public static class Renamer
  {
    public static void Run(IWin32Window owner, DirectoryInfo[] directories, RenameRule[] rules)
    {
      var form = new DumpForm();
      foreach (var dir in directories)
      {
        foreach (var rule in rules)
        {
          form.AddTab($"({dir.Name}) {rule.Contains}", Run(dir, rule));
        }
      }
      form.Show(owner);
    }

    private static IEnumerable<RenameResult> Run(DirectoryInfo dir, RenameRule rule)
    {
      if (!dir.Exists)
        yield break;

      var files = dir
        .EnumerateFiles()
        .Where(f => Regex.IsMatch(f.Name, rule.Contains, RegexOptions.IgnoreCase))
        .ToArray();

      var format = rule.Format;
      foreach (var file in files)
      {
        var regex = new Regex(rule.Pattern, RegexOptions.IgnoreCase);
        var m = regex.Match(file.Name);
        if (m.Success)
        {
          var groups = m.Groups.OfType<Group>().ToList();
          var values = new Dictionary<int, object>();

          var names = regex.GetGroupNames();
          foreach (var name in names)
          {
            var group = m.Groups[name];
            var index = groups.IndexOf(group);
            var token = $"${name}";
            var tokenIndex = format.IndexOf(token);
            if (tokenIndex >= 0)
            {
              var formatIndex = $"{{{index}}}";
              var afterToken = tokenIndex + token.Length;
              if (afterToken < format.Length && format[afterToken] == '#')
              {
                // this is a number!
                values[index] = $"{int.Parse(group.Value):000}";
                token = $"{token}#";
              }
              format = format.Replace(token, formatIndex);
            }
          }

          var args = groups
            .Select((g, i) => values.TryGetValue(i, out object value) ? value : g.Value)
            .ToArray();

          var filename = string.Format(format, args);
          var filepath = Path.Combine(file.Directory.FullName, filename);
          var result = new RenameResult(file.Name, filename);
          try
          {
            file.MoveTo(filepath);
          }
          catch
          {
            continue;
          }
          yield return result;
        }
      }
    }

    enum RenameType
    {
      Unchanged = 0,
      Changed,
    }

    class RenameResult
    {
      public RenameResult(string from, string to)
      {
        From = from;
        To = to;
      }

      public string From { get; }
      public string To { get; }
      public RenameType Type => (RenameType)(Convert.ToInt32(!string.Equals(From, To, StringComparison.OrdinalIgnoreCase)));
    }
  }
}
