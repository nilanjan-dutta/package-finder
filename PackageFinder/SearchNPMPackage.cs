using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace PackageFinder
{
    internal static class SearchNpmPackage
    {
        internal static List<SearchResult> FindNPMPackage(List<string> files, string packageToSearch)
        {
            var result = new List<SearchResult>();

            Parallel.ForEach(files, file =>
            {
                var packageFileObject = JObject.Parse(File.ReadAllText(file));
                if (packageFileObject.ContainsKey("dependencies") || packageFileObject.ContainsKey("devDependencies"))
                {
                    var dependencies = packageFileObject.GetValue("dependencies");
                    var devDependencies = packageFileObject.GetValue("devDependencies");
                    result.AddRange(GetResults(packageToSearch, file, packageFileObject, dependencies));
                    result.AddRange(GetResults(packageToSearch, file, packageFileObject, devDependencies));
                }
            });

            return result;
        }

        private static List<SearchResult> GetResults(string packageToSearch, string file, JObject packageFileObject, JToken dependencies)
        {
            var result = new List<SearchResult>();
            if (dependencies != null)
            {
                foreach (var package in ((JObject)dependencies).Properties().Where(package =>
                    package.Name.ToUpperInvariant().Contains(packageToSearch.ToUpperInvariant())))
                {
                    result.Add(new SearchResult
                        {
                            PackageName = packageToSearch,
                            Version = package.Value.ToString(),
                            Path = file,    
                            ProjectName = packageFileObject.ContainsKey("name") ? packageFileObject.GetValue("name").ToString() : ""
                        });
                }
            }
            return result;
        }
    }
}
