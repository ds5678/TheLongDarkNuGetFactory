namespace TheLongDarkNuGetFactory;

internal static class Rels
{
	public const string Path = "_rels/.rels";
	public const string Content = $"""
		<?xml version="1.0" encoding="utf-8"?>
		<Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
		  <Relationship Type="http://schemas.microsoft.com/packaging/2010/07/manifest" Target="/{NuSpec.Path}" Id="R34910332A66BF6E4" />
		  <Relationship Type="http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties" Target="/{Psmdcp.Path}" Id="R010373FC5B761579" />
		</Relationships>
		""";
}
