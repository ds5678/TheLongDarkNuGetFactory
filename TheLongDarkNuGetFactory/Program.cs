using ICSharpCode.SharpZipLib.Zip;
using System.Text;

namespace TheLongDarkNuGetFactory;

internal class Program
{
	static void Main(string[] args)
	{
		MemoryStream stream = new();
		ZipFile zipFile = ZipFile.Create(stream);
		zipFile.BeginUpdate();
		foreach ((string path, byte[] data) in GetEntries(args[0]))
		{
			zipFile.Add(new StreamDataSource(new MemoryStream(data)), new ZipEntry(path));
		}
		zipFile.CommitUpdate();
		File.WriteAllBytes($"{PackageInformation.Name}.nupkg", stream.ToArray());
		Console.WriteLine("Done!");
	}

	private static IEnumerable<(string, byte[])> GetEntries(string il2cppAssembliesDirectory)
	{
		yield return GetEntryData(Rels.Path, Rels.Content);
		yield return GetEntryData(NuSpec.Path, NuSpec.Content);
		yield return GetEntryData(ContentTypes.Path, ContentTypes.Content);
		yield return GetEntryData(Psmdcp.Path, Psmdcp.Content);
		foreach (string assemblyPath in Directory.EnumerateFiles(il2cppAssembliesDirectory, "*.dll"))
		{
			string fileName = Path.GetFileName(assemblyPath);
			yield return ($"lib/net6.0/{fileName}", File.ReadAllBytes(assemblyPath));
		}
	}

	private static (string, byte[]) GetEntryData(string path, string content)
	{
		return (path, Encoding.UTF8.GetBytes(content));
	}
}
