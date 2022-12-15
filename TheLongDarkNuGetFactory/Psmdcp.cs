namespace TheLongDarkNuGetFactory;

internal static class Psmdcp
{
	public const string Name = "c2e5ee414c1c47359f460a0927c4ae34";
	public const string Path = $"package/services/metadata/core-properties/{Name}.psmdcp";
	public const string Content = $"""
		<?xml version="1.0" encoding="utf-8"?>
		<coreProperties xmlns:dc="http://purl.org/dc/elements/1.1/" xmlns:dcterms="http://purl.org/dc/terms/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.openxmlformats.org/package/2006/metadata/core-properties">
		  <dc:creator>{PackageInformation.Name}</dc:creator>
		  <dc:description>{PackageInformation.Description}</dc:description>
		  <dc:identifier>{PackageInformation.Name}</dc:identifier>
		  <version>{PackageInformation.Version}</version>
		  <keywords>{PackageInformation.Tags}</keywords>
		  <lastModifiedBy>NuGet.Build.Tasks.Pack, Version=6.4.0.117, Culture=neutral, PublicKeyToken=31bf3856ad364e35;Microsoft Windows NT 10.0.17763.0;.NET Framework 4.7.2</lastModifiedBy>
		</coreProperties>
		""";
}