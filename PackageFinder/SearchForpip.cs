using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageFinder
{
    internal static class SearchPipPackage
    {
        internal static List<SearchResult> FindPiPPackage(List<string> files, string packageToSearch)
        {

            var result = new List<SearchResult>();

            Parallel.ForEach(files, file =>
            {
                var lines = File.ReadAllLines(file);
                result.AddRange(lines.Where(line => line.Contains(packageToSearch.Trim())).Select(x =>
                    new SearchResult
                    {
                        PackageName = x.Split(new string [] {"=="},StringSplitOptions.None)[0],
                        Version = x.Split(new string[] { "==" }, StringSplitOptions.None)[1],
                        Path = file,
                        ProjectName = Path.GetFileNameWithoutExtension(file)
                    }
                ));
            });

            return result;
        }
    }
}
