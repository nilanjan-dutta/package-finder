using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PackageFinder
{
    internal static class SearchNugetPackage
    {
        internal static List<SearchResult> FindNugetPackage(List<string> files, string packageToSearch)
        {
            var result = new List<SearchResult>();

            Parallel.ForEach(files, file =>
            {
                var projFile = XElement.Load(file); 
                var packages = projFile.Elements("ItemGroup").Elements("PackageReference").ToList();
                var matchedPackages = packages.Where(x => x.Attribute("Include") != null &&
                                        x.Attribute("Include").Value.ToUpperInvariant().Contains(packageToSearch.ToUpperInvariant()));

                result.AddRange(matchedPackages.Select(x =>
                    new SearchResult 
                    {
                        PackageName = x.Attribute("Include").Value,
                        Version = x.Attribute("Version").Value,
                        Path = file,
                        ProjectName = Path.GetFileNameWithoutExtension(file)
                    }
                ));
            });

            return result;
        }
    }
}
